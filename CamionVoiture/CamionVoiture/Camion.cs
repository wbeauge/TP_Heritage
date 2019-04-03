using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CamionVoiture
{
    class Camion:Vehicule
    {
        protected bool semiRemorque;
        protected int essieux;

        public Camion(string immatricule, int annee, string marque, int modele, bool semiRemorque, int essieux)
            : base(immatricule, annee, marque, modele)
        {
            this.semiRemorque = semiRemorque;
            this.essieux = essieux;
        }


        public string Afficher()
        {
            return string.Format("Decapotable : {0}, Sans Climatisation : {1}", this.decapotable, this.sansClimatisation);
        }
    }
}
