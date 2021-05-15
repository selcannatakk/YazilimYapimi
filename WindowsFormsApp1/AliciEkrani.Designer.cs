
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridTumUrunler = new System.Windows.Forms.DataGridView();
            this.btnAliciAl = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAliciUrunGoster = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtAliciUrunAdi = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAliciEkle = new System.Windows.Forms.Button();
            this.txtAliciBakiye = new System.Windows.Forms.TextBox();
            this.dataGridBakiye = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTumUrunler)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBakiye)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Controls.Add(this.btnAliciAl);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.btnAliciUrunGoster);
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Controls.Add(this.txtAliciUrunAdi);
            this.groupBox5.Location = new System.Drawing.Point(51, 214);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(864, 315);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridTumUrunler);
            this.groupBox2.Location = new System.Drawing.Point(308, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 267);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tüm Ürünler";
            // 
            // dataGridTumUrunler
            // 
            this.dataGridTumUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTumUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridTumUrunler.Location = new System.Drawing.Point(3, 18);
            this.dataGridTumUrunler.Name = "dataGridTumUrunler";
            this.dataGridTumUrunler.RowHeadersWidth = 51;
            this.dataGridTumUrunler.RowTemplate.Height = 24;
            this.dataGridTumUrunler.Size = new System.Drawing.Size(520, 246);
            this.dataGridTumUrunler.TabIndex = 0;
            // 
            // btnAliciAl
            // 
            this.btnAliciAl.Location = new System.Drawing.Point(60, 155);
            this.btnAliciAl.Name = "btnAliciAl";
            this.btnAliciAl.Size = new System.Drawing.Size(75, 23);
            this.btnAliciAl.TabIndex = 19;
            this.btnAliciAl.Text = "Al";
            this.btnAliciAl.UseVisualStyleBackColor = true;
            this.btnAliciAl.Click += new System.EventHandler(this.btnAliciAl_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ürün Miktari";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ürün Adı";
            // 
            // btnAliciUrunGoster
            // 
            this.btnAliciUrunGoster.Location = new System.Drawing.Point(168, 155);
            this.btnAliciUrunGoster.Name = "btnAliciUrunGoster";
            this.btnAliciUrunGoster.Size = new System.Drawing.Size(75, 23);
            this.btnAliciUrunGoster.TabIndex = 13;
            this.btnAliciUrunGoster.Text = "Göster";
            this.btnAliciUrunGoster.UseVisualStyleBackColor = true;
            this.btnAliciUrunGoster.Click += new System.EventHandler(this.btnAliciUrunGoster_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(143, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 9;
            // 
            // txtAliciUrunAdi
            // 
            this.txtAliciUrunAdi.Location = new System.Drawing.Point(143, 52);
            this.txtAliciUrunAdi.Name = "txtAliciUrunAdi";
            this.txtAliciUrunAdi.Size = new System.Drawing.Size(100, 22);
            this.txtAliciUrunAdi.TabIndex = 8;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAliciEkle);
            this.groupBox4.Controls.Add(this.txtAliciBakiye);
            this.groupBox4.Controls.Add(this.dataGridBakiye);
            this.groupBox4.Location = new System.Drawing.Point(51, 54);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(852, 154);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bakiye Ekle";
            // 
            // btnAliciEkle
            // 
            this.btnAliciEkle.Location = new System.Drawing.Point(192, 58);
            this.btnAliciEkle.Name = "btnAliciEkle";
            this.btnAliciEkle.Size = new System.Drawing.Size(51, 25);
            this.btnAliciEkle.TabIndex = 11;
            this.btnAliciEkle.Text = "Ekle";
            this.btnAliciEkle.UseVisualStyleBackColor = true;
            this.btnAliciEkle.Click += new System.EventHandler(this.btnAliciEkle_Click);
            // 
            // txtAliciBakiye
            // 
            this.txtAliciBakiye.Location = new System.Drawing.Point(35, 61);
            this.txtAliciBakiye.Name = "txtAliciBakiye";
            this.txtAliciBakiye.Size = new System.Drawing.Size(100, 22);
            this.txtAliciBakiye.TabIndex = 10;
            // 
            // dataGridBakiye
            // 
            this.dataGridBakiye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBakiye.Location = new System.Drawing.Point(308, 18);
            this.dataGridBakiye.Name = "dataGridBakiye";
            this.dataGridBakiye.RowHeadersWidth = 51;
            this.dataGridBakiye.RowTemplate.Height = 24;
            this.dataGridBakiye.Size = new System.Drawing.Size(526, 117);
            this.dataGridBakiye.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 2);
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
            this.ClientSize = new System.Drawing.Size(927, 531);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Name = "AliciEkrani";
            this.Text = "AliciEkrani";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTumUrunler)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBakiye)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnAliciUrunGoster;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtAliciUrunAdi;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAliciEkle;
        private System.Windows.Forms.TextBox txtAliciBakiye;
        private System.Windows.Forms.DataGridView dataGridBakiye;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridTumUrunler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAliciAl;
        private System.Windows.Forms.Button button1;
    }
}