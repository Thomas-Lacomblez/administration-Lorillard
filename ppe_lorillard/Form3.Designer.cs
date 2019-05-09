namespace ppe_lorillard
{
    partial class Form3
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
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxObservateur = new System.Windows.Forms.ComboBox();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.buttonAjout = new System.Windows.Forms.Button();
            this.Site = new System.Windows.Forms.Label();
            this.comboBoxSite = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxZone = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEquipe = new System.Windows.Forms.ComboBox();
            this.nbPersObs = new System.Windows.Forms.Label();
            this.nbPersObsInput = new System.Windows.Forms.NumericUpDown();
            this.nbPersContact = new System.Windows.Forms.Label();
            this.nbPersContactInput = new System.Windows.Forms.NumericUpDown();
            this.tempsObs = new System.Windows.Forms.Label();
            this.tempsObsInput = new System.Windows.Forms.NumericUpDown();
            this.date = new System.Windows.Forms.Label();
            this.dateInput = new System.Windows.Forms.DateTimePicker();
            this.Titre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nbPersObsInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPersContactInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempsObsInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Observateur";
            // 
            // comboBoxObservateur
            // 
            this.comboBoxObservateur.FormattingEnabled = true;
            this.comboBoxObservateur.Location = new System.Drawing.Point(436, 117);
            this.comboBoxObservateur.Name = "comboBoxObservateur";
            this.comboBoxObservateur.Size = new System.Drawing.Size(121, 24);
            this.comboBoxObservateur.TabIndex = 36;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(369, 498);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(95, 24);
            this.ButtonCancel.TabIndex = 35;
            this.ButtonCancel.Text = "Annuler";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonAjout
            // 
            this.buttonAjout.Location = new System.Drawing.Point(531, 498);
            this.buttonAjout.Name = "buttonAjout";
            this.buttonAjout.Size = new System.Drawing.Size(95, 24);
            this.buttonAjout.TabIndex = 34;
            this.buttonAjout.Text = "Ajouter";
            this.buttonAjout.UseVisualStyleBackColor = true;
            this.buttonAjout.Click += new System.EventHandler(this.buttonAjout_Click);
            // 
            // Site
            // 
            this.Site.AutoSize = true;
            this.Site.Location = new System.Drawing.Point(259, 455);
            this.Site.Name = "Site";
            this.Site.Size = new System.Drawing.Size(32, 17);
            this.Site.TabIndex = 33;
            this.Site.Text = "Site";
            // 
            // comboBoxSite
            // 
            this.comboBoxSite.FormattingEnabled = true;
            this.comboBoxSite.Location = new System.Drawing.Point(447, 448);
            this.comboBoxSite.Name = "comboBoxSite";
            this.comboBoxSite.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSite.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Zone";
            // 
            // comboBoxZone
            // 
            this.comboBoxZone.FormattingEnabled = true;
            this.comboBoxZone.Location = new System.Drawing.Point(447, 405);
            this.comboBoxZone.Name = "comboBoxZone";
            this.comboBoxZone.Size = new System.Drawing.Size(121, 24);
            this.comboBoxZone.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Equipe";
            // 
            // comboBoxEquipe
            // 
            this.comboBoxEquipe.FormattingEnabled = true;
            this.comboBoxEquipe.Location = new System.Drawing.Point(447, 357);
            this.comboBoxEquipe.Name = "comboBoxEquipe";
            this.comboBoxEquipe.Size = new System.Drawing.Size(121, 24);
            this.comboBoxEquipe.TabIndex = 28;
            // 
            // nbPersObs
            // 
            this.nbPersObs.AutoSize = true;
            this.nbPersObs.Location = new System.Drawing.Point(176, 310);
            this.nbPersObs.Name = "nbPersObs";
            this.nbPersObs.Size = new System.Drawing.Size(197, 17);
            this.nbPersObs.TabIndex = 27;
            this.nbPersObs.Text = "Nombre de personne observé";
            // 
            // nbPersObsInput
            // 
            this.nbPersObsInput.Location = new System.Drawing.Point(478, 310);
            this.nbPersObsInput.Name = "nbPersObsInput";
            this.nbPersObsInput.Size = new System.Drawing.Size(44, 22);
            this.nbPersObsInput.TabIndex = 26;
            // 
            // nbPersContact
            // 
            this.nbPersContact.AutoSize = true;
            this.nbPersContact.Location = new System.Drawing.Point(176, 263);
            this.nbPersContact.Name = "nbPersContact";
            this.nbPersContact.Size = new System.Drawing.Size(200, 17);
            this.nbPersContact.TabIndex = 25;
            this.nbPersContact.Text = "Nombre de personne contacté";
            // 
            // nbPersContactInput
            // 
            this.nbPersContactInput.Location = new System.Drawing.Point(478, 263);
            this.nbPersContactInput.Name = "nbPersContactInput";
            this.nbPersContactInput.Size = new System.Drawing.Size(44, 22);
            this.nbPersContactInput.TabIndex = 24;
            // 
            // tempsObs
            // 
            this.tempsObs.AutoSize = true;
            this.tempsObs.Location = new System.Drawing.Point(176, 220);
            this.tempsObs.Name = "tempsObs";
            this.tempsObs.Size = new System.Drawing.Size(155, 17);
            this.tempsObs.TabIndex = 23;
            this.tempsObs.Text = "Temps de l\'observation";
            // 
            // tempsObsInput
            // 
            this.tempsObsInput.Location = new System.Drawing.Point(478, 215);
            this.tempsObsInput.Name = "tempsObsInput";
            this.tempsObsInput.Size = new System.Drawing.Size(44, 22);
            this.tempsObsInput.TabIndex = 22;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(186, 175);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(145, 17);
            this.date.TabIndex = 21;
            this.date.Text = "Date de l\'Observation";
            // 
            // dateInput
            // 
            this.dateInput.Location = new System.Drawing.Point(405, 175);
            this.dateInput.Name = "dateInput";
            this.dateInput.Size = new System.Drawing.Size(200, 22);
            this.dateInput.TabIndex = 20;
            // 
            // Titre
            // 
            this.Titre.AutoSize = true;
            this.Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Titre.Location = new System.Drawing.Point(254, 9);
            this.Titre.Name = "Titre";
            this.Titre.Size = new System.Drawing.Size(454, 48);
            this.Titre.TabIndex = 19;
            this.Titre.Text = "Ajout d\'une observation";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 535);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxObservateur);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.buttonAjout);
            this.Controls.Add(this.Site);
            this.Controls.Add(this.comboBoxSite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxZone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxEquipe);
            this.Controls.Add(this.nbPersObs);
            this.Controls.Add(this.nbPersObsInput);
            this.Controls.Add(this.nbPersContact);
            this.Controls.Add(this.nbPersContactInput);
            this.Controls.Add(this.tempsObs);
            this.Controls.Add(this.tempsObsInput);
            this.Controls.Add(this.date);
            this.Controls.Add(this.dateInput);
            this.Controls.Add(this.Titre);
            this.Name = "Form3";
            this.Text = "Ajout d\'une observation";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nbPersObsInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPersContactInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempsObsInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxObservateur;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button buttonAjout;
        private System.Windows.Forms.Label Site;
        private System.Windows.Forms.ComboBox comboBoxSite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxZone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxEquipe;
        private System.Windows.Forms.Label nbPersObs;
        private System.Windows.Forms.NumericUpDown nbPersObsInput;
        private System.Windows.Forms.Label nbPersContact;
        private System.Windows.Forms.NumericUpDown nbPersContactInput;
        private System.Windows.Forms.Label tempsObs;
        private System.Windows.Forms.NumericUpDown tempsObsInput;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.DateTimePicker dateInput;
        private System.Windows.Forms.Label Titre;
    }
}