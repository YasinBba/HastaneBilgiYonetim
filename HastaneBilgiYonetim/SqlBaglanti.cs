using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HastaneBilgiYonetim
{
    public class SqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-29IUMJH\\MSSQL_SERVER;Initial Catalog=HastaneYonetimPaneliDB;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
