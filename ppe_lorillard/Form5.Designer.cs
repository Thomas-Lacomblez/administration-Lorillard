namespace ppe_lorillard
{
    partial class Form5
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
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.Adresse = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.buttonAjoutSite = new System.Windows.Forms.Button();
            this.Titre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(467, 243);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(204, 22);
            this.textBoxAdresse.TabIndex = 46;
            this.textBoxAdresse.Text = "Ajout d\'un site";
            // 
            // Adresse
            // 
            this.Adresse.AutoSize = true;
            this.Adresse.Location = new System.Drawing.Point(338, 246);
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(97, 17);
            this.Adresse.TabIndex = 45;
            this.Adresse.Text = "Ajout d\'un site";
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Location = new System.Drawing.Point(338, 152);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(97, 17);
            this.Nom.TabIndex = 44;
            this.Nom.Text = "Ajout d\'un site";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(467, 152);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(204, 22);
            this.textBoxNom.TabIndex = 43;
            this.textBoxNom.Text = "Ajout d\'un site";
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(381, 338);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(95, 24);
            this.ButtonCancel.TabIndex = 42;
            this.ButtonCancel.Text = "Annuler";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonAjoutSite
            // 
            this.buttonAjoutSite.Location = new System.Drawing.Point(558, 338);
            this.buttonAjoutSite.Name = "buttonAjoutSite";
            this.buttonAjoutSite.Size = new System.Drawing.Size(127, 24);
            this.buttonAjoutSite.TabIndex = 41;
            this.buttonAjoutSite.Text = "Ajout d\'un site";
            this.buttonAjoutSite.UseVisualStyleBackColor = true;
            this.buttonAjoutSite.Click += new System.EventHandler(this.buttonAjoutSite_Click);
            // 
            // Titre
            // 
            this.Titre.AutoSize = true;
            this.Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Titre.Location = new System.Drawing.Point(404, 28);
            this.Titre.Name = "Titre";
            this.Titre.Size = new System.Drawing.Size(281, 48);
            this.Titre.TabIndex = 40;
            this.Titre.Text = "Ajout d\'un site";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 518);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.Adresse);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.buttonAjoutSite);
            this.Controls.Add(this.Titre);
            this.Name = "Form5";
            this.Text = "Ajout d\'un site";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.Label Adresse;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button buttonAjoutSite;
        private System.Windows.Forms.Label Titre;
    }
}