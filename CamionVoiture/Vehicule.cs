using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CamionVoiture
{
    class Vehicule
    {
        protected string immatricule;
        protected int annee;
        protected string marque;
        protected int modele;


        public Vehicule(string immatricule, int annee, string marque, int modele) {
            this.immatricule = immatricule;
            this.annee = annee;
            this.marque = marque;
            this.modele = modele;
        }

        public string Afficher() {
            return string.Format("\nImmatricule : {0}, \nAnnee : {1}, \nMarque : {2}, \nModele : {3}", this.immatricule, this.annee, this.marque, this.modele);
        }

    }
}
