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
        public AnaEkran(int id)
        {
            userId = id;
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
