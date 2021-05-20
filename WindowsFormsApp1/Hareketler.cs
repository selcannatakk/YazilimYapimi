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
    public partial class Hareketler : Form
    {
        int ui;
        int bakiye = 0;
        public Hareketler(int userId)
        {
            ui = userId;
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=desktop-6LL8GP9;Initial Catalog=Projets;Integrated Security=True");
        private void Hareketler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'projetsDataSet.tblProduct2' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblProduct2TableAdapter.Fill(this.projetsDataSet.tblProduct2);

        }
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int saticiBakiye, aliciBakiye;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // alici bilgi alma işlemleri
            int bakiye, urunId;
           

            baglanti.Close();

            baglanti.Open();
            SqlCommand verioku = new SqlCommand(@"select MoneyAmount from tblAdminMoney2 where UserId= @userId", baglanti);
            verioku.Parameters.AddWithValue("@userId",ui);
            verioku.ExecuteNonQuery();
            SqlDataReader oku = verioku.ExecuteReader();
            
            if (oku.Read())
            {
                bakiye = Convert.ToInt32(oku["MoneyAmount"]);
                MessageBox.Show("alıcı bakiye:" + bakiye);
                oku.Close();
                if (bakiye < Convert.ToInt32(lblSaticiTutar.Text))
                {
                    MessageBox.Show("Sahip olsuğunuz bakiye urun tutarından düşük olduğu için işlem gerçekleşmemektedir.\n" +
                        "Sahip olduğunuz bakiye: "+bakiye+"\nAlınmak istenen ürünün tutarı: "+ Convert.ToInt32(lblSaticiTutar.Text));
                }
                else         // al sat işlemi
                {
                    
                    SqlCommand komut = new SqlCommand(@"select ProductID from tblProduct2 where UserId= @userId", baglanti);
                    komut.Parameters.AddWithValue("@userId", lblSaticiId.Text);
                    SqlDataReader veriokuma = komut.ExecuteReader();
                    if(veriokuma.Read())
                    {
                        urunId = Convert.ToInt32(veriokuma["ProductID"]);
                        MessageBox.Show(" satici id:" + Convert.ToInt32(lblSaticiId.Text));
                        MessageBox.Show("urun id:"+urunId);
                        veriokuma.Close();
                        //alici bakiye düşme 

                        SqlCommand data1 = new SqlCommand(@"update tblAdminMoney2 set MoneyAmount = MoneyAmount - @money where UserID = @userID ", baglanti);
                        data1.Parameters.AddWithValue("@Money", lblSaticiTutar.Text);
                        data1.Parameters.AddWithValue("@UserID", ui);
                        data1.ExecuteNonQuery();
                       

                        //satici bakiye artma 

                        SqlCommand data2 = new SqlCommand(@"update tblAdminMoney2 set MoneyAmount = MoneyAmount + @money where UserID = @userID ", baglanti);
                        data2.Parameters.AddWithValue("@Money", lblSaticiTutar.Text);
                        data2.Parameters.AddWithValue("@UserID", Convert.ToInt32(lblSaticiId.Text));
                        data2.ExecuteNonQuery();
                       

                        // yeni bakiyeleri cekme
                        
                        SqlCommand veri1 = new SqlCommand(@"select MoneyAmount from tblAdminMoney2 where UserId= @userId", baglanti);
                        veri1.Parameters.AddWithValue("@userId", Convert.ToInt32(lblSaticiId.Text));
                        veri1.ExecuteNonQuery();
                        SqlDataReader dr = veri1.ExecuteReader();
                        if (dr.Read())
                        {
                            saticiBakiye = Convert.ToInt32(dr["MoneyAmount"]);
                            MessageBox.Show("satici bakiye:" + saticiBakiye);
                        }
                        dr.Close();
                        
                        SqlCommand veri2 = new SqlCommand(@"select MoneyAmount from tblAdminMoney2 where UserId= @userId", baglanti);
                        veri2.Parameters.AddWithValue("@userId", ui);
                        veri2.ExecuteNonQuery();
                        SqlDataReader data = veri2.ExecuteReader();
                        if (data.Read())
                        {
                            aliciBakiye = Convert.ToInt32(data["MoneyAmount"]);
                            MessageBox.Show("alici bakiye:" + aliciBakiye);
                        }
                        dr.Close();
                        
                        // hareketler tablosu 
                        SqlCommand command = new SqlCommand(@"
                            insert into tblHareketler (AliciID,SaticiID,UrunID,AliciBakiye,SaticiBakiye)values(@aliciID,@saticiID,@urunID,@aliciBakiye,@saticiBakiye)", baglanti);
                        command.Parameters.AddWithValue("@aliciID",ui);
                        MessageBox.Show("+++++++++++++");
                        command.Parameters.AddWithValue("@aliciID", Convert.ToInt32(lblSaticiId.Text));
                        command.Parameters.AddWithValue("@urunID", urunId);
                        command.Parameters.AddWithValue("@aliciBakiye", aliciBakiye);
                        command.Parameters.AddWithValue("@saticiBakiye", saticiBakiye);
                        
                        MessageBox.Show("aliciID:" + ui);
                        MessageBox.Show("\nsaticiID:" + Convert.ToInt32(lblSaticiId.Text));
                        MessageBox.Show("\nurunID:" + urunId);
                        MessageBox.Show("\naliciBakiye:" + aliciBakiye);
                        MessageBox.Show("\nsaticiBakiye:" + saticiBakiye);

                        // alınan ürünü satılanürün tablosundan silme


                    }
                    else
                    {
                        MessageBox.Show("ProductId veri okunamadı");
                    }
                }

            }
            else
            {
                MessageBox.Show("Hic bir veri okunamadı..."); 
            }
            
           


            
            baglanti.Close();
          
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            SaticiEkrani se = new SaticiEkrani(ui);
            se.Show();
            this.Hide();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int urunMiktar, urunFiyat;
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                guna2DataGridView1.CurrentRow.Selected = true;
                lblSaticiId.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["userIDDataGridViewTextBoxColumn"].FormattedValue.ToString();
                lblSaticiUrunAd.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["productNameDataGridViewTextBoxColumn"].FormattedValue.ToString();
                lblSaticiUrunMiktar.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["productAmountDataGridViewTextBoxColumn"].FormattedValue.ToString();
                lblSaticiFiyat.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["productPriceDataGridViewTextBoxColumn"].FormattedValue.ToString();

                urunFiyat = Convert.ToInt32(lblSaticiFiyat.Text);
                urunMiktar = Convert.ToInt32(lblSaticiUrunMiktar.Text);

                lblSaticiTutar.Text = (urunMiktar * urunFiyat).ToString();

            }
        }

        // miktar= fiyat x miktar burayı hesapla
        //tutar labelina yazdir
        //ondan sonra bakiyeyle karşılastır ona göre işlem yapılamaz de yada işlem gerçeklesşti de
        //gerçekleşmişsse ürünü sil
        //bakiyeyi düüşürüp tekrardan update et adminmoney2 tabelinda
        //yukarda yaptığım bakiyeyi çekmede yanlış olabilir bi çok şeye baktımda yinede sen kontrol et
        //numlardan başka insert ederken felan sql de int olana text(string) olarak felan yapmaya çalışılan vardı sanki diğer formlarda h

        //tutarla bakiye karşılaştırılıp uygunsa alışverişine izin verilecek
        //bakiyeden tutar düşülecek
        // *** miktar olayı
        //ürün silenecek
        //message boxla alındı denecek
        // zaman kalırsa hareket tablosu yapacağız
    }
}
