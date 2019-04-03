using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hypothese_2
{
    class Felin:Mammifere
    {
        private int nombrePattes;

        public Felin(string nom, string LieuHabitation, string monCrie, bool jeSuisDomestique, Dangerosite danger, int nombrePattes)
            : base(nom, LieuHabitation, monCrie, jeSuisDomestique, danger)
        {
            this.nombrePattes = nombrePattes;
        }


        public new void Afficher()
        {
            base.Afficher();
            Console.WriteLine("nombre de Pattes : {0}\n\n", this.nombrePattes);
        }
    }
}
