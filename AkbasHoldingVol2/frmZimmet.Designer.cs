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
            this.akbasHoldingTestDataSet = new AkbasHoldingVol2.AkbasHoldingTestDataSet();
            this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPersonelTableAdapter = new AkbasHoldingVol2.AkbasHoldingTestDataSetTableAdapters.tblPersonelTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.spStokBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_StokBilgiTableAdapter = new AkbasHoldingVol2.AkbasHoldingTestDataSetTableAdapters.sp_StokBilgiTableAdapter();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.tblPersonelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.akbasHoldingTestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spStokBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // akbasHoldingTestDataSet
            // 
            this.akbasHoldingTestDataSet.DataSetName = "AkbasHoldingTestDataSet";
            this.akbasHoldingTestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPersonelBindingSource
            // 
            this.tblPersonelBindingSource.DataMember = "tblPersonel";
            this.tblPersonelBindingSource.DataSource = this.akbasHoldingTestDataSet;
            // 
            // tblPersonelTableAdapter
            // 
            this.tblPersonelTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "PERSONEL LİSTE";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "ZİMMETLENECEK EŞYA";
            // 
            // spStokBilgiBindingSource
            // 
            this.spStokBilgiBindingSource.DataMember = "sp_StokBilgi";
            this.spStokBilgiBindingSource.DataSource = this.akbasHoldingTestDataSet;
            // 
            // sp_StokBilgiTableAdapter
            // 
            this.sp_StokBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxControl1.DataSource = this.tblPersonelBindingSource;
            this.listBoxControl1.DisplayMember = "Ad";
            this.listBoxControl1.HorizontalScrollbar = true;
            this.listBoxControl1.Location = new System.Drawing.Point(101, 67);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxControl1.Size = new System.Drawing.Size(598, 152);
            this.listBoxControl1.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.listBoxControl1.TabIndex = 3;
            this.listBoxControl1.ValueMember = "PersonelID";
            this.listBoxControl1.SelectedIndexChanged += new System.EventHandler(this.listBoxControl1_SelectedIndexChanged);
            // 
            // tblPersonelBindingSource1
            // 
            this.tblPersonelBindingSource1.DataMember = "tblPersonel";
            this.tblPersonelBindingSource1.DataSource = this.akbasHoldingTestDataSet;
            // 
            // frmZimmet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 591);
            this.Controls.Add(this.listBoxControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmZimmet";
            this.ShowIcon = false;
            this.Text = "ZİMMETLEME";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmZimmet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.akbasHoldingTestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spStokBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AkbasHoldingTestDataSet akbasHoldingTestDataSet;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private AkbasHoldingTestDataSetTableAdapters.tblPersonelTableAdapter tblPersonelTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource spStokBilgiBindingSource;
        private AkbasHoldingTestDataSetTableAdapters.sp_StokBilgiTableAdapter sp_StokBilgiTableAdapter;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource1;
    }
}