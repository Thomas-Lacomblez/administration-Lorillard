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
    public partial class Form5 : Form
    {

        private static readonly MySqlDB Bdd = new MySqlDB(Program.MonServeur, Program.MaBDD, Program.MonId, Program.MonMdp);
        public Form5()
        {
            InitializeComponent();
        }

        private void buttonAjoutSite_Click(object sender, EventArgs e)
        {
            try
            { 
                Bdd.Exec("INSERT INTO site (nom, adresse) VALUES ("+ "\"" + textBoxNom.Text + "\"" + " , "+"\"" + textBoxAdresse.Text + "\"" +")");
                MessageBox.Show("Ajout du site réussi avec succès !");
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
