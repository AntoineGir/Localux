using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localux
{
    class Vehicule
    {
        private string immatriculation;
        private DateTime dateAchat;
        private Modele leModele;
        private List<Location> listLocation;

        public Vehicule(string uneImmatriculation, DateTime uneDateAchat, Modele unModele)
        {
            this.immatriculation = uneImmatriculation;
            this.dateAchat = uneDateAchat;
            this.leModele = unModele;
            this.listLocation = new List<Location>();
        }

        public Modele GetLeModele()
        {
            return leModele;
        }

        public double GetTotalDepasForfait()
        {
            double compteur = 0;
            foreach (Location location in listLocation)
            {
                compteur = compteur + location.GetMontantRegle();
            }

            return compteur;
        }
    }
}
