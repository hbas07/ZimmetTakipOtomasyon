namespace AkbasHoldingVol2
{
    partial class frmPersonelArama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonelArama));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPersonelAd = new System.Windows.Forms.TextBox();
            this.btnArama = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lstZimmetEsya = new DevExpress.XtraEditors.ListBoxControl();
            this.lblPersonelID = new System.Windows.Forms.Label();
            this.lblPersonelAd = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtDepartman = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.btnPersonelRapor = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPersonelSoyad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lstZimmetEsya)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel İsim";
            // 
            // txtPersonelAd
            // 
            this.txtPersonelAd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtPersonelAd.Location = new System.Drawing.Point(206, 61);
            this.txtPersonelAd.Name = "txtPersonelAd";
            this.txtPersonelAd.Size = new System.Drawing.Size(100, 28);
            this.txtPersonelAd.TabIndex = 1;
            // 
            // btnArama
            // 
            this.btnArama.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnArama.Appearance.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnArama.Appearance.Options.UseFont = true;
            this.btnArama.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnArama.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnArama.ImageOptions.SvgImage")));
            this.btnArama.Location = new System.Drawing.Point(619, 108);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(141, 35);
            this.btnArama.TabIndex = 2;
            this.btnArama.Text = "ARA";
            this.btnArama.Click += new System.EventHandler(this.btnArama_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(73, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "Personele Zimmetli Eşyalar";
            // 
            // lstZimmetEsya
            // 
            this.lstZimmetEsya.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lstZimmetEsya.Location = new System.Drawing.Point(79, 302);
            this.lstZimmetEsya.Name = "lstZimmetEsya";
            this.lstZimmetEsya.Size = new System.Drawing.Size(474, 161);
            this.lstZimmetEsya.TabIndex = 6;
            // 
            // lblPersonelID
            // 
            this.lblPersonelID.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblPersonelID.AutoSize = true;
            this.lblPersonelID.Location = new System.Drawing.Point(86, 108);
            this.lblPersonelID.Name = "lblPersonelID";
            this.lblPersonelID.Size = new System.Drawing.Size(92, 22);
            this.lblPersonelID.TabIndex = 7;
            this.lblPersonelID.Text = "Personel ID";
            // 
            // lblPersonelAd
            // 
            this.lblPersonelAd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblPersonelAd.AutoSize = true;
            this.lblPersonelAd.Location = new System.Drawing.Point(86, 155);
            this.lblPersonelAd.Name = "lblPersonelAd";
            this.lblPersonelAd.Size = new System.Drawing.Size(30, 22);
            this.lblPersonelAd.TabIndex = 7;
            this.lblPersonelAd.Text = "Ad";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Departman";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Soyad";
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtPersonelID.Location = new System.Drawing.Point(206, 105);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.ReadOnly = true;
            this.txtPersonelID.Size = new System.Drawing.Size(100, 28);
            this.txtPersonelID.TabIndex = 8;
            // 
            // txtAd
            // 
            this.txtAd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtAd.Location = new System.Drawing.Point(206, 152);
            this.txtAd.Name = "txtAd";
            this.txtAd.ReadOnly = true;
            this.txtAd.Size = new System.Drawing.Size(100, 28);
            this.txtAd.TabIndex = 9;
            // 
            // txtDepartman
            // 
            this.txtDepartman.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtDepartman.Location = new System.Drawing.Point(453, 105);
            this.txtDepartman.Name = "txtDepartman";
            this.txtDepartman.ReadOnly = true;
            this.txtDepartman.Size = new System.Drawing.Size(100, 28);
            this.txtDepartman.TabIndex = 10;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtSoyad.Location = new System.Drawing.Point(453, 151);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.ReadOnly = true;
            this.txtSoyad.Size = new System.Drawing.Size(100, 28);
            this.txtSoyad.TabIndex = 11;
            // 
            // btnPersonelRapor
            // 
            this.btnPersonelRapor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPersonelRapor.Appearance.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelRapor.Appearance.Options.UseFont = true;
            this.btnPersonelRapor.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnPersonelRapor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonelRapor.ImageOptions.Image")));
            this.btnPersonelRapor.Location = new System.Drawing.Point(600, 179);
            this.btnPersonelRapor.Name = "btnPersonelRapor";
            this.btnPersonelRapor.Size = new System.Drawing.Size(173, 35);
            this.btnPersonelRapor.TabIndex = 12;
            this.btnPersonelRapor.Text = "RAPOR AL";
            this.btnPersonelRapor.Click += new System.EventHandler(this.btnPersonelRapor_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Personel Soyad";
            // 
            // txtPersonelSoyad
            // 
            this.txtPersonelSoyad.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtPersonelSoyad.Location = new System.Drawing.Point(453, 61);
            this.txtPersonelSoyad.Name = "txtPersonelSoyad";
            this.txtPersonelSoyad.Size = new System.Drawing.Size(100, 28);
            this.txtPersonelSoyad.TabIndex = 2;
            // 
            // frmPersonelArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 591);
            this.Controls.Add(this.txtPersonelSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPersonelRapor);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtDepartman);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPersonelAd);
            this.Controls.Add(this.lblPersonelID);
            this.Controls.Add(this.lstZimmetEsya);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnArama);
            this.Controls.Add(this.txtPersonelAd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPersonelArama";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PERSONEL ARAMA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPersonelArama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstZimmetEsya)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPersonelAd;
        private DevExpress.XtraEditors.SimpleButton btnArama;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.ListBoxControl lstZimmetEsya;
        private System.Windows.Forms.Label lblPersonelID;
        private System.Windows.Forms.Label lblPersonelAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtDepartman;
        private System.Windows.Forms.TextBox txtSoyad;
        private DevExpress.XtraEditors.SimpleButton btnPersonelRapor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPersonelSoyad;
    }
}