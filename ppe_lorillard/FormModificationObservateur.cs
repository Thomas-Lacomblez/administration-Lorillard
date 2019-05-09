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
    public partial class FormModificationObservateur : Form
    {
        private static readonly MySqlDB Bdd = new MySqlDB(Program.MonServeur, Program.MaBDD, Program.MonId, Program.MonMdp);
        private DataGridViewRow LigneAmodifier;
        public FormModificationObservateur(DataGridViewRow rowAmodifier)
        {
            this.LigneAmodifier = rowAmodifier;
            InitializeComponent();
        }

        private void buttonModificationObservateur_Click(object sender, EventArgs e)
        {
            try
            {
                string hashPassword = BCrypt.Net.BCrypt.HashPassword(textBoxMdp.Text);
                Bdd.Exec("UPDATE observateur SET nom =\"" + textBoxNom.Text + "\"" + "," + "prenom=\"" + textBoxPrenom.Text + "\"" + "," + "mail=\" " + textBoxEmail.Text + "\"" + "," + "login=\"" + textBoxId.Text + "\"" + "," + "mdp=\"" + hashPassword + "\" WHERE id = " + this.LigneAmodifier.Cells[0].Value.ToString());
                MessageBox.Show("Observateur modifier avec succès !");
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

        private void FormModificationObservateur_Load(object sender, EventArgs e)
        {
            textBoxNom.Text = this.LigneAmodifier.Cells[1].Value.ToString();
            textBoxPrenom.Text = this.LigneAmodifier.Cells[2].Value.ToString();
            textBoxEmail.Text = this.LigneAmodifier.Cells[3].Value.ToString();
            textBoxId.Text = this.LigneAmodifier.Cells[4].Value.ToString();
            textBoxMdp.Text = this.LigneAmodifier.Cells[5].Value.ToString();

            textBoxMdp.PasswordChar = '*';
        }
    }
}
