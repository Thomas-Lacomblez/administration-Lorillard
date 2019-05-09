using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;


namespace ppe_lorillard
{
    public partial class FormAjoutObservateur : Form
    {
        private static readonly MySqlDB Bdd = new MySqlDB(Program.MonServeur, Program.MaBDD, Program.MonId, Program.MonMdp);
        public FormAjoutObservateur()
        {
            InitializeComponent();
        }

        private void FormAjoutObservateur_Load(object sender, EventArgs e)
        {
        }

        private void buttonAjoutSite_Click(object sender, EventArgs e)
        {
            try
            {
                string hashPassword = BCrypt.Net.BCrypt.HashPassword(textBoxMdp.Text);
                Bdd.Exec("INSERT INTO observateur(nom, prenom, mail, login, mdp) VALUES (" + "\"" + textBoxNom.Text + "\"" + "," + "\"" + textBoxPrenom.Text + "\"" + "," + "\"" + textBoxEmail.Text + "\"" + "," + "\"" + textBoxId.Text + "\"" + "," + "\"" + hashPassword + "\"" + ")");
                MessageBox.Show("Observateur ajouté avec succès ! ");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
