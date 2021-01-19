using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenaTraumacoaching.DAL.Interfaces;
using ZenaTraumacoaching.DAL.DTO;

namespace Logic
{
   public class Referentie
    {
        private int referentieid;
        public int ReferentieID { get => referentieid; }

        private int referentiecijfer;
        public int ReferentieCijfer { get => referentiecijfer; }

        private string referentietekst;
        public string ReferentieTekst { get => referentietekst; }

        public Referentie(int referentieid, int referentiecijfer, string referentietekst)
        {
            this.referentieid = referentieid;
            this.referentiecijfer = referentiecijfer;
            this.referentietekst = referentietekst;
        }

        public Referentie(ReferentieDTO referentie)
        {
            this.referentieid = referentie.ReferentieID;
            this.referentiecijfer = referentie.ReferentieCijfer;
            this.referentietekst = referentie.ReferentieTekst;
        }

        public void AddReferentieToDatabase(IReferentieContainer ReferentieDAL)
        {
            ConvertToDTO converter = new ConvertToDTO();
            ReferentieDAL.AddReferentieToDatabase(converter.ConvertReferentieToDTO(this));
        }

        public void ReferentieUpdate(IReferentieContainer ReferentieDAL)
        {
            ConvertToDTO converter = new ConvertToDTO();
            ReferentieDAL.ReferentieUpdate(converter.ConvertReferentieToDTO(this));
        }
    }
}
