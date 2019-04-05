using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hypothese
{
    class Cetace:Mammifere
    {
        protected int DureeApnee;
        protected int ProfondeurPlongee;

        public Cetace(string nom, string LieuHabitation, string monCrie, bool jeSuisDomestique, Dangerosite danger , int DureeApnee, int ProfondeurPlongee)
            : base(nom, LieuHabitation, monCrie, jeSuisDomestique,  danger)
        {
            this.DureeApnee = DureeApnee;
            this.ProfondeurPlongee = ProfondeurPlongee;
        }
    }
}
