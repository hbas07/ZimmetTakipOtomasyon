using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AkbasHoldingVol2
{
    class SqlBaglanti
    {
        public SqlConnection Baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-2RPJPRH;Initial Catalog=AkbasHoldingTest;Integrated Security=True");
            baglan.Open();

            return baglan;
        }
    }
}
