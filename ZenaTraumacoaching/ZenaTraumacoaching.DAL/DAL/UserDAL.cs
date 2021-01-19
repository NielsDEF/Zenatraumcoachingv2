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
    public class UserDAL : Connection, IUserContainer
    {

        public UserDAL()
        {

        }

        public string RequestPassword(string username)
        {
            string output = null;
            SqlDataReader rdr;
            StartConnection();
            SqlCommand cmd = Conn.CreateCommand();
            cmd.CommandText = "SELECT Password FROM [User] WHERE Username = '" + username + "'";
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                output = rdr["Password"].ToString();
            }
            rdr.Close();
            cmd.Dispose();
            CloseConnection();
            return output;
        }

        public void AddUserToDatabase(UserDTO user)
        {
            StartConnection();
            SqlCommand cmd = Conn.CreateCommand();
            cmd.CommandText = "INSERT INTO [User](Username, Password, FirstName, LastName ,Email ,Gender) VALUES(@Username, @Password, @FirstName, @LastName, @Email, @Gender)";
            cmd.Parameters.AddWithValue("@Username", user.Username);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            cmd.Parameters.AddWithValue("@FirstName", user.Firstname);
            cmd.Parameters.AddWithValue("@LastName", user.Lastname);
            cmd.Parameters.AddWithValue("@Email", user.Emailadress);
            cmd.Parameters.AddWithValue("@Gender", user.Gender);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }

        public UserDTO PullUserFromDatabase(int userid)
        {
            var result = ExecuteSqlReader("SELECT Firstname, LastName, Email, Gender FROM [User] WHERE UserID = @ID", new List<SqlParameter>()
            {
                new SqlParameter("@ID", userid),
            });
            UserDTO user = DataTableToUser(result, 0);
            return user;
        }

        private UserDTO DataTableToUser(DataTable result, int rowIndex)
        {
            return new UserDTO(result.Rows[rowIndex]["firstname"].ToString(), result.Rows[rowIndex]["lastname"].ToString(), result.Rows[rowIndex]["email"].ToString(), result.Rows[rowIndex]["gender"].ToString());
        }
        public int GetUserID(string username)
        {
            int output = 0;
            SqlDataReader rdr;
            StartConnection();
            SqlCommand cmd = Conn.CreateCommand();
            cmd.CommandText = "SELECT UserID FROM [User] WHERE Username = '" + username + "'";
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                output = Convert.ToInt32(rdr["UserID"]);
            }
            rdr.Close();
            cmd.Dispose();
            CloseConnection();
            return output;
        }
    }
}








