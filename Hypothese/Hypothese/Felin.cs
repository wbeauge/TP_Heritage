using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hypothese
{
    class Felin:Mammifere
    {
        protected int nombrePattes;

        public Felin(string nom, string LieuHabitation, string monCrie, bool jeSuisDomestique, Dangerosite danger , int nombrePattes)
            : base(nom, LieuHabitation, monCrie, jeSuisDomestique, danger)
        {
            this.nombrePattes = nombrePattes;
        }
    }
}
