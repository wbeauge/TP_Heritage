using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hypothese
{
    class Chat : Felin
    {
        public Chat(string nom, string LieuHabitation, string monCrie, bool jeSuisDomestique, Dangerosite danger , int nombrePattes)
            : base(nom, LieuHabitation, monCrie, jeSuisDomestique, danger, nombrePattes)
        {

        }

        public void Afficher()
        {
            Console.WriteLine("Nom : {0}, Lieu Habitation : {1}, Mon Crie : {2}, je Suis Domestique : {3}, nombre de Pattes : {4}, \nDangerosité : {5}\n", base.nom, base.LieuHabitation, base.monCrie, base.jeSuisDomestique, base.nombrePattes, base.danger);
        }

    }
}
