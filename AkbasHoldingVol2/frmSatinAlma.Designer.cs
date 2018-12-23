namespace AkbasHoldingVol2
{
    partial class frmSatinAlma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatinAlma));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tblSatinAlmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AkbasHoldingTestDataSet6 = new AkbasHoldingVol2.AkbasHoldingTestDataSet6();
            this.cmbFirma = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.lblParcaTur = new System.Windows.Forms.Label();
            this.cmbParca = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtedtTarih = new DevExpress.XtraEditors.DateEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblSatinAlmaTableAdapter = new AkbasHoldingVol2.AkbasHoldingTestDataSet6TableAdapters.tblSatinAlmaTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSatinAlmaRapor = new DevExpress.XtraEditors.SimpleButton();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tblSatinAlmaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AkbasHoldingTestDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFirma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbParca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtedtTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtedtTarih.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tblSatinAlmaBindingSource
            // 
            this.tblSatinAlmaBindingSource.DataMember = "tblSatinAlma";
            this.tblSatinAlmaBindingSource.DataSource = this.AkbasHoldingTestDataSet6;
            // 
            // AkbasHoldingTestDataSet6
            // 
            this.AkbasHoldingTestDataSet6.DataSetName = "AkbasHoldingTestDataSet6";
            this.AkbasHoldingTestDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbFirma
            // 
            this.cmbFirma.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmbFirma.Location = new System.Drawing.Point(204, 144);
            this.cmbFirma.Name = "cmbFirma";
            this.cmbFirma.Properties.Appearance.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbFirma.Properties.Appearance.Options.UseFont = true;
            this.cmbFirma.Properties.AutoComplete = false;
            this.cmbFirma.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFirma.Properties.Items.AddRange(new object[] {
            "ASUS",
            "TOSHIBA",
            "MSI",
            "DELL",
            "LENOVO"});
            this.cmbFirma.Size = new System.Drawing.Size(143, 26);
            this.cmbFirma.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "FİRMA";
            // 
            // lblParcaTur
            // 
            this.lblParcaTur.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblParcaTur.AutoSize = true;
            this.lblParcaTur.Location = new System.Drawing.Point(56, 192);
            this.lblParcaTur.Name = "lblParcaTur";
            this.lblParcaTur.Size = new System.Drawing.Size(118, 22);
            this.lblParcaTur.TabIndex = 1;
            this.lblParcaTur.Text = "PARÇA TÜRÜ";
            // 
            // cmbParca
            // 
            this.cmbParca.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmbParca.Location = new System.Drawing.Point(204, 192);
            this.cmbParca.Name = "cmbParca";
            this.cmbParca.Properties.AutoComplete = false;
            this.cmbParca.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbParca.Properties.Items.AddRange(new object[] {
            "BİLGİSAYAR",
            "KLAVYE",
            "KULAKLIK",
            "MOUSE",
            "DDR RAM"});
            this.cmbParca.Size = new System.Drawing.Size(143, 22);
            this.cmbParca.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "ADET";
            // 
            // txtAdet
            // 
            this.txtAdet.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtAdet.Location = new System.Drawing.Point(204, 240);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(143, 28);
            this.txtAdet.TabIndex = 4;
            this.txtAdet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdet_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "TARİH";
            // 
            // dtedtTarih
            // 
            this.dtedtTarih.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dtedtTarih.EditValue = null;
            this.dtedtTarih.Location = new System.Drawing.Point(204, 291);
            this.dtedtTarih.Name = "dtedtTarih";
            this.dtedtTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtedtTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtedtTarih.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this.dtedtTarih.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.dtedtTarih.Size = new System.Drawing.Size(143, 22);
            this.dtedtTarih.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "FİYAT";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtFiyat.Location = new System.Drawing.Point(204, 340);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(143, 28);
            this.txtFiyat.TabIndex = 6;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnKaydet.Appearance.BackColor = System.Drawing.Color.Teal;
            this.btnKaydet.Appearance.BackColor2 = System.Drawing.Color.OrangeRed;
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Appearance.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnKaydet.Appearance.Options.UseBackColor = true;
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.Appearance.Options.UseForeColor = true;
            this.btnKaydet.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnKaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKaydet.ImageOptions.SvgImage")));
            this.btnKaydet.Location = new System.Drawing.Point(220, 414);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(162, 61);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(304, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "SATIN ALINACAK ÜRÜN BİLGİLERİ";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            reportDataSource1.Name = "rprSatinAlma";
            reportDataSource1.Value = this.tblSatinAlmaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AkbasHoldingVol2.rprSatinAlma.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(402, 59);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(733, 500);
            this.reportViewer1.TabIndex = 9;
            // 
            // tblSatinAlmaTableAdapter
            // 
            this.tblSatinAlmaTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(681, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "SATIN ALMA GEÇMİŞİ";
            // 
            // btnSatinAlmaRapor
            // 
            this.btnSatinAlmaRapor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSatinAlmaRapor.Appearance.BackColor = System.Drawing.Color.Green;
            this.btnSatinAlmaRapor.Appearance.BackColor2 = System.Drawing.Color.Snow;
            this.btnSatinAlmaRapor.Appearance.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatinAlmaRapor.Appearance.Options.UseBackColor = true;
            this.btnSatinAlmaRapor.Appearance.Options.UseFont = true;
            this.btnSatinAlmaRapor.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnSatinAlmaRapor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSatinAlmaRapor.ImageOptions.Image")));
            this.btnSatinAlmaRapor.Location = new System.Drawing.Point(49, 502);
            this.btnSatinAlmaRapor.Name = "btnSatinAlmaRapor";
            this.btnSatinAlmaRapor.Size = new System.Drawing.Size(347, 57);
            this.btnSatinAlmaRapor.TabIndex = 11;
            this.btnSatinAlmaRapor.Text = "SATIN ALMA GEÇMİŞİ GÖRÜNTÜLE";
            this.btnSatinAlmaRapor.Click += new System.EventHandler(this.btnSatinAlmaRapor_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTemizle.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTemizle.Appearance.BackColor2 = System.Drawing.Color.Silver;
            this.btnTemizle.Appearance.BorderColor = System.Drawing.Color.Red;
            this.btnTemizle.Appearance.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Appearance.Options.UseBackColor = true;
            this.btnTemizle.Appearance.Options.UseBorderColor = true;
            this.btnTemizle.Appearance.Options.UseFont = true;
            this.btnTemizle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnTemizle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTemizle.ImageOptions.SvgImage")));
            this.btnTemizle.Location = new System.Drawing.Point(49, 414);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(165, 61);
            this.btnTemizle.TabIndex = 12;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // frmSatinAlma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 591);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnSatinAlmaRapor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.dtedtTarih);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbParca);
            this.Controls.Add(this.lblParcaTur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFirma);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSatinAlma";
            this.ShowIcon = false;
            this.Text = "SATIN ALMA İŞLEMLERİ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.tblSatinAlmaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AkbasHoldingTestDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFirma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbParca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtedtTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtedtTarih.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblParcaTur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tblSatinAlmaBindingSource;
        private AkbasHoldingTestDataSet6 AkbasHoldingTestDataSet6;
        private AkbasHoldingTestDataSet6TableAdapters.tblSatinAlmaTableAdapter tblSatinAlmaTableAdapter;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton btnSatinAlmaRapor;
        public DevExpress.XtraEditors.ComboBoxEdit cmbFirma;
        public DevExpress.XtraEditors.ComboBoxEdit cmbParca;
        public System.Windows.Forms.TextBox txtAdet;
        public DevExpress.XtraEditors.DateEdit dtedtTarih;
        public System.Windows.Forms.TextBox txtFiyat;
        public DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
    }
}