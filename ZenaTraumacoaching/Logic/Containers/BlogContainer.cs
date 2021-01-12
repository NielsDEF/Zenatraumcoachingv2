using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenaTraumacoaching.DAL;
using ZenaTraumacoaching.DAL.DTO;
using ZenaTraumacoaching.DAL.Interfaces;

namespace Logic.Containers
{
    public class BlogContainer
    {
        IBlogContainer blogDAL;

        public BlogContainer(IBlogContainer DAL)
        {
            this.blogDAL = DAL;
        }
        public List<Blog> GetAllBlogposts()
        {
            List<Blog> blogs = new List<Blog>();
            foreach (var blog in blogDAL.GetAllBlogposts())
            {
                blogs.Add(new Blog(blog));
            }
            return blogs;
        }
    }
}
