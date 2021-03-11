using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localux
{
    class FormuleAvecChauffeur : Formule
    {

        private string lieu;
        private double tarif;


        public FormuleAvecChauffeur(int unId, string unLibelle, string unLieu, double unTarif) : base(unId, unLibelle)
        {
            this.lieu = unLieu;
            this.tarif = unTarif;
        }


        public string GetLieu()
        {
            return lieu;
        }

        public double GetTarif()
        {
            return tarif;
        }

    }
}
