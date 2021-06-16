
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblua = new System.Windows.Forms.Label();
            this.lblup = new System.Windows.Forms.Label();
            this.lblAdi = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lblurunFiyati = new System.Windows.Forms.Label();
            this.lblUrunMiktar = new System.Windows.Forms.Label();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DataGridView2 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(473, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(284, 171);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BAKİYE";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(280, 154);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUrunOnay_CellClick);
            // 
            // lblua
            // 
            this.lblua.AutoSize = true;
            this.lblua.ForeColor = System.Drawing.Color.Yellow;
            this.lblua.Location = new System.Drawing.Point(624, 246);
            this.lblua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblua.Name = "lblua";
            this.lblua.Size = new System.Drawing.Size(35, 13);
            this.lblua.TabIndex = 25;
            this.lblua.Text = "XXXX";
            // 
            // lblup
            // 
            this.lblup.AutoSize = true;
            this.lblup.ForeColor = System.Drawing.Color.Yellow;
            this.lblup.Location = new System.Drawing.Point(624, 282);
            this.lblup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblup.Name = "lblup";
            this.lblup.Size = new System.Drawing.Size(35, 13);
            this.lblup.TabIndex = 26;
            this.lblup.Text = "XXXX";
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.ForeColor = System.Drawing.Color.Yellow;
            this.lblAdi.Location = new System.Drawing.Point(222, 234);
            this.lblAdi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(35, 13);
            this.lblAdi.TabIndex = 28;
            this.lblAdi.Text = "XXXX";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.ForeColor = System.Drawing.Color.Yellow;
            this.lblid.Location = new System.Drawing.Point(222, 300);
            this.lblid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(35, 13);
            this.lblid.TabIndex = 27;
            this.lblid.Text = "XXXX";
            // 
            // lblurunFiyati
            // 
            this.lblurunFiyati.AutoSize = true;
            this.lblurunFiyati.ForeColor = System.Drawing.Color.Yellow;
            this.lblurunFiyati.Location = new System.Drawing.Point(222, 277);
            this.lblurunFiyati.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblurunFiyati.Name = "lblurunFiyati";
            this.lblurunFiyati.Size = new System.Drawing.Size(35, 13);
            this.lblurunFiyati.TabIndex = 30;
            this.lblurunFiyati.Text = "XXXX";
            // 
            // lblUrunMiktar
            // 
            this.lblUrunMiktar.AutoSize = true;
            this.lblUrunMiktar.ForeColor = System.Drawing.Color.Yellow;
            this.lblUrunMiktar.Location = new System.Drawing.Point(222, 258);
            this.lblUrunMiktar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUrunMiktar.Name = "lblUrunMiktar";
            this.lblUrunMiktar.Size = new System.Drawing.Size(35, 13);
            this.lblUrunMiktar.TabIndex = 31;
            this.lblUrunMiktar.Text = "XXXX";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ÜRÜN ADI";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "ÜRÜN ADI";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 125;
            // 
            // ProductAmount
            // 
            this.ProductAmount.DataPropertyName = "ProductAmount";
            this.ProductAmount.HeaderText = "MİKTAR";
            this.ProductAmount.MinimumWidth = 6;
            this.ProductAmount.Name = "ProductAmount";
            this.ProductAmount.Width = 125;
            // 
            // ProductPrice
            // 
            this.ProductPrice.DataPropertyName = "ProductPrice";
            this.ProductPrice.HeaderText = "FİYAT";
            this.ProductPrice.MinimumWidth = 6;
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Width = 125;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.ContainerControl = this;
            this.guna2DragControl1.TargetControl = this;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(723, -1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 32;
            // 
            // guna2DataGridView2
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.guna2DataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView2.BackgroundColor = System.Drawing.Color.Silver;
            this.guna2DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView2.ColumnHeadersHeight = 27;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView2.DefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2DataGridView2.EnableHeadersVisualStyles = false;
            this.guna2DataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.guna2DataGridView2.Location = new System.Drawing.Point(2, 15);
            this.guna2DataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2DataGridView2.Name = "guna2DataGridView2";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.guna2DataGridView2.RowHeadersVisible = false;
            this.guna2DataGridView2.RowHeadersWidth = 51;
            this.guna2DataGridView2.RowTemplate.Height = 24;
            this.guna2DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView2.Size = new System.Drawing.Size(414, 160);
            this.guna2DataGridView2.TabIndex = 1;
            this.guna2DataGridView2.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView2.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.guna2DataGridView2.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.Height = 27;
            this.guna2DataGridView2.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView2.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.guna2DataGridView2.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView2_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.guna2DataGridView2);
            this.groupBox2.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox2.Location = new System.Drawing.Point(9, 36);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(418, 177);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ÜRÜN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(120, 258);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "ÜRÜN MİKTARI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(131, 277);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "ÜRÜN FİYATI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(146, 234);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "ÜRÜN ADI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(151, 300);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "SATICI ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(561, 282);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "BAKİYE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(530, 246);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "KULLANICI ID:";
            // 
            // guna2Button3
            // 
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Image = global::WindowsFormsApp1.Properties.Resources.ONAY;
            this.guna2Button3.Location = new System.Drawing.Point(564, 331);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(95, 21);
            this.guna2Button3.TabIndex = 35;
            this.guna2Button3.Text = "ONAYLA";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Image = global::WindowsFormsApp1.Properties.Resources.ONAY;
            this.guna2Button2.Location = new System.Drawing.Point(158, 331);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(95, 21);
            this.guna2Button2.TabIndex = 34;
            this.guna2Button2.Text = "ONAYLA";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::WindowsFormsApp1.Properties.Resources.geriiiiiii;
            this.guna2Button1.Location = new System.Drawing.Point(-1, -1);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(52, 23);
            this.guna2Button1.TabIndex = 33;
            this.guna2Button1.Text = "GERİ";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.CheckedState.Parent = this.guna2Button4;
            this.guna2Button4.CustomImages.Parent = this.guna2Button4;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.Parent = this.guna2Button4;
            this.guna2Button4.Image = global::WindowsFormsApp1.Properties.Resources.ürün;
            this.guna2Button4.Location = new System.Drawing.Point(681, 347);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(87, 21);
            this.guna2Button4.TabIndex = 42;
            this.guna2Button4.Text = "Hareket";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // AdminEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(769, 330);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.lblUrunMiktar);
            this.Controls.Add(this.lblurunFiyati);
            this.Controls.Add(this.lblAdi);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lblup);
            this.Controls.Add(this.lblua);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminEkrani";
            this.Text = " ";
            this.Load += new System.EventHandler(this.AdminEkrani_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    
        private System.Windows.Forms.Label lblua;
        private System.Windows.Forms.Label lblup;
        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblurunFiyati;
        private System.Windows.Forms.Label lblUrunMiktar;
     //   private ProjetsDataSetTableAdapters.tblProductTableAdapter tblProductTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Money;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
    }
}