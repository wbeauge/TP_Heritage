using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hypothese_2
{
    class Chat : Felin
    {
        public Chat(string nom, string LieuHabitation, string monCrie, bool jeSuisDomestique, Dangerosite danger, int nombrePattes)
            : base(nom, LieuHabitation, monCrie, jeSuisDomestique, danger, nombrePattes)
        {

        }

        public new void Afficher()
        {
            base.Afficher();
        }

    }
}
