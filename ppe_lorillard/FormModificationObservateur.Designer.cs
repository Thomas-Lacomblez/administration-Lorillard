namespace ppe_lorillard
{
    partial class FormModificationObservateur
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
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.buttonModificationObservateur = new System.Windows.Forms.Button();
            this.Titre = new System.Windows.Forms.Label();
            this.MotDePasse = new System.Windows.Forms.Label();
            this.textBoxMdp = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.Identifiant = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.Prénom = new System.Windows.Forms.Label();
            this.NomDeFamille = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(318, 340);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(96, 25);
            this.ButtonCancel.TabIndex = 42;
            this.ButtonCancel.Text = "Annuler";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonModificationObservateur
            // 
            this.buttonModificationObservateur.Location = new System.Drawing.Point(463, 340);
            this.buttonModificationObservateur.Name = "buttonModificationObservateur";
            this.buttonModificationObservateur.Size = new System.Drawing.Size(102, 25);
            this.buttonModificationObservateur.TabIndex = 41;
            this.buttonModificationObservateur.Text = "Modifier";
            this.buttonModificationObservateur.UseVisualStyleBackColor = true;
            this.buttonModificationObservateur.Click += new System.EventHandler(this.buttonModificationObservateur_Click);
            // 
            // Titre
            // 
            this.Titre.AutoSize = true;
            this.Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Titre.Location = new System.Drawing.Point(148, 9);
            this.Titre.Name = "Titre";
            this.Titre.Size = new System.Drawing.Size(574, 48);
            this.Titre.TabIndex = 40;
            this.Titre.Text = "Modification d\'un Observateur";
            // 
            // MotDePasse
            // 
            this.MotDePasse.AutoSize = true;
            this.MotDePasse.Location = new System.Drawing.Point(220, 277);
            this.MotDePasse.Name = "MotDePasse";
            this.MotDePasse.Size = new System.Drawing.Size(94, 17);
            this.MotDePasse.TabIndex = 71;
            this.MotDePasse.Text = "Mot de Passe";
            // 
            // textBoxMdp
            // 
            this.textBoxMdp.Location = new System.Drawing.Point(361, 272);
            this.textBoxMdp.Name = "textBoxMdp";
            this.textBoxMdp.Size = new System.Drawing.Size(204, 22);
            this.textBoxMdp.TabIndex = 70;
            this.textBoxMdp.Text = "Votre mot de passe";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(361, 227);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(204, 22);
            this.textBoxId.TabIndex = 69;
            this.textBoxId.Text = "Votre Identifiant";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(361, 184);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(204, 22);
            this.textBoxEmail.TabIndex = 68;
            this.textBoxEmail.Text = "Votre Email";
            // 
            // Identifiant
            // 
            this.Identifiant.AutoSize = true;
            this.Identifiant.Location = new System.Drawing.Point(220, 227);
            this.Identifiant.Name = "Identifiant";
            this.Identifiant.Size = new System.Drawing.Size(69, 17);
            this.Identifiant.TabIndex = 67;
            this.Identifiant.Text = "Identifiant";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(220, 184);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(42, 17);
            this.Email.TabIndex = 66;
            this.Email.Text = "Email";
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(361, 139);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(204, 22);
            this.textBoxPrenom.TabIndex = 65;
            this.textBoxPrenom.Text = "Votre Prénom";
            // 
            // Prénom
            // 
            this.Prénom.AutoSize = true;
            this.Prénom.Location = new System.Drawing.Point(220, 139);
            this.Prénom.Name = "Prénom";
            this.Prénom.Size = new System.Drawing.Size(57, 17);
            this.Prénom.TabIndex = 64;
            this.Prénom.Text = "Prénom";
            // 
            // NomDeFamille
            // 
            this.NomDeFamille.AutoSize = true;
            this.NomDeFamille.Location = new System.Drawing.Point(209, 92);
            this.NomDeFamille.Name = "NomDeFamille";
            this.NomDeFamille.Size = new System.Drawing.Size(105, 17);
            this.NomDeFamille.TabIndex = 63;
            this.NomDeFamille.Text = "Nom de Famille";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(361, 92);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(204, 22);
            this.textBoxNom.TabIndex = 62;
            this.textBoxNom.Text = "Votre nom de famille";
            // 
            // FormModificationObservateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.buttonModificationObservateur);
            this.Controls.Add(this.Titre);
            this.Name = "FormModificationObservateur";
            this.Text = "Modification d\'un Observateur";
            this.Load += new System.EventHandler(this.FormModificationObservateur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button buttonModificationObservateur;
        private System.Windows.Forms.Label Titre;
        private System.Windows.Forms.Label MotDePasse;
        private System.Windows.Forms.TextBox textBoxMdp;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label Identifiant;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label Prénom;
        private System.Windows.Forms.Label NomDeFamille;
        private System.Windows.Forms.TextBox textBoxNom;
    }
}