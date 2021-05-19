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
        public Hareketler(int userId)
        {
            ui = userId;
            InitializeComponent();
        }

        private void Hareketler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'projetsDataSet.tblProduct2' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblProduct2TableAdapter.Fill(this.projetsDataSet.tblProduct2);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //tutarla bakiye karşılaştırılıp uygunsa alışverişine izin verilecek
            //fiyattan tutar düşülecek
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
