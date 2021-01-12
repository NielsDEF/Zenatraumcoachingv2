using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenaTraumacoaching.Models;
using Logic;

namespace ZenaTraumacoaching.Converters
{
    public class BlogToModel
    {
        public BlogViewModel ConvertBlogToModel(Blog blog)
        {
            BlogViewModel blogViewModel = new BlogViewModel();
            blogViewModel.BlogID = blog.BlogID;
            blogViewModel.BlogTitel = blog.BlogTitel;
            blogViewModel.BlogTekst = blog.BlogTekst;

            return blogViewModel;
        }
    }
}
