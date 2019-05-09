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
    public partial class Form2 : Form
    {
        private DataGridViewRow LigneAmodifier;
        private List<observateur> ListObservateurs = new List<observateur>();
        private List<equipe> ListEquipe = new List<equipe>();
        private List<zone> ListZone = new List<zone>();
        private List<site> ListSite = new List<site>();
        private static readonly MySqlDB Bdd = new MySqlDB(Program.MonServeur, Program.MaBDD, Program.MonId, Program.MonMdp);

        public Form2(DataGridViewRow rowAmodifier)
        {
            this.LigneAmodifier = rowAmodifier;
            InitializeComponent();
        }
        //ListEquipe =  Bdd
        private void Form2_Load(object sender, EventArgs e)
        {
            

            // MessageBox.Show(this.LigneAmodifier.Cells[0].Value.ToString());
            Titre.Text = "Modification de l'observation n°" + this.LigneAmodifier.Cells[0].Value.ToString();



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

            string[] resO = LigneAmodifier.Cells[1].Value.ToString().Split('-'); ;
            int idObservateur = Bdd.GetBddidObservateur(resO[0]);
     
            comboBoxObservateur.SelectedIndex = comboBoxObservateur.FindString(idObservateur.ToString() + " - " + resO[0].Trim());

            dateInput.Value  = DateTime.Parse(LigneAmodifier.Cells[2].Value.ToString());

            tempsObsInput.Value = Int32.Parse(LigneAmodifier.Cells[3].Value.ToString());
            nbPersContactInput.Value = Int32.Parse(LigneAmodifier.Cells[4].Value.ToString());
            nbPersObsInput.Value = Int32.Parse(LigneAmodifier.Cells[5].Value.ToString());

            comboBoxEquipe.SelectedIndex = comboBoxEquipe.FindStringExact(LigneAmodifier.Cells[6].Value.ToString());
            comboBoxZone.SelectedIndex = comboBoxZone.FindStringExact(LigneAmodifier.Cells[7].Value.ToString());
            comboBoxSite.SelectedIndex = comboBoxSite.FindStringExact(LigneAmodifier.Cells[8].Value.ToString());
        }

        private void buttonModification_Click(object sender, EventArgs e)
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

                string values = Bdd.Exec("UPDATE observation SET idObservateur =" + pRes[0] + ", date =" + "\"" + dateInput.Value.ToString("yyyy-MM-dd") + "\"" + ", tempsObs =" + tempsObsInput.Value.ToString() + ", nbPersContact =" + nbPersContactInput.Value.ToString() + ", nbPersObs=" + nbPersObsInput.Value.ToString() + ", idEquipe = " + eqRes[0] + ", idZone = " + zRes[0] + ", idSite =" + sRes[0] + " WHERE id = " + LigneAmodifier.Cells[0].Value.ToString());
                MessageBox.Show("Observations ajouté avec succès ! ");
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
