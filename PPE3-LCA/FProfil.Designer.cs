namespace PPE3_LCA
{
    partial class FProfil
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
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.btnModifMDP = new System.Windows.Forms.Button();
            this.btnModifInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.btnValiderModif = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(12, 29);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom :";
            // 
            // txtNom
            // 
            this.txtNom.Enabled = false;
            this.txtNom.Location = new System.Drawing.Point(53, 26);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 1;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(12, 66);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(49, 13);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "Prénom :";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Enabled = false;
            this.txtPrenom.Location = new System.Drawing.Point(67, 63);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom.TabIndex = 3;
            // 
            // btnModifMDP
            // 
            this.btnModifMDP.Location = new System.Drawing.Point(15, 415);
            this.btnModifMDP.Name = "btnModifMDP";
            this.btnModifMDP.Size = new System.Drawing.Size(160, 23);
            this.btnModifMDP.TabIndex = 4;
            this.btnModifMDP.Text = "Modifier le mot de passe";
            this.btnModifMDP.UseVisualStyleBackColor = true;
            // 
            // btnModifInfo
            // 
            this.btnModifInfo.Location = new System.Drawing.Point(181, 415);
            this.btnModifInfo.Name = "btnModifInfo";
            this.btnModifInfo.Size = new System.Drawing.Size(160, 23);
            this.btnModifInfo.TabIndex = 5;
            this.btnModifInfo.Text = "Modifier les informations";
            this.btnModifInfo.UseVisualStyleBackColor = true;
            this.btnModifInfo.Click += new System.EventHandler(this.BtnModifInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Identifiant :";
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Enabled = false;
            this.txtIdentifiant.Location = new System.Drawing.Point(89, 98);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(100, 20);
            this.txtIdentifiant.TabIndex = 7;
            // 
            // btnValiderModif
            // 
            this.btnValiderModif.Location = new System.Drawing.Point(17, 177);
            this.btnValiderModif.Name = "btnValiderModif";
            this.btnValiderModif.Size = new System.Drawing.Size(172, 23);
            this.btnValiderModif.TabIndex = 8;
            this.btnValiderModif.Text = "Valider les modifications";
            this.btnValiderModif.UseVisualStyleBackColor = true;
            this.btnValiderModif.Visible = false;
            this.btnValiderModif.Click += new System.EventHandler(this.BtnValiderModif_Click);
            // 
            // FProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnValiderModif);
            this.Controls.Add(this.txtIdentifiant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModifInfo);
            this.Controls.Add(this.btnModifMDP);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNom);
            this.Name = "FProfil";
            this.Text = "Profil";
            this.Load += new System.EventHandler(this.FProfil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Button btnModifMDP;
        private System.Windows.Forms.Button btnModifInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.Button btnValiderModif;
    }
}