using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenaTraumacoaching.Models;
using Logic;

namespace ZenaTraumacoaching.Converters
{
    public class ReferentieToModel
    {
        public ReferentieViewModel ConvertReferentieToModel(Referentie referentie)
        {
            ReferentieViewModel referentieViewModel = new ReferentieViewModel();
            referentieViewModel.ReferentieID = referentie.ReferentieID;
            referentieViewModel.ReferentieCijfer = referentie.ReferentieCijfer;
            referentieViewModel.ReferentieTekst = referentie.ReferentieTekst;

            return referentieViewModel;
        }
    }
}
