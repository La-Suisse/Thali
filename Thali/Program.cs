using System;

namespace Thali
{
    class Program
    {
        static void Main(string[] args)
        {
            MiniExcurtion sables = new MiniExcurtion(1, "visite des Sables", 5,10);
            MiniExcurtion talmont = new MiniExcurtion(2, "autour de Takmont", 3,27); 
            sables.ajouteEtape(1, "balade sur le remblai", 60);
            sables.ajouteEtape(2, "quartier ile penotte", 30);
            sables.ajouteEtape(3, "traversee chenal", 15);
            sables.ajouteEtape(4, "quai de la chaume", 60);
            MiniExcurtionPlanifiee ExcurtionSables = new MiniExcurtionPlanifiee(sables, "14:00");
            MiniExcurtionPlanifiee ExcurtionTalmont = new MiniExcurtionPlanifiee(talmont, "14:30");
            PlanningJournee mars06 = new PlanningJournee("10/03/19");
            mars06.ajouteExcurtion(ExcurtionSables);
            mars06.ajouteExcurtion(ExcurtionTalmont);
            Console.WriteLine(mars06.ToString());
            Console.WriteLine(ExcurtionSables.ToString());
            Console.WriteLine("duree prévue de l'Excurtion : " + sables.donneDureePrevue() + "mn");
            Console.WriteLine("il y a " + ExcurtionSables.ajouteInscrit(2) + " inscrits pour l'Excurtion aux Sables");
            Console.WriteLine("Combien de nouvelles personnes à inscrire ?");
            int nb = int.Parse(Console.ReadLine());
            int nbInscrits = ExcurtionSables.ajouteInscrit(nb);
            if (nb == nbInscrits)
                Console.WriteLine("toutes les nouvelles personnes ont été inscrites");
            else
                Console.WriteLine("Seulement " + nbInscrits + " personnes ont été inscrites");
            Console.WriteLine("il reste " + ExcurtionSables.placeRestante() + " places disponibles");
            Console.ReadKey();
        }
    }
}
