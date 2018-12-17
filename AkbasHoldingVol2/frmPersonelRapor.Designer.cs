namespace AkbasHoldingVol2
{
    partial class frmPersonelRapor
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.AkbasHoldingTestDataSet6 = new AkbasHoldingVol2.AkbasHoldingTestDataSet6();
            this.vw_ZimmetBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_ZimmetBilgiTableAdapter = new AkbasHoldingVol2.AkbasHoldingTestDataSet6TableAdapters.vw_ZimmetBilgiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AkbasHoldingTestDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_ZimmetBilgiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "PersonelRapor";
            reportDataSource1.Value = this.vw_ZimmetBilgiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AkbasHoldingVol2.rprPersonelRapor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(900, 591);
            this.reportViewer1.TabIndex = 0;
            // 
            // AkbasHoldingTestDataSet5
            // 
            this.AkbasHoldingTestDataSet6.DataSetName = "AkbasHoldingTestDataSet5";
            this.AkbasHoldingTestDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vw_ZimmetBilgiBindingSource
            // 
            this.vw_ZimmetBilgiBindingSource.DataMember = "vw_ZimmetBilgi";
            this.vw_ZimmetBilgiBindingSource.DataSource = this.AkbasHoldingTestDataSet6;
            // 
            // vw_ZimmetBilgiTableAdapter
            // 
            this.vw_ZimmetBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // frmPersonelRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 591);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPersonelRapor";
            this.ShowIcon = false;
            this.Text = "PERSONEL RAPOR";
            this.Load += new System.EventHandler(this.frmPersonelRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AkbasHoldingTestDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_ZimmetBilgiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vw_ZimmetBilgiBindingSource;
        private AkbasHoldingTestDataSet6 AkbasHoldingTestDataSet6;
        private AkbasHoldingTestDataSet6TableAdapters.vw_ZimmetBilgiTableAdapter vw_ZimmetBilgiTableAdapter;
    }
}