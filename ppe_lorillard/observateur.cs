using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppe_lorillard
{
    class observateur
    {
        //variables
        private int id;
        private string nom;
        private string prenom;
        private string email;
        private string login;
        private string mdp;

        //constructeur
        public observateur (int ids, string noms, string prenoms, string emails, string logins, string mdps)
        {
            this.id = ids;
            this.nom = noms;
            this.prenom = prenoms;
            this.email = emails;
            this.login = logins;
            this.mdp = mdps;
        }
        //getters
        public int Getid()
        {
            return this.id;
        }
       public string GetNom()
        {
            return this.nom;
        }
        public string GetPrenom()
        {
            return this.prenom;
        }
        public string Getemail()
        {
            return this.email;
        }
        public string Getlogin()
        {
            return this.login;
        }
        public string Getmdp()
        {
            return this.mdp;
        }
     
        //setters
        public void SetNom(string parNom)
        {
            this.nom = parNom;
        }
        public void SetPrenom(string parPrenom)
        {
            this.prenom = parPrenom;
        }
    }
}
