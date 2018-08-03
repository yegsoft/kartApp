using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kartApp
{
    class Yardimci   {
        public static OleDbConnection Baglanti()
        {
            OleDbConnection olCon = new OleDbConnection();
            olCon.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\\Data.mdb;";
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
            string sorgu = "select ID, Ad, Soyad, Unvan, Tarih, Tel, Gsm, Fax, Mail, Adres, SirketAd, Web,KatAdi from AnaTablo A left join Kategori K on A.KatID = K.KatID where AktifPasif = '1'";
                //"select ID, Ad, Soyad, Unvan, Tarih, Tel, Gsm, Fax, Mail, Adres, SirketAd, Web from AnaTablo where AktifPasif='1'";
            return sorgu;
        }
        public static string VeriGetirRapor()
        {
            string sorgu = "select ID, Ad, Soyad, Unvan, Tarih, Tel, Gsm, Fax, Mail, Adres, SirketAd, Web, AktifPasif, KatAdi from AnaTablo A left join Kategori K on A.KatID = K.KatID";

            //"select ID, Ad, Soyad, Unvan, Tarih, Tel, Gsm, Fax, Mail, Adres, SirketAd, Web, AktifPasif from AnaTablo where AktifPasif='1'";
            return sorgu;
        }
        public static string VeriKaydet(string ad, string soyad, string unvan, string tarih, string tel, string gsm, string fax, string mail, string adres, string sirket, string web, string katid)
        {
            string sorgu = "insert into AnaTablo (Ad,Soyad,Unvan,Tarih,Tel,Gsm,Fax,Mail,Adres,SirketAd,Web,AktifPasif,KatID) values('" + ad + "','" + soyad + "','" + unvan + "','" + tarih + "','" + tel + "','" + gsm + "','" + fax + "','" + mail + "','" + adres + "','" + sirket + "','" + web + "','1','" + katid + "')";
            return sorgu;
        }
        public static string VeriGuncelle(string ad, string soyad, string unvan, string tarih, string tel, string gsm, string fax, string mail, string adres, string sirket, string web, string satir, string katid)
        {
            string sorgu = "update AnaTablo set Ad = " + "'" + ad + "'," + "Soyad = " + "'" + soyad + "'," + "Unvan = " + "'" + unvan + "'," + "Tarih =" + "'" + tarih + "'," + "Tel = " + "'" + tel + "'," + "Gsm =" + "'" + gsm + "'," + "Fax = " + "'" + fax + "'," + "Mail = " + "'" + mail + "'," + "Adres = " + "'" + adres + "'," + "SirketAd = " + "'" + sirket + "'," + "Web = " + "'" + web + "'" + "," + "KatID = " + "'" + katid + "' where ID = " + satir;
            return sorgu;
        }
        public static string VeriSil(string satir)
        {
            string sorgu = "update AnaTablo set AktifPasif= 0 where ID= " + satir;
            return sorgu;
        }
        public static string KaliciSil(string satir)
        {
            string sorgu = "delete from AnaTablo where ID= " + satir;
            return sorgu;
        }
        public static string KategoriEkle(string satir)
        {
            string sorgu = "insert into Kategori (KatAdi) values ('" + satir + "')";
            return sorgu;
        }
        public static string KategoriSil(int satir)
        {
            string sorgu = "delete from Kategori where KatID= " + satir;
            return sorgu;
        }
        public static string SilinenGoster()
        {
            string sorgu = "select ID, Ad, Soyad, Unvan, Tarih, Tel, Gsm, Fax, Mail, Adres, SirketAd, Web from AnaTablo where AktifPasif='0'";
            return sorgu;
        }
        public static string GeriAl(string satir)
        {
            string sorgu = "update AnaTablo set AktifPasif= 1 where ID= " + satir;
            return sorgu;
        }
        public static string KategoriGetir()
        {

            string sorgu = "select KatID,KatAdi from Kategori";
            return sorgu;
        }
        public static string KategoriGetir2(int satir)
        {
            string sorgu = "select ID, Ad, Soyad, Unvan, Tarih, Tel, Gsm, Fax, Mail, Adres, SirketAd, Web, AktifPasif from AnaTablo where KatID = " + satir;
            return sorgu;
        }
        public static string SatirSayisiGetir(int kategori)
        {
            string sorgu = "select count(KatID) from AnaTablo where KatID= " + kategori + "";
            return sorgu;
        }
        public static string KategoriGuncelle(string isim, int satir)
        {
            string sorgu = "update Kategori set KatAdi = '" + isim + "' where KatID = " + satir + "";
            return sorgu;
        }
        public static string KisiKategoriGuncelle(string isim, string satir)
        {
            string sorgu = "update AnaTablo set KatID = '" + isim + "' where ID = " + satir ;
            return sorgu;
        }



    }
}
