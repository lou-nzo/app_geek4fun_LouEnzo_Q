namespace app_geek4fun_LouEnzo_Q
{
    partial class connexion
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
            this.btnConnexion = new System.Windows.Forms.Button();
            this.lblMdp = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbMdp = new System.Windows.Forms.TextBox();
            this.lblMdpOublier = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(474, 371);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(493, 34);
            this.btnConnexion.TabIndex = 18;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Location = new System.Drawing.Point(546, 322);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(74, 13);
            this.lblMdp.TabIndex = 16;
            this.lblMdp.Text = "Mot De Passe";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(570, 281);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(33, 13);
            this.lblLogin.TabIndex = 15;
            this.lblLogin.Text = "Login";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(626, 278);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(271, 20);
            this.tbLogin.TabIndex = 12;
            // 
            // tbMdp
            // 
            this.tbMdp.Location = new System.Drawing.Point(626, 319);
            this.tbMdp.Name = "tbMdp";
            this.tbMdp.Size = new System.Drawing.Size(271, 20);
            this.tbMdp.TabIndex = 19;
            // 
            // lblMdpOublier
            // 
            this.lblMdpOublier.AutoSize = true;
            this.lblMdpOublier.Location = new System.Drawing.Point(666, 421);
            this.lblMdpOublier.Name = "lblMdpOublier";
            this.lblMdpOublier.Size = new System.Drawing.Size(114, 13);
            this.lblMdpOublier.TabIndex = 20;
            this.lblMdpOublier.Text = "Mot de passe oublier ?";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(619, 164);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(218, 42);
            this.lblTitre.TabIndex = 21;
            this.lblTitre.Text = "Connexion ";
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.Red;
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.Color.Black;
            this.btnQuitter.Location = new System.Drawing.Point(1250, 549);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(170, 66);
            this.btnQuitter.TabIndex = 22;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.RosyBrown;
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.ForeColor = System.Drawing.Color.Black;
            this.btnRetour.Location = new System.Drawing.Point(79, 549);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(168, 59);
            this.btnRetour.TabIndex = 24;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 647);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lblMdpOublier);
            this.Controls.Add(this.tbMdp);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.tbLogin);
            this.Name = "connexion";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbMdp;
        private System.Windows.Forms.Label lblMdpOublier;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnRetour;
    }
}