namespace PPE3_LCA
{
    partial class FAfficheFrais
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
            this.lblVisiteur = new System.Windows.Forms.Label();
            this.txtIdVisiteur = new System.Windows.Forms.TextBox();
            this.txtNomVisiteur = new System.Windows.Forms.TextBox();
            this.lblMois = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblVisiteur
            // 
            this.lblVisiteur.AutoSize = true;
            this.lblVisiteur.Location = new System.Drawing.Point(39, 36);
            this.lblVisiteur.Name = "lblVisiteur";
            this.lblVisiteur.Size = new System.Drawing.Size(41, 13);
            this.lblVisiteur.TabIndex = 0;
            this.lblVisiteur.Text = "Visiteur";
            // 
            // txtIdVisiteur
            // 
            this.txtIdVisiteur.Location = new System.Drawing.Point(193, 33);
            this.txtIdVisiteur.Name = "txtIdVisiteur";
            this.txtIdVisiteur.ReadOnly = true;
            this.txtIdVisiteur.Size = new System.Drawing.Size(100, 20);
            this.txtIdVisiteur.TabIndex = 1;
            // 
            // txtNomVisiteur
            // 
            this.txtNomVisiteur.Location = new System.Drawing.Point(376, 33);
            this.txtNomVisiteur.Name = "txtNomVisiteur";
            this.txtNomVisiteur.ReadOnly = true;
            this.txtNomVisiteur.Size = new System.Drawing.Size(273, 20);
            this.txtNomVisiteur.TabIndex = 2;
            // 
            // lblMois
            // 
            this.lblMois.AutoSize = true;
            this.lblMois.Location = new System.Drawing.Point(39, 90);
            this.lblMois.Name = "lblMois";
            this.lblMois.Size = new System.Drawing.Size(29, 13);
            this.lblMois.TabIndex = 3;
            this.lblMois.Text = "Mois";
            // 
            // FAfficheFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMois);
            this.Controls.Add(this.txtNomVisiteur);
            this.Controls.Add(this.txtIdVisiteur);
            this.Controls.Add(this.lblVisiteur);
            this.Name = "FAfficheFrais";
            this.Text = "FAfficheFrais";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVisiteur;
        private System.Windows.Forms.TextBox txtIdVisiteur;
        private System.Windows.Forms.TextBox txtNomVisiteur;
        private System.Windows.Forms.Label lblMois;
    }
}