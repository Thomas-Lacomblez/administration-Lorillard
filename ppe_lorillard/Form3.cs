using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ppe_lorillard
{
    public partial class Form3 : Form
    {
        private List<observateur> ListObservateurs = new List<observateur>();
        private List<equipe> ListEquipe = new List<equipe>();
        private List<zone> ListZone = new List<zone>();
        private List<site> ListSite = new List<site>();
        private static readonly MySqlDB Bdd = new MySqlDB(Program.MonServeur, Program.MaBDD, Program.MonId, Program.MonMdp);
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {


            ListObservateurs = Bdd.GetObservateur();
            ListEquipe = Bdd.GetEquipes();
            ListZone = Bdd.GetZone();
            ListSite = Bdd.GetSites();

            foreach (observateur Observateur in ListObservateurs)
            {
                comboBoxObservateur.Items.Add(Observateur.Getid().ToString() + " - " + Observateur.GetNom().ToString());
            }
            foreach (equipe Equipe in ListEquipe)
            {
                comboBoxEquipe.Items.Add(Equipe.GetIdEquipe().ToString() + " - " + Equipe.GetNomEquipe().ToString());
            }
            foreach (zone Zone in ListZone)
            {
                comboBoxZone.Items.Add(Zone.GetIdZone().ToString() + " - " + Zone.GetNomZone().ToString());
            }
            foreach (site Site in ListSite)
            {
                comboBoxSite.Items.Add(Site.GetId().ToString() + " - " + Site.GetNom().ToString());
            }

        }

        private void buttonAjout_Click(object sender, EventArgs e)
        {
            try
            { 
                string p = comboBoxObservateur.SelectedItem.ToString();
                string[] pRes = p.Split('-');
                string s = comboBoxSite.SelectedItem.ToString();
                string[] sRes = s.Split('-');
                string z = comboBoxZone.SelectedItem.ToString();
                string[] zRes = s.Split('-');
                string eq = comboBoxEquipe.SelectedItem.ToString();
                string[] eqRes = s.Split('-');
                Bdd.Exec("INSERT INTO observation(idObservateur, date, tempsObs, nbPersContact, nbPersObs,idEquipe, idZone, idSite) VALUES(" + " \" " + pRes[0]  +  "\"" + "," + "\"" + dateInput.Value.ToString("yyyy-MM-dd") + "\"" + "," + "\"" + Int32.Parse(tempsObsInput.Value.ToString()) +  "\"" + "," + "\"" + Int32.Parse(nbPersContactInput.Value.ToString()) + "\"" + "," + "\"" + Int32.Parse(nbPersObsInput.Value.ToString()) + "\"" + "," + eqRes[0] + "," + zRes[0] + "," + sRes[0] + ")");
                MessageBox.Show("Ajout de l'observation réussie");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
           
            
            this.Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
