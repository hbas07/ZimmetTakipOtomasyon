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
    public partial class frmPersonelArama : Form
    {
        public frmPersonelArama()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-2RPJPRH;Initial Catalog=AkbasHoldingTest;Integrated Security=True");

        private void btnArama_Click(object sender, EventArgs e)
        {   
            //AYNI İSİMDEKİ KAYITLAR İÇİN KOD YAZILACAK
            lstZimmetEsya.Items.Clear();
            Boolean personelKontrol = false;
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT p.PersonelID,p.Ad,p.Soyad,d.DepartmanAdı,d.DepartmanID " +
                     "FROM tblPersonel p INNER JOIN tblDepartman d ON (p.DepartmanID = d.DepartmanID)" +
                     "WHERE p.Ad=@p1 AND p.Soyad=@p2", baglanti);
                komut.Parameters.AddWithValue("@p1", txtPersonelAd.Text);
                komut.Parameters.AddWithValue("@p2", txtPersonelSoyad.Text);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {   
                    if(dr[4].ToString()==Login.depID.ToString() || Login.yetki==0 || Login.yetki==1)
                    {
                        txtPersonelID.Text = dr[0].ToString();
                        txtAd.Text = dr[1].ToString();
                        txtSoyad.Text = dr[2].ToString();
                        txtDepartman.Text = dr[3].ToString();
                        personelKontrol = true;
                    }
                    else
                    {
                        personelKontrol = true;
                        XtraMessageBox.Show("Sadece Kendi Departmanınızı Görüntüleyebilirsiniz !","Hata", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                if (personelKontrol == false)
                {
                    XtraMessageBox.Show("Personel Bulunamadı !", "Hata", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    btnPersonelRapor.Enabled = false;
                }
                else
                    btnPersonelRapor.Enabled = true;
                baglanti.Close();

                //PERSONELİN ZİMMETLİ EŞYALARINI LİSTELEME
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("SELECT s.Urun,f.Firma,d.DepartmanID " +
                       " FROM tblZimmet z INNER JOIN tblStok s ON (z.UrunID = s.UrunID AND z.FirmaID = s.FirmaID) " +
                       " INNER JOIN tblPersonel p ON (z.PersonelID = p.PersonelID) " +
                       " INNER JOIN tblFirma f ON (s.FirmaID = f.FirmaID) " +
                       " INNER JOIN tblDepartman d ON (d.DepartmanID = p.DepartmanID)" +
                       "WHERE Ad=@p1 AND Soyad=@p2", baglanti);
                komut2.Parameters.AddWithValue("@p1", txtPersonelAd.Text);
                komut2.Parameters.AddWithValue("@p2", txtPersonelSoyad.Text);
                SqlDataReader dr2 = komut2.ExecuteReader();
                while (dr2.Read())
                {
                    if (dr2[2].ToString() == Login.depID.ToString() || Login.yetki == 0 || Login.yetki == 1)
                    {
                        lstZimmetEsya.Items.Add(dr2[1] + "\t \t" + dr2[0]);
                    }
                }
                baglanti.Close();
            }
            catch (Exception hata)
            {
                XtraMessageBox.Show("HATA", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnPersonelRapor_Click(object sender, EventArgs e)
        {
            frmPersonelRapor frmPersonelRapor = new frmPersonelRapor();
            frmPersonelRapor.personelID =Convert.ToInt32(txtPersonelID.Text);
            frmPersonelRapor.Show();
        }

        private void frmPersonelArama_Load(object sender, EventArgs e)
        {
            btnPersonelRapor.Enabled = false;
        }
    }
}
