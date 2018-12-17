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
            ((System.ComponentModel.ISupportInitialize)(this.vw_RaporIslemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AkbasHoldingTestDataSet6)).BeginInit();
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
            this.btnRaporAl.Appearance.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRaporAl.Appearance.Options.UseFont = true;
            this.btnRaporAl.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRaporAl.ImageOptions.Image")));
            this.btnRaporAl.Location = new System.Drawing.Point(368, 27);
            this.btnRaporAl.Name = "btnRaporAl";
            this.btnRaporAl.Size = new System.Drawing.Size(181, 48);
            this.btnRaporAl.TabIndex = 0;
            this.btnRaporAl.Text = "RAPOR AL";
            this.btnRaporAl.Click += new System.EventHandler(this.btnRaporAl_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            reportDataSource1.Name = "RaporIslem";
            reportDataSource1.Value = this.vw_RaporIslemBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AkbasHoldingVol2.rprRaporIslem.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 95);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(876, 484);
            this.reportViewer1.TabIndex = 1;
            // 
            // vw_RaporIslemTableAdapter
            // 
            this.vw_RaporIslemTableAdapter.ClearBeforeFill = true;
            // 
            // frmRaporIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 591);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnRaporAl);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmRaporIslem";
            this.ShowIcon = false;
            this.Text = "RAPOR İŞLEMLERİ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.vw_RaporIslemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AkbasHoldingTestDataSet6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnRaporAl;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vw_RaporIslemBindingSource;
        private AkbasHoldingTestDataSet6 AkbasHoldingTestDataSet6;
        private AkbasHoldingTestDataSet6TableAdapters.vw_RaporIslemTableAdapter vw_RaporIslemTableAdapter;
    }
}