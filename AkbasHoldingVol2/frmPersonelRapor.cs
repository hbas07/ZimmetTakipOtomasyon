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
    public partial class frmPersonelRapor : Form
    {
        public frmPersonelRapor()
        {
            InitializeComponent();
        }
        public int personelID { get; set; }
        private void frmPersonelRapor_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'AkbasHoldingTestDataSet5.vw_ZimmetBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.vw_ZimmetBilgiTableAdapter.Fill(this.AkbasHoldingTestDataSet6.vw_ZimmetBilgi,personelID);
            this.reportViewer1.RefreshReport();
        }
    }
}
