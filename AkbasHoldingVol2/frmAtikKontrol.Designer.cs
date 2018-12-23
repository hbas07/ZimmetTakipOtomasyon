namespace AkbasHoldingVol2
{
    partial class frmAtikKontrol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAtikKontrol));
            this.label1 = new System.Windows.Forms.Label();
            this.btnZimmetSil = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.grdAtikKontrol = new DevExpress.XtraGrid.GridControl();
            this.spAtikKontrolBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.akbasHoldingTestDataSet6 = new AkbasHoldingVol2.AkbasHoldingTestDataSet6();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colZimmetID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZimmetliÜrün1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirma1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAd1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoyad1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartmanAdı1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZimmetAktifligi1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdZimmetListe = new DevExpress.XtraGrid.GridControl();
            this.spZimmetBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colZimmetID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZimmetliÜrün = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirma = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartmanAdı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZimmetAktifligi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sp_ZimmetBilgiTableAdapter = new AkbasHoldingVol2.AkbasHoldingTestDataSet6TableAdapters.sp_ZimmetBilgiTableAdapter();
            this.sp_AtikKontrolBilgiTableAdapter = new AkbasHoldingVol2.AkbasHoldingTestDataSet6TableAdapters.sp_AtikKontrolBilgiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grdAtikKontrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAtikKontrolBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.akbasHoldingTestDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdZimmetListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spZimmetBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(53, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "SİLMEK İSTEDİĞİNİZ ZİMMETİ SEÇİNİZ";
            // 
            // btnZimmetSil
            // 
            this.btnZimmetSil.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnZimmetSil.Appearance.BackColor = System.Drawing.Color.DarkOrange;
            this.btnZimmetSil.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btnZimmetSil.Appearance.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnZimmetSil.Appearance.Options.UseBackColor = true;
            this.btnZimmetSil.Appearance.Options.UseFont = true;
            this.btnZimmetSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnZimmetSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnZimmetSil.ImageOptions.Image")));
            this.btnZimmetSil.Location = new System.Drawing.Point(429, 346);
            this.btnZimmetSil.Name = "btnZimmetSil";
            this.btnZimmetSil.Size = new System.Drawing.Size(193, 40);
            this.btnZimmetSil.TabIndex = 2;
            this.btnZimmetSil.Text = "ZİMMET SİL";
            this.btnZimmetSil.Click += new System.EventHandler(this.btnZimmetSil_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(53, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "DAHA ÖNCE SİLİNEN ZİMMETLER";
            // 
            // grdAtikKontrol
            // 
            this.grdAtikKontrol.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.grdAtikKontrol.DataSource = this.spAtikKontrolBilgiBindingSource;
            this.grdAtikKontrol.Location = new System.Drawing.Point(57, 408);
            this.grdAtikKontrol.MainView = this.gridView2;
            this.grdAtikKontrol.Name = "grdAtikKontrol";
            this.grdAtikKontrol.Size = new System.Drawing.Size(796, 252);
            this.grdAtikKontrol.TabIndex = 6;
            this.grdAtikKontrol.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // spAtikKontrolBilgiBindingSource
            // 
            this.spAtikKontrolBilgiBindingSource.DataMember = "sp_AtikKontrolBilgi";
            this.spAtikKontrolBilgiBindingSource.DataSource = this.akbasHoldingTestDataSet6;
            // 
            // akbasHoldingTestDataSet6
            // 
            this.akbasHoldingTestDataSet6.DataSetName = "AkbasHoldingTestDataSet4";
            this.akbasHoldingTestDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Appearance.Row.BackColor = System.Drawing.Color.Peru;
            this.gridView2.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gridView2.Appearance.Row.Options.UseBackColor = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colZimmetID1,
            this.colZimmetliÜrün1,
            this.colFirma1,
            this.colAd1,
            this.colSoyad1,
            this.colDepartmanAdı1,
            this.colZimmetAktifligi1});
            this.gridView2.GridControl = this.grdAtikKontrol;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colZimmetID1
            // 
            this.colZimmetID1.FieldName = "ZimmetID";
            this.colZimmetID1.MinWidth = 25;
            this.colZimmetID1.Name = "colZimmetID1";
            this.colZimmetID1.Visible = true;
            this.colZimmetID1.VisibleIndex = 0;
            this.colZimmetID1.Width = 94;
            // 
            // colZimmetliÜrün1
            // 
            this.colZimmetliÜrün1.FieldName = "Zimmetli Ürün";
            this.colZimmetliÜrün1.MinWidth = 25;
            this.colZimmetliÜrün1.Name = "colZimmetliÜrün1";
            this.colZimmetliÜrün1.Visible = true;
            this.colZimmetliÜrün1.VisibleIndex = 1;
            this.colZimmetliÜrün1.Width = 94;
            // 
            // colFirma1
            // 
            this.colFirma1.FieldName = "Firma";
            this.colFirma1.MinWidth = 25;
            this.colFirma1.Name = "colFirma1";
            this.colFirma1.Visible = true;
            this.colFirma1.VisibleIndex = 2;
            this.colFirma1.Width = 94;
            // 
            // colAd1
            // 
            this.colAd1.FieldName = "Ad";
            this.colAd1.MinWidth = 25;
            this.colAd1.Name = "colAd1";
            this.colAd1.Visible = true;
            this.colAd1.VisibleIndex = 3;
            this.colAd1.Width = 94;
            // 
            // colSoyad1
            // 
            this.colSoyad1.FieldName = "Soyad";
            this.colSoyad1.MinWidth = 25;
            this.colSoyad1.Name = "colSoyad1";
            this.colSoyad1.Visible = true;
            this.colSoyad1.VisibleIndex = 4;
            this.colSoyad1.Width = 94;
            // 
            // colDepartmanAdı1
            // 
            this.colDepartmanAdı1.FieldName = "DepartmanAdı";
            this.colDepartmanAdı1.MinWidth = 25;
            this.colDepartmanAdı1.Name = "colDepartmanAdı1";
            this.colDepartmanAdı1.Visible = true;
            this.colDepartmanAdı1.VisibleIndex = 5;
            this.colDepartmanAdı1.Width = 94;
            // 
            // colZimmetAktifligi1
            // 
            this.colZimmetAktifligi1.FieldName = "ZimmetAktifligi";
            this.colZimmetAktifligi1.MinWidth = 25;
            this.colZimmetAktifligi1.Name = "colZimmetAktifligi1";
            this.colZimmetAktifligi1.Visible = true;
            this.colZimmetAktifligi1.VisibleIndex = 6;
            this.colZimmetAktifligi1.Width = 94;
            // 
            // grdZimmetListe
            // 
            this.grdZimmetListe.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.grdZimmetListe.DataSource = this.spZimmetBilgiBindingSource;
            this.grdZimmetListe.Location = new System.Drawing.Point(57, 85);
            this.grdZimmetListe.MainView = this.gridView1;
            this.grdZimmetListe.Name = "grdZimmetListe";
            this.grdZimmetListe.Size = new System.Drawing.Size(796, 240);
            this.grdZimmetListe.TabIndex = 7;
            this.grdZimmetListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // spZimmetBilgiBindingSource
            // 
            this.spZimmetBilgiBindingSource.DataMember = "sp_ZimmetBilgi";
            this.spZimmetBilgiBindingSource.DataSource = this.akbasHoldingTestDataSet6;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.White;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colZimmetID,
            this.colZimmetliÜrün,
            this.colFirma,
            this.colAd,
            this.colSoyad,
            this.colDepartmanAdı,
            this.colZimmetAktifligi});
            this.gridView1.GridControl = this.grdZimmetListe;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged_1);
            // 
            // colZimmetID
            // 
            this.colZimmetID.FieldName = "ZimmetID";
            this.colZimmetID.MinWidth = 25;
            this.colZimmetID.Name = "colZimmetID";
            this.colZimmetID.Visible = true;
            this.colZimmetID.VisibleIndex = 0;
            this.colZimmetID.Width = 94;
            // 
            // colZimmetliÜrün
            // 
            this.colZimmetliÜrün.FieldName = "Zimmetli Ürün";
            this.colZimmetliÜrün.MinWidth = 25;
            this.colZimmetliÜrün.Name = "colZimmetliÜrün";
            this.colZimmetliÜrün.Visible = true;
            this.colZimmetliÜrün.VisibleIndex = 1;
            this.colZimmetliÜrün.Width = 94;
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
            // colAd
            // 
            this.colAd.FieldName = "Ad";
            this.colAd.MinWidth = 25;
            this.colAd.Name = "colAd";
            this.colAd.Visible = true;
            this.colAd.VisibleIndex = 3;
            this.colAd.Width = 94;
            // 
            // colSoyad
            // 
            this.colSoyad.FieldName = "Soyad";
            this.colSoyad.MinWidth = 25;
            this.colSoyad.Name = "colSoyad";
            this.colSoyad.Visible = true;
            this.colSoyad.VisibleIndex = 4;
            this.colSoyad.Width = 94;
            // 
            // colDepartmanAdı
            // 
            this.colDepartmanAdı.FieldName = "DepartmanAdı";
            this.colDepartmanAdı.MinWidth = 25;
            this.colDepartmanAdı.Name = "colDepartmanAdı";
            this.colDepartmanAdı.Visible = true;
            this.colDepartmanAdı.VisibleIndex = 5;
            this.colDepartmanAdı.Width = 94;
            // 
            // colZimmetAktifligi
            // 
            this.colZimmetAktifligi.FieldName = "ZimmetAktifligi";
            this.colZimmetAktifligi.MinWidth = 25;
            this.colZimmetAktifligi.Name = "colZimmetAktifligi";
            this.colZimmetAktifligi.Visible = true;
            this.colZimmetAktifligi.VisibleIndex = 6;
            this.colZimmetAktifligi.Width = 94;
            // 
            // sp_ZimmetBilgiTableAdapter
            // 
            this.sp_ZimmetBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // sp_AtikKontrolBilgiTableAdapter
            // 
            this.sp_AtikKontrolBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // frmAtikKontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 672);
            this.Controls.Add(this.grdZimmetListe);
            this.Controls.Add(this.grdAtikKontrol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnZimmetSil);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAtikKontrol";
            this.ShowIcon = false;
            this.Text = "ATIK KONTROL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAtikKontrol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAtikKontrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAtikKontrolBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.akbasHoldingTestDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdZimmetListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spZimmetBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnZimmetSil;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl grdAtikKontrol;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl grdZimmetListe;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private AkbasHoldingTestDataSet6 akbasHoldingTestDataSet6;
        private System.Windows.Forms.BindingSource spZimmetBilgiBindingSource;
        private AkbasHoldingTestDataSet6TableAdapters.sp_ZimmetBilgiTableAdapter sp_ZimmetBilgiTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colZimmetID;
        private DevExpress.XtraGrid.Columns.GridColumn colZimmetliÜrün;
        private DevExpress.XtraGrid.Columns.GridColumn colFirma;
        private DevExpress.XtraGrid.Columns.GridColumn colAd;
        private DevExpress.XtraGrid.Columns.GridColumn colSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmanAdı;
        private DevExpress.XtraGrid.Columns.GridColumn colZimmetAktifligi;
        private System.Windows.Forms.BindingSource spAtikKontrolBilgiBindingSource;
        private AkbasHoldingTestDataSet6TableAdapters.sp_AtikKontrolBilgiTableAdapter sp_AtikKontrolBilgiTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colZimmetID1;
        private DevExpress.XtraGrid.Columns.GridColumn colZimmetliÜrün1;
        private DevExpress.XtraGrid.Columns.GridColumn colFirma1;
        private DevExpress.XtraGrid.Columns.GridColumn colAd1;
        private DevExpress.XtraGrid.Columns.GridColumn colSoyad1;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmanAdı1;
        private DevExpress.XtraGrid.Columns.GridColumn colZimmetAktifligi1;
    }
}