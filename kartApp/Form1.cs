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

        public void kaydet ()
        {
            lblKayitBasarili.Text = "KAYIT BAŞARILI";
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

        string satir;
        private void grdOgrenci_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            satir = grdOgrenci.CurrentRow.Cells[0].Value.ToString();
            btnIslem.Text = "GÜNCELLE";   
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            btnIslem.Text = "KAYDET";
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (satir!=null)
            {
                grdOgrenci.DataSource = Yardimci.Tablo(Yardimci.VeriSil(satir));
                grdOgrenci.DataSource = Yardimci.Tablo(Yardimci.VeriGetir());
                lblKayitBasarili.Text = "SİLİNDİ";
                time();
            }

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
        }
    }
}
