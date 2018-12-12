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
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-2RPJPRH;Initial Catalog=AkbasHoldingTest;Integrated Security=True");
        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int firmaID, urunID;
            firmaID = cmbFirma.SelectedIndex + 1;
            urunID = cmbParca.SelectedIndex + 1;
            if(txtAdet.Text!=" " && txtFiyat.Text!=" " && cmbFirma.SelectedIndex!=-1 && cmbParca.SelectedIndex!=-1 && dtedtTarih.SelectedText!=null )
            {
                if(Convert.ToDateTime(dtedtTarih.SelectedText) <= DateTime.Now)
                {
                    SqlCommand komut = new SqlCommand("INSERT INTO tblSatinAlma (UrunID,FirmaAdi,Urun,SatinAlmaTarihi,Adet,Fiyat,FirmaID) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
                    komut.Parameters.AddWithValue("@p1",urunID);
                    komut.Parameters.AddWithValue("@p2",cmbFirma.SelectedText);
                    komut.Parameters.AddWithValue("@p3",cmbParca.SelectedText);
                    komut.Parameters.AddWithValue("@p4", dtedtTarih.SelectedText);
                    komut.Parameters.AddWithValue("@p5", txtAdet.Text);
                    komut.Parameters.AddWithValue("@p6", txtFiyat.Text);
                    komut.Parameters.AddWithValue("@p7", firmaID);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    XtraMessageBox.Show("Satın Alma Başarılı !", "İşlem başarılı ", MessageBoxButtons.OK);
                 }
                else
                {
                    XtraMessageBox.Show("İleriki Bir Tarih Seçilemez", "İşlem başarısız ", MessageBoxButtons.OK);
                }
            }
            else
                XtraMessageBox.Show("Boş Alan Bırakılamaz !", "İşlem Başarısız", MessageBoxButtons.OK);
        }

        private void txtAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void frmSatinAlma_Load(object sender, EventArgs e)
        {
            txtAdet.Text =" ";
            txtFiyat.Text =" ";
        }
    }
}
