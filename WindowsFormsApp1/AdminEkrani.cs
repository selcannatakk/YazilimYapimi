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
        public AdminEkrani()
        {
            InitializeComponent();

            baglanti.Open();
            SqlCommand komut = new SqlCommand(@" select* from AdminMoney", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridBakiyeOnay.DataSource = dt;
            baglanti.Close();
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=desktop-6LL8GP9;Initial Catalog=Projets;Integrated Security=True");

        private void AdminEkrani_Load(object sender, EventArgs e)
        {

        }

        private void btnKayitKayitOl_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            giris.Hide();
        }

        private void dataGridBakiyeOnay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridBakiyeOnay.SelectedCells[0].RowIndex;
            label1.Text = dataGridBakiyeOnay.Rows[secilialan].Cells[0].Value.ToString();
            label2.Text = dataGridBakiyeOnay.Rows[secilialan].Cells[1].Value.ToString();
        }
}
}
