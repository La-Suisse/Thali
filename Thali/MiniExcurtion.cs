using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thali
{
    class MiniExcurtion
    {
        private int numMiniEcurtion;
        private int nombrePlaces;
        private string libelleMiniExcurtion;
        private double prix;
        List<Etape> lesEtapes = new List<Etape>();

        public int NombrePlaces { get => nombrePlaces; set => nombrePlaces = value; }
        public string LibelleMiniExcurtion { get => libelleMiniExcurtion; set => libelleMiniExcurtion = value; }

        public MiniExcurtion(int numMiniEcurtion, string libelleMiniExcurtion, int nombrePlaces,double prix)
        {
            this.numMiniEcurtion = numMiniEcurtion;
            this.nombrePlaces = nombrePlaces;
            this.libelleMiniExcurtion = libelleMiniExcurtion;
            this.prix = prix;
        }
        public int donneDureePrevue()
        {
            int total = 0;
            foreach(Etape etape in lesEtapes)
            {
                total += etape.DureePrevue;
            }
            return total;
        }
        public bool ajouteEtape(int unNumEtape,string uneDescription,int uneDureePrevue)
        {
            foreach (Etape etape in lesEtapes)
            {
                if (etape.NumEtape == unNumEtape)
                {
                    return false;
                }
            }
            Etape newEtape = new Etape(unNumEtape, uneDescription, uneDureePrevue);
            return true;
        }
    }
}
