using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class AliciEkrani : Form
    {
        int userId;
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-7GMMT8H;Initial Catalog=Projets;Integrated Security=True");
        public AliciEkrani(int id)
        {
            userId = id;
            InitializeComponent();

        }

        private void btnAliciEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into AdminMoney (Money,UserID) values (@Money, @UserID) ",baglanti);
            komut.Parameters.AddWithValue("@Money", txtAliciBakiye.Text);
            komut.Parameters.AddWithValue("@UserID", userId);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }


        private void btnAliciUrunGoster_Click(object sender, EventArgs e)
        {
            /* baglanti.Open();
             SqlCommand komut = new SqlCommand("UrunListeleme", baglanti);
             komut.CommandType = CommandType.StoredProcedure;
             komut.Parameters.AddWithValue("@urunIsmi",txtAliciUrunAdi.Text.Trim());
             SqlDataAdapter da = new SqlDataAdapter(komut); // databaseden verilerin aktarılır
             DataTable dt = new DataTable();  // tablo olusturarak
             da.Fill(dt);                     // verilen tabloya aktarılmasını saglıyoruz
             dataUrun.DataSource = dt;        // bu tablo uı da gosterılır 
             baglanti.Close();*/
        }
        private void btnAliciAl_Click(object sender, EventArgs e)
        {
            /**  // buarda admın ıcın sanal alıcı tablosuna gıdıcek
              baglanti.Open();
              SqlCommand komut = new SqlCommand("UrunListeleme", baglanti); 
              baglanti.Close();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaEkran anaEkran = new AnaEkran(userId);
            anaEkran.Show();
            this.Hide();
        }

        private void AliciEkrani_Load(object sender, EventArgs e)
        {
          

        }




        //******************************************************************************************

        /* public void DataGridBakiyeDoldurma()
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
         }*/

        /* baglanti.Open();    //store proc
          SqlCommand komut = new SqlCommand("SanalBakiyeEkle", baglanti);
          komut.CommandType = CommandType.StoredProcedure;
          komut.Parameters.AddWithValue("@kullaniciTc",anlikTc.Trim() );
          komut.Parameters.AddWithValue("@kullaniciBakiye", txtAliciBakiye.Text.Trim());
          komut.ExecuteNonQuery();
          baglanti.Close();*/


    }
}
