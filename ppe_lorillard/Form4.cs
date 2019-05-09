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
    public partial class Form4 : Form
    {
        private static readonly MySqlDB Bdd = new MySqlDB(Program.MonServeur, Program.MaBDD, Program.MonId, Program.MonMdp);
        private DataGridViewRow LigneAmodifier;
        public Form4(DataGridViewRow rowAmodifier)
        {
            this.LigneAmodifier = rowAmodifier;
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            textBoxNom.Text = LigneAmodifier.Cells[1].Value.ToString();
            textBoxAdresse.Text = LigneAmodifier.Cells[2].Value.ToString();
        }

        private void buttonModificationSite_Click(object sender, EventArgs e)
        {
            try
            {
                string values = Bdd.Exec("UPDATE site SET nom="+ textBoxNom.Text.ToString() +", adresse="+ textBoxAdresse.Text.ToString() + " WHERE id = " + LigneAmodifier.Cells[0].Value.ToString());
                MessageBox.Show("Site modifié avec succès !");
            }
            catch (Exception ex)
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
