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
        SqlConnection baglanti = new SqlConnection(@"Data Source=desktop-6LL8GP9;Initial Catalog=Projets;Integrated Security=True");
        
        private void btnKayitGirisYap_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
           
        }
        private void btnKayitKayitOl_Click(object sender, EventArgs e)
        {
            baglanti.Open();    //store proc
            SqlCommand komut = new SqlCommand(
             "insert into tblUsers(UserName,UserSurName,UserLogin_Name,User_TC_Number,Tel_Number,Address,E_Mail,Password)" +
             "values (@userName, @userSurName, @userLogin_Name, @user_TC_Number, @tel_Number, @address, @e_Mail, @password)", baglanti);
            komut.Parameters.AddWithValue("@userName", txtKayitAd.Text);
            komut.Parameters.AddWithValue("@userSurName", txtKayitSoyad.Text);
            komut.Parameters.AddWithValue("@userLogin_Name", txtKayitKullaniciAd.Text);
            komut.Parameters.AddWithValue("@user_TC_Number", txtKayitTc.Text);
            komut.Parameters.AddWithValue("@tel_Number", txtKayitTel.Text);
            komut.Parameters.AddWithValue("@address", txtKayitAdres.Text);
            komut.Parameters.AddWithValue("@e_Mail", txtKayitMail.Text);
            komut.Parameters.AddWithValue("@password", txtKayitSifre.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();


        }

      //------------------------------------------------------------------------------------------------------------------------
       /* string anlikTc = "2";
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
        }*/
    }
}
