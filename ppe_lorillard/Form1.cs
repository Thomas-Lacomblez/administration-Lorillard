using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace ppe_lorillard
{
    public partial class Form1 : Form
    {
       
        private static readonly MySqlDB Bdd = new MySqlDB(Program.MonServeur, Program.MaBDD, Program.MonId, Program.MonMdp);

        private DataTable _dt1;
        private DataTable _dt2;
        private DataTable _dt3;
        // private 
        private int _observationStats;
        private int _siteStats;

        private bool _fixeRep;
        //  int idBdd;

        public Form1()
        {
            InitializeComponent();
            //chart1.Titles.Add("Statistiques de l'application de detection de panne de l'entreprise Lorillard.");
            
        }
       
        private void ajouter_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == _dt1)
            {
                var values = Bdd.Exec("INSERT INTO observateur(nom,prenom,mail,login,mdp) VALUES( \" " + _dt1.Rows[dataGridView1.CurrentCell.RowIndex][1].ToString() + "\"" + "," + "\"" + _dt1.Rows[dataGridView1.CurrentCell.RowIndex][2].ToString() + " \"" + "," + "\"" + _dt1.Rows[dataGridView1.CurrentCell.RowIndex][3].ToString() + " \"" + "," + "\"" + _dt1.Rows[dataGridView1.CurrentCell.RowIndex][4].ToString() + " \"" + "," + "\"" + _dt1.Rows[dataGridView1.CurrentCell.RowIndex][5].ToString() + "\"" + ")");

                switch (values)
                {
                    case "succes":
                        MessageBox.Show("Champ ajouter avec succes");
                        break;
                    case "error":
                        MessageBox.Show("Une erreur c'est produite lors de l'ajout du champ");
                        break;
                }
            }
            else if (dataGridView1.DataSource == _dt2)
            {
                var values = Bdd.Exec("INSERT INTO site(nom,adresse) VALUES(" + " \" " + _dt2.Rows[dataGridView1.CurrentCell.RowIndex][0].ToString() + "\"" + "," + "\"" + _dt2.Rows[dataGridView1.CurrentCell.RowIndex][1].ToString() + " \" " + ")");
                switch (values)
                {
                    case "succes":
                        MessageBox.Show("Champ ajouter avec succes");
                        break;
                    case "error":
                        MessageBox.Show("Une erreur c'est produite lors de l'ajout du champ");
                        break;
                }
            }
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Bdd.Exec("DELETE FROM observation WHERE idObservateur =" + _dt1.Rows[dataGridView1.CurrentCell.RowIndex][0].ToString());
                Bdd.Exec("DELETE FROM observateur WHERE id =" + _dt1.Rows[dataGridView1.CurrentCell.RowIndex][0].ToString());
                _dt1.Rows[dataGridView1.CurrentCell.RowIndex].Delete();
            }
            else if (dataGridView1.SelectedRows.Count > 1)
            {
                MessageBox.Show("Vous ne pouvez pas supprimer plusieurs ligne en même temps");
            }
            else
            {
                MessageBox.Show("Aucune ligne à supprimer selectionner. Veuillez selectionner une ligne à modifier.");
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow rowAmodifier = new DataGridViewRow();
                rowAmodifier = dataGridView1.Rows[dataGridView1.CurrentRow.Index];
                FormModificationObservateur formModifObservateur = new FormModificationObservateur(rowAmodifier);
                formModifObservateur.ShowDialog();
            }
            else if (dataGridView1.SelectedRows.Count > 1)
            {
                MessageBox.Show("Vous ne pouvez pas modifier plusieurs ligne en même temps");
            }
            else
            {
                MessageBox.Show("Aucune ligne à modifier selectionner. Veuillez selectionner une ligne à modifier.");
            }
        }

        private void OPS_Click(object sender, EventArgs e)
        {
           /* if (tabControl1.TabIndex == 10)
            {
               _observationStats = Bdd.GetObservationStatsSite();
                _siteStats = Bdd.GetSiteStats();

                this.chart1.Series["observation par site"].Points.AddXY(_siteStats, _observationStats);
                chart1.Series["observation par site"].ChartArea = "ChartArea1";
                chart1.ChartAreas["ChartArea1"].Visible = true;
                chart1.ChartAreas["ChartArea2"].Visible = false;
            }
            */
        }

        private void TDO_Click(object sender, EventArgs e)
        {
            /*if (tabControl1.TabIndex == 10)
            {
                int tempsTotal = Bdd.GetTempsObsTotal();
                int ObservationTempsTotal = Bdd.GetObservationStatsTemps();
               
                this.chart1.Series["temps des observations"].Points.AddXY(ObservationTempsTotal, tempsTotal);
                chart1.Series["temps des observations"].ChartArea = "ChartArea2";

                int NbPersTotal = Bdd.GetPersonneObserveStatsObservation();
                int ObservationPersonneTotal = Bdd.GetObservationStatsPersonne();

                this.chart1.Series["Nombre de personnes observé"].Points.AddXY(ObservationPersonneTotal, NbPersTotal);
                chart1.Series["Nombre de personnes observé"].ChartArea = "ChartArea2";
                chart1.ChartAreas["ChartArea1"].Visible = false;
                chart1.ChartAreas["ChartArea2"].Visible = true;

            }*/

        }

        private void NPO_Click(object sender, EventArgs e)
        {
         /*   if (tabControl1.TabIndex == 10)
            {
             
            }*/

        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                this.TableObservateur();
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                _dt2 = Bdd.GetDataTableSites();
                dataGridView2.DataSource = _dt2;
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                _dt3 = Bdd.GetDataTableObservations();
                dataGridView3.DataSource = _dt3;
            }
            else
            {
            }
        }
        private void dataGridView3_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView3.ClearSelection();
        }

        private void buttonSupprimerObservation_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Bdd.Exec("DELETE FROM observation WHERE id = " + dataGridView3.Rows[dataGridView3.CurrentRow.Index].Cells[0].Value.ToString());
                _dt3.Rows[dataGridView3.CurrentRow.Index].Delete();
                _dt3 = Bdd.GetDataTableObservations();
            }
            else if (dataGridView1.SelectedRows.Count > 1)
            {
                MessageBox.Show("Vous ne pouvez pas supprimer plusieurs ligne en même temps");
            }
            else
            {
                MessageBox.Show("Aucune ligne à supprimer selectionner. Veuillez selectionner une ligne à modifier.");
            }
        }

        private void buttonAjoutObservation_Click(object sender, EventArgs e)
        {
            Form3 formAjout = new Form3();
            formAjout.ShowDialog();
        }

        private void buttonModificationObservation_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count == 1)
            {
                DataGridViewRow rowAmodifier = new DataGridViewRow();
                rowAmodifier = dataGridView3.Rows[dataGridView3.CurrentRow.Index];
                Form2 formModif = new Form2(rowAmodifier);
                formModif.ShowDialog();
            }
            else if (dataGridView3.SelectedRows.Count > 1)
            {
                MessageBox.Show("Vous ne pouvez pas modifier plusieurs ligne en même temps");
            }
            else
            {
                MessageBox.Show("Aucune ligne à modifier selectionner. Veuillez selectionner une ligne à modifier.");
            }
        }

        private void buttonUpdateSite_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 1)
            {
                DataGridViewRow rowAmodifier = new DataGridViewRow();
                rowAmodifier = dataGridView2.Rows[dataGridView2.CurrentRow.Index];
                Form4 form4 = new Form4(rowAmodifier);
                form4.ShowDialog();
            }
            else if (dataGridView2.SelectedRows.Count > 1)
            {
                MessageBox.Show("Vous ne pouvez pas modifier plusieurs ligne en même temps");
            }
            else
            {
                MessageBox.Show("Aucune ligne à modifier selectionner. Veuillez selectionner une ligne à modifier.");
            }
        }

        private void buttonDeleteSite_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 1)
            {
                Bdd.Exec("DELETE FROM observation WHERE idSite = " + dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value.ToString());
                Bdd.Exec("DELETE FROM site WHERE id = " + dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value.ToString());
                _dt2.Rows[dataGridView2.CurrentRow.Index].Delete();
            }
            else if (dataGridView2.SelectedRows.Count > 1)
            {
                MessageBox.Show("Vous ne pouvez pas modifier plusieurs ligne en même temps");
            }
            else
            {
                MessageBox.Show("Aucune ligne à modifier selectionner. Veuillez selectionner une ligne à modifier.");
            }

        }

        private void buttonAddSite_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        private void ButtonAjoutObservateur_Click(object sender, EventArgs e)
        {
            FormAjoutObservateur formAjoutObservateur = new FormAjoutObservateur();
            formAjoutObservateur.ShowDialog();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void dataGridView2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView2.ClearSelection();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                this.TableObservateur();
                //Bdd.Exec("SELECT * FROM observateur");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void TableObservateur()
        {
            _dt1 = Bdd.GetDataTableObservateur();
            dataGridView1.DataSource = _dt1;
        }

        private void tabObservations_Click(object sender, EventArgs e)
        {

        }

        private void DrawEllipseInt(PaintEventArgs e, int x2, int y2, string Text)
        {
            // Create pen.
            Pen RedPen = new Pen(Color.Red, 2);
            Font font1 = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);

            String drawString = Text;
            // Create font and brush.
            Font drawFont = new Font("Arial", 10);
            SolidBrush drawBrush = new SolidBrush(Color.Red);

            
            // Create location and size of ellipse.
            int x = x2;
            int y = y2;
            int width = 100;
            int height = 100;

          

            // Draw ellipse to screen.
            e.Graphics.DrawEllipse(RedPen, x, y, width, height);

            // Draw string to screen.
            e.Graphics.DrawString(drawString, drawFont, drawBrush,x+5,25);

            
        }
        private void PictureBox2_Paint(object sender, PaintEventArgs e)
        {
           e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            
           
            DrawEllipseInt(e, 1, 0, "         "+Bdd.GetPersonneContacteStats().ToString()+"\n   personnes \n   contactées");
            DrawEllipseInt(e, 350,0, "          " + Bdd.GetObservationStatsPersonne().ToString() + "\n    personnes \n    observées");
            DrawEllipseInt(e, 700, 0, "        " + Bdd.GetTempsObsTotal().ToString() + "\n     minutes \nd'observations");
            //MessageBox.Show(Bdd.GetNbObservationParSite().Length.ToString());
            switch (Bdd.GetNbObservationParSite().Length)
            {
                case 1:
                    DrawPieChart(Bdd.GetNbObservationParSite()[0]);
                    break;
                case 2:
                    DrawPieChart(Bdd.GetNbObservationParSite()[0], Bdd.GetNbObservationParSite()[1]);
                    break;
                case 3:
                    DrawPieChart(Bdd.GetNbObservationParSite()[0], Bdd.GetNbObservationParSite()[1], Bdd.GetNbObservationParSite()[2]);
                    break;
                case 4:
                    DrawPieChart(Bdd.GetNbObservationParSite()[0], Bdd.GetNbObservationParSite()[1], Bdd.GetNbObservationParSite()[2], Bdd.GetNbObservationParSite()[3]);
                    break;
                case 5:
                    DrawPieChart(Bdd.GetNbObservationParSite()[0], Bdd.GetNbObservationParSite()[1], Bdd.GetNbObservationParSite()[2], Bdd.GetNbObservationParSite()[3], Bdd.GetNbObservationParSite()[4]);
                    break;

            }

        }
        public void DrawPieInt(PaintEventArgs e,int StartA, int EndA, string color)
        {
            Color couleur = new Color();
            // Create pen.
            switch(color)
            {
                case "black":
                    couleur = Color.Black;
                    break;
                case "Red":
                    couleur = Color.Red;
                    break;
                case "Blue":
                    couleur = Color.Blue;
                    break;
                case "Green":
                    couleur = Color.Green;
                    break;

            }
            Pen Pen = new Pen(couleur, 3);

            // Create location and size of ellipse.
            int x = 100;
            int y = 100;
            int width = 200;
            int height = 100;

            // Create start and sweep angles.
            int startAngle = StartA;
            int sweepAngle = EndA;

            SolidBrush drawBrush = new SolidBrush(couleur);

            // Draw pie to screen.
            e.Graphics.DrawPie(Pen, x, y, width, height, startAngle, sweepAngle);
            e.Graphics.FillPie(drawBrush, x, y, width, height, startAngle, sweepAngle);
        }
        private void DrawPieChart(params object[] args)
        {
            //reset your chart series and legends
            chart1.Series.Clear();
            chart1.Legends.Clear();

            //Add a new Legend(if needed) and do some formating
            chart1.Legends.Add("Nombre d'observation par site");
            chart1.Legends[0].LegendStyle = LegendStyle.Table;
            chart1.Legends[0].Docking = Docking.Bottom;
            chart1.Legends[0].Alignment = StringAlignment.Center;
            chart1.Legends[0].Title = "sites";
            chart1.Legends[0].BorderColor = Color.Black;

            //Add a new chart-series
            string seriesname = "MySeriesName";
            chart1.Series.Add(seriesname);
            //set the chart-type to "Pie"
            chart1.Series[seriesname].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chart1.Series[seriesname].IsValueShownAsLabel = true;
            /*  chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
              chart1.ChartAreas["ChartArea1"].Area3DStyle.IsClustered = true;
              chart1.ChartAreas["ChartArea1"].Area3DStyle.Inclination = 60;*/

            //Add some datapoints so the series. in this case you can pass the values to this method
            //MessageBox.Show(Bdd.GetSiteStats().Length.ToString());
          /*  chart1.Series[seriesname].Points.AddXY(Bdd.GetSiteStats()[0], args[0]);
            chart1.Series[seriesname].Points.AddXY(Bdd.GetSiteStats()[1], args[1]);
            chart1.Series[seriesname].Points.AddXY(Bdd.GetSiteStats()[2], args[2]);
            chart1.Series[seriesname].Points.AddXY(Bdd.GetSiteStats()[3], args[3]);
            chart1.Series[seriesname].Points.AddXY(Bdd.GetSiteStats()[4], args[4]);*/
            for(int i =0;i< args.Length;i++)
            {
                chart1.Series[seriesname].Points.AddXY(Bdd.GetSiteStats()[i], args[i]);
            }
        }
    }
    
}