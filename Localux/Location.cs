using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localux
{
    class Location
    {
        private int numLocation;
        private DateTime dateLocation;
        private double montantRegle;
        private Vehicule leVehicule;

        public Location(int unNumLocation, DateTime uneDateLocation, double unMontantRegle, Vehicule unVehicule)
        {
            this.numLocation = unNumLocation;
            this.dateLocation = uneDateLocation;
            this.montantRegle = unMontantRegle;
            this.leVehicule = unVehicule;
        }

        public Vehicule GetLeVehicule()
        {
            return leVehicule;
        }

        public double GetMontantRegle()
        {
            return montantRegle;
        }
    }
}
