using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localux
{
    class Modele
    {

        private int id;
        private string libelle;
        private double tarifKmSupplementaire;

        public Modele(int unId, string unLibelle, double unTarifKmSupplementaire)
        {
            this.id = unId;
            this.libelle = unLibelle;
            this.tarifKmSupplementaire = unTarifKmSupplementaire;
        }

        public double GetTarifKmSupplemenataire()
        {
            return tarifKmSupplementaire;
        }
    }
}
