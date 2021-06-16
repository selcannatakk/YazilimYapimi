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
using System.Xml;

namespace WindowsFormsApp1
{
    public partial class SaticiEkrani : Form
    {
        int userId;
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-7GMMT8H;Initial Catalog=Projets;Integrated Security=True");

        //  string saticiMoney;
        public SaticiEkrani(int id)
        {
            userId = id;
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand command = new SqlCommand(@"insert into tblProduct (ProductName,ProductAmount,ProductPrice,UserID) 
            values(@productName,@productAmount,@productPrice,@userID)", baglanti);
            command.Parameters.AddWithValue("@userID", userId);
            command.Parameters.AddWithValue("@productName", txtAdi.Text);
            command.Parameters.AddWithValue("@productAmount", txtMiktar.Text);
            command.Parameters.AddWithValue("@productPrice", txtFiyat.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Ürün Admin onayına gönderildi onaylandıktan sonra yayınlacaktır!");
            baglanti.Close();
            txtAdi.Text = "";
            txtMiktar.Text = "";
            txtFiyat.Text = "";



        }
        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into AdminMoney (Money,UserID) values (@Money, @UserID) ", baglanti);
            komut.Parameters.AddWithValue("@Money", txtBakiye.Text);
            komut.Parameters.AddWithValue("@UserID", userId);
            komut.ExecuteNonQuery();
            MessageBox.Show("Bakiye Ekleme Admin onayına gönderildi onaylandıktan sonra yayınlacaktır!");
            baglanti.Close();
        }     
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Hareketler Hareketler = new Hareketler(userId);
            Hareketler.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Giris g = new Giris();
            g.Show();
            this.Hide();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void SaticiEkrani_Load(object sender, EventArgs e)
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldosya = new XmlDocument();
            xmldosya.Load(bugun);

            string dolaralis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            lbldolar.Text = dolaralis;
        }
    }
}
