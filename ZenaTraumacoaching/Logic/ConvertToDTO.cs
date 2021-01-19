using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenaTraumacoaching.DAL;
using ZenaTraumacoaching.DAL.Interfaces;
using ZenaTraumacoaching.DAL.DTO;

namespace Logic
{
    class ConvertToDTO
    {
        public UserDTO ConvertUserToDTO(User user)
        {
            UserDTO userDTO = new UserDTO(user.Username, user.Password, user.Firstname, user.Lastname, user.Emailadress, user.Gender);
            return userDTO;
        }

        public BlogDTO ConvertBlogToDTO(Blog blog)
        {
            BlogDTO blogDTO = new BlogDTO(blog.BlogID,blog.BlogTitel, blog.BlogTekst);
            return blogDTO;
        }

        public ReferentieDTO ConvertReferentieToDTO(Referentie referentie)
        {
            ReferentieDTO referentieDTO = new ReferentieDTO(referentie.ReferentieID,referentie.ReferentieCijfer, referentie.ReferentieTekst);
            return referentieDTO;
        }
    }
}
