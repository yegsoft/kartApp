using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kartApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            transparan();
            grdOgrenci.DataSource = Yardimci.Tablo(Yardimci.VeriGetir());
            grdOgrenci.Sort(grdOgrenci.Columns["Kimlik"], ListSortDirection.Ascending);  
        }


        string satir;
        private void grdOgrenci_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            satir = grdOgrenci.CurrentRow.Cells[0].Value.ToString();
            if (btnIslem2.Text == "SİLİNENLER")
            {
                btnIslem.Text = "GÜNCELLE";
            }
            else if (btnIslem2.Text == "ANA LİSTE")
            {
                btnIslem.Text = "GERİ AL";
            }
        }


        private void Form1_Click(object sender, EventArgs e)
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
            if (btnIslem2.Text == "SİLİNENLER")
            {
                grdOgrenci.DataSource = Yardimci.Tablo(Yardimci.SilinenGoster());
                grdOgrenci.Sort(grdOgrenci.Columns["Kimlik"], ListSortDirection.Ascending);
                btnIslem2.Text = "ANA LİSTE";
            }
            else if (btnIslem2.Text == "ANA LİSTE")
            {
                grdOgrenci.DataSource = Yardimci.Tablo(Yardimci.VeriGetir());
                grdOgrenci.Sort(grdOgrenci.Columns["Kimlik"], ListSortDirection.Ascending);
                btnIslem2.Text = "SİLİNENLER";
            }
        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            if (satir != null)
            {
                grdOgrenci.DataSource = Yardimci.Tablo(Yardimci.VeriSil(satir));
                grdOgrenci.DataSource = Yardimci.Tablo(Yardimci.VeriGetir());
                grdOgrenci.Sort(grdOgrenci.Columns["Kimlik"], ListSortDirection.Ascending);
                lblKayitBasarili.Text = "SİLİNDİ";
                time();
            }
        }


        public void kaydet ()
        {            
            int sonuc = zaten(tbTelefonu.Text);
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

                try
                {
                    grdOgrenci.DataSource = Yardimci.Tablo(Yardimci.VeriKaydet(ad, soyad, unvan, tarih, tel, fax, mail, adres, sirket, web));
                    grdOgrenci.DataSource = Yardimci.Tablo(Yardimci.VeriGetir());
                    grdOgrenci.Sort(grdOgrenci.Columns["Kimlik"], ListSortDirection.Ascending);

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
                lblKayitBasarili.Text = "ZATEN VAR";
                time();

                lblgosterge.Text = grdOgrenci.CurrentRow.Cells[0].Value.ToString();                
 
                tbAdi.Text = grdOgrenci.Rows[tüm].Cells[1].Value.ToString();
                tbSoyadi.Text = grdOgrenci.Rows[tüm].Cells[2].Value.ToString();
                tbUnvani.Text = grdOgrenci.Rows[tüm].Cells[3].Value.ToString();
                tbTarih.Text = grdOgrenci.Rows[tüm].Cells[4].Value.ToString();
                tbTelefonu.Text = grdOgrenci.Rows[tüm].Cells[5].Value.ToString();
                tbFaks.Text = grdOgrenci.Rows[tüm].Cells[6].Value.ToString();                
                tbAdresi.Text = grdOgrenci.Rows[tüm].Cells[8].Value.ToString();
                tbSirketAdi.Text = grdOgrenci.Rows[tüm].Cells[9].Value.ToString();
                tbWebSitesi.Text = grdOgrenci.Rows[tüm].Cells[10].Value.ToString();
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
                lblgosterge.Text = "";

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

                grdOgrenci.DataSource = Yardimci.Tablo(Yardimci.VeriGuncelle(ad, soyad, unvan, tarih, tel, fax, mail, adres, sirket, web, satir));
                grdOgrenci.DataSource = Yardimci.Tablo(Yardimci.VeriGetir());
                grdOgrenci.Sort(grdOgrenci.Columns["Kimlik"], ListSortDirection.Ascending);
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
        private int zaten(string telefon)
        {
            int sayi = grdOgrenci.Rows.Count;
            int sonuc=0;

            for (int i = 0; i < sayi-1; i++)
            {
                string deger = grdOgrenci.Rows[i].Cells[5].Value.ToString();
                bool esitMiTel = deger.Equals(telefon, StringComparison.OrdinalIgnoreCase);

                if (esitMiTel == true)
                {
                    sonuc = 1;
                    tüm = i;
                    break;
                }
                else
                { }
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
            lblgosterge.BackColor = Color.Transparent;

        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (grdOgrenci.DataSource as DataTable).DefaultView.RowFilter = string.Format("Ad like '%" + tbArama.Text + "%' OR Soyad like '%" + tbArama.Text + "%' OR Tarih like '%" + tbArama.Text + "%' OR SirketAd like '%" + tbArama.Text + "%'");
        }
    }
}

