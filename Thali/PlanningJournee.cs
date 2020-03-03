using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thali
{
    class PlanningJournee
    {
        private string laDate;
        private List<MiniExcurtionPlanifiee> lesMiniExcurtionPlanifiee = new List<MiniExcurtionPlanifiee>();

        public PlanningJournee(string laDate)
        {
            this.laDate = laDate;
        }
        public void ajouteExcurtion(MiniExcurtionPlanifiee uneMiniExcurtionPlanifiee)
        {
            lesMiniExcurtionPlanifiee.Add(uneMiniExcurtionPlanifiee);
        }
        public override string ToString()
        {
            return  "Planning du " + laDate;
        }
    }
}
