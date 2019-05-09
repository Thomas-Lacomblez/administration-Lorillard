namespace ppe_lorillard
{
    partial class Form4
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
            this.buttonModificationSite = new System.Windows.Forms.Button();
            this.Titre = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.Nom = new System.Windows.Forms.Label();
            this.Adresse = new System.Windows.Forms.Label();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(334, 304);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(95, 24);
            this.ButtonCancel.TabIndex = 35;
            this.ButtonCancel.Text = "Annuler";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonModificationSite
            // 
            this.buttonModificationSite.Location = new System.Drawing.Point(497, 304);
            this.buttonModificationSite.Name = "buttonModificationSite";
            this.buttonModificationSite.Size = new System.Drawing.Size(95, 24);
            this.buttonModificationSite.TabIndex = 34;
            this.buttonModificationSite.Text = "Modifier";
            this.buttonModificationSite.UseVisualStyleBackColor = true;
            this.buttonModificationSite.Click += new System.EventHandler(this.buttonModificationSite_Click);
            // 
            // Titre
            // 
            this.Titre.AutoSize = true;
            this.Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Titre.Location = new System.Drawing.Point(253, 9);
            this.Titre.Name = "Titre";
            this.Titre.Size = new System.Drawing.Size(437, 48);
            this.Titre.TabIndex = 19;
            this.Titre.Text = "Modification du Site n°";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(440, 131);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(100, 22);
            this.textBoxNom.TabIndex = 36;
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Location = new System.Drawing.Point(311, 131);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(46, 17);
            this.Nom.TabIndex = 37;
            this.Nom.Text = "label1";
            // 
            // Adresse
            // 
            this.Adresse.AutoSize = true;
            this.Adresse.Location = new System.Drawing.Point(311, 222);
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(60, 17);
            this.Adresse.TabIndex = 38;
            this.Adresse.Text = "Adresse";
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(440, 219);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(100, 22);
            this.textBoxAdresse.TabIndex = 39;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 420);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.Adresse);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.buttonModificationSite);
            this.Controls.Add(this.Titre);
            this.Name = "Form4";
            this.Text = "Modification Site";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button buttonModificationSite;
        private System.Windows.Forms.Label Titre;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.Label Adresse;
        private System.Windows.Forms.TextBox textBoxAdresse;
    }
}