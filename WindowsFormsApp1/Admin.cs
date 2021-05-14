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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
           // bakiyeOnay();
           // UrunOnay();
          
            

        }
        

        private void button1_Click(object sender, EventArgs e)
        {

        }
       /* public void bakiyeOnay()
        {

            baglanti.Open( );
            SqlCommand commant = new SqlCommand(" select* from tblSanalBakiye", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(commant); // databaseden verilerin aktarılır
            DataTable dt = new DataTable();  // tablo olusturarak
            da.Fill(dt);                     // verilen tabloya aktarılmasını saglıyoruz
            dataGridBakiyeOnay.DataSource = dt;        // bu tablo uı da gosterılır 
            baglanti.Close();
        }
        public void UrunOnay()
        {

            baglanti.Open();
            SqlCommand commant = new SqlCommand(" select* from tblSanalSatici", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(commant); // databaseden verilerin aktarılır
            DataTable dt = new DataTable();  // tablo olusturarak
            da.Fill(dt);                     // verilen tabloya aktarılmasını saglıyoruz
            dataGridSaticiUrunOnay.DataSource = dt;        // bu tablo uı da gosterılır 
            baglanti.Close();
        }***/

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
