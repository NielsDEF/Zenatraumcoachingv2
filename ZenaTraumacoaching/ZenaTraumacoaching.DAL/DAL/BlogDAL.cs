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
    public class BlogDAL : Connection, IBlogContainer
    {
        public BlogDAL()
        {
        
        }
        public void AddBlogToDatabase(BlogDTO blog)
        {
            StartConnection();
            try
            {
                SqlCommand cmd = Conn.CreateCommand();
                cmd.CommandText = "INSERT INTO [Blog](BlogTitel, BlogTekst) VALUES(@BlogTitel, @BlogTekst)";
                cmd.Parameters.AddWithValue("@BlogTitel", blog.BlogTitel);
                cmd.Parameters.AddWithValue("@BlogTekst", blog.BlogTekst);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                throw new Exception("De Post kan niet in de database gezet worden", ex);
            }
            CloseConnection();
        }

        public List<BlogDTO> GetAllBlogposts()
        {
            List<BlogDTO> blog = new List<BlogDTO>();
            SqlDataReader rdr;
            StartConnection();
            try
            {
                SqlCommand cmd = Conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Blog";
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    blog.Add(new BlogDTO(
                        (int)rdr["BlogID"],
                        (string)rdr["BlogTitel"],
                        (string)rdr["BlogTekst"]
                        )
                    );
                }
                rdr.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                throw new Exception("Er kan niks opgehaald worden", ex);
            }
            CloseConnection();
            return blog;
        }

        public void DeleteBlogFromDatabase(int blogpostid)
        {
            StartConnection();
            try
            {
                SqlCommand cmd = Conn.CreateCommand();
                cmd.CommandText = "DELETE FROM [BLOG] WHERE BlogID = @BlogID";
                cmd.Parameters.AddWithValue("@BlogID", blogpostid);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                throw new Exception("Er kan niks Verwijderd worden", ex);
            }
            CloseConnection();
        }
        public void BlogPostUpdate(BlogDTO blog)
        {
            StartConnection();
            try
            {
                SqlCommand cmd = Conn.CreateCommand();
                cmd.CommandText = "UPDATE [Blog] SET BlogTitel=@BlogTitel, BlogTekst=@BlogTekst WHERE BlogID = @BlogID";
                cmd.Parameters.AddWithValue("@BlogID", blog.BlogID);
                cmd.Parameters.AddWithValue("@BlogTitel", blog.BlogTitel);
                cmd.Parameters.AddWithValue("@BlogTekst", blog.BlogTekst);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                throw new Exception("De Post kan niet geupdate worden", ex);
            }
            CloseConnection();
        }
        public BlogDTO GetBlogPost(int blogpostid)
        {
            string blogtitel = null;
            string blogtekst = null;
            SqlDataReader rdr;
            StartConnection();
            try
            {
                SqlCommand cmd = Conn.CreateCommand();
                cmd.CommandText = "SELECT BlogTitel, BlogTekst FROM [Blog] WHERE BlogID = @BlogID";
                cmd.Parameters.AddWithValue("@BlogID", blogpostid);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    blogtitel = (string)rdr["BlogTitel"];
                    blogtekst = (string)rdr["BlogTekst"];
                }
                rdr.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                throw new Exception("Er is geen blogpost gevonden", ex);
            }
            CloseConnection();
            return new BlogDTO(blogpostid, blogtitel, blogtekst);
        }
    }
}
