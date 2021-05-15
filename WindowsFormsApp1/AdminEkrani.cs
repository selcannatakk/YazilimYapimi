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
            SqlCommand komut = new SqlCommand(@" select* from tblVirtualMoneys", baglanti);
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
    }
}
