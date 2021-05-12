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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        private void btnGirisGirisYap_Click(object sender, EventArgs e)
        {
            string anlikTc;                                               // kayit formundan giris formuna veri aktarımı
            KayitEkrani kayitEkrani = new KayitEkrani();
            anlikTc = kayitEkrani.VeriAktarimi();
            if (cmbGirisKullanici.Text=="Admin Girişi")
            {
                Admin admin = new Admin();
                admin.Show();
                this.Hide();
            }
             else if (cmbGirisKullanici.Text == "Alıcı Girişi")
            {
                AliciEkrani aliciEkrani = new AliciEkrani();
                aliciEkrani.Show();
                this.Hide();
            }
            else
            {
                SaticiEkrani saticiEkrani = new SaticiEkrani();
                saticiEkrani.Show();
                this.Hide();
            }
           
        }
    }
}
