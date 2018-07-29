using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace kartApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            transparan();
            grdOgrenci.DataSource = Yardimci.Tablo(Yardimci.VeriGetir());
            grdOgrenci.Sort(grdOgrenci.Columns["ID"], ListSortDirection.Ascending);
            grdOgrenciRapor.DataSource = Yardimci.Tablo(Yardimci.VeriGetir());

            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "X";
            checkColumn.HeaderText = "X";
            checkColumn.Width = 50;
            checkColumn.ReadOnly = false;
            checkColumn.FillWeight = 12;            
            grdOgrenciRapor.Columns.Add(checkColumn);

            

            



            for (int i = 1; i <= 11; i++)
            {
                grdOgrenciRapor.Columns[i].Visible = false;
            }

            cmbKategori.DataSource = Yardimci.Tablo(Yardimci.KategoriGetir());
            cmbKategori.DisplayMember = "KatAdi";
            cmbKategori.ValueMember = "KatID";
        }


        string satir;
        private void grdOgrenci_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            satir = grdOgrenci.CurrentRow.Cells[0].Value.ToString();
            if (btnIslem2.Text == "PASİFLER")
            {
                btnIslem.Text = "GÜNCELLE";
            }
            else if (btnIslem2.Text == "AKTİFLER")
            {
                btnIslem.Text = "GERİ AL";
            }
        }


        private void Form1_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            btnIslem.Text = "KAYDET";
        }


        private void btnIslem_Click(object sender, EventArgs e)
        {
            if (btnIslem.Text == "KAYDET")
            {
                kaydet();
            }
            else if (btnIslem.Text == "GÜNCELLE")
            {
                guncelle();
            }
            else if (btnIslem.Text == "GERİ AL")
            {
                gerial();
            }
        }


        private void btnIslem2_Click(object sender, EventArgs e)
        {
            if (btnIslem2.Text == "PASİFLER")
            {
                grdOgrenci.DataSource = Yardimci.Tablo(Yardimci.SilinenGoster());
                grdOgrenci.Sort(grdOgrenci.Columns["ID"], ListSortDirection.Ascending);
                btnIslem2.Text = "AKTİFLER";
            }
            else if (btnIslem2.Text == "AKTİFLER")
            {
                grdOgrenci.DataSource = Yardimci.Tablo(Yardimci.VeriGetir());
                grdOgrenci.Sort(grdOgrenci.Columns["ID"], ListSortDirection.Ascending);
                btnIslem2.Text = "PASİFLER";
            }
        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            if (satir != null)
            {
                grdOgrenci.DataSource = Yardimci.Tablo(Yardimci.VeriSil(satir));
                grdOgrenci.DataSource = Yardimci.Tablo(Yardimci.VeriGetir());
                grdOgrenci.Sort(grdOgrenci.Columns["ID"], ListSortDirection.Ascending);
                lblKayitBasarili.Text = "PASİFLENDİ";
                time();
            }
        }


        private void btnKaliciSil_Click(object sender, EventArgs e)
        {
            grdOgrenci.DataSource = Yardimci.Tablo(Yardimci.KaliciSil(satir));
            grdOgrenci.DataSource = Yardimci.Tablo(Yardimci.VeriGetir());
            grdOgrenci.Sort(grdOgrenci.Columns["ID"], ListSortDirection.Ascending);
            lblKayitBasarili.Text = "SİLİNDİ";
            time();

        }


        public void kaydet ()
        {            
            int sonuc = zaten(tbAdi.Text.Trim(),tbSoyadi.Text.Trim());
            if (sonuc == 0)
            {
                tbAdi.Text = tbAdi.Text.Trim();
                tbSoyadi.Text = tbSoyadi.Text.Trim();
                tbUnvani.Text = tbUnvani.Text.Trim();
                tbTarih.Text = tbTarih.Text.Trim();
                tbTelefonu.Text = tbTelefonu.Text.Trim();
                tbFaks.Text = tbFaks.Text.Trim();
                tbMail.Text = tbMail.Text.Trim();
                tbUzanti.Text = tbUzanti.Text.Trim();
                tbAdresi.Text = tbAdresi.Text.Trim();
                tbSirketAdi.Text = tbSirketAdi.Text.Trim();
                tbWebSitesi.Text = tbWebSitesi.Text.Trim();
                tbGsm.Text = tbGsm.Text.Trim();


                string ad = Convert.ToString(tbAdi.Text);
                string soyad = Convert.ToString(tbSoyadi.Text);
                string unvan = Convert.ToString(tbUnvani.Text);
                string tarih = Convert.ToString(tbTarih.Text);
                string tel = Convert.ToString(tbTelefonu.Text);
                string fax = Convert.ToString(tbFaks.Text);
                string mail = Convert.ToString(tbMail.Text) + "@" + Convert.ToString(tbUzanti.Text);
                string adres = Convert.ToString(tbAdresi.Text);
                string sirket = Convert.ToString(tbSirketAdi.Text);
                string web = Convert.ToString(tbWebSitesi.Text);
                string gsm = Convert.ToString(tbGsm.Text);

                try
                {
                    grdOgrenci.DataSource = Yardimci.Tablo(Yardimci.VeriKaydet(ad, soyad, unvan, tarih, tel, gsm, fax, mail, adres, sirket, web));
                    grdOgrenci.DataSource = Yardimci.Tablo(Yardimci.VeriGetir());
                    grdOgrenci.Sort(grdOgrenci.Columns["ID"], ListSortDirection.Ascending);

                }
                catch (Exception ex)
                {
                    lblKayitBasarili.Text = "Değerler boş";
                }

                lblKayitBasarili.Text = "KAYIT BAŞARILI";
                time();
            }
            else if (sonuc == 1)
            {

                DialogResult dialogresult = MessageBox.Show("Aynı olmadığına emin misiniz?", "Bu kayıt muhtemelen var",MessageBoxButtons.YesNo);
                if (dialogresult == DialogResult.Yes)
                {
                    tbAdi.Text = tbAdi.Text.Trim();
                    tbSoyadi.Text = tbSoyadi.Text.Trim();
                    tbUnvani.Text = tbUnvani.Text.Trim();
                    tbTarih.Text = tbTarih.Text.Trim();
                    tbTelefonu.Text = tbTelefonu.Text.Trim();
                    tbFaks.Text = tbFaks.Text.Trim();
                    tbMail.Text = tbMail.Text.Trim();
                    tbUzanti.Text = tbUzanti.Text.Trim();
                    tbAdresi.Text = tbAdresi.Text.Trim();
                    tbSirketAdi.Text = tbSirketAdi.Text.Trim();
                    tbWebSitesi.Text = tbWebSitesi.Text.Trim();
                    tbGsm.Text = tbGsm.Text.Trim();


                    string ad = Convert.ToString(tbAdi.Text);
                    string soyad = Convert.ToString(tbSoyadi.Text);
                    string unvan = Convert.ToString(tbUnvani.Text);
                    string tarih = Convert.ToString(tbTarih.Text);
                    string tel = Convert.ToString(tbTelefonu.Text);
                    string fax = Convert.ToString(tbFaks.Text);
                    string mail = Convert.ToString(tbMail.Text) + "@" + Convert.ToString(tbUzanti.Text);
                    string adres = Convert.ToString(tbAdresi.Text);
                    string sirket = Convert.ToString(tbSirketAdi.Text);
                    string web = Convert.ToString(tbWebSitesi.Text);
                    string gsm = Convert.ToString(tbGsm.Text);

                    grdOgrenci.DataSource = Yardimci.Tablo(Yardimci.VeriKaydet(ad, soyad, unvan, tarih, tel, gsm, fax, mail, adres, sirket, web));
                    grdOgrenci.DataSource = Yardimci.Tablo(Yardimci.VeriGetir());
                    grdOgrenci.Sort(grdOgrenci.Columns["ID"], ListSortDirection.Ascending);

                    lblKayitBasarili.Text = "KAYIT BAŞARILI";
                    time();


                }
                else if (dialogresult == DialogResult.No)
                {
                    lblKayitBasarili.Text = "İŞLEM İPTAL";
                    time();

                }














                //lblKayitBasarili.Text = "ZATEN VAR";
                //time();

                //lblgosterge.Text = grdOgrenci.CurrentRow.Cells[0].Value.ToString();                

                //tbAdi.Text = grdOgrenci.Rows[tüm].Cells[1].Value.ToString();
                //tbSoyadi.Text = grdOgrenci.Rows[tüm].Cells[2].Value.ToString();
                //tbUnvani.Text = grdOgrenci.Rows[tüm].Cells[3].Value.ToString();
                //tbTarih.Text = grdOgrenci.Rows[tüm].Cells[4].Value.ToString();
                //tbTelefonu.Text = grdOgrenci.Rows[tüm].Cells[5].Value.ToString();
                //tbGsm.Text = grdOgrenci.Rows[tüm].Cells[6].Value.ToString();
                //tbFaks.Text = grdOgrenci.Rows[tüm].Cells[7].Value.ToString();                
                //tbAdresi.Text = grdOgrenci.Rows[tüm].Cells[9].Value.ToString();
                //tbSirketAdi.Text = grdOgrenci.Rows[tüm].Cells[10].Value.ToString();
                //tbWebSitesi.Text = grdOgrenci.Rows[tüm].Cells[11].Value.ToString();

            }
        }


        public void guncelle()
        {
            if (satir != null)
            {
                lblKayitBasarili.Text = "GÜNCELLENDİ";
                time();

                tbAdi.Text = tbAdi.Text.Trim();
                tbSoyadi.Text = tbSoyadi.Text.Trim();
                tbUnvani.Text = tbUnvani.Text.Trim();
                tbTarih.Text = tbTarih.Text.Trim();
                tbTelefonu.Text = tbTelefonu.Text.Trim();
                tbFaks.Text = tbFaks.Text.Trim();
                tbMail.Text = tbMail.Text.Trim();
                tbUzanti.Text = tbUzanti.Text.Trim();
                tbAdresi.Text = tbAdresi.Text.Trim();
                tbSirketAdi.Text = tbSirketAdi.Text.Trim();
                tbWebSitesi.Text = tbWebSitesi.Text.Trim();
                tbGsm.Text = tbGsm.Text.Trim();
                

                string ad = Convert.ToString(tbAdi.Text);
                string soyad = Convert.ToString(tbSoyadi.Text);
                string unvan = Convert.ToString(tbUnvani.Text);
                string tarih = Convert.ToString(tbTarih.Text);
                string tel = Convert.ToString(tbTelefonu.Text);
                string fax = Convert.ToString(tbFaks.Text);
                string mail = Convert.ToString(tbMail.Text) + "@" + Convert.ToString(tbUzanti.Text);
                string adres = Convert.ToString(tbAdresi.Text);
                string sirket = Convert.ToString(tbSirketAdi.Text);
                string web = Convert.ToString(tbWebSitesi.Text);
                string gsm = Convert.ToString(tbGsm.Text);

                grdOgrenci.DataSource = Yardimci.Tablo(Yardimci.VeriGuncelle(ad, soyad, unvan, tarih, tel, gsm, fax, mail, adres, sirket, web, satir));
                grdOgrenci.DataSource = Yardimci.Tablo(Yardimci.VeriGetir());
                grdOgrenci.Sort(grdOgrenci.Columns["ID"], ListSortDirection.Ascending);
            }
        }


        public void gerial()
        {
            grdOgrenci.DataSource = Yardimci.Tablo(Yardimci.GeriAl(satir));
            grdOgrenci.DataSource = Yardimci.Tablo(Yardimci.SilinenGoster());
            lblKayitBasarili.Text = "GERİ ALINDI";
            time();
        }

   
        int tüm;
        private int zaten(string ad, string soyad)
        {
            int sayi = grdOgrenci.Rows.Count;
            int sonuc=0;

            

            for (int i = 0; i < sayi-1; i++)
            {

                string adX = grdOgrenci.Rows[i].Cells[1].Value.ToString();
                bool esitMiAd = adX.Equals(ad, StringComparison.OrdinalIgnoreCase);

                string soyadX = grdOgrenci.Rows[i].Cells[2].Value.ToString();
                bool esitMiSoyad = soyadX.Equals(soyad, StringComparison.OrdinalIgnoreCase);

                

                if ((esitMiAd && esitMiSoyad) == true)
                {
                    sonuc = 1;
                    tüm = i;
                    break;
                }
                else
                {
                    continue;
                }
            }
            

        return sonuc;   
        }


        private void time()
        {
            timer1 = new Timer();
            timer1.Interval = 2000;
            timer1.Tick += new System.EventHandler(this.timer1_Tick);
            lblKayitBasarili.Visible = true;            
            timer1.Start();           
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            lblKayitBasarili.Visible = false;            
        }


        private void transparan()
        {
            lblAdi.BackColor = Color.Transparent;
            lblAdresi.BackColor = Color.Transparent;
            lblFaks.BackColor = Color.Transparent;
            lblMail.BackColor = Color.Transparent;
            lblUzanti.BackColor = Color.Transparent;
            lblSirketAdi.BackColor = Color.Transparent;
            lblSoyadi.BackColor = Color.Transparent;
            lblTelefonu.BackColor = Color.Transparent;
            lblUnvani.BackColor = Color.Transparent;
            lblWebSitesi.BackColor = Color.Transparent;
            lblTarih.BackColor = Color.Transparent;            
            lblGsm.BackColor = Color.Transparent;
            lblArama.BackColor = Color.Transparent;

            

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (grdOgrenci.DataSource as DataTable).DefaultView.RowFilter = string.Format("Ad like '%" + tbArama.Text + "%' OR Soyad like '%" + tbArama.Text + "%' OR Tarih like '%" + tbArama.Text + "%' OR SirketAd like '%" + tbArama.Text + "%'");
        }

        private void checkAd_CheckedChanged(object sender, EventArgs e)
        {
            if (grdOgrenciRapor.Columns[2].Visible == false)
            {
                grdOgrenciRapor.Columns[2].Visible = true;
            }
            else if (grdOgrenciRapor.Columns[2].Visible == true)
            {
                grdOgrenciRapor.Columns[2].Visible = false;
            }
        }

        private void checkSoyad_CheckedChanged(object sender, EventArgs e)
        {
            if (grdOgrenciRapor.Columns[3].Visible == false)
            {
                grdOgrenciRapor.Columns[3].Visible = true;
            }
            else if (grdOgrenciRapor.Columns[3].Visible == true)
            {
                grdOgrenciRapor.Columns[3].Visible = false;
            }
        }

        private void checkUnvan_CheckedChanged(object sender, EventArgs e)
        {
            if (grdOgrenciRapor.Columns[4].Visible == false)
            {
                grdOgrenciRapor.Columns[4].Visible = true;
            }
            else if (grdOgrenciRapor.Columns[4].Visible == true)
            {
                grdOgrenciRapor.Columns[4].Visible = false;
            }
        }

        private void checkTarih_CheckedChanged(object sender, EventArgs e)
        {
            if (grdOgrenciRapor.Columns[5].Visible == false)
            {
                grdOgrenciRapor.Columns[5].Visible = true;
            }
            else if (grdOgrenciRapor.Columns[5].Visible == true)
            {
                grdOgrenciRapor.Columns[5].Visible = false;
            }
        }

        private void checkTelefon_CheckedChanged(object sender, EventArgs e)
        {
            if (grdOgrenciRapor.Columns[6].Visible == false)
            {
                grdOgrenciRapor.Columns[6].Visible = true;
            }
            else if (grdOgrenciRapor.Columns[6].Visible == true)
            {
                grdOgrenciRapor.Columns[6].Visible = false;
            }
        }

        private void checkGsm_CheckedChanged(object sender, EventArgs e)
        {
            if (grdOgrenciRapor.Columns[7].Visible == false)
            {
                grdOgrenciRapor.Columns[7].Visible = true;
            }
            else if (grdOgrenciRapor.Columns[7].Visible == true)
            {
                grdOgrenciRapor.Columns[7].Visible = false;
            }
        }

        private void checkFaks_CheckedChanged(object sender, EventArgs e)
        {
            if (grdOgrenciRapor.Columns[8].Visible == false)
            {
                grdOgrenciRapor.Columns[8].Visible = true;
            }
            else if (grdOgrenciRapor.Columns[8].Visible == true)
            {
                grdOgrenciRapor.Columns[8].Visible = false;
            }
        }

        private void checkMail_CheckedChanged(object sender, EventArgs e)
        {
            if (grdOgrenciRapor.Columns[9].Visible == false)
            {
                grdOgrenciRapor.Columns[9].Visible = true;
            }
            else if (grdOgrenciRapor.Columns[9].Visible == true)
            {
                grdOgrenciRapor.Columns[9].Visible = false;
            }
        }

        private void checkAdres_CheckedChanged(object sender, EventArgs e)
        {
            if (grdOgrenciRapor.Columns[10].Visible == false)
            {
                grdOgrenciRapor.Columns[10].Visible = true;
            }
            else if (grdOgrenciRapor.Columns[10].Visible == true)
            {
                grdOgrenciRapor.Columns[10].Visible = false;
            }
        }

        private void checkSirket_CheckedChanged(object sender, EventArgs e)
        {
            if (grdOgrenciRapor.Columns[11].Visible == false)
            {
                grdOgrenciRapor.Columns[11].Visible = true;
            }
            else if (grdOgrenciRapor.Columns[11].Visible == true)
            {
                grdOgrenciRapor.Columns[11].Visible = false;
            }
        }

        private void checkWeb_CheckedChanged(object sender, EventArgs e)
        {
            if (grdOgrenciRapor.Columns[12].Visible == false)
            {
                grdOgrenciRapor.Columns[12].Visible = true;
            }
            else if (grdOgrenciRapor.Columns[12].Visible == true)
            {
                grdOgrenciRapor.Columns[12].Visible = false;
            }
        }

        private void checkID_CheckedChanged(object sender, EventArgs e)
        {
            if (grdOgrenciRapor.Columns[1].Visible == false)
            {
                grdOgrenciRapor.Columns[1].Visible = true;
            }
            else if (grdOgrenciRapor.Columns[1].Visible == true)
            {
                grdOgrenciRapor.Columns[1].Visible = false;
            }
        }

        private void checkGenis_CheckedChanged(object sender, EventArgs e)
        {
            if (grdOgrenci.AutoSizeColumnsMode == DataGridViewAutoSizeColumnsMode.Fill)
            {
                grdOgrenci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
            else if (grdOgrenci.AutoSizeColumnsMode == DataGridViewAutoSizeColumnsMode.DisplayedCells)
            {
                grdOgrenci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }




        }

        

        private void btnCikti_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grdOgrenciRapor.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.Equals(true))
                {
                    row.Selected = true;
                    row.DefaultCellStyle.SelectionBackColor = Color.LightSlateGray;
                }
                else
                    row.Selected = false;
            }

            for (int i = 0; i < (grdOgrenciRapor.Rows.Count)-1; i++)
            {
                DataGridViewBand band = grdOgrenciRapor.Rows[i];                
                if (band.Selected == false)
                {
                    band.Visible = false;
                }
                else
                {
                    continue;
                }

            }

            grdOgrenciRapor.Columns[0].Visible = false;

            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            grdOgrenciRapor.Columns[0].Visible = true;
            grdOgrenciRapor.DataSource = Yardimci.Tablo(Yardimci.VeriGetir());
        }

        private void copyAlltoClipboard()
        {
            grdOgrenciRapor.SelectAll();
            
            DataObject dataObj = grdOgrenciRapor.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        


    }
}

