namespace PPE3_LCA
{
    partial class FResponsabilite
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
            this.components = new System.ComponentModel.Container();
            this.dgvRegionResp = new System.Windows.Forms.DataGridView();
            this.bsRegionResp = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSecteurResp = new System.Windows.Forms.DataGridView();
            this.bsSecteurResp = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegionResp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegionResp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecteurResp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSecteurResp)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRegionResp
            // 
            this.dgvRegionResp.AllowUserToAddRows = false;
            this.dgvRegionResp.AllowUserToDeleteRows = false;
            this.dgvRegionResp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegionResp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegionResp.Location = new System.Drawing.Point(16, 43);
            this.dgvRegionResp.Name = "dgvRegionResp";
            this.dgvRegionResp.ReadOnly = true;
            this.dgvRegionResp.RowHeadersVisible = false;
            this.dgvRegionResp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRegionResp.Size = new System.Drawing.Size(240, 150);
            this.dgvRegionResp.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Région où vous êtes responsable :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Secteur où vous êtes responsable :";
            // 
            // dgvSecteurResp
            // 
            this.dgvSecteurResp.AllowUserToAddRows = false;
            this.dgvSecteurResp.AllowUserToDeleteRows = false;
            this.dgvSecteurResp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSecteurResp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSecteurResp.Location = new System.Drawing.Point(16, 233);
            this.dgvSecteurResp.Name = "dgvSecteurResp";
            this.dgvSecteurResp.ReadOnly = true;
            this.dgvSecteurResp.RowHeadersVisible = false;
            this.dgvSecteurResp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSecteurResp.Size = new System.Drawing.Size(240, 150);
            this.dgvSecteurResp.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(97, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Aucune région";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(97, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Aucun secteur";
            // 
            // FResponsabilite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 450);
            this.Controls.Add(this.dgvSecteurResp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRegionResp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Name = "FResponsabilite";
            this.Text = "Mes responsabilités";
            this.Load += new System.EventHandler(this.FResponsabilite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegionResp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegionResp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecteurResp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSecteurResp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRegionResp;
        private System.Windows.Forms.BindingSource bsRegionResp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSecteurResp;
        private System.Windows.Forms.BindingSource bsSecteurResp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}