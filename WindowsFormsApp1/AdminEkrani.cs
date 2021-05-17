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
    public partial class AdminEkrani : Form
    {
        int userId;
        
        SqlConnection baglanti = new SqlConnection(@"Data Source=desktop-6LL8GP9;Initial Catalog=Projets;Integrated Security=True");
        public AdminEkrani(int id)
        {
            userId = id;
            InitializeComponent();

            baglanti.Open();
            SqlCommand komut = new SqlCommand(@" select* from AdminMoney", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridBakiyeOnay.DataSource = dt;

            SqlCommand command = new SqlCommand(@" select* from tblProduct", baglanti);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridUrunOnay.DataSource = dataTable;
            baglanti.Close();
            InitializeComponent();
        }
       

        private void button3_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            giris.Hide();
        }

      
       

        private void btnKayitKayitOl_Click(object sender, EventArgs e)
        {
            bool state;

            baglanti.Open();
            SqlCommand command = new SqlCommand(@"update AdminMoney set State=1 where UserID=@userID",baglanti);
            command.Parameters.AddWithValue("@userID", txtUserID.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("state=1");
            
            SqlCommand komut = new SqlCommand("select State From AdminMoney where UserID=@userID ", baglanti);
            komut.Parameters.AddWithValue("@userID", txtUserID.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                state= Convert.ToBoolean(dr["State"]);
                MessageBox.Show("state"+state);
            }
            baglanti.Close();

            // AnaEkran anaEkran = new AnaEkran(userId,1);


            //SqlDataReader dataReader = command.ExecuteReader();
            //if(dataReader.Read())
            //{
            //    moneyState = 1;
            //}


            baglanti.Close();

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            baglanti.Open();
            SqlCommand command = new SqlCommand(@"update tblProduct set State=1 where ProductID=@productID", baglanti);
            command.Parameters.AddWithValue("@productID", Convert.ToInt32(txtId.Text));
            command.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
