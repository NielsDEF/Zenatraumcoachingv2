using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenaTraumacoaching.Models;
using Logic;

namespace ZenaTraumacoaching.Converters
{
    public class ConvertReferentieModel
    {
        public Referentie ConvertModelToReferentie(ReferentieViewModel model)
        {
            Referentie referentie = new Referentie(model.ReferentieID, model.ReferentieCijfer, model.ReferentieTekst);

            return referentie;
        }
    }
}
