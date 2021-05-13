using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class AliciEkrani : Form
    {
        string anlikTc;
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-6LL8GP9;Initial Catalog=Project;Integrated Security=True");
        public AliciEkrani()
        {
            InitializeComponent();
            
            KayitEkrani kayitEkrani = new KayitEkrani();
            anlikTc= kayitEkrani.VeriAktarimi();
            DataGridBakiyeDoldurma();
            DataGridTUmUrunlerDoldurma();
            
            

            
        }
        
        private void btnAliciEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();    //store proc
            SqlCommand komut = new SqlCommand("SanalBakiyeEkle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@kullaniciTc",anlikTc.Trim() );
            komut.Parameters.AddWithValue("@kullaniciBakiye", txtAliciBakiye.Text.Trim());
            komut.ExecuteNonQuery();
            baglanti.Close();


        }

       
        private void btnAliciUrunGoster_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UrunListeleme", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@urunIsmi",txtAliciUrunAdi.Text.Trim());
            SqlDataAdapter da = new SqlDataAdapter(komut); // databaseden verilerin aktarılır
            DataTable dt = new DataTable();  // tablo olusturarak
            da.Fill(dt);                     // verilen tabloya aktarılmasını saglıyoruz
            dataUrun.DataSource = dt;        // bu tablo uı da gosterılır 
            baglanti.Close();
        }
        private void btnAliciAl_Click(object sender, EventArgs e)
        {
            // buarda admın ıcın sanal alıcı tablosuna gıdıcek
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UrunListeleme", baglanti); 
            baglanti.Close();
        }




        //******************************************************************************************

        public void DataGridBakiyeDoldurma()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(" select* from tblBakiye", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut); // databaseden verilerin aktarılır
            DataTable dt = new DataTable();  // tablo olusturarak
            da.Fill(dt);                     // verilen tabloya aktarılmasını saglıyoruz
            dataGridBakiye.DataSource = dt;        // bu tablo uı da gosterılır 
            baglanti.Close();
        }
        public void DataGridTUmUrunlerDoldurma()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(" select* from viewUrunler", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut); // databaseden verilerin aktarılır
            DataTable dt = new DataTable();  // tablo olusturarak
            da.Fill(dt);                     // verilen tabloya aktarılmasını saglıyoruz
            dataGridTumUrunler.DataSource = dt;        // bu tablo uı da gosterılır 
            baglanti.Close();
        }

       
    }
}
