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
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int miktar = 0;
            baglanti.Open();
            SqlCommand verioku = new SqlCommand("select * from tblAdminMoney2 where userId= '" + Convert.ToString(ui) + "'", baglanti);
            verioku.ExecuteNonQuery();
            SqlDataReader oku;
            oku = verioku.ExecuteReader();

            while (oku.Read())
            {
                bakiye = Convert.ToInt32(oku["userId"]);
            }
            oku.Close();
            baglanti.Close();
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

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            SaticiEkrani se = new SaticiEkrani(ui);
            se.Show();
            this.Hide();
        }

       
    }
}
