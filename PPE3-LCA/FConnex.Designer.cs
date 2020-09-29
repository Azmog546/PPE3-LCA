namespace PPE3_LCA
{
    partial class FConnex
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
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.panelConnexion = new System.Windows.Forms.Panel();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.panelConnexion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Location = new System.Drawing.Point(68, 46);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(53, 13);
            this.lblIdentifiant.TabIndex = 0;
            this.lblIdentifiant.Text = "Identifiant";
            // 
            // panelConnexion
            // 
            this.panelConnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelConnexion.Controls.Add(this.btnOk);
            this.panelConnexion.Controls.Add(this.btnValider);
            this.panelConnexion.Controls.Add(this.txtPassword);
            this.panelConnexion.Controls.Add(this.lblPassword);
            this.panelConnexion.Controls.Add(this.txtIdentifiant);
            this.panelConnexion.Controls.Add(this.lblIdentifiant);
            this.panelConnexion.Location = new System.Drawing.Point(-11, 0);
            this.panelConnexion.Name = "panelConnexion";
            this.panelConnexion.Size = new System.Drawing.Size(817, 455);
            this.panelConnexion.TabIndex = 1;
            this.panelConnexion.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelConnexion_Paint);
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.BackColor = System.Drawing.Color.White;
            this.txtIdentifiant.Location = new System.Drawing.Point(192, 43);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(336, 20);
            this.txtIdentifiant.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(71, 92);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(71, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Mot de passe";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(192, 89);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(336, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(281, 383);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 4;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOk.Location = new System.Drawing.Point(381, 383);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Visible = false;
            // 
            // FConnex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelConnexion);
            this.Name = "FConnex";
            this.Text = "Connexion";
            this.panelConnexion.ResumeLayout(false);
            this.panelConnexion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.Panel panelConnexion;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnOk;
    }
}