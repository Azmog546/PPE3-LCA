namespace PPE3_LCA
{
    partial class FFrais
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
            this.cbFrais = new System.Windows.Forms.ComboBox();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnAffiche = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbFrais
            // 
            this.cbFrais.FormattingEnabled = true;
            this.cbFrais.Location = new System.Drawing.Point(13, 13);
            this.cbFrais.Name = "cbFrais";
            this.cbFrais.Size = new System.Drawing.Size(139, 21);
            this.cbFrais.TabIndex = 0;
            this.cbFrais.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(215, 11);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(154, 23);
            this.btnModif.TabIndex = 1;
            this.btnModif.Text = "Créer/modifier fiche de frais";
            this.btnModif.UseVisualStyleBackColor = true;
            // 
            // btnAffiche
            // 
            this.btnAffiche.Location = new System.Drawing.Point(13, 62);
            this.btnAffiche.Name = "btnAffiche";
            this.btnAffiche.Size = new System.Drawing.Size(102, 23);
            this.btnAffiche.TabIndex = 2;
            this.btnAffiche.Text = "Affiche fiche frais";
            this.btnAffiche.UseVisualStyleBackColor = true;
            // 
            // FFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAffiche);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.cbFrais);
            this.Name = "FFrais";
            this.Text = "FFrais";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFrais;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnAffiche;
    }
}