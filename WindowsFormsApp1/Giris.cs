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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=desktop-6LL8GP9;Initial Catalog=Projets;Integrated Security=True");
        private void btnGirisGirisYap_Click(object sender, EventArgs e)
        {
           // baglanti.Open();

           // SqlParameter[] parameters = new SqlParameter[]
           //{
           //      new SqlParameter("@Username",SqlDbType.NVarChar),
           //      new SqlParameter("@Password",SqlDbType.NVarChar)
           //};
           //  parameters[0].Value = txtKullaniciAd.Text;
           //  parameters[1].Value = txtsifre.Text;
            
           // SqlCommand komut = new SqlCommand("select * From tblUsers where UserName=@Username AND Password=@Password", baglanti);
           // SqlDataReader dr = komut.ExecuteReader();
           // if (dr.Read())
           //  {
           //     MessageBox.Show("gtbhd");
           //  }
           //  else
           //  {
           //      MessageBox.Show("UserName or Pasword invalid!");

           //  }
           // baglanti.Close();

           // /*id donucek*/
           // baglanti.Open();
           // SqlCommand command = new SqlCommand("select UserID *from tblUsers where UserLogin_Name = @userLogin_Name and Password=@password", baglanti);
           ////abel5.Text = command.ToString();
           // SqlDataReader usersData = command.ExecuteReader();
           // if (usersData.Read())
           // {
           //     label5.Text= usersData["UserID"].ToString();
           // }
           // else
           // {

           // }
            
           // baglanti.Close();

            //baglanti.Open();    //store proc
            //SqlCommand command = new SqlCommand(@"exec userLogin ", baglanti);
            //command.CommandType = CommandType.StoredProcedure;
            //command.Parameters.AddWithValue("@Username", txtKullaniciAd.Text.Trim());
            //command.Parameters.AddWithValue("@Password", txtsifre.Text.Trim());

           
           //ataTable dataTable = usersData.HasRows.ToString();

            //    if (dataTable.Rows.Count>0)
            //    {
            //        //giris
            //        SqlCommand komut SqlCommand("select UserID *from tblUsers where UserLogin_Name = @userLogin_Name and Password=@password", baglanti);
            //        label5.Text = komut.ExecuteNonQuery();

            //    }
            //    else
            //    {

            //    }

            //    baglanti.Close();
        }

        private void cmbGirisKullanici_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
