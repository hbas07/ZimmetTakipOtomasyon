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
    public partial class frmDepartmanEkle : Form
    {
        public frmDepartmanEkle()
        {
            InitializeComponent();
        }
        
        SqlBaglanti baglan = new SqlBaglanti();

        private void frmDepartmanEkle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'akbasHoldingTestDataSet6.tblDepartman' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblDepartmanTableAdapter.Fill(this.akbasHoldingTestDataSet6.tblDepartman);

        }

        private void btnDepartmanEkle_Click(object sender, EventArgs e)
        {
            Boolean depisimkontrol = true;
            SqlCommand komut1 = new SqlCommand("SELECT DepartmanAdı FROM tblDepartman", baglan.Baglanti());
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                if (dr[0].ToString() == txtDepartmanAdi.Text)
                    depisimkontrol = false;
            }
            baglan.Baglanti().Close();

            if(txtDepartmanAdi.Text!="")
            {
                if (depisimkontrol)
                {
                    int maxDepId = -1;
                    SqlCommand komut2 = new SqlCommand("SELECT MAX(DepartmanID) FROM tblDepartman", baglan.Baglanti());
                    SqlDataReader dr2 = komut2.ExecuteReader();
                    while(dr2.Read())
                         maxDepId = Convert.ToInt32(dr2[0]);
                    baglan.Baglanti().Close();

                    SqlCommand komut = new SqlCommand("INSERT tblDepartman VALUES (@p1,@p2)", baglan.Baglanti());
                    komut.Parameters.AddWithValue("@p1", maxDepId + 1);
                    komut.Parameters.AddWithValue("@p2", txtDepartmanAdi.Text);
                    komut.ExecuteNonQuery();
                    baglan.Baglanti().Close();
                    XtraMessageBox.Show("Departman eklendi !", "İşlem başarılı ", MessageBoxButtons.OK);
                    akbasHoldingTestDataSet6.Reset();
                    this.tblDepartmanTableAdapter.Fill(this.akbasHoldingTestDataSet6.tblDepartman);
                }
                else
                    XtraMessageBox.Show("Bu Departman Zaten Var !", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                XtraMessageBox.Show("Bir Departman Adı Giriniz", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txtDepartmanAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
    }
}
