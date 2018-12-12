namespace AkbasHoldingVol2
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnLogin = new DevExpress.XtraBars.BarButtonItem();
            this.btnSatinAlma = new DevExpress.XtraBars.BarButtonItem();
            this.btnZimmet = new DevExpress.XtraBars.BarButtonItem();
            this.btnAtikKontrol = new DevExpress.XtraBars.BarButtonItem();
            this.btnRaporİslem = new DevExpress.XtraBars.BarButtonItem();
            this.btnStok = new DevExpress.XtraBars.BarButtonItem();
            this.btnArama = new DevExpress.XtraBars.BarButtonItem();
            this.btnKullaniciEkle = new DevExpress.XtraBars.BarButtonItem();
            this.rbnİslem = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnLogin,
            this.btnSatinAlma,
            this.btnZimmet,
            this.btnAtikKontrol,
            this.btnRaporİslem,
            this.btnStok,
            this.btnArama,
            this.btnKullaniciEkle});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbnİslem});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.Size = new System.Drawing.Size(1089, 186);
            // 
            // btnLogin
            // 
            this.btnLogin.Caption = "LOGİN";
            this.btnLogin.Id = 1;
            this.btnLogin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.ImageOptions.Image")));
            this.btnLogin.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLogin.ImageOptions.SvgImage")));
            this.btnLogin.ItemAppearance.Normal.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.ItemAppearance.Normal.Options.UseFont = true;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogin_ItemClick);
            // 
            // btnSatinAlma
            // 
            this.btnSatinAlma.Caption = "SATIN ALMA";
            this.btnSatinAlma.Id = 2;
            this.btnSatinAlma.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSatinAlma.ImageOptions.Image")));
            this.btnSatinAlma.ItemAppearance.Normal.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatinAlma.ItemAppearance.Normal.Options.UseFont = true;
            this.btnSatinAlma.Name = "btnSatinAlma";
            this.btnSatinAlma.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnSatinAlma.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSatinAlma_ItemClick);
            // 
            // btnZimmet
            // 
            this.btnZimmet.Caption = "ZİMMETLEME";
            this.btnZimmet.Id = 3;
            this.btnZimmet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnZimmet.ImageOptions.Image")));
            this.btnZimmet.ItemAppearance.Normal.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnZimmet.ItemAppearance.Normal.Options.UseFont = true;
            this.btnZimmet.Name = "btnZimmet";
            this.btnZimmet.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnZimmet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnZimmet_ItemClick);
            // 
            // btnAtikKontrol
            // 
            this.btnAtikKontrol.Caption = "ATIK KONTROL";
            this.btnAtikKontrol.Id = 4;
            this.btnAtikKontrol.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtikKontrol.ImageOptions.Image")));
            this.btnAtikKontrol.ItemAppearance.Normal.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAtikKontrol.ItemAppearance.Normal.Options.UseFont = true;
            this.btnAtikKontrol.Name = "btnAtikKontrol";
            this.btnAtikKontrol.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnAtikKontrol.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAtikKontrol_ItemClick);
            // 
            // btnRaporİslem
            // 
            this.btnRaporİslem.Caption = "RAPOR İŞLEMLERİ";
            this.btnRaporİslem.Id = 5;
            this.btnRaporİslem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRaporİslem.ImageOptions.Image")));
            this.btnRaporİslem.ItemAppearance.Normal.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRaporİslem.ItemAppearance.Normal.Options.UseFont = true;
            this.btnRaporİslem.Name = "btnRaporİslem";
            this.btnRaporİslem.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnRaporİslem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRaporİslem_ItemClick);
            // 
            // btnStok
            // 
            this.btnStok.Caption = "STOK";
            this.btnStok.Id = 6;
            this.btnStok.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStok.ImageOptions.Image")));
            this.btnStok.ItemAppearance.Normal.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStok.ItemAppearance.Normal.Options.UseFont = true;
            this.btnStok.Name = "btnStok";
            this.btnStok.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnStok.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStok_ItemClick);
            // 
            // btnArama
            // 
            this.btnArama.Caption = "ARAMA";
            this.btnArama.Id = 7;
            this.btnArama.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnArama.ImageOptions.Image")));
            this.btnArama.ItemAppearance.Normal.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnArama.ItemAppearance.Normal.Options.UseFont = true;
            this.btnArama.Name = "btnArama";
            this.btnArama.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnArama.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnArama_ItemClick);
            // 
            // btnKullaniciEkle
            // 
            this.btnKullaniciEkle.Caption = "KULLANICI EKLE";
            this.btnKullaniciEkle.Id = 8;
            this.btnKullaniciEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKullaniciEkle.ImageOptions.Image")));
            this.btnKullaniciEkle.ItemAppearance.Normal.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullaniciEkle.ItemAppearance.Normal.Options.UseFont = true;
            this.btnKullaniciEkle.Name = "btnKullaniciEkle";
            this.btnKullaniciEkle.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnKullaniciEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKullaniciEkle_ItemClick);
            // 
            // rbnİslem
            // 
            this.rbnİslem.Appearance.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbnİslem.Appearance.Options.UseFont = true;
            this.rbnİslem.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rbnİslem.Name = "rbnİslem";
            this.rbnİslem.Text = "Akbaş Holding";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLogin);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSatinAlma);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnZimmet);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAtikKontrol);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRaporİslem);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnStok);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnArama);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKullaniciEkle);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "ribbonPage3";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 634);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "Akbaş Holding";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbnİslem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnLogin;
        private DevExpress.XtraBars.BarButtonItem btnSatinAlma;
        private DevExpress.XtraBars.BarButtonItem btnZimmet;
        private DevExpress.XtraBars.BarButtonItem btnAtikKontrol;
        private DevExpress.XtraBars.BarButtonItem btnRaporİslem;
        private DevExpress.XtraBars.BarButtonItem btnStok;
        private DevExpress.XtraBars.BarButtonItem btnArama;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.BarButtonItem btnKullaniciEkle;
    }
}