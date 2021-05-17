
namespace WindowsFormsApp1
{
    partial class AliciEkrani
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
            this.components = new System.ComponentModel.Container();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAliciAl = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAliciEkle = new System.Windows.Forms.Button();
            this.txtAliciBakiye = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAliciUrunGoster = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtAliciUrunAdi = new System.Windows.Forms.TextBox();
            this.tblProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Controls.Add(this.btnAliciAl);
            this.groupBox5.Controls.Add(this.groupBox4);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.btnAliciUrunGoster);
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Controls.Add(this.txtAliciUrunAdi);
            this.groupBox5.Location = new System.Drawing.Point(12, 44);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(704, 315);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Alıcı İşlem";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(248, 21);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(452, 267);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tüm Ürünler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(446, 248);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAliciAl
            // 
            this.btnAliciAl.Location = new System.Drawing.Point(60, 282);
            this.btnAliciAl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAliciAl.Name = "btnAliciAl";
            this.btnAliciAl.Size = new System.Drawing.Size(75, 23);
            this.btnAliciAl.TabIndex = 19;
            this.btnAliciAl.Text = "Al";
            this.btnAliciAl.UseVisualStyleBackColor = true;
            this.btnAliciAl.Click += new System.EventHandler(this.btnAliciAl_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAliciEkle);
            this.groupBox4.Controls.Add(this.txtAliciBakiye);
            this.groupBox4.Location = new System.Drawing.Point(23, 39);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(176, 63);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bakiye Ekle";
            // 
            // btnAliciEkle
            // 
            this.btnAliciEkle.Location = new System.Drawing.Point(117, 25);
            this.btnAliciEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAliciEkle.Name = "btnAliciEkle";
            this.btnAliciEkle.Size = new System.Drawing.Size(51, 25);
            this.btnAliciEkle.TabIndex = 11;
            this.btnAliciEkle.Text = "Ekle";
            this.btnAliciEkle.UseVisualStyleBackColor = true;
            this.btnAliciEkle.Click += new System.EventHandler(this.btnAliciEkle_Click);
            // 
            // txtAliciBakiye
            // 
            this.txtAliciBakiye.Location = new System.Drawing.Point(11, 25);
            this.txtAliciBakiye.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAliciBakiye.Name = "txtAliciBakiye";
            this.txtAliciBakiye.Size = new System.Drawing.Size(100, 22);
            this.txtAliciBakiye.TabIndex = 10;
            this.txtAliciBakiye.TextChanged += new System.EventHandler(this.txtAliciBakiye_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ürün Miktari";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ürün Adı";
            // 
            // btnAliciUrunGoster
            // 
            this.btnAliciUrunGoster.Location = new System.Drawing.Point(168, 282);
            this.btnAliciUrunGoster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAliciUrunGoster.Name = "btnAliciUrunGoster";
            this.btnAliciUrunGoster.Size = new System.Drawing.Size(75, 23);
            this.btnAliciUrunGoster.TabIndex = 13;
            this.btnAliciUrunGoster.Text = "Göster";
            this.btnAliciUrunGoster.UseVisualStyleBackColor = true;
            this.btnAliciUrunGoster.Click += new System.EventHandler(this.btnAliciUrunGoster_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(140, 218);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 9;
            // 
            // txtAliciUrunAdi
            // 
            this.txtAliciUrunAdi.Location = new System.Drawing.Point(140, 178);
            this.txtAliciUrunAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAliciUrunAdi.Name = "txtAliciUrunAdi";
            this.txtAliciUrunAdi.Size = new System.Drawing.Size(100, 22);
            this.txtAliciUrunAdi.TabIndex = 8;
            // 
            // tblProductBindingSource
            // 
            this.tblProductBindingSource.DataMember = "tblProduct";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 25);
            this.button1.TabIndex = 12;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AliciEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 370);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox5);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AliciEkrani";
            this.Text = "a";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtAliciUrunAdi;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAliciEkle;
        private System.Windows.Forms.TextBox txtAliciBakiye;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAliciAl;
        private System.Windows.Forms.Button button1;
        
        private System.Windows.Forms.BindingSource tblProductBindingSource;
      
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrideDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAliciUrunGoster;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}