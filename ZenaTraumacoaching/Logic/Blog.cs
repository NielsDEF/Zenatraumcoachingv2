using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenaTraumacoaching.DAL.Interfaces;
using ZenaTraumacoaching.DAL.DTO;

namespace Logic
{
   public class Blog
    {
        private string blogtitel;
        public string BlogTitel { get => blogtitel; }

        private string blogtekst;
        public string BlogTekst { get => blogtekst; }

        public Blog(string blogtitel, string blogtekst)
        {
            this.blogtitel = blogtitel;
            this.blogtekst = blogtekst;
        }

        public Blog(BlogDTO blog)
        {
            this.blogtitel = blog.BlogTitel;
            this.blogtekst = blog.BlogTekst;
        }

        public void AddBlogToDatabase(IBlog BlogDAL)
        {
            ConvertToDTO converter = new ConvertToDTO();
            BlogDAL.AddBlogToDatabase(converter.ConvertBlogToDTO(this));
        }

        //public void GetAllBlogposts(IBlogContainer BlogDAL)
        //{
        //    ConvertToDTO converter = new ConvertToDTO();
        //    BlogDAL.GetAllBlogposts(converter.ConvertBlogToDTO(this));
        //}
    }
}
