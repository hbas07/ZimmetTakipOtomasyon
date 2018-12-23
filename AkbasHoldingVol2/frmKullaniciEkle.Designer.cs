namespace AkbasHoldingVol2
{
    partial class frmKullaniciEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullaniciEkle));
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDepartman = new System.Windows.Forms.ComboBox();
            this.cmbYetki = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEkle.Appearance.BackColor = System.Drawing.Color.Red;
            this.btnEkle.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEkle.Appearance.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Appearance.Options.UseBackColor = true;
            this.btnEkle.Appearance.Options.UseFont = true;
            this.btnEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnEkle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEkle.ImageOptions.SvgImage")));
            this.btnEkle.Location = new System.Drawing.Point(367, 336);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(153, 56);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtSifre.Location = new System.Drawing.Point(367, 162);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(153, 28);
            this.txtSifre.TabIndex = 1;
            this.txtSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSifre_KeyPress);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(367, 111);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(153, 28);
            this.txtKullaniciAdi.TabIndex = 0;
            this.txtKullaniciAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKullaniciAdi_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "DEPARTMAN";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "YETKİ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "ŞİFRE";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "KULLANICI ADI";
            // 
            // cmbDepartman
            // 
            this.cmbDepartman.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmbDepartman.FormattingEnabled = true;
            this.cmbDepartman.Location = new System.Drawing.Point(367, 265);
            this.cmbDepartman.Name = "cmbDepartman";
            this.cmbDepartman.Size = new System.Drawing.Size(153, 29);
            this.cmbDepartman.TabIndex = 11;
            // 
            // cmbYetki
            // 
            this.cmbYetki.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmbYetki.FormattingEnabled = true;
            this.cmbYetki.Items.AddRange(new object[] {
            "Admin",
            "Satış Sorumlusu",
            "Bölüm Başkanı"});
            this.cmbYetki.Location = new System.Drawing.Point(367, 212);
            this.cmbYetki.Name = "cmbYetki";
            this.cmbYetki.Size = new System.Drawing.Size(153, 29);
            this.cmbYetki.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(644, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 288);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTemizle.Appearance.BackColor = System.Drawing.Color.Tomato;
            this.btnTemizle.Appearance.BackColor2 = System.Drawing.Color.Gray;
            this.btnTemizle.Appearance.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Appearance.Options.UseBackColor = true;
            this.btnTemizle.Appearance.Options.UseFont = true;
            this.btnTemizle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.ImageOptions.Image")));
            this.btnTemizle.Location = new System.Drawing.Point(170, 336);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(143, 56);
            this.btnTemizle.TabIndex = 14;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // frmKullaniciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 680);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbYetki);
            this.Controls.Add(this.cmbDepartman);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizeBox = false;
            this.Name = "frmKullaniciEkle";
            this.ShowIcon = false;
            this.Text = "KULLANICI EKLE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKullaniciEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public DevExpress.XtraEditors.SimpleButton btnEkle;
        public System.Windows.Forms.TextBox txtSifre;
        public System.Windows.Forms.TextBox txtKullaniciAdi;
        public System.Windows.Forms.ComboBox cmbDepartman;
        public System.Windows.Forms.ComboBox cmbYetki;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
    }
}