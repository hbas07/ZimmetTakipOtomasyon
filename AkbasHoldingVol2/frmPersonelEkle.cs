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
    public partial class frmPersonelEkle : Form
    {
        public frmPersonelEkle()
        {
            InitializeComponent();
        }

        SqlBaglanti baglan = new SqlBaglanti();

        private void frmPersonelEkle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'akbasHoldingTestDataSet6.tblDepartman' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblDepartmanTableAdapter.Fill(this.akbasHoldingTestDataSet6.tblDepartman);
            lueDepartman.ItemIndex = -1;
            lueDepartman.Properties.NullText = " ";
        }
        
        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            int depID = -1;
            int personelID =-1;
            if(lueDepartman.ItemIndex!=-1 && txtPersonelAd.Text!="" && txtPersonelSoyad.Text!="")
            {
                depID = depID = Convert.ToInt32(lueDepartman.EditValue.ToString());
                SqlCommand komut = new SqlCommand("SELECT MAX(PersonelID) FROM tblPersonel", baglan.Baglanti());
                SqlDataReader dr = komut.ExecuteReader();
                while(dr.Read())
                {
                    personelID =Convert.ToInt32(dr[0]);
                }
                baglan.Baglanti().Close();

                SqlCommand komut2 = new SqlCommand("INSERT tblPersonel VALUES (@p1,@p2,@p3,@p4)", baglan.Baglanti());
                komut2.Parameters.AddWithValue("@p1", personelID + 1);
                komut2.Parameters.AddWithValue("@p2", txtPersonelAd.Text);
                komut2.Parameters.AddWithValue("@p3", txtPersonelSoyad.Text);
                komut2.Parameters.AddWithValue("@p4", depID);
                komut2.ExecuteNonQuery();
                baglan.Baglanti().Close();
                XtraMessageBox.Show("Personel eklendi !", "İşlem başarılı ", MessageBoxButtons.OK);
            }
            else
                XtraMessageBox.Show("Boş Alan Bırakılamaz", "İşlem başarısız ", MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void txtPersonelAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txtPersonelSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
    }
}
