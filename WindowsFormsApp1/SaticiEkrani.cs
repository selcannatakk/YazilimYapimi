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
    public partial class SaticiEkrani : Form
    {
        int userId;
      //  string saticiMoney;
        public SaticiEkrani(int id)
        {
            userId = id;
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=desktop-6LL8GP9;Initial Catalog=Projets;Integrated Security=True");
        public void SaticiBakiye()
        {
            //int money;
           // saticiMoney = txtBakiye.Text;
            baglanti.Open();
            SqlCommand komut = new SqlCommand(@"insert into AdminMoney (UserID,Money) values(@userID,@money)",baglanti);
            komut.Parameters.AddWithValue("@userID", userId);
            komut.Parameters.AddWithValue("@money", txtBakiye.Text);
            komut.ExecuteNonQuery();


            baglanti.Close();
            //txtFiyat.Text = saticiMoney;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // bakiye istek

            SaticiBakiye();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            AnaEkran anaEkran = new AnaEkran(userId);
            anaEkran.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int productId;
            baglanti.Open();
            SqlCommand command=new SqlCommand(@"insert into tblProduct (ProductName,ProductAmount,ProductPrice,UserID) 
            values(@productName,@productAmount,@productPrice,@userID)",baglanti);
            command.Parameters.AddWithValue("@userID",userId);
            command.Parameters.AddWithValue("@productName", txtAdi.Text);
            command.Parameters.AddWithValue("@productAmount", txtMiktar.Text);
            command.Parameters.AddWithValue("@productPrice", txtFiyat.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("urun eklendi");
            baglanti.Close();
            baglanti.Open();

            SqlCommand komut = new SqlCommand(@"select P.ProductID from tblUsers U inner join tblProduct P on U.UserID=P.UserID ",baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                productId = Convert.ToInt32(dr["ProductID"]);
                MessageBox.Show("urun id:" + productId);
            }
            else
            {
                MessageBox.Show("urun id alınamadı");
            }

            baglanti.Close();
        }
    }
}
