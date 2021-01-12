using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenaTraumacoaching.DAL.DTO
{
   public class BlogDTO
    {
        private int blogid;
        public int BlogID
        {
            get { return blogid; }
        }

        private string blogtitel;

        public string BlogTitel
        {
            get { return blogtitel; }
        }
        private string blogtekst;

        public string BlogTekst
        {
            get { return blogtekst; }
        }

        public BlogDTO(string blogtitel, string blogtekst)
        {
            this.blogtitel = blogtitel;
            this.blogtekst = blogtekst;
        }

        public BlogDTO(int blogid, string blogtitel, string blogtekst)
        {
            this.blogid = blogid;
            this.blogtitel = blogtitel;
            this.blogtekst = blogtekst;
        }
    }
}
