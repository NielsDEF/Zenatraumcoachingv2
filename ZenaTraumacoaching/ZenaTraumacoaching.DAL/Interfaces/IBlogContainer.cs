using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenaTraumacoaching.DAL.DTO;


namespace ZenaTraumacoaching.DAL.Interfaces
{
    public interface IBlogContainer
    {
        void AddBlogToDatabase(BlogDTO blog);
        List<BlogDTO> GetAllBlogposts();
        void DeleteBlogFromDatabase(int blogpostid);
        void BlogPostUpdate(BlogDTO blog);
        BlogDTO GetBlogPost(int blogpostid);
    }
}
