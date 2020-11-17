namespace PPE3_LCA
{
    partial class FModifMDP
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
            this.txtNouvMDP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConfMDP = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.lblErreur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNouvMDP
            // 
            this.txtNouvMDP.Location = new System.Drawing.Point(15, 47);
            this.txtNouvMDP.Name = "txtNouvMDP";
            this.txtNouvMDP.PasswordChar = '•';
            this.txtNouvMDP.Size = new System.Drawing.Size(242, 20);
            this.txtNouvMDP.TabIndex = 0;
            this.txtNouvMDP.TextChanged += new System.EventHandler(this.TxtNouvMDP_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nouveau mot de passe :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Confirmation mot de passe :";
            // 
            // txtConfMDP
            // 
            this.txtConfMDP.Location = new System.Drawing.Point(15, 86);
            this.txtConfMDP.Name = "txtConfMDP";
            this.txtConfMDP.PasswordChar = '•';
            this.txtConfMDP.Size = new System.Drawing.Size(242, 20);
            this.txtConfMDP.TabIndex = 3;
            this.txtConfMDP.TextChanged += new System.EventHandler(this.TxtConfMDP_TextChanged);
            // 
            // btnValider
            // 
            this.btnValider.Enabled = false;
            this.btnValider.Location = new System.Drawing.Point(94, 143);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 4;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // lblErreur
            // 
            this.lblErreur.AutoSize = true;
            this.lblErreur.ForeColor = System.Drawing.Color.Red;
            this.lblErreur.Location = new System.Drawing.Point(12, 118);
            this.lblErreur.Name = "lblErreur";
            this.lblErreur.Size = new System.Drawing.Size(0, 13);
            this.lblErreur.TabIndex = 5;
            // 
            // FModifMDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 178);
            this.Controls.Add(this.lblErreur);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtConfMDP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNouvMDP);
            this.Name = "FModifMDP";
            this.Text = "Modifier le mot de passe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNouvMDP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConfMDP;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label lblErreur;
    }
}