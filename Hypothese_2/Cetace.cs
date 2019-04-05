using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hypothese_2
{
    class Cetace:Mammifere
    {
        private int DureeApnee;
        private int ProfondeurPlongee;

        public Cetace(string nom, string LieuHabitation, string monCrie, bool jeSuisDomestique, Dangerosite danger, int DureeApnee, int ProfondeurPlongee)
            : base(nom, LieuHabitation, monCrie, jeSuisDomestique, danger)
        {
            this.DureeApnee = DureeApnee;
            this.ProfondeurPlongee = ProfondeurPlongee;
        }


        public new void Afficher()
        {
            base.Afficher();
            Console.WriteLine("Duree d'Apnee : {0} \nProfondeur de Plongee : {1}\n\n", this.DureeApnee, this.ProfondeurPlongee);
        }

    }
}
