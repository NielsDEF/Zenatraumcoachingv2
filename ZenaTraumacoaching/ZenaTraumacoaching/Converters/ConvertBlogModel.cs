using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenaTraumacoaching.Models;
using Logic;

namespace ZenaTraumacoaching.Converters
{
    public class ConvertBlogModel
    {
        public Blog ConvertModelToBlogPost(BlogViewModel model)
        {
            Blog blog = new Blog(model.BlogTitel, model.BlogTekst);

            return blog;
        }
    }
}
