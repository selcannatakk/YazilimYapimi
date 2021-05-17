
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
            this.dataGridUrunOnay = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridBakiyeOnay = new System.Windows.Forms.DataGridView();
            this.btnKayitKayitOl = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUrunOnay)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBakiyeOnay)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridUrunOnay);
            this.groupBox1.Location = new System.Drawing.Point(40, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 157);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ürün onay";
            // 
            // dataGridUrunOnay
            // 
            this.dataGridUrunOnay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUrunOnay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridUrunOnay.Location = new System.Drawing.Point(3, 18);
            this.dataGridUrunOnay.Name = "dataGridUrunOnay";
            this.dataGridUrunOnay.RowHeadersWidth = 51;
            this.dataGridUrunOnay.RowTemplate.Height = 24;
            this.dataGridUrunOnay.Size = new System.Drawing.Size(301, 136);
            this.dataGridUrunOnay.TabIndex = 0;
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
            this.btnKayitKayitOl.Location = new System.Drawing.Point(559, 261);
            this.btnKayitKayitOl.Name = "btnKayitKayitOl";
            this.btnKayitKayitOl.Size = new System.Drawing.Size(124, 28);
            this.btnKayitKayitOl.TabIndex = 13;
            this.btnKayitKayitOl.Text = "onay";
            this.btnKayitKayitOl.UseVisualStyleBackColor = true;
            this.btnKayitKayitOl.Click += new System.EventHandler(this.btnKayitKayitOl_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(328, 382);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 28);
            this.button3.TabIndex = 16;
            this.button3.Text = "geri";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Onaylanıcak UserID:";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(559, 217);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(68, 22);
            this.txtUserID.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Onaylanıcak UserID:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(183, 217);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnKayitKayitOl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminEkrani";
            this.Text = "AdminEkrani";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUrunOnay)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBakiyeOnay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridUrunOnay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridBakiyeOnay;
        private System.Windows.Forms.Button btnKayitKayitOl;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button button1;
    }
}