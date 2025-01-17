namespace Hastane
{
    partial class FrmDuyurular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDuyurular));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.duyuruIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duyuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDuyurularBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneDataSet6 = new Hastane.HastaneDataSet6();
            this.tbl_DuyurularTableAdapter = new Hastane.HastaneDataSet6TableAdapters.Tbl_DuyurularTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDuyurularBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.duyuruIDDataGridViewTextBoxColumn,
            this.duyuruDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblDuyurularBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(806, 504);
            this.dataGridView1.TabIndex = 0;
            // 
            // duyuruIDDataGridViewTextBoxColumn
            // 
            this.duyuruIDDataGridViewTextBoxColumn.DataPropertyName = "DuyuruID";
            this.duyuruIDDataGridViewTextBoxColumn.HeaderText = "DuyuruID";
            this.duyuruIDDataGridViewTextBoxColumn.Name = "duyuruIDDataGridViewTextBoxColumn";
            this.duyuruIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // duyuruDataGridViewTextBoxColumn
            // 
            this.duyuruDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.duyuruDataGridViewTextBoxColumn.DataPropertyName = "Duyuru";
            this.duyuruDataGridViewTextBoxColumn.HeaderText = "Duyuru";
            this.duyuruDataGridViewTextBoxColumn.Name = "duyuruDataGridViewTextBoxColumn";
            // 
            // tblDuyurularBindingSource
            // 
            this.tblDuyurularBindingSource.DataMember = "Tbl_Duyurular";
            this.tblDuyurularBindingSource.DataSource = this.hastaneDataSet6;
            // 
            // hastaneDataSet6
            // 
            this.hastaneDataSet6.DataSetName = "HastaneDataSet6";
            this.hastaneDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_DuyurularTableAdapter
            // 
            this.tbl_DuyurularTableAdapter.ClearBeforeFill = true;
            // 
            // FrmDuyurular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 504);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDuyurular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DUYURULAR";
            this.Load += new System.EventHandler(this.FrmDuyurular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDuyurularBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HastaneDataSet6 hastaneDataSet6;
        private System.Windows.Forms.BindingSource tblDuyurularBindingSource;
        private HastaneDataSet6TableAdapters.Tbl_DuyurularTableAdapter tbl_DuyurularTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn duyuruIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duyuruDataGridViewTextBoxColumn;
    }
}