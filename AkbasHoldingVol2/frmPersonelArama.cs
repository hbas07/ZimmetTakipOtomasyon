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
            lstZimmetEsya.Items.Clear();
            Boolean personelKontrol = false;
            string temp = txtPersonelAd.Text;
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT p.PersonelID,p.Ad,p.Soyad,d.DepartmanAdı,d.DepartmanID " +
                     "FROM tblPersonel p INNER JOIN tblDepartman d ON (p.DepartmanID = d.DepartmanID)" +
                     "WHERE p.Ad=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", temp);
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
                        MessageBox.Show("Sadece Kendi Departmanınızı Görüntüleyebilirsiniz.");
                    }
                }
                if (personelKontrol == false)
                    MessageBox.Show("Personel Bulunamadı", "Hata");
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("SELECT s.Urun,f.Firma,d.DepartmanID " +
                       " FROM tblZimmet z INNER JOIN tblStok s ON (z.UrunID = s.UrunID AND z.FirmaID = s.FirmaID) " +
                       " INNER JOIN tblPersonel p ON (z.PersonelID = p.PersonelID) " +
                       " INNER JOIN tblFirma f ON (s.FirmaID = f.FirmaID) " +
                       " INNER JOIN tblDepartman d ON (d.DepartmanID = p.DepartmanID)" +
                       "WHERE Ad=@p1 ", baglanti);
                komut2.Parameters.AddWithValue("@p1", temp);
                SqlDataReader dr2 = komut2.ExecuteReader();
                while (dr2.Read())
                {
                    if (dr2[2].ToString() == Login.depID.ToString() || Login.yetki == 0 || Login.yetki == 1)
                        lstZimmetEsya.Items.Add(dr2[1] + "  " + dr2[0]);
                }
                baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("HATA" + hata.ToString());
                throw;
            }
        }
    }
}
