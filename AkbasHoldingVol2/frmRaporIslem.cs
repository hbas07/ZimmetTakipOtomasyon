using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace AkbasHoldingVol2
{
    public partial class frmRaporIslem : Form
    {
        public frmRaporIslem()
        {
            InitializeComponent();
        }

        private void btnRaporAl_Click(object sender, EventArgs e)
        {
            if(Login.yetki==2)
            {
                this.vw_RaporIslemTableAdapter.Fill(this.AkbasHoldingTestDataSet6.vw_RaporIslem, Login.depID, Login.depID,
                    Login.depID, Login.depID, Login.depID, Login.depID);
                this.reportViewer1.RefreshReport();
            }
            else
            {
                this.vw_RaporIslemTableAdapter.Fill(this.AkbasHoldingTestDataSet6.vw_RaporIslem,1,2,3,4,5,6);
                this.reportViewer1.RefreshReport();
            }
        }

        private void frmRaporIslem_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'AkbasHoldingTestDataSet6.tblDepartman' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblDepartmanTableAdapter.Fill(this.AkbasHoldingTestDataSet6.tblDepartman);
            if (Login.yetki == 0)
            {
                lueBolum.Enabled = true;
                btnBolumRapor.Enabled = true;
                lueBolum.ItemIndex = -1;
                lueBolum.Properties.NullText = " ";
            }
        }

        private void btnBolumRapor_Click(object sender, EventArgs e)
        {   
            int depID = -1;
            if (Login.yetki == 0)
            {
                if ( lueBolum.ItemIndex!=(-1) )
                {
                    depID = Convert.ToInt32(lueBolum.EditValue.ToString());
                    this.vw_RaporIslemTableAdapter.Fill(this.AkbasHoldingTestDataSet6.vw_RaporIslem, depID, depID, depID, depID, depID, depID);
                    this.reportViewer1.RefreshReport();
                    if(AkbasHoldingTestDataSet6.vw_RaporIslem.Rows.Count==0)
                        XtraMessageBox.Show("Bu Departmana Ait Zimmet Bulunamadı", "İşlem başarısız ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    XtraMessageBox.Show("Departman Seçiniz", "İşlem başarısız ", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
