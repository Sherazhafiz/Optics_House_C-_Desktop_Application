using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optics_1._0
{
    internal class Connectivity
    {
        public static SqlConnection Connection()
        {
            string connectionString = "Data Source=DESKTOP-MP3S7K5\\SQLEXPRESS;Initial Catalog=Optics_DB;Integrated Security=True";
            SqlConnection Connection1 = new SqlConnection(connectionString);
            try
            {
                Connection1.Open();
                MessageBox.Show("CONNECTED TO Database");
            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
            return Connection1;
        }
    }
}
