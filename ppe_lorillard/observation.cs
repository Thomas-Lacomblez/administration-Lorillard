using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppe_lorillard
{
    class observation
    {
        //variables
        private int idObservation;
        private int idObservateur;
        private DateTime date;
        private int tempsObs;
        private int nbPersContact;
        private int nbPersObs;
        private int site_id;
        private int zone_id;
        private int equipe_id;
        //constructeur
        public observation(int idObservations,int idObservateurs, DateTime dates, int tempsObss, int nbPersContacts, int nbPersObss, int equipe_ids, int zone_ids, int site_ids)
        {
            this.idObservation = idObservations;
            this.idObservateur = idObservateurs;
            this.date = dates;
            this.tempsObs = tempsObss;
            this.nbPersContact = nbPersContacts;
            this.nbPersObs = nbPersObss;
            this.equipe_id = equipe_ids;
            this.zone_id = zone_ids;
            this.site_id = site_ids;
        }

        //getters
        public int GetidObservation()
        {
            return this.idObservation;
        }
        public int GetidObservateur()
        {
            return this.idObservateur;
        }
        public DateTime GetDateObservation()
        {
            return this.date;
        }
        public int GetTempsObs()
        {
            return this.tempsObs;
        }
        public int GetNbPersContact()
        {
            return this.nbPersContact;
        }
        public int GetNbPersObs()
        {
            return this.nbPersObs;
        }
        public int GetidSite()
        {
            return this.site_id;
        }
        public int GetidZone()
        {
            return this.zone_id;
        }
        public int GetidEquipe()
        {
            return this.equipe_id;
        }
    }
}
