using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hypothese_2
{
    class Baleine:Cetace
    {

        public Baleine(string nom, string LieuHabitation, string monCrie, bool jeSuisDomestique, Dangerosite danger, int DureeApnee, int ProfondeurPlongee)
            : base(nom, LieuHabitation, monCrie, jeSuisDomestique, danger, DureeApnee, ProfondeurPlongee)
        {
        }




        public new void Afficher()
        {
            base.Afficher();
        }
    }
}
