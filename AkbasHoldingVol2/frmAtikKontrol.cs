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
    public partial class frmAtikKontrol : Form
    {
        public frmAtikKontrol()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-2RPJPRH;Initial Catalog=AkbasHoldingTest;Integrated Security=True");
        private void frmAtikKontrol_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'akbasHoldingTestDataSet4.sp_AtikKontrolBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sp_AtikKontrolBilgiTableAdapter.Fill(this.akbasHoldingTestDataSet6.sp_AtikKontrolBilgi);
            // TODO: Bu kod satırı 'akbasHoldingTestDataSet4.sp_ZimmetBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sp_ZimmetBilgiTableAdapter.Fill(this.akbasHoldingTestDataSet6.sp_ZimmetBilgi);

        }
        int zimmetID = -1;
        
        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                zimmetID = Convert.ToInt32(dr[0]);
            }
        }

        private void btnZimmetSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("INSERT tblAtikKontrol VALUES (@p1,0)", baglanti);
                komut.Parameters.AddWithValue("@p1", zimmetID);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();

                SqlCommand komut2 = new SqlCommand("UPDATE tblZimmet SET ZimmetAktifligi=0 WHERE ZimmetID=@p2", baglanti);
                komut2.Parameters.AddWithValue("@p2", zimmetID);
                baglanti.Open();
                komut2.ExecuteNonQuery();
                baglanti.Close();

            }
            catch (Exception)
            {
                XtraMessageBox.Show("Zimmet silme başarısız.Bu kaydın zimmeti zaten düşürülmüş !", "Hata Oluştu", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

          this.akbasHoldingTestDataSet6.Reset();
           this.sp_AtikKontrolBilgiTableAdapter.Fill(this.akbasHoldingTestDataSet6.sp_AtikKontrolBilgi);
           this.sp_ZimmetBilgiTableAdapter.Fill(this.akbasHoldingTestDataSet6.sp_ZimmetBilgi);
        }

    }
}
