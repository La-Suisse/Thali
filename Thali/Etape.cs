using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thali
{
    class Etape
    {
        private int numEtape;
        private string description;
        private int dureePrevue;

        public Etape(int numEtape, string description, int dureePrevue)
        {
            this.numEtape = numEtape;
            this.description = description;
            this.dureePrevue = dureePrevue;
        }

        public int NumEtape { get => numEtape; set => numEtape = value; }
        public string Description { get => description; set => description = value; }
        public int DureePrevue { get => dureePrevue; set => dureePrevue = value; }
    }
}
