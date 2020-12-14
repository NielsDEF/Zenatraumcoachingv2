using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ZenaTraumacoaching.DAL
{
    public abstract class Connection
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
        public int ExecuteNonQuery(string query, List<SqlParameter> parameters = null)
        {
            try
            {
                using (var cmd = Conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    if (parameters != null)
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.Add(param);
                        }

                    //StartConnection();

                    return Convert.ToInt32(cmd.ExecuteNonQuery());
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public DataTable ExecuteSqlReader(string query, List<SqlParameter> parameters = null)
        {

            DataTable dataTable = new DataTable();
            using (var conn = Conn)

                try
                {
                    using (var cmd = Conn.CreateCommand())
                    {
                        cmd.CommandText = query;
                        if (parameters != null)
                        {
                            foreach (var param in parameters)
                            {
                                cmd.Parameters.Add(param);
                            }
                        }
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dataTable);
                        conn.Close();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            return dataTable;
        }
    }
}
