namespace ppe_lorillard
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonAjoutObservateur = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.supprimer = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabObservateurs = new System.Windows.Forms.TabPage();
            this.tabSite = new System.Windows.Forms.TabPage();
            this.buttonAddSite = new System.Windows.Forms.Button();
            this.buttonUpdateSite = new System.Windows.Forms.Button();
            this.buttonDeleteSite = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabObservations = new System.Windows.Forms.TabPage();
            this.buttonSupprimerObservation = new System.Windows.Forms.Button();
            this.buttonModificationObservation = new System.Windows.Forms.Button();
            this.buttonAjoutObservation = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Statistiques = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabObservateurs.SuspendLayout();
            this.tabSite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabObservations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.Statistiques.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ButtonAjoutObservateur);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.supprimer);
            this.panel1.Controls.Add(this.Modifier);
            this.panel1.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // ButtonAjoutObservateur
            // 
            resources.ApplyResources(this.ButtonAjoutObservateur, "ButtonAjoutObservateur");
            this.ButtonAjoutObservateur.Name = "ButtonAjoutObservateur";
            this.ButtonAjoutObservateur.UseVisualStyleBackColor = true;
            this.ButtonAjoutObservateur.Click += new System.EventHandler(this.ButtonAjoutObservateur_Click);
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.DataBindings.Add(new System.Windows.Forms.Binding("ReadOnly", global::ppe_lorillard.Properties.Settings.Default, "disable", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = global::ppe_lorillard.Properties.Settings.Default.disable;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // supprimer
            // 
            resources.ApplyResources(this.supprimer, "supprimer");
            this.supprimer.Name = "supprimer";
            this.supprimer.UseVisualStyleBackColor = true;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // Modifier
            // 
            resources.ApplyResources(this.Modifier, "Modifier");
            this.Modifier.Name = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabObservateurs);
            this.tabControl1.Controls.Add(this.tabSite);
            this.tabControl1.Controls.Add(this.tabObservations);
            this.tabControl1.Controls.Add(this.Statistiques);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabObservateurs
            // 
            this.tabObservateurs.Controls.Add(this.panel1);
            resources.ApplyResources(this.tabObservateurs, "tabObservateurs");
            this.tabObservateurs.Name = "tabObservateurs";
            this.tabObservateurs.UseVisualStyleBackColor = true;
            // 
            // tabSite
            // 
            this.tabSite.Controls.Add(this.buttonAddSite);
            this.tabSite.Controls.Add(this.buttonUpdateSite);
            this.tabSite.Controls.Add(this.buttonDeleteSite);
            this.tabSite.Controls.Add(this.dataGridView2);
            resources.ApplyResources(this.tabSite, "tabSite");
            this.tabSite.Name = "tabSite";
            this.tabSite.UseVisualStyleBackColor = true;
            // 
            // buttonAddSite
            // 
            resources.ApplyResources(this.buttonAddSite, "buttonAddSite");
            this.buttonAddSite.Name = "buttonAddSite";
            this.buttonAddSite.UseVisualStyleBackColor = true;
            this.buttonAddSite.Click += new System.EventHandler(this.buttonAddSite_Click);
            // 
            // buttonUpdateSite
            // 
            resources.ApplyResources(this.buttonUpdateSite, "buttonUpdateSite");
            this.buttonUpdateSite.Name = "buttonUpdateSite";
            this.buttonUpdateSite.UseVisualStyleBackColor = true;
            this.buttonUpdateSite.Click += new System.EventHandler(this.buttonUpdateSite_Click);
            // 
            // buttonDeleteSite
            // 
            resources.ApplyResources(this.buttonDeleteSite, "buttonDeleteSite");
            this.buttonDeleteSite.Name = "buttonDeleteSite";
            this.buttonDeleteSite.UseVisualStyleBackColor = true;
            this.buttonDeleteSite.Click += new System.EventHandler(this.buttonDeleteSite_Click);
            // 
            // dataGridView2
            // 
            resources.ApplyResources(this.dataGridView2, "dataGridView2");
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView2.DataBindings.Add(new System.Windows.Forms.Binding("ReadOnly", global::ppe_lorillard.Properties.Settings.Default, "disable", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = global::ppe_lorillard.Properties.Settings.Default.disable;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView2_DataBindingComplete);
            // 
            // tabObservations
            // 
            this.tabObservations.Controls.Add(this.buttonSupprimerObservation);
            this.tabObservations.Controls.Add(this.buttonModificationObservation);
            this.tabObservations.Controls.Add(this.buttonAjoutObservation);
            this.tabObservations.Controls.Add(this.dataGridView3);
            resources.ApplyResources(this.tabObservations, "tabObservations");
            this.tabObservations.Name = "tabObservations";
            this.tabObservations.UseVisualStyleBackColor = true;
            this.tabObservations.Click += new System.EventHandler(this.tabObservations_Click);
            // 
            // buttonSupprimerObservation
            // 
            resources.ApplyResources(this.buttonSupprimerObservation, "buttonSupprimerObservation");
            this.buttonSupprimerObservation.Name = "buttonSupprimerObservation";
            this.buttonSupprimerObservation.UseVisualStyleBackColor = true;
            this.buttonSupprimerObservation.Click += new System.EventHandler(this.buttonSupprimerObservation_Click);
            // 
            // buttonModificationObservation
            // 
            resources.ApplyResources(this.buttonModificationObservation, "buttonModificationObservation");
            this.buttonModificationObservation.Name = "buttonModificationObservation";
            this.buttonModificationObservation.UseVisualStyleBackColor = true;
            this.buttonModificationObservation.Click += new System.EventHandler(this.buttonModificationObservation_Click);
            // 
            // buttonAjoutObservation
            // 
            resources.ApplyResources(this.buttonAjoutObservation, "buttonAjoutObservation");
            this.buttonAjoutObservation.Name = "buttonAjoutObservation";
            this.buttonAjoutObservation.UseVisualStyleBackColor = true;
            this.buttonAjoutObservation.Click += new System.EventHandler(this.buttonAjoutObservation_Click);
            // 
            // dataGridView3
            // 
            resources.ApplyResources(this.dataGridView3, "dataGridView3");
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView3.DataBindings.Add(new System.Windows.Forms.Binding("ReadOnly", global::ppe_lorillard.Properties.Settings.Default, "disable", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = global::ppe_lorillard.Properties.Settings.Default.disable;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView3_DataBindingComplete);
            // 
            // Statistiques
            // 
            this.Statistiques.Controls.Add(this.chart1);
            this.Statistiques.Controls.Add(this.pictureBox2);
            resources.ApplyResources(this.Statistiques, "Statistiques");
            this.Statistiques.Name = "Statistiques";
            this.Statistiques.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            resources.ApplyResources(this.chart1, "chart1");
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox2_Paint);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabObservateurs.ResumeLayout(false);
            this.tabSite.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabObservations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.Statistiques.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonAjoutObservateur;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabObservateurs;
        private System.Windows.Forms.TabPage Statistiques;
        private System.Windows.Forms.TabPage tabSite;
        private System.Windows.Forms.TabPage tabObservations;
        private System.Windows.Forms.Button buttonAddSite;
        private System.Windows.Forms.Button buttonUpdateSite;
        private System.Windows.Forms.Button buttonDeleteSite;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button buttonSupprimerObservation;
        private System.Windows.Forms.Button buttonModificationObservation;
        private System.Windows.Forms.Button buttonAjoutObservation;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

