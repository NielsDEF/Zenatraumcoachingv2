using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ZenaTraumacoaching.DAL
{
    public class Connection
    {
        string connectionstring = "Server=mssql.fhict.local;Database=dbi448154;Uid=dbi448154;Pwd=Niels2001";
        SqlConnection conn = null;
        public SqlConnection Conn { get => conn; }

        public Connection()
        {
            StartConnection();
        }
        public void StartConnection()
        {
            try
            {
                conn = new SqlConnection(connectionstring);

                conn.Open();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
        }
        public void CloseConnection()
        {
            if (conn != null)
            {
                conn.Dispose();
                conn.Close();
            }
        }
    }
}
