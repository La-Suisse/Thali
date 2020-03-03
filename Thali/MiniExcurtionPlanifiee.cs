using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thali
{
    class MiniExcurtionPlanifiee
    {
        private MiniExcurtion laMiniExcurtion;
        private string heureDepart;
        private int nombreInscrit;

        public MiniExcurtionPlanifiee(MiniExcurtion laMiniExcurtion, string heureDepart)
        {
            this.laMiniExcurtion = laMiniExcurtion;
            this.heureDepart = heureDepart;
        }
        public bool estComplete()
        {
            if (nombreInscrit == laMiniExcurtion.NombrePlaces) return true;
            return false;
        }
        public int ajouteInscrit(int nb)
        {
            if (estComplete())
            {
                return 0;
            }
            if (nombreInscrit + nb > laMiniExcurtion.NombrePlaces)
            {
                int val = nb - (nombreInscrit + nb - laMiniExcurtion.NombrePlaces);
                nombreInscrit = laMiniExcurtion.NombrePlaces;
                return val;
            }
            nombreInscrit += nb;
            return nb;
        }
        public int placeRestante()
        {
            return laMiniExcurtion.NombrePlaces - nombreInscrit;
        }
        public override string ToString()
        {
            return "excurtion: " + laMiniExcurtion.LibelleMiniExcurtion + "\n prevue a : " + heureDepart;
        }
    }
}
