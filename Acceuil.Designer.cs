
namespace csse3
{
    partial class Acceuil
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_connexion = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_responsable = new System.Windows.Forms.Button();
            this.bt_AgentAdministratif = new System.Windows.Forms.Button();
            this.bt_conseillere = new System.Windows.Forms.Button();
            this.bt_directeur = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.bt_connexion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 31);
            this.panel1.TabIndex = 0;
            // 
            // bt_connexion
            // 
            this.bt_connexion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_connexion.FlatAppearance.BorderSize = 0;
            this.bt_connexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_connexion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_connexion.Image = global::csse3.Properties.Resources.icons8_shutdown_24px;
            this.bt_connexion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_connexion.Location = new System.Drawing.Point(819, 0);
            this.bt_connexion.Name = "bt_connexion";
            this.bt_connexion.Size = new System.Drawing.Size(124, 31);
            this.bt_connexion.TabIndex = 0;
            this.bt_connexion.Text = "      Se Connecter";
            this.bt_connexion.UseVisualStyleBackColor = false;
            this.bt_connexion.Click += new System.EventHandler(this.bt_connexion_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Controls.Add(this.bt_responsable);
            this.panel3.Controls.Add(this.bt_AgentAdministratif);
            this.panel3.Controls.Add(this.bt_conseillere);
            this.panel3.Controls.Add(this.bt_directeur);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 405);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(943, 139);
            this.panel3.TabIndex = 2;
            // 
            // bt_responsable
            // 
            this.bt_responsable.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_responsable.Enabled = false;
            this.bt_responsable.FlatAppearance.BorderSize = 0;
            this.bt_responsable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_responsable.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_responsable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_responsable.Image = global::csse3.Properties.Resources.icons8_male_user_100px;
            this.bt_responsable.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_responsable.Location = new System.Drawing.Point(706, 0);
            this.bt_responsable.Name = "bt_responsable";
            this.bt_responsable.Size = new System.Drawing.Size(230, 138);
            this.bt_responsable.TabIndex = 6;
            this.bt_responsable.Text = "Responsable Formation Evénement";
            this.bt_responsable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_responsable.UseVisualStyleBackColor = false;
            this.bt_responsable.Click += new System.EventHandler(this.bt_responsable_Click);
            // 
            // bt_AgentAdministratif
            // 
            this.bt_AgentAdministratif.Enabled = false;
            this.bt_AgentAdministratif.FlatAppearance.BorderSize = 0;
            this.bt_AgentAdministratif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AgentAdministratif.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_AgentAdministratif.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_AgentAdministratif.Image = global::csse3.Properties.Resources.icons8_male_user_100px;
            this.bt_AgentAdministratif.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_AgentAdministratif.Location = new System.Drawing.Point(467, 0);
            this.bt_AgentAdministratif.Name = "bt_AgentAdministratif";
            this.bt_AgentAdministratif.Size = new System.Drawing.Size(233, 138);
            this.bt_AgentAdministratif.TabIndex = 5;
            this.bt_AgentAdministratif.Text = "Agent Administratif ";
            this.bt_AgentAdministratif.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_AgentAdministratif.UseVisualStyleBackColor = true;
            this.bt_AgentAdministratif.Click += new System.EventHandler(this.bt_AgentAdministratif_Click);
            // 
            // bt_conseillere
            // 
            this.bt_conseillere.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_conseillere.Enabled = false;
            this.bt_conseillere.FlatAppearance.BorderSize = 0;
            this.bt_conseillere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_conseillere.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_conseillere.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_conseillere.Image = global::csse3.Properties.Resources.icons8_male_user_100px;
            this.bt_conseillere.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_conseillere.Location = new System.Drawing.Point(226, 0);
            this.bt_conseillere.Name = "bt_conseillere";
            this.bt_conseillere.Size = new System.Drawing.Size(235, 141);
            this.bt_conseillere.TabIndex = 4;
            this.bt_conseillere.Text = "Conseillére Relation Clientelle";
            this.bt_conseillere.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_conseillere.UseVisualStyleBackColor = false;
            this.bt_conseillere.Click += new System.EventHandler(this.bt_conseillere_Click);
            // 
            // bt_directeur
            // 
            this.bt_directeur.Enabled = false;
            this.bt_directeur.FlatAppearance.BorderSize = 0;
            this.bt_directeur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_directeur.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_directeur.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_directeur.Image = global::csse3.Properties.Resources.icons8_male_user_100px;
            this.bt_directeur.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_directeur.Location = new System.Drawing.Point(3, 2);
            this.bt_directeur.Name = "bt_directeur";
            this.bt_directeur.Size = new System.Drawing.Size(217, 134);
            this.bt_directeur.TabIndex = 3;
            this.bt_directeur.Text = "Directeur";
            this.bt_directeur.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_directeur.UseVisualStyleBackColor = true;
            this.bt_directeur.Click += new System.EventHandler(this.bt_directeur_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::csse3.Properties.Resources.sticker_citation_papillon_bienvenue_chez_nous_60;
            this.pictureBox1.Location = new System.Drawing.Point(167, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(610, 237);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(0, 34);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(943, 382);
            this.panel4.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(943, 55);
            this.panel2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(508, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Evénements";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(662, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Coaching";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(793, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Formation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "CCSE";
            // 
            // Acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(943, 544);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Acceuil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceuil";
            this.Load += new System.EventHandler(this.Acceuil_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bt_responsable;
        private System.Windows.Forms.Button bt_AgentAdministratif;
        private System.Windows.Forms.Button bt_conseillere;
        private System.Windows.Forms.Button bt_directeur;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_connexion;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}