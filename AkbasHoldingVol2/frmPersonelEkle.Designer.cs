namespace AkbasHoldingVol2
{
    partial class frmPersonelEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonelEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPersonelAd = new System.Windows.Forms.TextBox();
            this.txtPersonelSoyad = new System.Windows.Forms.TextBox();
            this.lueDepartman = new DevExpress.XtraEditors.LookUpEdit();
            this.tblDepartmanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.akbasHoldingTestDataSet6 = new AkbasHoldingVol2.AkbasHoldingTestDataSet6();
            this.btnPersonelEkle = new DevExpress.XtraEditors.SimpleButton();
            this.tblDepartmanTableAdapter = new AkbasHoldingVol2.AkbasHoldingTestDataSet6TableAdapters.tblDepartmanTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lueDepartman.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepartmanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.akbasHoldingTestDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "PERSONEL AD";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "PERSONEL SOYAD";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "DEPARTMAN";
            // 
            // txtPersonelAd
            // 
            this.txtPersonelAd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtPersonelAd.Location = new System.Drawing.Point(306, 122);
            this.txtPersonelAd.Name = "txtPersonelAd";
            this.txtPersonelAd.Size = new System.Drawing.Size(100, 28);
            this.txtPersonelAd.TabIndex = 0;
            this.txtPersonelAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonelAd_KeyPress);
            // 
            // txtPersonelSoyad
            // 
            this.txtPersonelSoyad.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtPersonelSoyad.Location = new System.Drawing.Point(306, 183);
            this.txtPersonelSoyad.Name = "txtPersonelSoyad";
            this.txtPersonelSoyad.Size = new System.Drawing.Size(100, 28);
            this.txtPersonelSoyad.TabIndex = 1;
            this.txtPersonelSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonelSoyad_KeyPress);
            // 
            // lueDepartman
            // 
            this.lueDepartman.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lueDepartman.Location = new System.Drawing.Point(306, 245);
            this.lueDepartman.Name = "lueDepartman";
            this.lueDepartman.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueDepartman.Properties.DataSource = this.tblDepartmanBindingSource;
            this.lueDepartman.Properties.DisplayMember = "DepartmanAdı";
            this.lueDepartman.Properties.ValueMember = "DepartmanID";
            this.lueDepartman.Size = new System.Drawing.Size(149, 22);
            this.lueDepartman.TabIndex = 2;
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
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPersonelEkle.Appearance.BackColor = System.Drawing.Color.Red;
            this.btnPersonelEkle.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPersonelEkle.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPersonelEkle.Appearance.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelEkle.Appearance.Options.UseBackColor = true;
            this.btnPersonelEkle.Appearance.Options.UseBorderColor = true;
            this.btnPersonelEkle.Appearance.Options.UseFont = true;
            this.btnPersonelEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnPersonelEkle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPersonelEkle.ImageOptions.SvgImage")));
            this.btnPersonelEkle.Location = new System.Drawing.Point(160, 344);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(196, 44);
            this.btnPersonelEkle.TabIndex = 3;
            this.btnPersonelEkle.Text = "PERSONEL EKLE";
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // tblDepartmanTableAdapter
            // 
            this.tblDepartmanTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(504, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(347, 310);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmPersonelEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 591);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPersonelEkle);
            this.Controls.Add(this.lueDepartman);
            this.Controls.Add(this.txtPersonelSoyad);
            this.Controls.Add(this.txtPersonelAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPersonelEkle";
            this.ShowIcon = false;
            this.Text = "PERSONEL EKLE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPersonelEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lueDepartman.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepartmanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.akbasHoldingTestDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPersonelAd;
        private System.Windows.Forms.TextBox txtPersonelSoyad;
        private DevExpress.XtraEditors.LookUpEdit lueDepartman;
        private DevExpress.XtraEditors.SimpleButton btnPersonelEkle;
        private AkbasHoldingTestDataSet6 akbasHoldingTestDataSet6;
        private System.Windows.Forms.BindingSource tblDepartmanBindingSource;
        private AkbasHoldingTestDataSet6TableAdapters.tblDepartmanTableAdapter tblDepartmanTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}