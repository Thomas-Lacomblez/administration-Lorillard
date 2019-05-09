namespace ppe_lorillard
{
    partial class FormAjoutObservateur
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
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.Prénom = new System.Windows.Forms.Label();
            this.NomDeFamille = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.buttonAjoutSite = new System.Windows.Forms.Button();
            this.Titre = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Identifiant = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxMdp = new System.Windows.Forms.TextBox();
            this.MotDePasse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(366, 149);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(204, 22);
            this.textBoxPrenom.TabIndex = 53;
            this.textBoxPrenom.Text = "Votre Prénom";
            // 
            // Prénom
            // 
            this.Prénom.AutoSize = true;
            this.Prénom.Location = new System.Drawing.Point(225, 149);
            this.Prénom.Name = "Prénom";
            this.Prénom.Size = new System.Drawing.Size(57, 17);
            this.Prénom.TabIndex = 52;
            this.Prénom.Text = "Prénom";
            // 
            // NomDeFamille
            // 
            this.NomDeFamille.AutoSize = true;
            this.NomDeFamille.Location = new System.Drawing.Point(225, 99);
            this.NomDeFamille.Name = "NomDeFamille";
            this.NomDeFamille.Size = new System.Drawing.Size(105, 17);
            this.NomDeFamille.TabIndex = 51;
            this.NomDeFamille.Text = "Nom de Famille";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(366, 99);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(204, 22);
            this.textBoxNom.TabIndex = 50;
            this.textBoxNom.Text = "Votre nom de famille";
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(280, 348);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(104, 24);
            this.ButtonCancel.TabIndex = 49;
            this.ButtonCancel.Text = "Annuler";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonAjoutSite
            // 
            this.buttonAjoutSite.Location = new System.Drawing.Point(459, 348);
            this.buttonAjoutSite.Name = "buttonAjoutSite";
            this.buttonAjoutSite.Size = new System.Drawing.Size(127, 24);
            this.buttonAjoutSite.TabIndex = 48;
            this.buttonAjoutSite.Text = "Ajouter";
            this.buttonAjoutSite.UseVisualStyleBackColor = true;
            this.buttonAjoutSite.Click += new System.EventHandler(this.buttonAjoutSite_Click);
            // 
            // Titre
            // 
            this.Titre.AutoSize = true;
            this.Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Titre.Location = new System.Drawing.Point(220, 9);
            this.Titre.Name = "Titre";
            this.Titre.Size = new System.Drawing.Size(445, 48);
            this.Titre.TabIndex = 47;
            this.Titre.Text = "Ajout d\'un Observateur";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(225, 194);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(42, 17);
            this.Email.TabIndex = 54;
            this.Email.Text = "Email";
            // 
            // Identifiant
            // 
            this.Identifiant.AutoSize = true;
            this.Identifiant.Location = new System.Drawing.Point(225, 237);
            this.Identifiant.Name = "Identifiant";
            this.Identifiant.Size = new System.Drawing.Size(69, 17);
            this.Identifiant.TabIndex = 55;
            this.Identifiant.Text = "Identifiant";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(366, 194);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(204, 22);
            this.textBoxEmail.TabIndex = 56;
            this.textBoxEmail.Text = "Votre Email";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(366, 237);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(204, 22);
            this.textBoxId.TabIndex = 57;
            this.textBoxId.Text = "Votre Identifiant";
            // 
            // textBoxMdp
            // 
            this.textBoxMdp.Location = new System.Drawing.Point(366, 282);
            this.textBoxMdp.Name = "textBoxMdp";
            this.textBoxMdp.Size = new System.Drawing.Size(204, 22);
            this.textBoxMdp.TabIndex = 58;
            this.textBoxMdp.Text = "Votre mot de passe";
            // 
            // MotDePasse
            // 
            this.MotDePasse.AutoSize = true;
            this.MotDePasse.Location = new System.Drawing.Point(225, 287);
            this.MotDePasse.Name = "MotDePasse";
            this.MotDePasse.Size = new System.Drawing.Size(94, 17);
            this.MotDePasse.TabIndex = 59;
            this.MotDePasse.Text = "Mot de Passe";
            // 
            // FormAjoutObservateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 472);
            this.ControlBox = false;
            this.Controls.Add(this.MotDePasse);
            this.Controls.Add(this.textBoxMdp);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.Identifiant);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.Prénom);
            this.Controls.Add(this.NomDeFamille);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.buttonAjoutSite);
            this.Controls.Add(this.Titre);
            this.Name = "FormAjoutObservateur";
            this.Text = "Ajout d\'un Observateur";
            this.Load += new System.EventHandler(this.FormAjoutObservateur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label Prénom;
        private System.Windows.Forms.Label NomDeFamille;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button buttonAjoutSite;
        private System.Windows.Forms.Label Titre;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Identifiant;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxMdp;
        private System.Windows.Forms.Label MotDePasse;
    }
}