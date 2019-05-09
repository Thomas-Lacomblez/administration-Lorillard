using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppe_lorillard
{

    class equipe
    {
        private int idEquipe;
        private string nom;
        private int idZone;

        public equipe(int idEquipes, string noms, int idZones)
        {
            this.idEquipe = idEquipes;
            this.nom = noms;
            this.idZone = idZones;
        }

        public int GetIdEquipe()
        {
            return this.idEquipe;
        }
        public string GetNomEquipe()
        {
            return this.nom;
        }
        public int GetIZone()
        {
            return this.idZone;
        }
    }
}
