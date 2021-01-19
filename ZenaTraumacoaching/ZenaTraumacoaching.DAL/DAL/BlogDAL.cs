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
            SqlCommand cmd = Conn.CreateCommand();
            cmd.CommandText = "INSERT INTO [Blog](BlogTitel, BlogTekst) VALUES(@BlogTitel, @BlogTekst)";
            cmd.Parameters.AddWithValue("@BlogTitel", blog.BlogTitel);
            cmd.Parameters.AddWithValue("@BlogTekst", blog.BlogTekst);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }

        public List<BlogDTO> GetAllBlogposts()
        {
            List<BlogDTO> blog = new List<BlogDTO>();
            SqlDataReader rdr;
            StartConnection();
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
            CloseConnection();
            return blog;
        }

        public void DeleteBlogFromDatabase(int blogpostid)
        {
            StartConnection();
            SqlCommand cmd = Conn.CreateCommand();
            cmd.CommandText = "DELETE FROM [BLOG] WHERE BlogID = @BlogID";
            cmd.Parameters.AddWithValue("@BlogID", blogpostid);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void BlogPostUpdate(BlogDTO blog)
        {
            StartConnection();
            SqlCommand cmd = Conn.CreateCommand();
            cmd.CommandText = "UPDATE [Blog] SET BlogTitel=@BlogTitel, BlogTekst=@BlogTekst WHERE BlogID = @BlogID";
            cmd.Parameters.AddWithValue("@BlogID", blog.BlogID);
            cmd.Parameters.AddWithValue("@BlogTitel", blog.BlogTitel);
            cmd.Parameters.AddWithValue("@BlogTekst", blog.BlogTekst);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public BlogDTO GetBlogPost(int blogpostid)
        {
            string blogtitel = null;
            string blogtekst = null;
            SqlDataReader rdr;
            StartConnection();
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
            CloseConnection();
            return new BlogDTO(blogpostid, blogtitel, blogtekst);
        }
    }
}
