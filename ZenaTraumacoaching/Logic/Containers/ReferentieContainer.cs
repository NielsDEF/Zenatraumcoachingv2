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
   public class ReferentieContainer
    {
        IReferentieContainer referentieDAL;

        public ReferentieContainer(IReferentieContainer DAL)
        {
            this.referentieDAL = DAL;
        }
        public List<Referentie> GetAllReferenties()
        {
            List<Referentie> referenties = new List<Referentie>();
            foreach (var referentie in referentieDAL.GetAllReferenties())
            {
                referenties.Add(new Referentie(referentie));
            }
            return referenties;
        }
        public void DeleteReferentieFromDatabase(int referentiepostid)
        {
            referentieDAL.DeleteReferentieFromDatabase(referentiepostid);
        }
        public Referentie GetReferentie(int referentiepostid)
        {
            return new Referentie(referentieDAL.GetReferentie(referentiepostid));
        }
    }
}
