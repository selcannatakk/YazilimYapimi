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
        SqlConnection baglanti = new SqlConnection(@"Data Source=desktop-6LL8GP9;Initial Catalog=Projets;Integrated Security=True");

        //  string saticiMoney;
        public SaticiEkrani(int id)
        {
            userId = id;
            
            
            
            InitializeComponent();
          
        }



        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
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

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into AdminMoney (Money,UserID) values (@Money, @UserID) ", baglanti);
            komut.Parameters.AddWithValue("@Money", txtBakiye.Text);
            komut.Parameters.AddWithValue("@UserID", userId);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void SaticiEkrani_Load(object sender, EventArgs e)
        {

        }

        private void dataGridBakiyeOnay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
