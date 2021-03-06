﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenaTraumacoaching.DAL.DTO
{
   public class ReferentieDTO
    {
        private int referentieid;
        public int ReferentieID
        {
            get { return referentieid; }
        }

        private int referentiecijfer;

        public int ReferentieCijfer
        {
            get { return referentiecijfer; }
        }
        private string referentietekst;

        public string ReferentieTekst
        {
            get { return referentietekst; }
        }

        public ReferentieDTO(int referentiecijfer, string referentietekst)
        {
            this.referentiecijfer = referentiecijfer;
            this.referentietekst = referentietekst;
        }

        public ReferentieDTO(int referentieid, int referentiecijfer, string referentietekst)
        {
            this.referentieid = referentieid;
            this.referentiecijfer = referentiecijfer;
            this.referentietekst = referentietekst;
        }
    }
}
