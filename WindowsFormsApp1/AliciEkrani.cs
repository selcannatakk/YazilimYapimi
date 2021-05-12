using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AliciEkrani : Form
    {
        public AliciEkrani()
        {
            InitializeComponent();
            string anlikTc;
            KayitEkrani kayitEkrani = new KayitEkrani();
            anlikTc= kayitEkrani.VeriAktarimi();
        }


        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
