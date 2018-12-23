using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraEditors;

namespace AkbasHoldingVol2
{
    public partial class frmSatinAlma : Form
    {
        public frmSatinAlma()
        {
            InitializeComponent();
        }

        SqlBaglanti baglan = new SqlBaglanti();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int firmaID, urunID;
            firmaID = cmbFirma.SelectedIndex + 1;
            urunID = cmbParca.SelectedIndex + 1;
            if(txtAdet.Text!="" && txtFiyat.Text!="" && cmbFirma.SelectedIndex!=-1 && cmbParca.SelectedIndex!=-1 && dtedtTarih.SelectedText!=null )
            {
                if (Convert.ToDateTime(dtedtTarih.SelectedText) <= DateTime.Now)
                {
                    int k = 0;
                    int[] FirmaIDkont = new int[25];
                    int[] UrunIDkont=new int[25];
                    SqlCommand komut2 = new SqlCommand("SELECT UrunID,FirmaID FROM tblStok", baglan.Baglanti());
                    SqlDataReader dr = komut2.ExecuteReader();
                    while(dr.Read())                //STOKTA VAR OLAN URUNLERIN PKLARI OLAN URUNID VE FIRMAID TOPLANIR
                    {       
                            FirmaIDkont[k] = Convert.ToInt32(dr[1]);
                            UrunIDkont[k] = Convert.ToInt32(dr[0]);
                            k++;
                    }
                    baglan.Baglanti().Close();
                    for (int i = 0; i < FirmaIDkont.Length; i++)  //EGER SATIN ALINAN ÜRÜN VARSA O ÜRÜNÜN STOK ADEDİ ARTTIRILIR
                    {
                        if(FirmaIDkont[i]==firmaID)
                        {
                            if(UrunIDkont[i]==urunID)
                            {
                                SqlCommand komut3 = new SqlCommand("UPDATE tblStok SET Adet=Adet+@p3 WHERE UrunID=@p1 AND FirmaID=@p2", baglan.Baglanti());
                                komut3.Parameters.AddWithValue("@p1", urunID);
                                komut3.Parameters.AddWithValue("@p2", firmaID);
                                komut3.Parameters.AddWithValue("@p3", txtAdet.Text);
                                komut3.ExecuteNonQuery();
                                baglan.Baglanti().Close();
                            }
                        }
                    }
                    SqlCommand komut = new SqlCommand("INSERT INTO tblSatinAlma (UrunID,FirmaAdi,Urun,SatinAlmaTarihi,Adet,Fiyat,FirmaID) " +
                        "VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglan.Baglanti()); //URUN DAHA ONCE ALINMAMISSA
                    komut.Parameters.AddWithValue("@p1",urunID);                    //YENİ BİR KAYIT AÇILIR VE STOK TABLOSUNA EKLENİR
                    komut.Parameters.AddWithValue("@p2",cmbFirma.SelectedText);
                    komut.Parameters.AddWithValue("@p3",cmbParca.SelectedText);
                    komut.Parameters.AddWithValue("@p4", dtedtTarih.SelectedText);
                    komut.Parameters.AddWithValue("@p5", txtAdet.Text);
                    komut.Parameters.AddWithValue("@p6", txtFiyat.Text);
                    komut.Parameters.AddWithValue("@p7", firmaID);
                    komut.ExecuteNonQuery();
                    baglan.Baglanti().Close();
                    XtraMessageBox.Show("Satın Alma Başarılı !", "İşlem başarılı ", MessageBoxButtons.OK);
                    
                }
                else
                {
                    XtraMessageBox.Show("İleriki Bir Tarih Seçilemez", "İşlem başarısız ", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
                XtraMessageBox.Show("Boş Alan Bırakılamaz !", "İşlem Başarısız", MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void txtAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        

        private void btnSatinAlmaRapor_Click(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'AkbasHoldingTestDataSet6.tblSatinAlma' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblSatinAlmaTableAdapter.Fill(this.AkbasHoldingTestDataSet6.tblSatinAlma);
            this.reportViewer1.RefreshReport();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAdet.Text = "";
            txtFiyat.Text = "";
            cmbFirma.SelectedIndex = -1;
            cmbParca.SelectedIndex = -1;
            dtedtTarih.EditValue =null ;
        }
    }
}
