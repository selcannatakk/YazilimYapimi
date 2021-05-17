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
    public partial class AnaEkran : Form
    {
        int userId;
        int moneyState;
        SqlConnection baglanti = new SqlConnection(@"Data Source=desktop-6LL8GP9;Initial Catalog=Projets;Integrated Security=True");

        public AnaEkran(int id)
        {
            userId = id;
            //moneyState = state;
            //label1.Text = state.ToString();
            
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaticiEkrani saticiEkrani = new SaticiEkrani(userId);
            saticiEkrani.Show();
            this.Hide();
            //label1.Text = userId.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AliciEkrani aliciEkrani = new AliciEkrani(userId);
            aliciEkrani.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }
    }
}
