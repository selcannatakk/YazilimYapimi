
namespace WindowsFormsApp1
{
    partial class SaticiEkrani
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtAdi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFiyat = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBakiye = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.txtMiktar = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtdolar = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lbldolar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BorderRadius = 10;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.Yellow;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.Black;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Location = new System.Drawing.Point(262, 218);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(126, 45);
            this.guna2GradientButton1.TabIndex = 18;
            this.guna2GradientButton1.Text = "ÜRÜNÜ EKLE";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // txtAdi
            // 
            this.txtAdi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txtAdi.BorderRadius = 6;
            this.txtAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdi.DefaultText = "";
            this.txtAdi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAdi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAdi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdi.DisabledState.Parent = this.txtAdi;
            this.txtAdi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.txtAdi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdi.FocusedState.Parent = this.txtAdi;
            this.txtAdi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAdi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdi.HoverState.Parent = this.txtAdi;
            this.txtAdi.Location = new System.Drawing.Point(262, 68);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.PasswordChar = '\0';
            this.txtAdi.PlaceholderForeColor = System.Drawing.Color.Yellow;
            this.txtAdi.PlaceholderText = "         ÜRÜN ADI";
            this.txtAdi.SelectedText = "";
            this.txtAdi.ShadowDecoration.Parent = this.txtAdi;
            this.txtAdi.Size = new System.Drawing.Size(126, 41);
            this.txtAdi.TabIndex = 33;
            // 
            // txtFiyat
            // 
            this.txtFiyat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txtFiyat.BorderRadius = 6;
            this.txtFiyat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiyat.DefaultText = "";
            this.txtFiyat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFiyat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFiyat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiyat.DisabledState.Parent = this.txtFiyat;
            this.txtFiyat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiyat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.txtFiyat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiyat.FocusedState.Parent = this.txtFiyat;
            this.txtFiyat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFiyat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiyat.HoverState.Parent = this.txtFiyat;
            this.txtFiyat.Location = new System.Drawing.Point(262, 115);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.PasswordChar = '\0';
            this.txtFiyat.PlaceholderForeColor = System.Drawing.Color.Yellow;
            this.txtFiyat.PlaceholderText = "            FİYATI";
            this.txtFiyat.SelectedText = "";
            this.txtFiyat.ShadowDecoration.Parent = this.txtFiyat;
            this.txtFiyat.Size = new System.Drawing.Size(126, 41);
            this.txtFiyat.TabIndex = 34;
            // 
            // txtBakiye
            // 
            this.txtBakiye.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txtBakiye.BorderRadius = 20;
            this.txtBakiye.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBakiye.DefaultText = "";
            this.txtBakiye.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBakiye.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBakiye.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBakiye.DisabledState.Parent = this.txtBakiye;
            this.txtBakiye.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBakiye.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.txtBakiye.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBakiye.FocusedState.Parent = this.txtBakiye;
            this.txtBakiye.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBakiye.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBakiye.HoverState.Parent = this.txtBakiye;
            this.txtBakiye.Location = new System.Drawing.Point(435, 162);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.PasswordChar = '\0';
            this.txtBakiye.PlaceholderForeColor = System.Drawing.Color.Yellow;
            this.txtBakiye.PlaceholderText = "              BAKİYE";
            this.txtBakiye.SelectedText = "";
            this.txtBakiye.ShadowDecoration.Parent = this.txtBakiye;
            this.txtBakiye.Size = new System.Drawing.Size(135, 41);
            this.txtBakiye.TabIndex = 36;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(540, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 38;
            // 
            // txtMiktar
            // 
            this.txtMiktar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txtMiktar.BorderRadius = 6;
            this.txtMiktar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMiktar.DefaultText = "";
            this.txtMiktar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMiktar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMiktar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMiktar.DisabledState.Parent = this.txtMiktar;
            this.txtMiktar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMiktar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.txtMiktar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMiktar.FocusedState.Parent = this.txtMiktar;
            this.txtMiktar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMiktar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMiktar.HoverState.Parent = this.txtMiktar;
            this.txtMiktar.Location = new System.Drawing.Point(262, 162);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.PasswordChar = '\0';
            this.txtMiktar.PlaceholderForeColor = System.Drawing.Color.Yellow;
            this.txtMiktar.PlaceholderText = "            MİKTAR";
            this.txtMiktar.SelectedText = "";
            this.txtMiktar.ShadowDecoration.Parent = this.txtMiktar;
            this.txtMiktar.Size = new System.Drawing.Size(126, 41);
            this.txtMiktar.TabIndex = 39;
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::WindowsFormsApp1.Properties.Resources.ürün;
            this.guna2Button1.Location = new System.Drawing.Point(474, 314);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(111, 26);
            this.guna2Button1.TabIndex = 40;
            this.guna2Button1.Text = "ALIM EKRANI";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.CheckedState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.CustomImages.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.FillColor = System.Drawing.Color.Yellow;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.Black;
            this.guna2CircleButton1.HoverState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Image = global::WindowsFormsApp1.Properties.Resources.BAKİYE;
            this.guna2CircleButton1.Location = new System.Drawing.Point(474, 209);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Size = new System.Drawing.Size(70, 56);
            this.guna2CircleButton1.TabIndex = 37;
            this.guna2CircleButton1.Text = "EKLE";
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Image = global::WindowsFormsApp1.Properties.Resources.geriiiiiii;
            this.guna2Button2.Location = new System.Drawing.Point(-1, -1);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(52, 23);
            this.guna2Button2.TabIndex = 41;
            this.guna2Button2.Text = "GERİ";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.guna2TextBox1.BorderRadius = 6;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(74, 162);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Yellow;
            this.guna2TextBox1.PlaceholderText = "            MİKTAR";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(126, 41);
            this.guna2TextBox1.TabIndex = 45;
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.guna2TextBox2.BorderRadius = 6;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.FocusedState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.HoverState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Location = new System.Drawing.Point(74, 115);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderForeColor = System.Drawing.Color.Yellow;
            this.guna2TextBox2.PlaceholderText = "            FİYATI";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.ShadowDecoration.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Size = new System.Drawing.Size(126, 41);
            this.guna2TextBox2.TabIndex = 44;
            // 
            // guna2TextBox3
            // 
            this.guna2TextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.guna2TextBox3.BorderRadius = 6;
            this.guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox3.DefaultText = "";
            this.guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.DisabledState.Parent = this.guna2TextBox3;
            this.guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.FocusedState.Parent = this.guna2TextBox3;
            this.guna2TextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.HoverState.Parent = this.guna2TextBox3;
            this.guna2TextBox3.Location = new System.Drawing.Point(74, 68);
            this.guna2TextBox3.Name = "guna2TextBox3";
            this.guna2TextBox3.PasswordChar = '\0';
            this.guna2TextBox3.PlaceholderForeColor = System.Drawing.Color.Yellow;
            this.guna2TextBox3.PlaceholderText = "         ÜRÜN ADI";
            this.guna2TextBox3.SelectedText = "";
            this.guna2TextBox3.ShadowDecoration.Parent = this.guna2TextBox3;
            this.guna2TextBox3.Size = new System.Drawing.Size(126, 41);
            this.guna2TextBox3.TabIndex = 43;
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.BorderRadius = 10;
            this.guna2GradientButton2.CheckedState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.CustomImages.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.Yellow;
            this.guna2GradientButton2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.Black;
            this.guna2GradientButton2.HoverState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Location = new System.Drawing.Point(74, 218);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.ShadowDecoration.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Size = new System.Drawing.Size(126, 45);
            this.guna2GradientButton2.TabIndex = 42;
            this.guna2GradientButton2.Text = "Alım İsteği";
            // 
            // txtdolar
            // 
            this.txtdolar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txtdolar.BorderRadius = 20;
            this.txtdolar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdolar.DefaultText = "";
            this.txtdolar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdolar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdolar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdolar.DisabledState.Parent = this.txtdolar;
            this.txtdolar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdolar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.txtdolar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdolar.FocusedState.Parent = this.txtdolar;
            this.txtdolar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtdolar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdolar.HoverState.Parent = this.txtdolar;
            this.txtdolar.Location = new System.Drawing.Point(435, 68);
            this.txtdolar.Name = "txtdolar";
            this.txtdolar.PasswordChar = '\0';
            this.txtdolar.PlaceholderForeColor = System.Drawing.Color.Yellow;
            this.txtdolar.PlaceholderText = "         $ DÖNÜŞTÜR";
            this.txtdolar.SelectedText = "";
            this.txtdolar.ShadowDecoration.Parent = this.txtdolar;
            this.txtdolar.Size = new System.Drawing.Size(135, 41);
            this.txtdolar.TabIndex = 46;
            // 
            // guna2GradientButton3
            // 
            this.guna2GradientButton3.BorderRadius = 10;
            this.guna2GradientButton3.CheckedState.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.CustomImages.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.FillColor2 = System.Drawing.Color.Yellow;
            this.guna2GradientButton3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GradientButton3.ForeColor = System.Drawing.Color.Black;
            this.guna2GradientButton3.HoverState.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.Location = new System.Drawing.Point(441, 115);
            this.guna2GradientButton3.Name = "guna2GradientButton3";
            this.guna2GradientButton3.ShadowDecoration.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.Size = new System.Drawing.Size(129, 29);
            this.guna2GradientButton3.TabIndex = 47;
            this.guna2GradientButton3.Text = "DÖNÜŞTÜR";
            this.guna2GradientButton3.Click += new System.EventHandler(this.guna2GradientButton3_Click);
            // 
            // lbldolar
            // 
            this.lbldolar.AutoSize = true;
            this.lbldolar.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldolar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbldolar.Location = new System.Drawing.Point(500, 32);
            this.lbldolar.Name = "lbldolar";
            this.lbldolar.Size = new System.Drawing.Size(58, 23);
            this.lbldolar.TabIndex = 48;
            this.lbldolar.Text = "oooo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(433, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 49;
            this.label1.Text = "$ Alış:";
            // 
            // SaticiEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(582, 340);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbldolar);
            this.Controls.Add(this.guna2GradientButton3);
            this.Controls.Add(this.txtdolar);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.guna2TextBox2);
            this.Controls.Add(this.guna2TextBox3);
            this.Controls.Add(this.guna2GradientButton2);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.txtBakiye);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.guna2GradientButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SaticiEkrani";
            this.Text = "SaticiEkrani";
            this.Load += new System.EventHandler(this.SaticiEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2TextBox txtFiyat;
        private Guna.UI2.WinForms.Guna2TextBox txtAdi;
        private Guna.UI2.WinForms.Guna2TextBox txtBakiye;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox txtMiktar;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
        private Guna.UI2.WinForms.Guna2TextBox txtdolar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldolar;
    }
}