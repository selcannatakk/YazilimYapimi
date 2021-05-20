
namespace WindowsFormsApp1
{
    partial class Hareket
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.projetsDataSet = new WindowsFormsApp1.ProjetsDataSet();
            this.tblHareketlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblHareketlerTableAdapter = new WindowsFormsApp1.ProjetsDataSetTableAdapters.tblHareketlerTableAdapter();
            this.aliciIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saticiIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aliciBakiyeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saticiBakiyeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHareketlerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aliciIDDataGridViewTextBoxColumn,
            this.saticiIDDataGridViewTextBoxColumn,
            this.urunIDDataGridViewTextBoxColumn,
            this.aliciBakiyeDataGridViewTextBoxColumn,
            this.saticiBakiyeDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tblHareketlerBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(711, 316);
            this.dataGridView2.TabIndex = 1;
            // 
            // projetsDataSet
            // 
            this.projetsDataSet.DataSetName = "ProjetsDataSet";
            this.projetsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblHareketlerBindingSource
            // 
            this.tblHareketlerBindingSource.DataMember = "tblHareketler";
            this.tblHareketlerBindingSource.DataSource = this.projetsDataSet;
            // 
            // tblHareketlerTableAdapter
            // 
            this.tblHareketlerTableAdapter.ClearBeforeFill = true;
            // 
            // aliciIDDataGridViewTextBoxColumn
            // 
            this.aliciIDDataGridViewTextBoxColumn.DataPropertyName = "AliciID";
            this.aliciIDDataGridViewTextBoxColumn.HeaderText = "AliciID";
            this.aliciIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aliciIDDataGridViewTextBoxColumn.Name = "aliciIDDataGridViewTextBoxColumn";
            // 
            // saticiIDDataGridViewTextBoxColumn
            // 
            this.saticiIDDataGridViewTextBoxColumn.DataPropertyName = "SaticiID";
            this.saticiIDDataGridViewTextBoxColumn.HeaderText = "SaticiID";
            this.saticiIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saticiIDDataGridViewTextBoxColumn.Name = "saticiIDDataGridViewTextBoxColumn";
            // 
            // urunIDDataGridViewTextBoxColumn
            // 
            this.urunIDDataGridViewTextBoxColumn.DataPropertyName = "UrunID";
            this.urunIDDataGridViewTextBoxColumn.HeaderText = "UrunID";
            this.urunIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunIDDataGridViewTextBoxColumn.Name = "urunIDDataGridViewTextBoxColumn";
            // 
            // aliciBakiyeDataGridViewTextBoxColumn
            // 
            this.aliciBakiyeDataGridViewTextBoxColumn.DataPropertyName = "AliciBakiye";
            this.aliciBakiyeDataGridViewTextBoxColumn.HeaderText = "AliciBakiye";
            this.aliciBakiyeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aliciBakiyeDataGridViewTextBoxColumn.Name = "aliciBakiyeDataGridViewTextBoxColumn";
            // 
            // saticiBakiyeDataGridViewTextBoxColumn
            // 
            this.saticiBakiyeDataGridViewTextBoxColumn.DataPropertyName = "SaticiBakiye";
            this.saticiBakiyeDataGridViewTextBoxColumn.HeaderText = "SaticiBakiye";
            this.saticiBakiyeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saticiBakiyeDataGridViewTextBoxColumn.Name = "saticiBakiyeDataGridViewTextBoxColumn";
            // 
            // Hareket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Hareket";
            this.Text = "Hareket";
            this.Load += new System.EventHandler(this.Hareket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHareketlerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private ProjetsDataSet projetsDataSet;
        private System.Windows.Forms.BindingSource tblHareketlerBindingSource;
        private ProjetsDataSetTableAdapters.tblHareketlerTableAdapter tblHareketlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aliciIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saticiIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aliciBakiyeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saticiBakiyeDataGridViewTextBoxColumn;
    }
}