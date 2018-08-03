using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
        StringFormat strFormat;
        ArrayList arrColumnLefts = new ArrayList();
        ArrayList arrColumnWidths = new ArrayList();
        ArrayList liste = new ArrayList();
        int iCellHeight = 0;
        int iTotalWidth = 0;
        int iRow = 0;
        bool bFirstPage = false;
        bool bNewPage = false;
        int iHeaderHeight = 0;        
        public Form1()
        {
            InitializeComponent();
            transparan();
            grdOgrenci.DataSource = Yardimci.Tablo(Yardimci.VeriGetir());
            grdOgrenci.Sort(grdOgrenci.Columns["ID"], ListSortDirection.Ascending);
            grdOgrenciRapor.DataSource = Yardimci.Tablo(Yardimci.VeriGetirRapor());
            grdKategori.DataSource = Yardimci.Tablo(Yardimci.KategoriGetir());



            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "X";
            checkColumn.HeaderText = "seçiniz";
            checkColumn.Width = 50;
            checkColumn.ReadOnly = false;
            checkColumn.FillWeight = 12;
            checkColumn.DisplayIndex = 0;
            grdOgrenci.Columns.Add(checkColumn);

            cmbKategori.DataSource = Yardimci.Tablo(Yardimci.KategoriGetir());
            cmbKategori.DisplayMember = "KatAdi";
            cmbKategori.ValueMember = "KatID";

            grdOgrenciRapor.Columns[0].Visible = false;
            for (int i = 4; i <= 13; i++)
            {
                grdOgrenciRapor.Columns[i].Visible = false;
            }
        }


        string satir;

        private void grdOgrenci_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {   
            
            satir = grdOgrenci.CurrentRow.Cells[1].Value.ToString();

            if (btnIslem2.Text == "PASİFLER")
            {
                btnIslem.Text = "GÜNCELLE";
            }
            else if (btnIslem2.Text == "AKTİFLER")
            {
                btnIslem.Text = "GERİ AL";
            }

            tbAdi.Text = grdOgrenci.CurrentRow.Cells[2].Value.ToString();
            tbSoyadi.Text = grdOgrenci.CurrentRow.Cells[3].Value.ToString();
            tbUnvani.Text = grdOgrenci.CurrentRow.Cells[4].Value.ToString();
            tbTarih.Text = grdOgrenci.CurrentRow.Cells[5].Value.ToString();
            tbTelefonu.Text = grdOgrenci.CurrentRow.Cells[5].Value.ToString();
            tbGsm.Text = grdOgrenci.CurrentRow.Cells[6].Value.ToString();
            tbFaks.Text = grdOgrenci.CurrentRow.Cells[8].Value.ToString();
            tbAdresi.Text = grdOgrenci.CurrentRow.Cells[10].Value.ToString();
            tbSirketAdi.Text = grdOgrenci.CurrentRow.Cells[11].Value.ToString();
            tbWebSitesi.Text = grdOgrenci.CurrentRow.Cells[12].Value.ToString();

            

        }

        
        private void grdKategori_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            satir = grdKategori.CurrentRow.Cells[0].Value.ToString();

            btnKatEkle2.Text = "GÜNCELLE";

        }
        private void tabPage2_Click(object sender, EventArgs e)
        {
            btnKatEkle2.Text = "EKLE";
            btnKatEkle2.Enabled = true;
            btnKatSil.Enabled = true;
            lblCift.Text = "Kategoriye ait verileri görmek için çift tıklatın.";
            grdKategori.DataSource = Yardimci.Tablo(Yardimci.KategoriGetir());

            
        }


        private void Form1_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            btnIslem.Text = "KAYDET";
            tbAdi.Clear();
            tbSoyadi.Clear();
            tbUnvani.Clear();
            tbTelefonu.Clear();
            tbMail.Clear();
            tbUzanti.Clear();
            tbFaks.Clear();
            tbWebSitesi.Clear();
            tbAdresi.Clear();
            tbSirketAdi.Clear();
            tbTarih.Clear();
            tbGsm.Clear();

            

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grdOgrenci.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.Equals(true))                
                {
                    row.Selected = true;
                    row.DefaultCellStyle.SelectionBackColor = Color.LightSlateGray;                    
                }
                else
                    row.Selected = false;
            }



            foreach (DataGridViewRow row in grdOgrenci.Rows)
            {
                if (row.Selected == true)
                {

                    string b = row.Cells[1].Value.ToString();
                    //string b = grdOgrenci.CurrentRow.Cells[1].Value.ToString();
                    string a = cmbKategori.SelectedValue.ToString();
                    Yardimci.Tablo(Yardimci.KisiKategoriGuncelle(a, b));

                }
                else
                {
                    continue;
                }
            }


                
                grdOgrenci.DataSource = Yardimci.Tablo(Yardimci.VeriGetir());
                grdOgrenci.ClearSelection();
            
        }


        private void btnIslem_Click(object sender, EventArgs e)
        {
            if (btnIslem.Text == "KAYDET")
            {
                kaydet();
            }
            else if (btnIslem.Text == "GÜNCELLE")
            {
                DialogResult dialogresult = MessageBox.Show("Emin misiniz?", "GÜNCELLE", MessageBoxButtons.YesNo);                
                if (dialogresult == DialogResult.Yes)
                {
                    guncelle();
                }
                
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
                grdOgrenci.DataSource = Yardimci.Tablo(Yardimci.VeriGetirRapor());
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
            DialogResult dialogresult = MessageBox.Show("Emin misiniz?", "SİL", MessageBoxButtons.YesNo);
            if (dialogresult==DialogResult.Yes)
            {
            grdOgrenci.DataSource = Yardimci.Tablo(Yardimci.KaliciSil(satir));
            grdOgrenci.DataSource = Yardimci.Tablo(Yardimci.VeriGetir());
            grdOgrenci.Sort(grdOgrenci.Columns["ID"], ListSortDirection.Ascending);
            lblKayitBasarili.Text = "SİLİNDİ";
            time();
            }

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
                string katid = cmbKategori.SelectedValue.ToString();

                try
                {
                    grdOgrenci.DataSource = Yardimci.Tablo(Yardimci.VeriKaydet(ad, soyad, unvan, tarih, tel, gsm, fax, mail, adres, sirket, web, katid));
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
                    string katid = cmbKategori.SelectedValue.ToString();

                    grdOgrenci.DataSource = Yardimci.Tablo(Yardimci.VeriKaydet(ad, soyad, unvan, tarih, tel, gsm, fax, mail, adres, sirket, web, katid));
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
                string katid = cmbKategori.SelectedValue.ToString();

                grdOgrenci.DataSource = Yardimci.Tablo(Yardimci.VeriGuncelle(ad, soyad, unvan, tarih, tel, gsm, fax, mail, adres, sirket, web, satir, katid));
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

                string adX = grdOgrenci.Rows[i].Cells[2].Value.ToString();
                bool esitMiAd = adX.Equals(ad, StringComparison.OrdinalIgnoreCase);

                string soyadX = grdOgrenci.Rows[i].Cells[3].Value.ToString();
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

        private int zatenKategori(string kat)
        {
            int sayi = grdKategori.Rows.Count;
            int sonuc = 0;

            for (int i = 0; i < sayi - 1; i++)
            {

                string katX = grdKategori.Rows[i].Cells[1].Value.ToString();
                bool esitMiKat = katX.Equals(kat, StringComparison.OrdinalIgnoreCase);               
                
                if (esitMiKat == true)
                {
                    sonuc = 1;                    
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
            lblAramaRapor.BackColor = Color.Transparent;
            lblAramaRapor2.BackColor = Color.Transparent;


        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbArama_TextChanged(object sender, EventArgs e)
        {
            (grdOgrenci.DataSource as DataTable).DefaultView.RowFilter = string.Format("Ad like '%" + tbArama.Text + "%' OR Soyad like '%" + tbArama.Text + "%' OR Tarih like '%" + tbArama.Text + "%' OR SirketAd like '%" + tbArama.Text + "%'");

        }

        private void tbAramaRapor_TextChanged(object sender, EventArgs e)
        {
            (grdOgrenciRapor.DataSource as DataTable).DefaultView.RowFilter = string.Format("Ad like '%" + tbAramaRapor.Text + "%' OR Soyad like '%" + tbAramaRapor.Text + "%' OR Tarih like '%" + tbAramaRapor.Text + "%' OR SirketAd like '%" + tbAramaRapor.Text + "%'");
        }
        private void tbAramaRapor2_TextChanged(object sender, EventArgs e)
        {
            (grdOgrenciRapor.DataSource as DataTable).DefaultView.RowFilter = string.Format("KatAdi like '%" + tbAramaRapor2.Text + "%'");
        }

        private void checkAd_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAd.Checked == true)
            {
                grdOgrenciRapor.Columns[1].Visible = true;
            }
            else if (checkAd.Checked == false)
            {
                grdOgrenciRapor.Columns[1].Visible = false;
            }
        }

        private void checkSoyad_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSoyad.Checked == true)
            {
                grdOgrenciRapor.Columns[2].Visible = true;
            }
            else if (checkSoyad.Checked == false)
            {
                grdOgrenciRapor.Columns[2].Visible = false;
            }
        }

        private void checkUnvan_CheckedChanged(object sender, EventArgs e)
        {
            if (checkUnvan.Checked == true)
            {
                grdOgrenciRapor.Columns[3].Visible = true;
            }
            else if (checkUnvan.Checked == false)
            {
                grdOgrenciRapor.Columns[3].Visible = false;
            }
        }

        private void checkTarih_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTarih.Checked == true)
            {
                grdOgrenciRapor.Columns[4].Visible = true;
            }
            else if (checkTarih.Checked == false)
            {
                grdOgrenciRapor.Columns[4].Visible = false;
            }
        }

        private void checkTelefon_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTelefon.Checked == true)
            {
                grdOgrenciRapor.Columns[5].Visible = true;
            }
            else if (checkTelefon.Checked == false)
            {
                grdOgrenciRapor.Columns[5].Visible = false;
            }
        }

        private void checkGsm_CheckedChanged(object sender, EventArgs e)
        {
            if (checkGsm.Checked == true)
            {
                grdOgrenciRapor.Columns[6].Visible = true;
            }
            else if (checkGsm.Checked == false)
            {
                grdOgrenciRapor.Columns[6].Visible = false;
            }
        }

        private void checkFaks_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFaks.Checked == true)
            {
                grdOgrenciRapor.Columns[7].Visible = true;
            }
            else if (checkFaks.Checked == false)
            {
                grdOgrenciRapor.Columns[7].Visible = false;
            }
        }

        private void checkMail_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMail.Checked == true)
            {
                grdOgrenciRapor.Columns[8].Visible = true;
            }
            else if (checkMail.Checked == false)
            {
                grdOgrenciRapor.Columns[8].Visible = false;
            }
        }

        private void checkAdres_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAdres.Checked == true)
            {
                grdOgrenciRapor.Columns[9].Visible = true;
            }
            else if (checkAdres.Checked == false)
            {
                grdOgrenciRapor.Columns[9].Visible = false;
            }
        }

        private void checkSirket_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSirket.Checked == true)
            {
                grdOgrenciRapor.Columns[10].Visible = true;
            }
            else if (checkSirket.Checked == false)
            {
                grdOgrenciRapor.Columns[10].Visible = false;
            }
        }

        private void checkWeb_CheckedChanged(object sender, EventArgs e)
        {
            if (checkWeb.Checked == true)
            {
                grdOgrenciRapor.Columns[11].Visible = true;
            }
            else if (checkWeb.Checked == false)
            {
                grdOgrenciRapor.Columns[11].Visible = false;
            }
        }

        private void checkID_CheckedChanged(object sender, EventArgs e)
        {
            if (checkID.Checked == true)
            {
                grdOgrenciRapor.Columns[0].Visible = true;
            }
            else if (checkID.Checked == false)
            {
                grdOgrenciRapor.Columns[0].Visible = false;
            }
        }

        private void checkAktifPasif_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAktifPasif.Checked == true)
            {
                grdOgrenciRapor.Columns[12].Visible = true;
            }
            else if (checkAktifPasif.Checked == false)
            {
                grdOgrenciRapor.Columns[12].Visible = false;
            }

        }

        private void checkKatAdi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkKatAdi.Checked == true)
            {
                grdOgrenciRapor.Columns[13].Visible = true;
            }
            else if (checkKatAdi.Checked == false)
            {
                grdOgrenciRapor.Columns[13].Visible = false;
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
            grdOgrenciRapor.Sort(grdOgrenciRapor.Columns["ID"], ListSortDirection.Descending);
            DataTable dt = new DataTable();


            foreach (DataGridViewColumn col in grdOgrenciRapor.Columns)
            {
                if (grdOgrenciRapor.Columns[col.Index].Visible != false)
                {
                    dt.Columns.Add(col.Name);
                }
                else
                {
                    liste.Add(col.Name);
                }
            }

            for (int i = 0; i < liste.Count; i++)            
            {
                grdOgrenciRapor.Columns.Remove(liste[i].ToString());
            }

            foreach (DataGridViewRow row in grdOgrenciRapor.Rows)
            {
                row.Selected = true;

            }

            
            PrintPreviewDialog onizleme = new PrintPreviewDialog();
            onizleme.Document = printDocument1;
            printDocument1.DefaultPageSettings.Landscape = true;
            ((Form)onizleme).WindowState = FormWindowState.Maximized;
            onizleme.ShowDialog();
            Application.Restart();



            //if (checkTumunu.Checked == true)
            //{
                
                

            //}
            //else
            //{


            //    int kontrol = 0;
            //    foreach (DataGridViewRow row in grdOgrenciRapor.Rows)
            //    {
            //        if (row.Cells[0].Value != null && row.Cells[0].Value.Equals(true))
            //        {
            //            row.Selected = true;
            //            row.DefaultCellStyle.SelectionBackColor = Color.LightSlateGray;
            //            kontrol = 1;
            //        }
            //        else
            //            row.Selected = false;
            //    }

            //    if (kontrol == 0)
            //    {
            //        DialogResult dialogresult = MessageBox.Show("Lütfen en az bir satır seçiniz.", "Hiçbir satır seçilmedi.", MessageBoxButtons.OK);
            //        Application.Restart();
            //    }
            //    else
            //    {
                    
            //        PrintPreviewDialog onizleme = new PrintPreviewDialog();
            //        onizleme.Document = printDocument1;
            //        onizleme.ShowDialog();
            //        Application.Restart();

            //    }

      
            //}

            


        }

        

        private void btnKatEkle_Click(object sender, EventArgs e)
        {
            if (btnKatEkle2.Text == "EKLE")
            {                
                tbKategori.Text = tbKategori.Text.Trim();
                string kat = Convert.ToString(tbKategori.Text);
                int sonuc = zatenKategori(kat);

                if (sonuc == 0)
                {
                    grdKategori.DataSource = Yardimci.Tablo(Yardimci.KategoriEkle(kat));
                    grdKategori.DataSource = Yardimci.Tablo(Yardimci.KategoriGetir());
                }
                else
                {
                    DialogResult dialogresult = MessageBox.Show("Bu isimde bir kategori zaten var.", "HATA", MessageBoxButtons.OK);
                }

                
            }
            else if (btnKatEkle2.Text == "GÜNCELLE")
            {
                int satir = int.Parse(grdKategori.CurrentRow.Cells[0].Value.ToString());
                tbKategori.Text = tbKategori.Text.Trim();
                string kat = Convert.ToString(tbKategori.Text);
                grdKategori.DataSource = Yardimci.Tablo(Yardimci.KategoriGuncelle(kat, satir));
                grdKategori.DataSource = Yardimci.Tablo(Yardimci.KategoriGetir());
            }


            
        }

    
        private void btnKatSil_Click(object sender, EventArgs e)
        {

            int satir = int.Parse(grdKategori.CurrentRow.Cells[0].Value.ToString());
            DataTable dt = Yardimci.Tablo(Yardimci.SatirSayisiGetir(satir));
            int kactane = int.Parse(dt.Rows[0][0].ToString());
            
            if (kactane > 0)
            {
                DialogResult dialogresult = MessageBox.Show("Lütfen tüm kayıtları sildikten sonra tekrar deneyin.", "Bu kategoriye ait kayıtlar var.", MessageBoxButtons.OK);
            }
            else
            {
                grdKategori.DataSource = Yardimci.Tablo(Yardimci.KategoriSil(satir));
                grdKategori.DataSource = Yardimci.Tablo(Yardimci.KategoriGetir());
            }

        }

        private void grdKategori_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int satir = int.Parse(grdKategori.CurrentRow.Cells[0].Value.ToString());
            grdKategori.DataSource = Yardimci.Tablo(Yardimci.KategoriGetir2(satir));
            btnKatEkle2.Enabled = false;
            btnKatSil.Enabled = false;
            btnKatEkle2.Text = "GERİ";
            btnKatSil.Text = "GERİ";
            lblCift.Text = "Geri dönmek için üst kısımda herhangi bir yere tıklayın.";

            

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {            
            try
            {
                int iLeftMargin = e.MarginBounds.Left;
                int iTopMargin = e.MarginBounds.Top;
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;
                bFirstPage = true;

                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in grdOgrenciRapor.Columns)
                    {
                        iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                                       (double)iTotalWidth * (double)iTotalWidth *
                                       ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;


                        arrColumnLefts.Add(iLeftMargin);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }
                }

                while (iRow <= grdOgrenciRapor.SelectedRows.Count - 1)
                {
                    DataGridViewRow GridRow = grdOgrenciRapor.SelectedRows[iRow];

                    iCellHeight = GridRow.Height + 5;
                    int iCount = 0;

                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {

                            e.Graphics.DrawString("RAPOR", new Font(grdOgrenciRapor.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString("RAPOR", new Font(grdOgrenciRapor.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();

                            e.Graphics.DrawString(strDate, new Font(grdOgrenciRapor.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new Font(grdOgrenciRapor.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString("RAPOR", new Font(new Font(grdOgrenciRapor.Font,
                                    FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);


                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in grdOgrenciRapor.Columns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                iCount++;
                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                        }
                        iCount = 0;

                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {
                            if (Cel.Value != null)
                            {
                                e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                            new SolidBrush(Cel.InheritedStyle.ForeColor),
                                            new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                            (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                            }

                            e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)arrColumnLefts[iCount],
                                    iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));

                            iCount++;
                        }
                    }
                    iRow++;
                    iTopMargin += iCellHeight;
                }


                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {           
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                bNewPage = true;

                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in grdOgrenciRapor.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void checkTumunu_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTumunu.Checked == true)
            {
                checkAd.Checked = true;
                checkSoyad.Checked = true;
                checkUnvan.Checked = true;
                checkTarih.Checked = true;
                checkTelefon.Checked = true;
                checkGsm.Checked = true;
                checkFaks.Checked = true;
                checkID.Checked = true;
                checkKatAdi.Checked = true;
                checkSirket.Checked = true;
                checkWeb.Checked = true;
                checkAdres.Checked = true;
                checkAktifPasif.Checked = true;
                checkMail.Checked = true;

                for (int i = 0; i <= 13; i++)
                {
                    grdOgrenciRapor.Columns[i].Visible = true;
                    
                }
            }
            else if (checkTumunu.Checked == false)
            {
                checkAd.Checked = false;
                checkSoyad.Checked = false;
                checkUnvan.Checked = false;
                checkTarih.Checked = false;
                checkTelefon.Checked = false;
                checkGsm.Checked = false;
                checkFaks.Checked = false;
                checkID.Checked = false;
                checkKatAdi.Checked = false;
                checkSirket.Checked = false;
                checkWeb.Checked = false;
                checkAdres.Checked = false;
                checkAktifPasif.Checked = false;
                checkMail.Checked = false;

                for (int i = 0; i <= 13; i++)
                {
                    grdOgrenciRapor.Columns[i].Visible = false;
                }
            }

        }

        private void btnyenile3_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnYenile2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnYenile1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
