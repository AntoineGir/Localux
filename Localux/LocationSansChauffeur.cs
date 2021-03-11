using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localux
{
    class LocationSansChauffeur : Location
    {

        private double nbKmDepart;
        private double nbKmRetour;

        private FormuleSansChauffeur laFormuleSansChauffeur;

        private FormuleSansChauffeur formuleSansChauffeur;

        public LocationSansChauffeur(int unNumLocation, DateTime uneDateLocation, double unMontantRegle, double unNbKmDepart, double unNbKmRetour, FormuleSansChauffeur uneFormuleSansChauffeur, Vehicule unVehicule) : base(unNumLocation, uneDateLocation, unMontantRegle, unVehicule)
        {
            this.nbKmDepart = unNbKmDepart;
            nbKmRetour = 0;
            this.laFormuleSansChauffeur = uneFormuleSansChauffeur;
        }

        public void setNbKmRetour(double unNbKmRetour)
        {
            this.nbKmRetour = unNbKmRetour;
        }

        public double GetMontantDepasForfait()
        {
            double nbkminclus = this.laFormuleSansChauffeur.GetNbKmInclus();

            double nbkmparcourue = this.nbKmRetour - this.nbKmDepart;
            double kmsuperieur = nbkmparcourue - nbkminclus;

            double tarif = 0;

            if (kmsuperieur > 0)
            {
                Vehicule unevehicule = this.GetLeVehicule();
                Modele unmodele = unevehicule.GetLeModele();
                tarif = unmodele.GetTarifKmSupplemenataire();
            }

            return kmsuperieur * tarif;
        }
    }
}
