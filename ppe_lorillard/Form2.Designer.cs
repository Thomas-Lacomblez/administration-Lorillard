namespace ppe_lorillard
{
    partial class Form2
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
            this.Titre = new System.Windows.Forms.Label();
            this.dateInput = new System.Windows.Forms.DateTimePicker();
            this.date = new System.Windows.Forms.Label();
            this.tempsObsInput = new System.Windows.Forms.NumericUpDown();
            this.tempsObs = new System.Windows.Forms.Label();
            this.nbPersContactInput = new System.Windows.Forms.NumericUpDown();
            this.nbPersContact = new System.Windows.Forms.Label();
            this.nbPersObsInput = new System.Windows.Forms.NumericUpDown();
            this.nbPersObs = new System.Windows.Forms.Label();
            this.comboBoxEquipe = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxZone = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSite = new System.Windows.Forms.ComboBox();
            this.Site = new System.Windows.Forms.Label();
            this.buttonModification = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.comboBoxObservateur = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tempsObsInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPersContactInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPersObsInput)).BeginInit();
            this.SuspendLayout();
            // 
            // Titre
            // 
            this.Titre.AutoSize = true;
            this.Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Titre.Location = new System.Drawing.Point(236, 9);
            this.Titre.Name = "Titre";
            this.Titre.Size = new System.Drawing.Size(593, 48);
            this.Titre.TabIndex = 0;
            this.Titre.Text = "Modification d\'une Observation";
            // 
            // dateInput
            // 
            this.dateInput.Location = new System.Drawing.Point(438, 175);
            this.dateInput.Name = "dateInput";
            this.dateInput.Size = new System.Drawing.Size(200, 22);
            this.dateInput.TabIndex = 1;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(209, 175);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(145, 17);
            this.date.TabIndex = 2;
            this.date.Text = "Date de l\'Observation";
            // 
            // tempsObsInput
            // 
            this.tempsObsInput.Location = new System.Drawing.Point(511, 215);
            this.tempsObsInput.Name = "tempsObsInput";
            this.tempsObsInput.Size = new System.Drawing.Size(44, 22);
            this.tempsObsInput.TabIndex = 3;
            // 
            // tempsObs
            // 
            this.tempsObs.AutoSize = true;
            this.tempsObs.Location = new System.Drawing.Point(209, 220);
            this.tempsObs.Name = "tempsObs";
            this.tempsObs.Size = new System.Drawing.Size(155, 17);
            this.tempsObs.TabIndex = 4;
            this.tempsObs.Text = "Temps de l\'observation";
            // 
            // nbPersContactInput
            // 
            this.nbPersContactInput.Location = new System.Drawing.Point(511, 263);
            this.nbPersContactInput.Name = "nbPersContactInput";
            this.nbPersContactInput.Size = new System.Drawing.Size(44, 22);
            this.nbPersContactInput.TabIndex = 5;
            // 
            // nbPersContact
            // 
            this.nbPersContact.AutoSize = true;
            this.nbPersContact.Location = new System.Drawing.Point(209, 263);
            this.nbPersContact.Name = "nbPersContact";
            this.nbPersContact.Size = new System.Drawing.Size(200, 17);
            this.nbPersContact.TabIndex = 6;
            this.nbPersContact.Text = "Nombre de personne contacté";
            // 
            // nbPersObsInput
            // 
            this.nbPersObsInput.Location = new System.Drawing.Point(511, 310);
            this.nbPersObsInput.Name = "nbPersObsInput";
            this.nbPersObsInput.Size = new System.Drawing.Size(44, 22);
            this.nbPersObsInput.TabIndex = 7;
            // 
            // nbPersObs
            // 
            this.nbPersObs.AutoSize = true;
            this.nbPersObs.Location = new System.Drawing.Point(209, 310);
            this.nbPersObs.Name = "nbPersObs";
            this.nbPersObs.Size = new System.Drawing.Size(197, 17);
            this.nbPersObs.TabIndex = 8;
            this.nbPersObs.Text = "Nombre de personne observé";
            // 
            // comboBoxEquipe
            // 
            this.comboBoxEquipe.FormattingEnabled = true;
            this.comboBoxEquipe.Location = new System.Drawing.Point(480, 357);
            this.comboBoxEquipe.Name = "comboBoxEquipe";
            this.comboBoxEquipe.Size = new System.Drawing.Size(121, 24);
            this.comboBoxEquipe.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Equipe";
            // 
            // comboBoxZone
            // 
            this.comboBoxZone.FormattingEnabled = true;
            this.comboBoxZone.Location = new System.Drawing.Point(480, 405);
            this.comboBoxZone.Name = "comboBoxZone";
            this.comboBoxZone.Size = new System.Drawing.Size(121, 24);
            this.comboBoxZone.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Zone";
            // 
            // comboBoxSite
            // 
            this.comboBoxSite.FormattingEnabled = true;
            this.comboBoxSite.Location = new System.Drawing.Point(480, 448);
            this.comboBoxSite.Name = "comboBoxSite";
            this.comboBoxSite.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSite.TabIndex = 13;
            // 
            // Site
            // 
            this.Site.AutoSize = true;
            this.Site.Location = new System.Drawing.Point(292, 455);
            this.Site.Name = "Site";
            this.Site.Size = new System.Drawing.Size(32, 17);
            this.Site.TabIndex = 14;
            this.Site.Text = "Site";
            // 
            // buttonModification
            // 
            this.buttonModification.Location = new System.Drawing.Point(564, 498);
            this.buttonModification.Name = "buttonModification";
            this.buttonModification.Size = new System.Drawing.Size(95, 24);
            this.buttonModification.TabIndex = 15;
            this.buttonModification.Text = "Modifier";
            this.buttonModification.UseVisualStyleBackColor = true;
            this.buttonModification.Click += new System.EventHandler(this.buttonModification_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(402, 498);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(95, 24);
            this.ButtonCancel.TabIndex = 16;
            this.ButtonCancel.Text = "Annuler";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // comboBoxObservateur
            // 
            this.comboBoxObservateur.FormattingEnabled = true;
            this.comboBoxObservateur.Location = new System.Drawing.Point(469, 117);
            this.comboBoxObservateur.Name = "comboBoxObservateur";
            this.comboBoxObservateur.Size = new System.Drawing.Size(121, 24);
            this.comboBoxObservateur.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Observateur";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 570);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxObservateur);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.buttonModification);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Modification d\'une observation";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tempsObsInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPersContactInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPersObsInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titre;
        private System.Windows.Forms.DateTimePicker dateInput;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.NumericUpDown tempsObsInput;
        private System.Windows.Forms.Label tempsObs;
        private System.Windows.Forms.NumericUpDown nbPersContactInput;
        private System.Windows.Forms.Label nbPersContact;
        private System.Windows.Forms.NumericUpDown nbPersObsInput;
        private System.Windows.Forms.Label nbPersObs;
        private System.Windows.Forms.ComboBox comboBoxEquipe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxZone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSite;
        private System.Windows.Forms.Label Site;
        private System.Windows.Forms.Button buttonModification;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.ComboBox comboBoxObservateur;
        private System.Windows.Forms.Label label3;
    }
}