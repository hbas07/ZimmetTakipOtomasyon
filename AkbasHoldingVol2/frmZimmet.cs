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
    public partial class frmZimmet : Form
    {
        public frmZimmet()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-2RPJPRH;Initial Catalog=AkbasHoldingTest;Integrated Security=True");

        private void frmZimmet_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'akbasHoldingTestDataSet.sp_StokBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sp_StokBilgiTableAdapter.Fill(this.akbasHoldingTestDataSet.sp_StokBilgi);
            // TODO: Bu kod satırı 'akbasHoldingTestDataSet.tblPersonel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblPersonelTableAdapter.Fill(this.akbasHoldingTestDataSet.tblPersonel);
         /*   string p1, p2, p3, p4;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM tblPersonel",baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                p1 = dr[0].ToString();
                p2 = dr[1].ToString();
                p3 = dr[2].ToString();
                p4 = dr[3].ToString();
                listBoxControl1.Items.Add(p1 +" " + p2 +" "+ p3 +" "+ p4);
            }
            baglanti.Close();*/

        }

        private void luePersonelBilgi_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void listBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
