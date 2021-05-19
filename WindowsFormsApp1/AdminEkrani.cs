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
using System;

namespace WindowsFormsApp1
{
    public partial class AdminEkrani : Form
    {
        int userId;
        
        SqlConnection baglanti = new SqlConnection(@"Data Source=desktop-6LL8GP9;Initial Catalog=Projets;Integrated Security=True");
        public AdminEkrani(int id)
        {
            
            InitializeComponent();

            
        }
       

        private void button3_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            giris.Hide();
        }

      
       

        

       

       

        private void AdminEkrani_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projetsDataSet.tblProduct' table. You can move, or remove it, as needed.
            this.tblProductTableAdapter.Fill(this.projetsDataSet.tblProduct);
            // TODO: This line of code loads data into the 'projetsDataSet.AdminMoney' table. You can move, or remove it, as needed.
            this.adminMoneyTableAdapter.Fill(this.projetsDataSet.AdminMoney);

        }

        private void guna2DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (guna2DataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!= null)
            {
                guna2DataGridView2.CurrentRow.Selected = true;
                lblAdi.Text= guna2DataGridView2.Rows[e.RowIndex].Cells["productNameDataGridViewTextBoxColumn1"].FormattedValue.ToString();
                lblUrunMiktar.Text = guna2DataGridView2.Rows[e.RowIndex].Cells["productAmountDataGridViewTextBoxColumn"].FormattedValue.ToString();
                lblurunFiyati.Text = guna2DataGridView2.Rows[e.RowIndex].Cells["productPriceDataGridViewTextBoxColumn"].FormattedValue.ToString();
                lblid.Text= guna2DataGridView2.Rows[e.RowIndex].Cells["userIDDataGridViewTextBoxColumn2"].FormattedValue.ToString();
            }
        }

        private void btnUrunOnay_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand( @"insert into tblProduct2 (ProductName,ProductAmount,ProductPrice,UserID) 
            values(@productName,@productAmount,@productPrice,@userID)",baglanti);
            komut.Parameters.AddWithValue("@productName", lblAdi.Text);
            komut.Parameters.AddWithValue("@productAmount", Convert.ToInt32(lblUrunMiktar.Text));
            komut.Parameters.AddWithValue("@productPrice",Convert.ToInt32(lblurunFiyati.Text));
            komut.Parameters.AddWithValue("@userID", Convert.ToInt32(lblid.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Onay İşlemi Gerçekleşti.");
            //delete unutma
            
        }

        private void dataGridUrunOnay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                lblua.Text = dataGridView1.Rows[e.RowIndex].Cells["User"].FormattedValue.ToString();
                lblup.Text = dataGridView1.Rows[e.RowIndex].Cells["Money"].FormattedValue.ToString();
               
            }
        }

        private void btnbakiyeonay_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(@"insert into tblAdminMoney2 (MoneyAmount,UserID) 
            values(@moneyAmount,@userID)", baglanti);
            komut.Parameters.AddWithValue("@moneyAmount", Convert.ToInt32(lblup.Text));
            komut.Parameters.AddWithValue("@userID", Convert.ToInt32(lblua.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Onay İşlemi Gerçekleşti.");
            //delete unutma
            baglanti.Close();
        }
    }
}
