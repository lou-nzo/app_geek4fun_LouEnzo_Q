namespace app_geek4fun_LouEnzo_Q
{
    partial class choix
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
            this.btnUti = new System.Windows.Forms.Button();
            this.btnSommaire = new System.Windows.Forms.Button();
            this.btnTheme = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnDeco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUti
            // 
            this.btnUti.Location = new System.Drawing.Point(568, 382);
            this.btnUti.Name = "btnUti";
            this.btnUti.Size = new System.Drawing.Size(284, 53);
            this.btnUti.TabIndex = 11;
            this.btnUti.Text = "Gérer les utilisateurs";
            this.btnUti.UseVisualStyleBackColor = true;
            // 
            // btnSommaire
            // 
            this.btnSommaire.Location = new System.Drawing.Point(568, 305);
            this.btnSommaire.Name = "btnSommaire";
            this.btnSommaire.Size = new System.Drawing.Size(284, 53);
            this.btnSommaire.TabIndex = 10;
            this.btnSommaire.Text = "Sommaire";
            this.btnSommaire.UseVisualStyleBackColor = true;
            // 
            // btnTheme
            // 
            this.btnTheme.Location = new System.Drawing.Point(568, 228);
            this.btnTheme.Name = "btnTheme";
            this.btnTheme.Size = new System.Drawing.Size(284, 53);
            this.btnTheme.TabIndex = 9;
            this.btnTheme.Text = "les Thèmes";
            this.btnTheme.UseVisualStyleBackColor = true;
            this.btnTheme.Click += new System.EventHandler(this.btnTheme_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.Red;
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.Color.Black;
            this.btnQuitter.Location = new System.Drawing.Point(1180, 559);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(168, 59);
            this.btnQuitter.TabIndex = 12;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(561, 47);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(291, 42);
            this.lblTitre.TabIndex = 23;
            this.lblTitre.Text = "Choisie la page";
            // 
            // btnDeco
            // 
            this.btnDeco.BackColor = System.Drawing.Color.RosyBrown;
            this.btnDeco.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeco.ForeColor = System.Drawing.Color.Black;
            this.btnDeco.Location = new System.Drawing.Point(161, 559);
            this.btnDeco.Name = "btnDeco";
            this.btnDeco.Size = new System.Drawing.Size(238, 59);
            this.btnDeco.TabIndex = 24;
            this.btnDeco.Text = "Deconnexion ";
            this.btnDeco.UseVisualStyleBackColor = false;
            this.btnDeco.Click += new System.EventHandler(this.btnDeco_Click);
            // 
            // choix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 655);
            this.Controls.Add(this.btnDeco);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnUti);
            this.Controls.Add(this.btnSommaire);
            this.Controls.Add(this.btnTheme);
            this.Name = "choix";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUti;
        private System.Windows.Forms.Button btnSommaire;
        private System.Windows.Forms.Button btnTheme;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnDeco;
    }
}