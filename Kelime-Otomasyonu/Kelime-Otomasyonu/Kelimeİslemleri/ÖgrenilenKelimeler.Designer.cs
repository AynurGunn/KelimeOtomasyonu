namespace Kelime_Otomasyonu.Kelimeİslemleri
{
    partial class ÖgrenilenKelimeler
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
            this.kelimeOtomasyonuDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kelimeOtomasyonuDataSet = new Kelime_Otomasyonu.KelimeOtomasyonuDataSet();
            this.stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            this.lblOgrenilenKelime = new System.Windows.Forms.Label();
            this.kelimeOtomasyonuDataSet1 = new Kelime_Otomasyonu.KelimeOtomasyonuDataSet();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tblKelimeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kelimeOtomasyonuDataSet11 = new Kelime_Otomasyonu.KelimeOtomasyonuDataSet1();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIngilizce = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTurkce = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCumle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tblkelimeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kelimeDataSet = new Kelime_Otomasyonu.KelimeDataSet();
            this.kelimeOtomasyonuDataSet2 = new Kelime_Otomasyonu.KelimeOtomasyonuDataSet();
            this.tbl_KelimeTableAdapter1 = new Kelime_Otomasyonu.KelimeOtomasyonuDataSetTableAdapters.tbl_KelimeTableAdapter();
            this.tbl_kelimeTableAdapter = new Kelime_Otomasyonu.KelimeDataSetTableAdapters.tbl_kelimeTableAdapter();
            this.tbl_KelimeTableAdapter2 = new Kelime_Otomasyonu.KelimeOtomasyonuDataSet1TableAdapters.tbl_KelimeTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.sbtnTumKelimeler = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.kelimeOtomasyonuDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelimeOtomasyonuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).BeginInit();
            this.stackPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kelimeOtomasyonuDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKelimeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelimeOtomasyonuDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblkelimeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelimeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelimeOtomasyonuDataSet2)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // kelimeOtomasyonuDataSetBindingSource
            // 
            this.kelimeOtomasyonuDataSetBindingSource.AllowNew = true;
            this.kelimeOtomasyonuDataSetBindingSource.DataSource = this.kelimeOtomasyonuDataSet;
            this.kelimeOtomasyonuDataSetBindingSource.Position = 0;
            // 
            // kelimeOtomasyonuDataSet
            // 
            this.kelimeOtomasyonuDataSet.CaseSensitive = true;
            this.kelimeOtomasyonuDataSet.DataSetName = "KelimeOtomasyonuDataSet";
            this.kelimeOtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stackPanel1
            // 
            this.stackPanel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.stackPanel1.Appearance.Options.UseBackColor = true;
            this.stackPanel1.Controls.Add(this.lblOgrenilenKelime);
            this.stackPanel1.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.BottomUp;
            this.stackPanel1.Location = new System.Drawing.Point(12, 12);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(700, 39);
            this.stackPanel1.TabIndex = 1;
            // 
            // lblOgrenilenKelime
            // 
            this.lblOgrenilenKelime.AutoSize = true;
            this.lblOgrenilenKelime.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrenilenKelime.Location = new System.Drawing.Point(230, 11);
            this.lblOgrenilenKelime.Name = "lblOgrenilenKelime";
            this.lblOgrenilenKelime.Size = new System.Drawing.Size(240, 28);
            this.lblOgrenilenKelime.TabIndex = 0;
            this.lblOgrenilenKelime.Text = "BÜTÜN KELİMELER";
            // 
            // kelimeOtomasyonuDataSet1
            // 
            this.kelimeOtomasyonuDataSet1.DataSetName = "KelimeOtomasyonuDataSet";
            this.kelimeOtomasyonuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tblKelimeBindingSource1;
            this.gridControl1.Location = new System.Drawing.Point(12, 57);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(700, 413);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
        
            // 
            // tblKelimeBindingSource1
            // 
            this.tblKelimeBindingSource1.DataMember = "tbl_Kelime";
            this.tblKelimeBindingSource1.DataSource = this.kelimeOtomasyonuDataSet11;
            // 
            // kelimeOtomasyonuDataSet11
            // 
            this.kelimeOtomasyonuDataSet11.DataSetName = "KelimeOtomasyonuDataSet1";
            this.kelimeOtomasyonuDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.RosyBrown;
            this.gridView1.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.RosyBrown;
            this.gridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.SandyBrown;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colIngilizce,
            this.colTurkce,
            this.colCumle});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Standard;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.ShowUnboundExpressionMenu = true;
            this.colID.Width = 20;
            // 
            // colIngilizce
            // 
            this.colIngilizce.FieldName = "Ingilizce";
            this.colIngilizce.Name = "colIngilizce";
            this.colIngilizce.Visible = true;
            this.colIngilizce.VisibleIndex = 0;
            this.colIngilizce.Width = 205;
            // 
            // colTurkce
            // 
            this.colTurkce.FieldName = "Turkce";
            this.colTurkce.Name = "colTurkce";
            this.colTurkce.Visible = true;
            this.colTurkce.VisibleIndex = 1;
            this.colTurkce.Width = 205;
            // 
            // colCumle
            // 
            this.colCumle.FieldName = "Cumle";
            this.colCumle.Name = "colCumle";
            this.colCumle.Visible = true;
            this.colCumle.VisibleIndex = 2;
            this.colCumle.Width = 210;
            // 
            // tblkelimeBindingSource
            // 
            this.tblkelimeBindingSource.DataMember = "tbl_kelime";
            this.tblkelimeBindingSource.DataSource = this.kelimeDataSet;
            // 
            // kelimeDataSet
            // 
            this.kelimeDataSet.DataSetName = "KelimeDataSet";
            this.kelimeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kelimeOtomasyonuDataSet2
            // 
            this.kelimeOtomasyonuDataSet2.DataSetName = "KelimeOtomasyonuDataSet";
            this.kelimeOtomasyonuDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_KelimeTableAdapter1
            // 
            this.tbl_KelimeTableAdapter1.ClearBeforeFill = true;
            // 
            // tbl_kelimeTableAdapter
            // 
            this.tbl_kelimeTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_KelimeTableAdapter2
            // 
            this.tbl_KelimeTableAdapter2.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fillByToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(571, 442);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(138, 25);
            this.fillByToolStrip.TabIndex = 3;
            this.fillByToolStrip.Text = "Öğrenilen Kelimeler";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(126, 22);
            this.fillByToolStripButton.Text = "Öğrenilen Kelimeler";
            this.fillByToolStripButton.Click += new System.EventHandler(this.FillByToolStripButton_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(710, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // sbtnTumKelimeler
            // 
            this.sbtnTumKelimeler.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sbtnTumKelimeler.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sbtnTumKelimeler.Appearance.Options.UseBackColor = true;
            this.sbtnTumKelimeler.Appearance.Options.UseFont = true;
            this.sbtnTumKelimeler.Location = new System.Drawing.Point(22, 444);
            this.sbtnTumKelimeler.Name = "sbtnTumKelimeler";
            this.sbtnTumKelimeler.Size = new System.Drawing.Size(99, 23);
            this.sbtnTumKelimeler.TabIndex = 5;
            this.sbtnTumKelimeler.Text = "Tüm Kelimeler";
            this.sbtnTumKelimeler.Click += new System.EventHandler(this.SbtnTumKelimeler_Click);
            // 
            // ÖgrenilenKelimeler
            // 
            this.Appearance.BackColor = System.Drawing.Color.Teal;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 482);
            this.Controls.Add(this.sbtnTumKelimeler);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.stackPanel1);
            this.Name = "ÖgrenilenKelimeler";
            this.Text = "ÖgrenilenKelimeler";
            this.Load += new System.EventHandler(this.ÖgrenilenKelimeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kelimeOtomasyonuDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelimeOtomasyonuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).EndInit();
            this.stackPanel1.ResumeLayout(false);
            this.stackPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kelimeOtomasyonuDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKelimeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelimeOtomasyonuDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblkelimeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelimeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelimeOtomasyonuDataSet2)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.Utils.Layout.StackPanel stackPanel1;
        private System.Windows.Forms.Label lblOgrenilenKelime;
        public System.Windows.Forms.BindingSource kelimeOtomasyonuDataSetBindingSource;
        public KelimeOtomasyonuDataSet kelimeOtomasyonuDataSet;
        private KelimeOtomasyonuDataSet kelimeOtomasyonuDataSet1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private KelimeOtomasyonuDataSet kelimeOtomasyonuDataSet2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colIngilizce;
        private DevExpress.XtraGrid.Columns.GridColumn colTurkce;
        private DevExpress.XtraGrid.Columns.GridColumn colCumle;
        private KelimeOtomasyonuDataSetTableAdapters.tbl_KelimeTableAdapter tbl_KelimeTableAdapter1;
        private KelimeDataSet kelimeDataSet;
        private System.Windows.Forms.BindingSource tblkelimeBindingSource;
        private KelimeDataSetTableAdapters.tbl_kelimeTableAdapter tbl_kelimeTableAdapter;
        private KelimeOtomasyonuDataSet1 kelimeOtomasyonuDataSet11;
        private System.Windows.Forms.BindingSource tblKelimeBindingSource1;
        private KelimeOtomasyonuDataSet1TableAdapters.tbl_KelimeTableAdapter tbl_KelimeTableAdapter2;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.SimpleButton sbtnTumKelimeler;
    }
}