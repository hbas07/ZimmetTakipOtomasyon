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

        SqlBaglanti baglan = new SqlBaglanti();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Boolean isimkontrol = true;
            SqlCommand komut1 = new SqlCommand("SELECT KullaniciAdi FROM tblKullanici", baglan.Baglanti());
            SqlDataReader dr = komut1.ExecuteReader();
            while(dr.Read())
            {
                if (dr[0].ToString() == txtKullaniciAdi.Text)
                    isimkontrol = false;
            }
            baglan.Baglanti().Close();
            if (cmbYetki.SelectedIndex!=-1 && cmbDepartman.SelectedIndex!=-1 && txtKullaniciAdi.Text!="" && txtSifre.Text!="")
            { 
                if(isimkontrol)
                {
                    int yetkiID = cmbYetki.SelectedIndex ;
                    int departmanID = cmbDepartman.SelectedIndex + 1;
                    SqlCommand komut = new SqlCommand("INSERT tblKullanici VALUES (@p1,@p2,@p3,@p4)", baglan.Baglanti());
                    komut.Parameters.AddWithValue("@p1",txtKullaniciAdi.Text);
                    komut.Parameters.AddWithValue("@p2",Convert.ToInt32(txtSifre.Text));
                    komut.Parameters.AddWithValue("@p3",yetkiID);
                    komut.Parameters.AddWithValue("@p4",departmanID);
                    komut.ExecuteNonQuery();
                    baglan.Baglanti().Close();
                    XtraMessageBox.Show("Kullanıcı eklendi !", "İşlem başarılı ", MessageBoxButtons.OK);
                }
                else
                    XtraMessageBox.Show("Bu Kullanıcı Adı Kullanılmakta !", "İşlem başarısız ", MessageBoxButtons.OK);
            }
            else
                XtraMessageBox.Show("Kullanıcı ekleme başarısız.Tüm alanları doldurmanız gerekmektedir !", "İşlem başarısız ", MessageBoxButtons.OK);
        }
        
        private void txtKullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void frmKullaniciEkle_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT departmanAdI FROM tblDepartman", baglan.Baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                cmbDepartman.Items.Add(dr[0]);
            }
            baglan.Baglanti().Close();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
            cmbDepartman.SelectedIndex = -1;
            cmbYetki.SelectedIndex = -1;
        }
    }
}
