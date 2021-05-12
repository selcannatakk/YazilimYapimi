
namespace WindowsFormsApp1
{
    partial class KayitEkrani
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
            this.btnKayitGirisYap = new System.Windows.Forms.Button();
            this.btnKayitKayitOl = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblKayitTc = new System.Windows.Forms.Label();
            this.txtKayitKullaniciAd = new System.Windows.Forms.TextBox();
            this.txtKayitSifre = new System.Windows.Forms.TextBox();
            this.txtKayitTel = new System.Windows.Forms.TextBox();
            this.txtKayitMail = new System.Windows.Forms.TextBox();
            this.txtKayitAdres = new System.Windows.Forms.TextBox();
            this.txtKayitSoyad = new System.Windows.Forms.TextBox();
            this.txtKayitTc = new System.Windows.Forms.TextBox();
            this.txtKayitAd = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKayitGirisYap
            // 
            this.btnKayitGirisYap.Location = new System.Drawing.Point(365, 338);
            this.btnKayitGirisYap.Name = "btnKayitGirisYap";
            this.btnKayitGirisYap.Size = new System.Drawing.Size(156, 28);
            this.btnKayitGirisYap.TabIndex = 10;
            this.btnKayitGirisYap.Text = "Giris Yap";
            this.btnKayitGirisYap.UseVisualStyleBackColor = true;
            this.btnKayitGirisYap.Click += new System.EventHandler(this.btnKayitGirisYap_Click);
            // 
            // btnKayitKayitOl
            // 
            this.btnKayitKayitOl.Location = new System.Drawing.Point(588, 338);
            this.btnKayitKayitOl.Name = "btnKayitKayitOl";
            this.btnKayitKayitOl.Size = new System.Drawing.Size(167, 28);
            this.btnKayitKayitOl.TabIndex = 11;
            this.btnKayitKayitOl.Text = "Kayit Ol";
            this.btnKayitKayitOl.UseVisualStyleBackColor = true;
            this.btnKayitKayitOl.Click += new System.EventHandler(this.btnKayitKayitOl_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblKayitTc);
            this.groupBox1.Controls.Add(this.txtKayitKullaniciAd);
            this.groupBox1.Controls.Add(this.btnKayitKayitOl);
            this.groupBox1.Controls.Add(this.txtKayitSifre);
            this.groupBox1.Controls.Add(this.btnKayitGirisYap);
            this.groupBox1.Controls.Add(this.txtKayitTel);
            this.groupBox1.Controls.Add(this.txtKayitMail);
            this.groupBox1.Controls.Add(this.txtKayitAdres);
            this.groupBox1.Controls.Add(this.txtKayitSoyad);
            this.groupBox1.Controls.Add(this.txtKayitTc);
            this.groupBox1.Controls.Add(this.txtKayitAd);
            this.groupBox1.Location = new System.Drawing.Point(39, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(797, 421);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblKayitTc
            // 
            this.lblKayitTc.AutoSize = true;
            this.lblKayitTc.Location = new System.Drawing.Point(181, 226);
            this.lblKayitTc.Name = "lblKayitTc";
            this.lblKayitTc.Size = new System.Drawing.Size(24, 17);
            this.lblKayitTc.TabIndex = 18;
            this.lblKayitTc.Text = "Tc";
            // 
            // txtKayitKullaniciAd
            // 
            this.txtKayitKullaniciAd.Location = new System.Drawing.Point(300, 157);
            this.txtKayitKullaniciAd.Name = "txtKayitKullaniciAd";
            this.txtKayitKullaniciAd.Size = new System.Drawing.Size(100, 22);
            this.txtKayitKullaniciAd.TabIndex = 17;
            // 
            // txtKayitSifre
            // 
            this.txtKayitSifre.Location = new System.Drawing.Point(588, 178);
            this.txtKayitSifre.Name = "txtKayitSifre";
            this.txtKayitSifre.Size = new System.Drawing.Size(100, 22);
            this.txtKayitSifre.TabIndex = 16;
            // 
            // txtKayitTel
            // 
            this.txtKayitTel.Location = new System.Drawing.Point(588, 226);
            this.txtKayitTel.Name = "txtKayitTel";
            this.txtKayitTel.Size = new System.Drawing.Size(100, 22);
            this.txtKayitTel.TabIndex = 15;
            // 
            // txtKayitMail
            // 
            this.txtKayitMail.Location = new System.Drawing.Point(588, 60);
            this.txtKayitMail.Name = "txtKayitMail";
            this.txtKayitMail.Size = new System.Drawing.Size(100, 22);
            this.txtKayitMail.TabIndex = 14;
            // 
            // txtKayitAdres
            // 
            this.txtKayitAdres.Location = new System.Drawing.Point(588, 103);
            this.txtKayitAdres.Name = "txtKayitAdres";
            this.txtKayitAdres.Size = new System.Drawing.Size(100, 22);
            this.txtKayitAdres.TabIndex = 13;
            // 
            // txtKayitSoyad
            // 
            this.txtKayitSoyad.Location = new System.Drawing.Point(300, 103);
            this.txtKayitSoyad.Name = "txtKayitSoyad";
            this.txtKayitSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtKayitSoyad.TabIndex = 12;
            // 
            // txtKayitTc
            // 
            this.txtKayitTc.Location = new System.Drawing.Point(300, 223);
            this.txtKayitTc.Name = "txtKayitTc";
            this.txtKayitTc.Size = new System.Drawing.Size(100, 22);
            this.txtKayitTc.TabIndex = 11;
            // 
            // txtKayitAd
            // 
            this.txtKayitAd.Location = new System.Drawing.Point(300, 60);
            this.txtKayitAd.Name = "txtKayitAd";
            this.txtKayitAd.Size = new System.Drawing.Size(100, 22);
            this.txtKayitAd.TabIndex = 10;
            // 
            // KayitEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 552);
            this.Controls.Add(this.groupBox1);
            this.Name = "KayitEkrani";
            this.Text = "KayitEkrani";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnKayitGirisYap;
        private System.Windows.Forms.Button btnKayitKayitOl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKayitKullaniciAd;
        private System.Windows.Forms.TextBox txtKayitSifre;
        private System.Windows.Forms.TextBox txtKayitTel;
        private System.Windows.Forms.TextBox txtKayitMail;
        private System.Windows.Forms.TextBox txtKayitAdres;
        private System.Windows.Forms.TextBox txtKayitSoyad;
        private System.Windows.Forms.TextBox txtKayitTc;
        private System.Windows.Forms.TextBox txtKayitAd;
        private System.Windows.Forms.Label lblKayitTc;
    }
}