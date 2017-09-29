using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Photogram.Models.SqlViewModels
{
    public class Sql
    {
        SqlConnection photgramDbConnection = new SqlConnection();

        public Sql()
        {
            photgramDbConnection.ConnectionString=
                "Data Source = photogramdb.database.windows.net;" +
                " Initial Catalog = master;" +
                " Integrated Security = False; User ID = pgadmin;" +
                " Password = ********;" +
                " Connect Timeout = 60;" +
                " Encrypt = True; " +
                "TrustServerCertificate = False;" +
                " ApplicationIntent = ReadWrite;" +
                " MultiSubnetFailover = False";
            photgramDbConnection.Open();
        }

        public void InsertPicturePathToDatabase(string photoName)
        {
            string generatedName = Guid.NewGuid().ToString();
            
        }
    }
}
