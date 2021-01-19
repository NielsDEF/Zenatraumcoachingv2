using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenaTraumacoaching.DAL.DTO;

namespace ZenaTraumacoaching.DAL.Interfaces
{
    public interface IReferentieContainer
    {
        List<ReferentieDTO> GetAllReferenties();
        void AddReferentieToDatabase(ReferentieDTO referentie);
        void DeleteReferentieFromDatabase(int referentiepostid);
        void ReferentieUpdate(ReferentieDTO referentie);
        ReferentieDTO GetReferentie(int referentiepostid);
    }
}
