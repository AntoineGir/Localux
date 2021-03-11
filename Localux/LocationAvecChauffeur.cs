using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localux
{
    class LocationAvecChauffeur : Location
    {

        private FormuleAvecChauffeur laFormuleAvecChauffeur;

        public LocationAvecChauffeur(int unNumLocation, DateTime uneDateLocation, double unMontantRegle, Vehicule unVehicule, FormuleAvecChauffeur uneFormuleAvecChauffeur) : base(unNumLocation, uneDateLocation, unMontantRegle, unVehicule)
        {
            this.laFormuleAvecChauffeur = uneFormuleAvecChauffeur;
        }




    }
}
