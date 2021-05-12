using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class KayitEkrani : Form
    {
        public KayitEkrani()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-6LL8GP9;Initial Catalog=Project;Integrated Security=True");
        
        private void btnKayitGirisYap_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
           
        }
        private void btnKayitKayitOl_Click(object sender, EventArgs e)
        {
            baglanti.Open();    //store proc
            SqlCommand komut = new SqlCommand("kullaniciEkle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@kullaniciAd", txtKayitAd.Text.Trim());
            komut.Parameters.AddWithValue("@kullaniciSoyad", txtKayitSoyad.Text.Trim());
            komut.Parameters.AddWithValue("@kullaniciGirisAdi", txtKayitKullaniciAd.Text.Trim());
            komut.Parameters.AddWithValue("@kullaniciTc", txtKayitTc.Text.Trim());
            komut.Parameters.AddWithValue("@kullaniciMail", txtKayitMail.Text.Trim());
            komut.Parameters.AddWithValue("@kullaniciTelefon", txtKayitTel.Text.Trim());
            komut.Parameters.AddWithValue("@kullaniciAdres", txtKayitAdres.Text.Trim());
            komut.Parameters.AddWithValue("@kullaniciSifre", txtKayitSifre.Text.Trim());
            komut.ExecuteNonQuery();
            baglanti.Close();


        }

      //------------------------------------------------------------------------------------------------------------------------
        string anlikTc = "2";
        public string VeriAktarimi()
        {
            anlikTc = txtKayitTc.Text;
            return anlikTc;

        }
        public void Fonksiyonlar()
        {
            //baglanti.Open();    //store proc
            //SqlCommand komut = new SqlCommand(" select* from tblullanici", baglanti);
            //SqlDataAdapter da = new SqlDataAdapter(komut); // databaseden verilerin aktarılır
            //DataTable dt = new DataTable();  // tablo olusturarak
            //da.Fill(dt);                     // verilen tabloya aktarılmasını saglıyoruz
            //dataGridView1.DataSource = dt;        // bu tablo uı da gosterılır 
            //baglanti.Close();
        }
    }
}
