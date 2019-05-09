using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppe_lorillard
{
    class site
    {
        private int Sid;
        private string nom;
        private string adresse;

        public site(int Sids, string noms,string adresses)
        {
            this.Sid = Sids;
            this.nom = noms;
            this.adresse = adresses;
        }

        public int GetId()
        {
            return this.Sid;
        }

        public string GetNom()
        {
            return this.nom;
        }
        public string GetAdresse()
        {
            return this.adresse;
        }
        public void SetNom(string paraN)
        {
            this.nom = paraN;
        }
        public void SetAdresse(string paraA)
        {
            this.adresse = paraA;
        }

    }
}
