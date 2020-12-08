namespace PPE3_LCA
{
    partial class FListeVisiteur
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
            this.rbParSecteur = new System.Windows.Forms.RadioButton();
            this.rbParRegion = new System.Windows.Forms.RadioButton();
            this.cboPar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbParSecteur
            // 
            this.rbParSecteur.AutoSize = true;
            this.rbParSecteur.Location = new System.Drawing.Point(286, 44);
            this.rbParSecteur.Name = "rbParSecteur";
            this.rbParSecteur.Size = new System.Drawing.Size(79, 17);
            this.rbParSecteur.TabIndex = 1;
            this.rbParSecteur.TabStop = true;
            this.rbParSecteur.Text = "Par secteur";
            this.rbParSecteur.UseVisualStyleBackColor = true;
            // 
            // rbParRegion
            // 
            this.rbParRegion.AutoSize = true;
            this.rbParRegion.Location = new System.Drawing.Point(460, 44);
            this.rbParRegion.Name = "rbParRegion";
            this.rbParRegion.Size = new System.Drawing.Size(73, 17);
            this.rbParRegion.TabIndex = 2;
            this.rbParRegion.TabStop = true;
            this.rbParRegion.Text = "Par région";
            this.rbParRegion.UseVisualStyleBackColor = true;
            // 
            // cboPar
            // 
            this.cboPar.FormattingEnabled = true;
            this.cboPar.Location = new System.Drawing.Point(327, 100);
            this.cboPar.Name = "cboPar";
            this.cboPar.Size = new System.Drawing.Size(121, 21);
            this.cboPar.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nom";
            // 
            // FListeVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboPar);
            this.Controls.Add(this.rbParRegion);
            this.Controls.Add(this.rbParSecteur);
            this.Name = "FListeVisiteur";
            this.Text = "Liste des visiteurs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbParSecteur;
        private System.Windows.Forms.RadioButton rbParRegion;
        private System.Windows.Forms.ComboBox cboPar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}