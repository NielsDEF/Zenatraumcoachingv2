﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenaTraumacoaching.DAL.DTO;


namespace ZenaTraumacoaching.DAL.Interfaces
{
    public interface IBlogContainer
    {
        List<BlogDTO> GetAllBlogposts();
    }
}
