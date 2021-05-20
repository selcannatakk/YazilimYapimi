
namespace WindowsFormsApp1
{
    partial class Hareketler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Hareketler
            // 
            this.ClientSize = new System.Drawing.Size(593, 480);
            this.Name = "Hareketler";
            this.Load += new System.EventHandler(this.Hareketler_Load_1);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSaticiTutar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSaticiFiyat;
        private System.Windows.Forms.Label lblSaticiUrunMiktar;
        private System.Windows.Forms.Label lblSaticiUrunAd;
        private System.Windows.Forms.Label lblSaticiId;
        private Guna.UI2.WinForms.Guna2Button guna2BtnAl;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private ProjetsDataSet projetsDataSet;
        private System.Windows.Forms.BindingSource tblProduct2BindingSource;
        private ProjetsDataSetTableAdapters.tblProduct2TableAdapter tblProduct2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
    }
}