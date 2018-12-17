namespace AkbasHoldingVol2
{
    partial class frmStok
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
            this.grdStok = new DevExpress.XtraGrid.GridControl();
            this.spStokBilgiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.akbasHoldingTestDataSet6 = new AkbasHoldingVol2.AkbasHoldingTestDataSet6();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUrunID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirma = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrun = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAktiflikDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sp_StokBilgiTableAdapter1 = new AkbasHoldingVol2.AkbasHoldingTestDataSet6TableAdapters.sp_StokBilgiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grdStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spStokBilgiBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.akbasHoldingTestDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdStok
            // 
            this.grdStok.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.grdStok.DataSource = this.spStokBilgiBindingSource2;
            this.grdStok.Location = new System.Drawing.Point(12, 12);
            this.grdStok.MainView = this.gridView1;
            this.grdStok.Name = "grdStok";
            this.grdStok.Size = new System.Drawing.Size(876, 567);
            this.grdStok.TabIndex = 0;
            this.grdStok.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // spStokBilgiBindingSource2
            // 
            this.spStokBilgiBindingSource2.DataMember = "sp_StokBilgi";
            this.spStokBilgiBindingSource2.DataSource = this.akbasHoldingTestDataSet6;
            // 
            // akbasHoldingTestDataSet6
            // 
            this.akbasHoldingTestDataSet6.DataSetName = "AkbasHoldingTestDataSet6";
            this.akbasHoldingTestDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.DodgerBlue;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.Aqua;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUrunID,
            this.colFirma,
            this.colUrun,
            this.colAdet,
            this.colAktiflikDurumu});
            this.gridView1.GridControl = this.grdStok;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colUrunID
            // 
            this.colUrunID.FieldName = "UrunID";
            this.colUrunID.MinWidth = 25;
            this.colUrunID.Name = "colUrunID";
            this.colUrunID.Visible = true;
            this.colUrunID.VisibleIndex = 0;
            this.colUrunID.Width = 94;
            // 
            // colFirma
            // 
            this.colFirma.FieldName = "Firma";
            this.colFirma.MinWidth = 25;
            this.colFirma.Name = "colFirma";
            this.colFirma.Visible = true;
            this.colFirma.VisibleIndex = 1;
            this.colFirma.Width = 94;
            // 
            // colUrun
            // 
            this.colUrun.FieldName = "Urun";
            this.colUrun.MinWidth = 25;
            this.colUrun.Name = "colUrun";
            this.colUrun.Visible = true;
            this.colUrun.VisibleIndex = 2;
            this.colUrun.Width = 94;
            // 
            // colAdet
            // 
            this.colAdet.FieldName = "Adet";
            this.colAdet.MinWidth = 25;
            this.colAdet.Name = "colAdet";
            this.colAdet.Visible = true;
            this.colAdet.VisibleIndex = 3;
            this.colAdet.Width = 94;
            // 
            // colAktiflikDurumu
            // 
            this.colAktiflikDurumu.FieldName = "AktiflikDurumu";
            this.colAktiflikDurumu.MinWidth = 25;
            this.colAktiflikDurumu.Name = "colAktiflikDurumu";
            this.colAktiflikDurumu.Visible = true;
            this.colAktiflikDurumu.VisibleIndex = 4;
            this.colAktiflikDurumu.Width = 94;
            // 
            // sp_StokBilgiTableAdapter1
            // 
            this.sp_StokBilgiTableAdapter1.ClearBeforeFill = true;
            // 
            // frmStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 591);
            this.Controls.Add(this.grdStok);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmStok";
            this.ShowIcon = false;
            this.Text = "STOK";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmStok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spStokBilgiBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.akbasHoldingTestDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdStok;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
     //   private AkbasHoldingDataSet2TableAdapters.sp_StokBilgiTableAdapter sp_StokBilgiTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunID;
        private DevExpress.XtraGrid.Columns.GridColumn colFirma;
        private DevExpress.XtraGrid.Columns.GridColumn colUrun;
        private DevExpress.XtraGrid.Columns.GridColumn colAdet;
        private DevExpress.XtraGrid.Columns.GridColumn colAktiflikDurumu;
        private AkbasHoldingTestDataSet6 akbasHoldingTestDataSet6;
        private System.Windows.Forms.BindingSource spStokBilgiBindingSource2;
        private AkbasHoldingTestDataSet6TableAdapters.sp_StokBilgiTableAdapter sp_StokBilgiTableAdapter1;
    }
}