using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppe_lorillard
{
    class zone
    {
        private int idZone;
        private string nomZone;
        private int idSite;

        public zone (int idZones, string nomZones, int idSites)
        {
            this.idZone = idZones;
            this.nomZone = nomZones;
            this.idSite = idSites;
        }

        public int GetIdZone()
        {
            return this.idZone;
        }
        public string GetNomZone()
        {
            return this.nomZone;
        }
        public int GetIdSite()
        {
            return this.idSite;
        }
    }
}
