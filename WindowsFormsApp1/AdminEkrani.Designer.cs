
namespace WindowsFormsApp1
{
    partial class AdminEkrani
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridBakiyeOnay = new System.Windows.Forms.DataGridView();
            this.btnKayitKayitOl = new System.Windows.Forms.Button();
            this.btnKayitGirisYap = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBakiyeOnay)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(40, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 157);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ürün onay";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(301, 136);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridBakiyeOnay);
            this.groupBox2.Location = new System.Drawing.Point(399, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 157);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "bakiye onay";
            // 
            // dataGridBakiyeOnay
            // 
            this.dataGridBakiyeOnay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBakiyeOnay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridBakiyeOnay.Location = new System.Drawing.Point(3, 18);
            this.dataGridBakiyeOnay.Name = "dataGridBakiyeOnay";
            this.dataGridBakiyeOnay.RowHeadersWidth = 51;
            this.dataGridBakiyeOnay.RowTemplate.Height = 24;
            this.dataGridBakiyeOnay.Size = new System.Drawing.Size(343, 136);
            this.dataGridBakiyeOnay.TabIndex = 0;
            // 
            // btnKayitKayitOl
            // 
            this.btnKayitKayitOl.Location = new System.Drawing.Point(424, 211);
            this.btnKayitKayitOl.Name = "btnKayitKayitOl";
            this.btnKayitKayitOl.Size = new System.Drawing.Size(145, 28);
            this.btnKayitKayitOl.TabIndex = 13;
            this.btnKayitKayitOl.Text = "onay";
            this.btnKayitKayitOl.UseVisualStyleBackColor = true;
            this.btnKayitKayitOl.Click += new System.EventHandler(this.btnKayitKayitOl_Click);
            // 
            // btnKayitGirisYap
            // 
            this.btnKayitGirisYap.Location = new System.Drawing.Point(592, 211);
            this.btnKayitGirisYap.Name = "btnKayitGirisYap";
            this.btnKayitGirisYap.Size = new System.Drawing.Size(132, 28);
            this.btnKayitGirisYap.TabIndex = 12;
            this.btnKayitGirisYap.Text = "sil";
            this.btnKayitGirisYap.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "sil";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(43, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 28);
            this.button2.TabIndex = 14;
            this.button2.Text = "onay";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AdminEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnKayitKayitOl);
            this.Controls.Add(this.btnKayitGirisYap);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminEkrani";
            this.Text = "AdminEkrani";
            this.Load += new System.EventHandler(this.AdminEkrani_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBakiyeOnay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridBakiyeOnay;
        private System.Windows.Forms.Button btnKayitKayitOl;
        private System.Windows.Forms.Button btnKayitGirisYap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}