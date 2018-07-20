using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kartApp
{
    class Yardimci
    {
        public static OleDbConnection Baglanti()
        {
            OleDbConnection olCon = new OleDbConnection();
            olCon.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Data.mdb;";
            return olCon;
        }
        public static DataTable Tablo(string sorgu)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Baglanti());
            DataTable dt = new DataTable();

            da.Fill(dt);
            return dt;
        }
        public static string VeriGetir()
        {
            string sorgu = "select Kimlik, Ad, Soyad, Unvan, Tarih, Tel, Fax, Mail, Adres, SirketAd, Web from tblOgrenci where AktifPasif='1'";
            return sorgu;
        }
        public static string VeriKaydet(string ad, string soyad, string unvan, string tarih, string tel, string fax, string mail, string adres, string sirket, string web)
        {
            //string sorgu = "insert into tblOgrenci (Ad,Soyad,Unvan,Tarih,Tel,Fax,Mail,Adres,SirketAd,Web,AktifPasif) values('" + ad + "','" + soyad + "'," + numara + ",1)";
            string sorgu = "insert into tblOgrenci (Ad,Soyad,Unvan,Tarih,Tel,Fax,Mail,Adres,SirketAd,Web,AktifPasif) values('" + ad + "','" + soyad + "','" + unvan + "','" + tarih + "','" + tel + "','" + fax + "','" + mail + "','" + adres + "','" + sirket + "','" + web + "','1')";
            return sorgu;
        }

        public static string VeriGuncelle(string ad, string soyad, string unvan, string tarih, string tel, string fax, string mail, string adres, string sirket, string web, string satir)
        {
            string sorgu = "update tblOgrenci set Ad = " + "'" + ad + "'," + "Soyad = " + "'" + soyad + "'," + "Unvan = " + "'" + unvan + "'," + "Tarih =" + "'" + tarih + "'," + "Tel = " + "'" + tel + "'," + "Fax = " + "'" + fax + "'," + "Mail = " + "'" + mail + "'," + "Adres = " + "'" + adres + "'," + "SirketAd = " + "'" + sirket + "'," + "Web = " + "'" + web + "'" + "where Kimlik = " + satir;
            return sorgu;
        }

        public static string VeriSil(string satir)
        {
            string sorgu = "update tblOgrenci set AktifPasif= 0 where Kimlik= " + satir;
            return sorgu;
        }

        public static string SilinenGoster()
        {
            string sorgu = "select Kimlik, Ad, Soyad, Unvan, Tarih, Tel, Fax, Mail, Adres, SirketAd, Web from tblOgrenci where AktifPasif='0'";
            return sorgu;
        }

        public static string GeriAl(string satir)
        {
            string sorgu = "update tblOgrenci set AktifPasif= 1 where Kimlik= " + satir;
            return sorgu;
        }


    }
}

//Yardimci.Tablo(Yardimci.VeriKaydet(tbAdi.Text, tbSoyadi, tbUnvani, Convert.ToString(tbTelefonu), tbMail, Convert.ToString(tbFaks), tbWebSitesi, tbAdresi, tbSirketAdi, Convert.ToString(tbFaks)));
