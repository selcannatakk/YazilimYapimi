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
        public AdminEkrani()
        {
            
            InitializeComponent();

            
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

      
        private void dataGridUrunOnay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                lblua.Text = dataGridView1.Rows[e.RowIndex].Cells["User"].FormattedValue.ToString();
                lblup.Text = dataGridView1.Rows[e.RowIndex].Cells["Money"].FormattedValue.ToString();  
            }
            
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(@"insert into tblProduct2 (ProductName,ProductAmount,ProductPrice,UserID) 
            values(@productName,@productAmount,@productPrice,@userID)", baglanti);
            komut.Parameters.AddWithValue("@productName", lblAdi.Text);
            komut.Parameters.AddWithValue("@productAmount", Convert.ToInt32(lblUrunMiktar.Text));
            komut.Parameters.AddWithValue("@productPrice", Convert.ToInt32(lblurunFiyati.Text));
            komut.Parameters.AddWithValue("@userID", Convert.ToInt32(lblid.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Onay İşlemi Gerçekleşti.");
            //DELETEEEEEEEEEEEEEEEEE UNUTMAAAAAA
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select UserID From tblAdminMoney2 where UserID=@userID", baglanti);
            komut.Parameters.AddWithValue("@userID", Convert.ToInt32(lblua.Text));

            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                // update
                dr.Close();
                SqlCommand komut3 = new SqlCommand(@"
                update tblAdminMoney2 set MoneyAmount = MoneyAmount + @money where UserID = @userID ", baglanti);
                komut3.Parameters.AddWithValue("@Money", lblup.Text);
                komut3.Parameters.AddWithValue("@userID", Convert.ToInt32(lblua.Text));
                komut3.ExecuteNonQuery();
                MessageBox.Show("Onay İşlemi Gerçekleşti.");
                
            }
            else
            {      
                // insert
                dr.Close();
                SqlCommand komut2 = new SqlCommand(@"
                insert into tblAdminMoney2 (MoneyAmount,UserID) 
                values(@moneyAmount,@userID)", baglanti);
                komut2.Parameters.AddWithValue("@moneyAmount", Convert.ToInt32(lblup.Text));
                komut2.Parameters.AddWithValue("@userID", Convert.ToInt32(lblua.Text));
                komut2.ExecuteNonQuery();
                MessageBox.Show("Onay İşlemi Gerçekleşti.");

            }
            SqlCommand command = new SqlCommand(@"delete from AdminMoney where UserID=@userID", baglanti);
            command.Parameters.AddWithValue("@userID", Convert.ToInt32(lblua.Text));
            command.ExecuteNonQuery();
            MessageBox.Show("Silme İşlemi Gerçekleşti.");
            baglanti.Close();
            this.adminMoneyTableAdapter.Fill(this.projetsDataSet.AdminMoney);
            baglanti.Close();


           


            //baglanti.Open();
            //SqlCommand komut = new SqlCommand(@"insert into tblAdminMoney2 (MoneyAmount,UserID) 
            //values(@moneyAmount,@userID)", baglanti);
            //komut.Parameters.AddWithValue("@moneyAmount", Convert.ToInt32(lblup.Text));
            //komut.Parameters.AddWithValue("@userID", Convert.ToInt32(lblua.Text));
            //komut.ExecuteNonQuery();

            //MessageBox.Show("Onay İşlemi Gerçekleşti.");
            ////delete unutma
            //SqlCommand command = new SqlCommand(@"delete from AdminMoney where UserID=@userID", baglanti);
            //command.Parameters.AddWithValue("@userID", Convert.ToInt32(lblua.Text));
            //command.ExecuteNonQuery();
            //MessageBox.Show("Silme İşlemi Gerçekleşti.");
            //baglanti.Close();

            //this.adminMoneyTableAdapter.Fill(this.projetsDataSet.AdminMoney);

            //bakiye güncelleme user id döndür varmı yokmu varsa update yoksa insert into
            //baglanti.Open();
            //SqlCommand komut = new SqlCommand(@"update tblAdminMoney2 set MoneyAmount = MoneyAmount + @money where UserID = @userID ", baglanti);
            //komut.Parameters.AddWithValue("@Money", txtBakiye.Text);
            //komut.Parameters.AddWithValue("@UserID", userId);
            //komut.ExecuteNonQuery();
            //baglanti.Close();


        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Hareket hareket = new Hareket();
            hareket.Show();
            this.Hide();
        }
    }
}
