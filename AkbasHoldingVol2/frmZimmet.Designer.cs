namespace AkbasHoldingVol2
{
    partial class frmZimmet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmZimmet));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grdPersonelBilgi = new DevExpress.XtraGrid.GridControl();
            this.vwPersonelBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.akbasHoldingTestDataSet6 = new AkbasHoldingVol2.AkbasHoldingTestDataSet6();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPersonelID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartmanAdı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartmanID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnZimmetle = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUrunID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrun = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirma = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAktiflikDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirmaID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdZimmetUrun = new DevExpress.XtraGrid.GridControl();
            this.spStokBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spStokBilgiBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.vw_PersonelBilgiTableAdapter = new AkbasHoldingVol2.AkbasHoldingTestDataSet6TableAdapters.vw_PersonelBilgiTableAdapter();
            this.sp_StokBilgiTableAdapter = new AkbasHoldingVol2.AkbasHoldingTestDataSet6TableAdapters.sp_StokBilgiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grdPersonelBilgi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPersonelBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.akbasHoldingTestDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdZimmetUrun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spStokBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spStokBilgiBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "PERSONEL LİSTE";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "ZİMMETLENECEK EŞYA";
            // 
            // grdPersonelBilgi
            // 
            this.grdPersonelBilgi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grdPersonelBilgi.DataSource = this.vwPersonelBilgiBindingSource;
            this.grdPersonelBilgi.Location = new System.Drawing.Point(131, 134);
            this.grdPersonelBilgi.MainView = this.gridView1;
            this.grdPersonelBilgi.Name = "grdPersonelBilgi";
            this.grdPersonelBilgi.Size = new System.Drawing.Size(601, 200);
            this.grdPersonelBilgi.TabIndex = 0;
            this.grdPersonelBilgi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // vwPersonelBilgiBindingSource
            // 
            this.vwPersonelBilgiBindingSource.DataMember = "vw_PersonelBilgi";
            this.vwPersonelBilgiBindingSource.DataSource = this.akbasHoldingTestDataSet6;
            // 
            // akbasHoldingTestDataSet6
            // 
            this.akbasHoldingTestDataSet6.DataSetName = "AkbasHoldingTestDataSet6";
            this.akbasHoldingTestDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Red;
            this.gridView1.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.Red;
            this.gridView1.Appearance.EvenRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.Red;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.Blue;
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPersonelID,
            this.colAd,
            this.colSoyad,
            this.colDepartmanAdı,
            this.colDepartmanID});
            this.gridView1.GridControl = this.grdPersonelBilgi;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colPersonelID
            // 
            this.colPersonelID.FieldName = "PersonelID";
            this.colPersonelID.MinWidth = 25;
            this.colPersonelID.Name = "colPersonelID";
            this.colPersonelID.Visible = true;
            this.colPersonelID.VisibleIndex = 0;
            this.colPersonelID.Width = 94;
            // 
            // colAd
            // 
            this.colAd.FieldName = "Ad";
            this.colAd.MinWidth = 25;
            this.colAd.Name = "colAd";
            this.colAd.Visible = true;
            this.colAd.VisibleIndex = 1;
            this.colAd.Width = 94;
            // 
            // colSoyad
            // 
            this.colSoyad.FieldName = "Soyad";
            this.colSoyad.MinWidth = 25;
            this.colSoyad.Name = "colSoyad";
            this.colSoyad.Visible = true;
            this.colSoyad.VisibleIndex = 2;
            this.colSoyad.Width = 94;
            // 
            // colDepartmanAdı
            // 
            this.colDepartmanAdı.FieldName = "DepartmanAdı";
            this.colDepartmanAdı.MinWidth = 25;
            this.colDepartmanAdı.Name = "colDepartmanAdı";
            this.colDepartmanAdı.Visible = true;
            this.colDepartmanAdı.VisibleIndex = 3;
            this.colDepartmanAdı.Width = 94;
            // 
            // colDepartmanID
            // 
            this.colDepartmanID.FieldName = "DepartmanID";
            this.colDepartmanID.MinWidth = 25;
            this.colDepartmanID.Name = "colDepartmanID";
            this.colDepartmanID.Visible = true;
            this.colDepartmanID.VisibleIndex = 4;
            this.colDepartmanID.Width = 94;
            // 
            // btnZimmetle
            // 
            this.btnZimmetle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnZimmetle.Appearance.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnZimmetle.Appearance.Options.UseFont = true;
            this.btnZimmetle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnZimmetle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnZimmetle.ImageOptions.SvgImage")));
            this.btnZimmetle.Location = new System.Drawing.Point(763, 331);
            this.btnZimmetle.Name = "btnZimmetle";
            this.btnZimmetle.Size = new System.Drawing.Size(159, 55);
            this.btnZimmetle.TabIndex = 4;
            this.btnZimmetle.Text = "ZİMMETLE";
            this.btnZimmetle.Click += new System.EventHandler(this.btnZimmetle_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(562, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "ZİMMETLEME YAPMAK İÇİN BİR PERSONEL VE BİR EŞYA SEÇİNİZ";
            // 
            // gridView2
            // 
            this.gridView2.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gridView2.Appearance.Row.BackColor2 = System.Drawing.Color.Lime;
            this.gridView2.Appearance.Row.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView2.Appearance.Row.Options.UseBackColor = true;
            this.gridView2.Appearance.Row.Options.UseFont = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUrunID,
            this.colUrun,
            this.colFirma,
            this.colAdet,
            this.colAktiflikDurumu,
            this.colFirmaID});
            this.gridView2.GridControl = this.grdZimmetUrun;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
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
            // colUrun
            // 
            this.colUrun.FieldName = "Urun";
            this.colUrun.MinWidth = 25;
            this.colUrun.Name = "colUrun";
            this.colUrun.Visible = true;
            this.colUrun.VisibleIndex = 1;
            this.colUrun.Width = 94;
            // 
            // colFirma
            // 
            this.colFirma.FieldName = "Firma";
            this.colFirma.MinWidth = 25;
            this.colFirma.Name = "colFirma";
            this.colFirma.Visible = true;
            this.colFirma.VisibleIndex = 2;
            this.colFirma.Width = 94;
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
            // colFirmaID
            // 
            this.colFirmaID.FieldName = "FirmaID";
            this.colFirmaID.MinWidth = 25;
            this.colFirmaID.Name = "colFirmaID";
            this.colFirmaID.Visible = true;
            this.colFirmaID.VisibleIndex = 5;
            this.colFirmaID.Width = 94;
            // 
            // grdZimmetUrun
            // 
            this.grdZimmetUrun.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grdZimmetUrun.DataSource = this.spStokBilgiBindingSource;
            this.grdZimmetUrun.Location = new System.Drawing.Point(131, 390);
            this.grdZimmetUrun.MainView = this.gridView2;
            this.grdZimmetUrun.Name = "grdZimmetUrun";
            this.grdZimmetUrun.Size = new System.Drawing.Size(601, 200);
            this.grdZimmetUrun.TabIndex = 0;
            this.grdZimmetUrun.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // spStokBilgiBindingSource
            // 
            this.spStokBilgiBindingSource.DataMember = "sp_StokBilgi";
            this.spStokBilgiBindingSource.DataSource = this.akbasHoldingTestDataSet6;
            // 
            // vw_PersonelBilgiTableAdapter
            // 
            this.vw_PersonelBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // sp_StokBilgiTableAdapter
            // 
            this.sp_StokBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // frmZimmet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 591);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grdZimmetUrun);
            this.Controls.Add(this.btnZimmetle);
            this.Controls.Add(this.grdPersonelBilgi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmZimmet";
            this.ShowIcon = false;
            this.Text = "ZİMMETLEME";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmZimmet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPersonelBilgi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPersonelBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.akbasHoldingTestDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdZimmetUrun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spStokBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spStokBilgiBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl grdPersonelBilgi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonelID;
        private DevExpress.XtraGrid.Columns.GridColumn colAd;
        private DevExpress.XtraGrid.Columns.GridColumn colSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmanAdı;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmanID;
        private DevExpress.XtraEditors.SimpleButton btnZimmetle;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunID;
        private DevExpress.XtraGrid.Columns.GridColumn colUrun;
        private DevExpress.XtraGrid.Columns.GridColumn colFirma;
        private DevExpress.XtraGrid.Columns.GridColumn colAdet;
        private DevExpress.XtraGrid.Columns.GridColumn colAktiflikDurumu;
        private DevExpress.XtraGrid.Columns.GridColumn colFirmaID;
        private DevExpress.XtraGrid.GridControl grdZimmetUrun;
        private System.Windows.Forms.BindingSource spStokBilgiBindingSource3;
        private AkbasHoldingTestDataSet6 akbasHoldingTestDataSet6;
        private System.Windows.Forms.BindingSource vwPersonelBilgiBindingSource;
        private AkbasHoldingTestDataSet6TableAdapters.vw_PersonelBilgiTableAdapter vw_PersonelBilgiTableAdapter;
        private System.Windows.Forms.BindingSource spStokBilgiBindingSource;
        private AkbasHoldingTestDataSet6TableAdapters.sp_StokBilgiTableAdapter sp_StokBilgiTableAdapter;
    }
}