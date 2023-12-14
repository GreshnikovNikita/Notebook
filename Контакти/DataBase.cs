using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseConnection
{
    internal class DataBase
    {
        SqlConnection connection = new SqlConnection(@"Data Source = DESKTOP-CGJHJQ9\SQLEXPRESS; Initial Catalog = Contacts; Integrated Security = True");

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }
    }
}
