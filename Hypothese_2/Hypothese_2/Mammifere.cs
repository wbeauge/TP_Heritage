using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hypothese_2
{
    class Mammifere
    {

        private string nom;
        private string LieuHabitation;
        private string monCrie;
        private bool jeSuisDomestique;
        private Dangerosite danger;

        public Mammifere(string nom, string LieuHabitation, string monCrie, bool jeSuisDomestique, Dangerosite danger)
        {
            this.nom = nom;
            this.LieuHabitation = LieuHabitation;
            this.monCrie = monCrie;
            this.jeSuisDomestique = jeSuisDomestique;
            this.danger = danger;
        }



        public void Afficher()
        {
            Console.WriteLine("Nom : {0} \nLieu Habitation : {1} \nMon Crie : {2} \nje Suis Domestique : {3} \nDangerosité : {4}\n", this.nom, this.LieuHabitation, this.monCrie, this.jeSuisDomestique, this.danger);
        }

        public bool JeSuisDangeux()
        {

            return this.jeSuisDomestique;
        }
    }
}
