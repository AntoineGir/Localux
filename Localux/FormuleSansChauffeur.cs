using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localux
{
    class FormuleSansChauffeur : Formule
    {

        private int duree;
        private double nbKmInclus;

        private FormuleSansChauffeur(int unId, string unLibelle, int uneDuree, double unNbKmInclus) : base(unId, unLibelle)
        {
            this.duree = uneDuree;
            this.nbKmInclus = unNbKmInclus;
        }

        public double GetNbKmInclus()
        {
            return nbKmInclus;
        }

        public int GetDuree()
        {
            return duree;
        }
    }
}
