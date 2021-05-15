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
        public SaticiEkrani(int id)
        {
            userId = id;
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=desktop-6LL8GP9;Initial Catalog=Projets;Integrated Security=True");


        private void button2_Click(object sender, EventArgs e)
        {
            //////////////////////////////// ekleme işlemine bak 
            //baglanti.Open();
            //SqlCommand command = new SqlCommand(@"insert into tblVirtualMoneys (UserID,VirtualMoneyAmount) values(@userID,@virtualMoneyAmount)",baglanti);
            //command.Parameters.AddWithValue("@userID", userId.ToString());
            //command.Parameters.AddWithValue("@virtualMoneyAmount", txtBakiye.Text);
            //baglanti.Close();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            AnaEkran anaEkran = new AnaEkran(userId);
            anaEkran.Show();
            this.Hide();

        }
    }
}
