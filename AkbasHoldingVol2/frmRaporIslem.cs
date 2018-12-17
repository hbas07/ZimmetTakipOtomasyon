using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
