using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ZenaTraumacoaching.DAL.Interfaces;
using ZenaTraumacoaching.DAL.DTO;
using System.Data;

namespace ZenaTraumacoaching.DAL.DAL
{
    class UserDAL : IUserContainer
    {
        Connection connection;
        public UserDAL()
        {
            connection = new Connection();
        }

        public string RequestPassword(string username)
        {
            string output = null;
            SqlDataReader rdr;
            connection.StartConnection();
            SqlCommand cmd = connection.Conn.CreateCommand();
            cmd.CommandText = "SELECT Password FROM User WHERE Username = '" + username + "'";
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                output = rdr["Password"].ToString();
            }
            rdr.Close();
            cmd.Dispose();
            connection.CloseConnection();
            return output;
        }

        public void AddUserToDatabase(UserDTO user)
        {
            connection.StartConnection();
            SqlCommand cmd = connection.Conn.CreateCommand();
            cmd.CommandText = "INSERT INTO User(Username, Password, FirstName, LastName ,Email,Gender,UserType) VALUES(?Username, ?Password, ?FirstName, ?LastName, ?Email, ?Gender, ?UserType )";
            cmd.Parameters.AddWithValue("?Username", user.Username);
            cmd.Parameters.AddWithValue("?Password", user.Password);
            cmd.Parameters.AddWithValue("?FirstName", user.Firstname);
            cmd.Parameters.AddWithValue("?LastName", user.Lastname);
            cmd.Parameters.AddWithValue("?Email", user.Emailadress);
            cmd.Parameters.AddWithValue("?Gender", user.Gender);
            cmd.Parameters.AddWithValue("?UserType", user.Usertype);
            cmd.ExecuteNonQuery();
            connection.CloseConnection();
        }

        public UserDTO PullUserFromDatabase(int userid)
        {
            var result = ExecuteSqlReader("SELECT Firstname, LastName, Gender, Email, Usertype FROM User WHERE UserID = @ID", new List<SqlParameter>()
            {
                new SqlParameter("@ID", userid),

            });
            UserDTO user = DataTableToUser(result, 0);

            return user;
        }

        private UserDTO DataTableToUser(DataTable result, int rowIndex)
        {
            return new UserDTO(result.Rows[rowIndex]["firstname"].ToString(), result.Rows[rowIndex]["lastname"].ToString(), result.Rows[rowIndex]["gender"].ToString(), result.Rows[rowIndex]["email"].ToString(), result.Rows[rowIndex]["Usertype"].ToString());
        }


        public int ExecuteNonQuery(string query, List<SqlParameter> parameters = null)
        {
            try
            {
                using (var cmd = connection.Conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    if (parameters != null)
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.Add(param);
                        }

                    //connection.StartConnection();

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
            using (var conn = connection.Conn)

                try
                {
                    using (var cmd = connection.Conn.CreateCommand())
                    {
                        cmd.CommandText = query;
                        if (parameters != null)
                        {
                            foreach (var param in parameters)
                            {
                                cmd.Parameters.Add(param);
                            }
                        }

                        //conn.Open();

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dataTable);
                        conn.Close();

                        //using (var reader = cmd.ExecuteReader())
                        //{
                        //    dataTable.Load(reader);
                        //}
                        //connection.CloseConnection();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            return dataTable;
        }
        public int GetUserID(string username)
        {
            int output = 0;
            SqlDataReader rdr;
            connection.StartConnection();
            SqlCommand cmd = connection.Conn.CreateCommand();
            cmd.CommandText = "SELECT UserID FROM User WHERE Username = '" + username + "'";
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                output = Convert.ToInt32(rdr["UserID"]);
            }
            rdr.Close();
            cmd.Dispose();
            connection.CloseConnection();
            return output;
        }
        public string GetUserType(string username)
        {
            string output = null;
            SqlDataReader rdr;
            connection.StartConnection();
            SqlCommand cmd = connection.Conn.CreateCommand();
            cmd.CommandText = "SELECT UserID FROM User WHERE Username = '" + username + "'";
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                output = rdr["UserID"].ToString();
            }
            rdr.Close();
            cmd.Dispose();
            connection.CloseConnection();
            return output;

        }
    }
}








