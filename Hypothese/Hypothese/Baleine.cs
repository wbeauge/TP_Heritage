using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hypothese
{
    class Baleine:Cetace
    {
        public Baleine(string nom, string LieuHabitation, string monCrie, bool jeSuisDomestique, Dangerosite danger , int DureeApnee, int ProfondeurPlongee)
            : base(nom, LieuHabitation, monCrie, jeSuisDomestique, danger, DureeApnee, ProfondeurPlongee)
        {
        }




        public void Afficher()
        {
            Console.WriteLine("Nom : {0}, Lieu Habitation : {1}, Mon Crie : {2}, je Suis Domestique : {3},  \nDuree de l'Apnee : {4}, Profondeur de Plongee : {5}, \nDangerosité : {6}\n", base.nom, base.LieuHabitation, base.monCrie, base.jeSuisDomestique, base.DureeApnee, base.ProfondeurPlongee, base.danger);
        }
    }
}
