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
    public class BlogDAL : Connection, IBlogContainer, IBlog
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

        public void DeleteBlogFromDatabase(int id)
        {
            StartConnection();
            SqlCommand cmd = Conn.CreateCommand();
            cmd.CommandText = "DELETE FROM [BLOG] WHERE BlogID = @BlogID";
            cmd.Parameters.AddWithValue("@BlogID", id);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
    }
}
