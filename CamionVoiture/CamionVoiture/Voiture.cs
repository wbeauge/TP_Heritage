using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CamionVoiture
{
    class Voiture:Vehicule
    {
        protected bool decapotable;
        protected bool Climatisation;

        public Voiture(string immatricule, int annee, string marque, int modele, bool decapotable, bool Climatisation) : base(immatricule, annee, marque, modele) {
            this.decapotable = decapotable;
            this.Climatisation =Climatisation;
        }


        public string Afficher()
        {
            return string.Format("Decapotable : {0}, Sans Climatisation : {1}", this.decapotable, this.sansClimatisation);
        }
    }
}
