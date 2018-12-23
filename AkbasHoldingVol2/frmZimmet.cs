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
    public partial class frmZimmet : Form
    {
        public frmZimmet()
        {
            InitializeComponent();
        }

        SqlBaglanti baglan = new SqlBaglanti();
        private void frmZimmet_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'akbasHoldingTestDataSet6.sp_StokBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sp_StokBilgiTableAdapter.Fill(this.akbasHoldingTestDataSet6.sp_StokBilgi);
            // TODO: Bu kod satırı 'akbasHoldingTestDataSet6.vw_PersonelBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.vw_PersonelBilgiTableAdapter.Fill(this.akbasHoldingTestDataSet6.vw_PersonelBilgi);
            
        }
        

        int personelID=-1, departmanID=-1,firmaID=-1,urunID=-1,urunAdet=-1;
        string personelad, personelsoyad, urun, marka;

        public void gridView1_FocusedRowChanged(object sender, 
            DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr!=null)
            {
                personelID =Convert.ToInt32( dr[0]);
                departmanID =Convert.ToInt32(dr[4]);
                personelad = dr[1].ToString();
                personelsoyad = dr[2].ToString();
            }
        }

        public void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            if(dr!=null)
            {
                firmaID = Convert.ToInt32(dr[5]);
                urunAdet = Convert.ToInt32(dr[3]);
                urunID = Convert.ToInt32(dr[0]);
                urun = dr[1].ToString();
                marka = dr[2].ToString();
            }
        }

        public void btnZimmetle_Click(object sender, EventArgs e)
        {
            DialogResult secim;
            if(firmaID!=-1 && departmanID!=-1 && personelID!=-1 && urunID!=-1)
            {
                if (urunAdet != 0)
                {
                    secim = XtraMessageBox.Show("" + personelad + " " + personelsoyad +
                       " adlı personele " + marka + " " + urun + " zimmetlenecek.Onaylıyor musunuz ?",
                       "Zimmetleme", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
                    if (secim == DialogResult.Yes)
                    {
                        urunAdet -= 1;
                        SqlCommand komut = new SqlCommand("INSERT tblZimmet (PersonelID,UrunID,DepartmanID,FirmaID,ZimmetAktifligi) " +
                            "VALUES (@p1,@p2,@p3,@p4,1)", baglan.Baglanti());
                        komut.Parameters.AddWithValue("@p1", personelID);
                        komut.Parameters.AddWithValue("@p2", urunID);
                        komut.Parameters.AddWithValue("@p3", departmanID);
                        komut.Parameters.AddWithValue("@p4", firmaID);
                        komut.ExecuteNonQuery();
                        baglan.Baglanti().Close();

                        SqlCommand komut2 = new SqlCommand("UPDATE tblStok SET Adet=@p1 WHERE UrunID=@p2 AND FirmaID=@p3", baglan.Baglanti());
                        komut2.Parameters.AddWithValue("@p1", urunAdet);
                        komut2.Parameters.AddWithValue("@p2", urunID);
                        komut2.Parameters.AddWithValue("@p3", firmaID);
                        komut2.ExecuteNonQuery();
                        baglan.Baglanti().Close();
                        XtraMessageBox.Show("Zimmetleme Başarılı ! ", "İşlem Başarılı", MessageBoxButtons.OK);
                        if (urunAdet == 0) //ZİMMETLENEN ÜRÜNÜN ADETİ 0 OLDUĞU ZAMAN VERİTABANINDAN AKTİFLİK DURUMUNU FALSE YAP
                        {
                            SqlCommand komut3 = new SqlCommand("UPDATE tblStok SET AktiflikDurumu='false' WHERE UrunID=@p2 AND FirmaID=@p3", baglan.Baglanti());
                            komut3.Parameters.AddWithValue("@p2", urunID);
                            komut3.Parameters.AddWithValue("@p3", firmaID);
                            komut3.ExecuteNonQuery();
                            baglan.Baglanti().Close();
                        }
                        this.akbasHoldingTestDataSet6.Reset();
                        this.sp_StokBilgiTableAdapter.Fill(this.akbasHoldingTestDataSet6.sp_StokBilgi);
                        this.vw_PersonelBilgiTableAdapter.Fill(this.akbasHoldingTestDataSet6.vw_PersonelBilgi);
                    }
                    else
                        XtraMessageBox.Show("İşleminiz iptal edilmiştir.", "İşlem Başarısız ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    XtraMessageBox.Show("Seçtiğiniz Ürün Stokta Bulunmamaktadır ! ", "İşlem başarısız ", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
                XtraMessageBox.Show("Zimmetleme Başarısız Lütfen Bir Personel Ve Bir Ürün Seçiniz ! ", "İşlem başarısız ", MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

    }
}
