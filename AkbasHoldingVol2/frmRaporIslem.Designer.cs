namespace AkbasHoldingVol2
{
    partial class frmRaporIslem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRaporIslem));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.vw_RaporIslemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AkbasHoldingTestDataSet6 = new AkbasHoldingVol2.AkbasHoldingTestDataSet6();
            this.btnRaporAl = new DevExpress.XtraEditors.SimpleButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vw_RaporIslemTableAdapter = new AkbasHoldingVol2.AkbasHoldingTestDataSet6TableAdapters.vw_RaporIslemTableAdapter();
            this.lueBolum = new DevExpress.XtraEditors.LookUpEdit();
            this.tblDepartmanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblDepartmanTableAdapter = new AkbasHoldingVol2.AkbasHoldingTestDataSet6TableAdapters.tblDepartmanTableAdapter();
            this.btnBolumRapor = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vw_RaporIslemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AkbasHoldingTestDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueBolum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepartmanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vw_RaporIslemBindingSource
            // 
            this.vw_RaporIslemBindingSource.DataMember = "vw_RaporIslem";
            this.vw_RaporIslemBindingSource.DataSource = this.AkbasHoldingTestDataSet6;
            // 
            // AkbasHoldingTestDataSet6
            // 
            this.AkbasHoldingTestDataSet6.DataSetName = "AkbasHoldingTestDataSet6";
            this.AkbasHoldingTestDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnRaporAl
            // 
            this.btnRaporAl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRaporAl.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRaporAl.Appearance.BackColor2 = System.Drawing.Color.Silver;
            this.btnRaporAl.Appearance.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRaporAl.Appearance.Options.UseBackColor = true;
            this.btnRaporAl.Appearance.Options.UseFont = true;
            this.btnRaporAl.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnRaporAl.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRaporAl.ImageOptions.Image")));
            this.btnRaporAl.Location = new System.Drawing.Point(12, 114);
            this.btnRaporAl.Name = "btnRaporAl";
            this.btnRaporAl.Size = new System.Drawing.Size(422, 48);
            this.btnRaporAl.TabIndex = 0;
            this.btnRaporAl.Text = "YETKİM OLAN BÖLÜMLERİN RAPORUNU AL";
            this.btnRaporAl.Click += new System.EventHandler(this.btnRaporAl_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            reportDataSource1.Name = "RaporIslem";
            reportDataSource1.Value = this.vw_RaporIslemBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AkbasHoldingVol2.rprRaporIslem.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 183);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(876, 396);
            this.reportViewer1.TabIndex = 1;
            // 
            // vw_RaporIslemTableAdapter
            // 
            this.vw_RaporIslemTableAdapter.ClearBeforeFill = true;
            // 
            // lueBolum
            // 
            this.lueBolum.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lueBolum.Enabled = false;
            this.lueBolum.Location = new System.Drawing.Point(638, 72);
            this.lueBolum.Name = "lueBolum";
            this.lueBolum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueBolum.Properties.DataSource = this.tblDepartmanBindingSource;
            this.lueBolum.Properties.DisplayMember = "DepartmanAdı";
            this.lueBolum.Properties.ValueMember = "DepartmanID";
            this.lueBolum.Size = new System.Drawing.Size(214, 22);
            this.lueBolum.TabIndex = 2;
            // 
            // tblDepartmanBindingSource
            // 
            this.tblDepartmanBindingSource.DataMember = "tblDepartman";
            this.tblDepartmanBindingSource.DataSource = this.AkbasHoldingTestDataSet6;
            // 
            // tblDepartmanTableAdapter
            // 
            this.tblDepartmanTableAdapter.ClearBeforeFill = true;
            // 
            // btnBolumRapor
            // 
            this.btnBolumRapor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBolumRapor.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnBolumRapor.Appearance.BackColor2 = System.Drawing.Color.DarkGreen;
            this.btnBolumRapor.Appearance.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBolumRapor.Appearance.Options.UseBackColor = true;
            this.btnBolumRapor.Appearance.Options.UseFont = true;
            this.btnBolumRapor.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnBolumRapor.Enabled = false;
            this.btnBolumRapor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBolumRapor.ImageOptions.Image")));
            this.btnBolumRapor.Location = new System.Drawing.Point(508, 114);
            this.btnBolumRapor.Name = "btnBolumRapor";
            this.btnBolumRapor.Size = new System.Drawing.Size(344, 48);
            this.btnBolumRapor.TabIndex = 3;
            this.btnBolumRapor.Text = "SEÇİLİ BÖLÜM RAPORU AL";
            this.btnBolumRapor.Click += new System.EventHandler(this.btnBolumRapor_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(504, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "DEPARTMAN";
            // 
            // frmRaporIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 591);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBolumRapor);
            this.Controls.Add(this.lueBolum);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnRaporAl);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmRaporIslem";
            this.ShowIcon = false;
            this.Text = "RAPOR İŞLEMLERİ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRaporIslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vw_RaporIslemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AkbasHoldingTestDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueBolum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepartmanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnRaporAl;
        private System.Windows.Forms.BindingSource vw_RaporIslemBindingSource;
        private AkbasHoldingTestDataSet6 AkbasHoldingTestDataSet6;
        private AkbasHoldingTestDataSet6TableAdapters.vw_RaporIslemTableAdapter vw_RaporIslemTableAdapter;
        private System.Windows.Forms.BindingSource tblDepartmanBindingSource;
        private AkbasHoldingTestDataSet6TableAdapters.tblDepartmanTableAdapter tblDepartmanTableAdapter;
        private System.Windows.Forms.Label label1;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public DevExpress.XtraEditors.LookUpEdit lueBolum;
        public DevExpress.XtraEditors.SimpleButton btnBolumRapor;
    }
}