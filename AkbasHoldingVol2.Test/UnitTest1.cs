using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AkbasHoldingVol2.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AdminGiris()
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.txtKullaniciAdi.Text = "admin";
            frmLogin.txtSifre.Text = "1234";
            frmLogin.btnGiris.PerformClick();
        }

        [TestMethod]
        public void SatinAlma()
        {
            frmSatinAlma frmSatinAlma = new frmSatinAlma();
            frmSatinAlma.cmbFirma.SelectedIndex = 2;
            frmSatinAlma.cmbParca.SelectedIndex = 3;
            frmSatinAlma.txtAdet.Text = "4";
            frmSatinAlma.dtedtTarih.Text = "15.12.2018";
            frmSatinAlma.txtFiyat.Text = "4.5";
            frmSatinAlma.btnKaydet.PerformClick();
        }

        [TestMethod]
        public void Zimmetleme()
        {
            frmZimmet frmZimmet = new frmZimmet();
            frmZimmet.btnZimmetle.PerformClick();
        }

        [TestMethod]
        public void BolumRaporlama()
        {
            frmRaporIslem frmRaporIslem = new frmRaporIslem();
            frmRaporIslem.lueBolum.ItemIndex = 3;
            frmRaporIslem.btnBolumRapor.PerformClick();
        }

        [TestMethod]
        public void KullaniciEkle()
        {
            frmKullaniciEkle frmKullaniciEkle = new frmKullaniciEkle();
            frmKullaniciEkle.txtKullaniciAdi.Text = "hakan";
            frmKullaniciEkle.txtSifre.Text = "1234";
            frmKullaniciEkle.cmbYetki.SelectedIndex = 1;
            frmKullaniciEkle.btnEkle.PerformClick();
        }
    }
}
