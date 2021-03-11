using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localux
{
    abstract class Formule
    {

        private int id;
        private string libelle;

        public Formule(int unId, string unLibelle)
        {
            this.id = unId;
            this.libelle = unLibelle;
        }

        public string getLibelle()
        {
            return libelle;
        }
    }
}
