namespace AkbasHoldingVol2
{
    partial class frmDepartmanEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartmanEkle));
            this.label2 = new System.Windows.Forms.Label();
            this.btnDepartmanEkle = new DevExpress.XtraEditors.SimpleButton();
            this.txtDepartmanAdi = new System.Windows.Forms.TextBox();
            this.grdDepartmanListe = new DevExpress.XtraGrid.GridControl();
            this.tblDepartmanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.akbasHoldingTestDataSet6 = new AkbasHoldingVol2.AkbasHoldingTestDataSet6();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDepartmanID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartmanAdı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tblDepartmanTableAdapter = new AkbasHoldingVol2.AkbasHoldingTestDataSet6TableAdapters.tblDepartmanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grdDepartmanListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepartmanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.akbasHoldingTestDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "DEPARTMAN ADI";
            // 
            // btnDepartmanEkle
            // 
            this.btnDepartmanEkle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDepartmanEkle.Appearance.BackColor = System.Drawing.Color.Coral;
            this.btnDepartmanEkle.Appearance.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepartmanEkle.Appearance.Options.UseBackColor = true;
            this.btnDepartmanEkle.Appearance.Options.UseFont = true;
            this.btnDepartmanEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnDepartmanEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDepartmanEkle.ImageOptions.Image")));
            this.btnDepartmanEkle.Location = new System.Drawing.Point(259, 133);
            this.btnDepartmanEkle.Name = "btnDepartmanEkle";
            this.btnDepartmanEkle.Size = new System.Drawing.Size(343, 45);
            this.btnDepartmanEkle.TabIndex = 2;
            this.btnDepartmanEkle.Text = "DEPARTMAN EKLE";
            this.btnDepartmanEkle.Click += new System.EventHandler(this.btnDepartmanEkle_Click);
            // 
            // txtDepartmanAdi
            // 
            this.txtDepartmanAdi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtDepartmanAdi.Location = new System.Drawing.Point(431, 70);
            this.txtDepartmanAdi.Name = "txtDepartmanAdi";
            this.txtDepartmanAdi.Size = new System.Drawing.Size(211, 28);
            this.txtDepartmanAdi.TabIndex = 3;
            this.txtDepartmanAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDepartmanAdi_KeyPress);
            // 
            // grdDepartmanListe
            // 
            this.grdDepartmanListe.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.grdDepartmanListe.DataSource = this.tblDepartmanBindingSource;
            this.grdDepartmanListe.Location = new System.Drawing.Point(144, 205);
            this.grdDepartmanListe.MainView = this.gridView1;
            this.grdDepartmanListe.Name = "grdDepartmanListe";
            this.grdDepartmanListe.Size = new System.Drawing.Size(595, 181);
            this.grdDepartmanListe.TabIndex = 4;
            this.grdDepartmanListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tblDepartmanBindingSource
            // 
            this.tblDepartmanBindingSource.DataMember = "tblDepartman";
            this.tblDepartmanBindingSource.DataSource = this.akbasHoldingTestDataSet6;
            // 
            // akbasHoldingTestDataSet6
            // 
            this.akbasHoldingTestDataSet6.DataSetName = "AkbasHoldingTestDataSet6";
            this.akbasHoldingTestDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.Aqua;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDepartmanID,
            this.colDepartmanAdı});
            this.gridView1.GridControl = this.grdDepartmanListe;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colDepartmanID
            // 
            this.colDepartmanID.FieldName = "DepartmanID";
            this.colDepartmanID.MinWidth = 25;
            this.colDepartmanID.Name = "colDepartmanID";
            this.colDepartmanID.Visible = true;
            this.colDepartmanID.VisibleIndex = 0;
            this.colDepartmanID.Width = 94;
            // 
            // colDepartmanAdı
            // 
            this.colDepartmanAdı.FieldName = "DepartmanAdı";
            this.colDepartmanAdı.MinWidth = 25;
            this.colDepartmanAdı.Name = "colDepartmanAdı";
            this.colDepartmanAdı.Visible = true;
            this.colDepartmanAdı.VisibleIndex = 1;
            this.colDepartmanAdı.Width = 94;
            // 
            // tblDepartmanTableAdapter
            // 
            this.tblDepartmanTableAdapter.ClearBeforeFill = true;
            // 
            // frmDepartmanEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 591);
            this.Controls.Add(this.grdDepartmanListe);
            this.Controls.Add(this.txtDepartmanAdi);
            this.Controls.Add(this.btnDepartmanEkle);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDepartmanEkle";
            this.ShowIcon = false;
            this.Text = "DEPARTMAN EKLE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDepartmanEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDepartmanListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepartmanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.akbasHoldingTestDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnDepartmanEkle;
        private System.Windows.Forms.TextBox txtDepartmanAdi;
        private DevExpress.XtraGrid.GridControl grdDepartmanListe;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private AkbasHoldingTestDataSet6 akbasHoldingTestDataSet6;
        private System.Windows.Forms.BindingSource tblDepartmanBindingSource;
        private AkbasHoldingTestDataSet6TableAdapters.tblDepartmanTableAdapter tblDepartmanTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmanID;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmanAdı;
    }
}