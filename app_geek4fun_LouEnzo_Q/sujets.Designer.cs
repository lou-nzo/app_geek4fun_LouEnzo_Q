namespace app_geek4fun_LouEnzo_Q
{
    partial class sujets
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
            this.lblTheme = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblTitreSujet = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheme.Location = new System.Drawing.Point(61, 20);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(126, 42);
            this.lblTheme.TabIndex = 24;
            this.lblTheme.Text = "theme";
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.Red;
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.Color.Black;
            this.btnQuitter.Location = new System.Drawing.Point(1258, 571);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(168, 59);
            this.btnQuitter.TabIndex = 28;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.RosyBrown;
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.ForeColor = System.Drawing.Color.Black;
            this.btnRetour.Location = new System.Drawing.Point(14, 571);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(168, 59);
            this.btnRetour.TabIndex = 29;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(29, -43);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1022, 527);
            this.listView1.TabIndex = 30;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lblTitreSujet
            // 
            this.lblTitreSujet.AutoSize = true;
            this.lblTitreSujet.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreSujet.Location = new System.Drawing.Point(435, 3);
            this.lblTitreSujet.Name = "lblTitreSujet";
            this.lblTitreSujet.Size = new System.Drawing.Size(196, 42);
            this.lblTitreSujet.TabIndex = 25;
            this.lblTitreSujet.Text = "Text Sujet";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1025, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 484);
            this.vScrollBar1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "le text du sujet ";
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.LimeGreen;
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.Color.Black;
            this.btnValider.Location = new System.Drawing.Point(451, 425);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(168, 59);
            this.btnValider.TabIndex = 30;
            this.btnValider.Text = "Valider Theme";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnValider);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.vScrollBar1);
            this.panel1.Controls.Add(this.lblTitreSujet);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Location = new System.Drawing.Point(188, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 541);
            this.panel1.TabIndex = 26;
            // 
            // sujets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 652);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTheme);
            this.Name = "sujets";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblTitreSujet;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Panel panel1;
    }
}