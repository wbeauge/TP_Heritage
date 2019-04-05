using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hypothese
{
    class Mammifere
    {
        protected string nom;
        protected string LieuHabitation;
        protected string monCrie;
        protected bool jeSuisDomestique;
        protected Dangerosite danger;

        public Mammifere( string nom, string LieuHabitation, string monCrie, bool jeSuisDomestique, Dangerosite danger) {
            this.nom = nom;
            this.LieuHabitation = LieuHabitation;
            this.monCrie = monCrie;
            this.jeSuisDomestique = jeSuisDomestique;
            this.danger = danger;
        }

        public bool JeSuisDangeux() { 
            
            return this.jeSuisDomestique;
        }
    }
}
