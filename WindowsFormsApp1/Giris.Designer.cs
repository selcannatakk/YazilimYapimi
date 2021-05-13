
namespace WindowsFormsApp1
{
    partial class Giris
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
            this.btnGirisGirisYap = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.cmbGirisKullanici = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnGirisGirisYap
            // 
            this.btnGirisGirisYap.Location = new System.Drawing.Point(195, 256);
            this.btnGirisGirisYap.Name = "btnGirisGirisYap";
            this.btnGirisGirisYap.Size = new System.Drawing.Size(261, 32);
            this.btnGirisGirisYap.TabIndex = 11;
            this.btnGirisGirisYap.Text = "Giris Yap";
            this.btnGirisGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisGirisYap.Click += new System.EventHandler(this.btnGirisGirisYap_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Sifre";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Kullanıcı Adı";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(310, 72);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(146, 22);
            this.textBox7.TabIndex = 23;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(310, 123);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(146, 22);
            this.textBox6.TabIndex = 22;
            // 
            // cmbGirisKullanici
            // 
            this.cmbGirisKullanici.FormattingEnabled = true;
            this.cmbGirisKullanici.Items.AddRange(new object[] {
            "Admin Girişi",
            "Alıcı Girişi",
            "Satıcı Girişi"});
            this.cmbGirisKullanici.Location = new System.Drawing.Point(310, 175);
            this.cmbGirisKullanici.Name = "cmbGirisKullanici";
            this.cmbGirisKullanici.Size = new System.Drawing.Size(146, 24);
            this.cmbGirisKullanici.TabIndex = 29;
            this.cmbGirisKullanici.SelectedIndexChanged += new System.EventHandler(this.cmbGirisKullanici_SelectedIndexChanged);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 465);
            this.Controls.Add(this.cmbGirisKullanici);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.btnGirisGirisYap);
            this.Name = "Giris";
            this.Text = "GirisEkrani";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGirisGirisYap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox cmbGirisKullanici;
    }
}

