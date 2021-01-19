using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenaTraumacoaching.DAL.Interfaces;
using ZenaTraumacoaching.DAL.DTO;
using ZenaTraumacoaching.DAL.DAL;

namespace Logic
{
   public class Blog
    {
        private int blogid;
        public int BlogID { get => blogid; }

        private string blogtitel;
        public string BlogTitel { get => blogtitel; }

        private string blogtekst;
        public string BlogTekst { get => blogtekst; }

        public Blog(int blogid, string blogtitel, string blogtekst)
        {
            this.blogid = blogid;
            this.blogtitel = blogtitel;
            this.blogtekst = blogtekst;
        }

        public Blog(BlogDTO blog)
        {
            this.blogid = blog.BlogID;
            this.blogtitel = blog.BlogTitel;
            this.blogtekst = blog.BlogTekst;
        }

        public void AddBlogToDatabase(IBlogContainer BlogDAL)
        {
            ConvertToDTO converter = new ConvertToDTO();
            BlogDAL.AddBlogToDatabase(converter.ConvertBlogToDTO(this));
        }
        public void BlogPostUpdate(IBlogContainer BlogDAL)
        {
            ConvertToDTO converter = new ConvertToDTO();
            BlogDAL.BlogPostUpdate(converter.ConvertBlogToDTO(this));
        }
    }
}
