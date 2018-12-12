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
    public partial class frmKullaniciEkle : Form
    {
        public frmKullaniciEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-2RPJPRH;Initial Catalog=AkbasHoldingTest;Integrated Security=True");

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int yetkiID = cmbYetki.SelectedIndex ;
            int departmanID = cmbDepartman.SelectedIndex+1;
            SqlCommand komut = new SqlCommand("INSERT tblKullanici VALUES (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1",txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2",Convert.ToInt32(txtSifre.Text));
            komut.Parameters.AddWithValue("@p3",yetkiID);
            komut.Parameters.AddWithValue("@p4",departmanID);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            XtraMessageBox.Show("Kullanıcı eklendi !", "İşlem başarılı ", MessageBoxButtons.OK);

        }
    }
}
