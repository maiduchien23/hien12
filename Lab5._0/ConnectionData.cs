
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product
{
    public class ConnectionData
    {
        public SqlConnection SqlConnection { get; private set; }

        public SqlConnection GetConnection()
        {


            string connectionString = @"Data Source=LAPTOP-21F5N0OT\SQLEXPRESS;Initial Catalog=DbTest;Integrated Security=True";

            SqlConnection = new SqlConnection(connectionString);

            return SqlConnection;


        }

        internal SqlConnection GetDatabase()
        {
            throw new NotImplementedException();
        }
    }
}
