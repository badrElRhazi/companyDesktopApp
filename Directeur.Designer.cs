
namespace csse3
{
    partial class Directeur
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
            this.pi_min = new System.Windows.Forms.PictureBox();
            this.pi_max = new System.Windows.Forms.PictureBox();
            this.bt_restaurer = new System.Windows.Forms.Button();
            this.bt_Fermer = new System.Windows.Forms.Button();
            this.pi_menu = new System.Windows.Forms.PictureBox();
            this.pa_menuGlobal = new System.Windows.Forms.Panel();
            this.bt_parametre = new System.Windows.Forms.Button();
            this.bt_Conge = new System.Windows.Forms.Button();
            this.bt_Formateur = new System.Windows.Forms.Button();
            this.bt_Equipe = new System.Windows.Forms.Button();
            this.bt_Evenement = new System.Windows.Forms.Button();
            this.bt_agenda = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.bt_ChangeMP = new System.Windows.Forms.Button();
            this.bt_Deconncte = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pi_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi_menu)).BeginInit();
            this.pa_menuGlobal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.pi_min);
            this.panel1.Controls.Add(this.pi_max);
            this.panel1.Controls.Add(this.bt_restaurer);
            this.panel1.Controls.Add(this.bt_Fermer);
            this.panel1.Controls.Add(this.pi_menu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 47);
            this.panel1.TabIndex = 0;
            // 
            // pi_min
            // 
            this.pi_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pi_min.Image = global::csse3.Properties.Resources.icons8_group_objects_80px;
            this.pi_min.Location = new System.Drawing.Point(942, 17);
            this.pi_min.Name = "pi_min";
            this.pi_min.Size = new System.Drawing.Size(30, 30);
            this.pi_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pi_min.TabIndex = 6;
            this.pi_min.TabStop = false;
            this.pi_min.Visible = false;
            this.pi_min.Click += new System.EventHandler(this.pi_min_Click);
            // 
            // pi_max
            // 
            this.pi_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pi_max.Image = global::csse3.Properties.Resources.icons8_rounded_square_24px;
            this.pi_max.Location = new System.Drawing.Point(942, 12);
            this.pi_max.Name = "pi_max";
            this.pi_max.Size = new System.Drawing.Size(30, 30);
            this.pi_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pi_max.TabIndex = 5;
            this.pi_max.TabStop = false;
            this.pi_max.Click += new System.EventHandler(this.pi_max_Click);
            // 
            // bt_restaurer
            // 
            this.bt_restaurer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_restaurer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_restaurer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_restaurer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_restaurer.Location = new System.Drawing.Point(906, 12);
            this.bt_restaurer.Name = "bt_restaurer";
            this.bt_restaurer.Size = new System.Drawing.Size(30, 30);
            this.bt_restaurer.TabIndex = 3;
            this.bt_restaurer.Text = "__";
            this.bt_restaurer.UseVisualStyleBackColor = true;
            this.bt_restaurer.Click += new System.EventHandler(this.bt_restaurer_Click);
            // 
            // bt_Fermer
            // 
            this.bt_Fermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Fermer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_Fermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Fermer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Fermer.Location = new System.Drawing.Point(976, 11);
            this.bt_Fermer.Name = "bt_Fermer";
            this.bt_Fermer.Size = new System.Drawing.Size(30, 30);
            this.bt_Fermer.TabIndex = 2;
            this.bt_Fermer.Text = "X";
            this.bt_Fermer.UseVisualStyleBackColor = true;
            this.bt_Fermer.Click += new System.EventHandler(this.bt_Fermer_Click);
            // 
            // pi_menu
            // 
            this.pi_menu.Image = global::csse3.Properties.Resources.icons8_menu_50px_1;
            this.pi_menu.Location = new System.Drawing.Point(12, 11);
            this.pi_menu.Name = "pi_menu";
            this.pi_menu.Size = new System.Drawing.Size(30, 30);
            this.pi_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pi_menu.TabIndex = 0;
            this.pi_menu.TabStop = false;
            this.pi_menu.Click += new System.EventHandler(this.pi_menu_Click);
            // 
            // pa_menuGlobal
            // 
            this.pa_menuGlobal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pa_menuGlobal.Controls.Add(this.bt_parametre);
            this.pa_menuGlobal.Controls.Add(this.bt_Conge);
            this.pa_menuGlobal.Controls.Add(this.bt_Formateur);
            this.pa_menuGlobal.Controls.Add(this.bt_Equipe);
            this.pa_menuGlobal.Controls.Add(this.bt_Evenement);
            this.pa_menuGlobal.Controls.Add(this.bt_agenda);
            this.pa_menuGlobal.Controls.Add(this.panel3);
            this.pa_menuGlobal.Controls.Add(this.pictureBox2);
            this.pa_menuGlobal.Dock = System.Windows.Forms.DockStyle.Left;
            this.pa_menuGlobal.Location = new System.Drawing.Point(0, 47);
            this.pa_menuGlobal.Name = "pa_menuGlobal";
            this.pa_menuGlobal.Size = new System.Drawing.Size(145, 510);
            this.pa_menuGlobal.TabIndex = 0;
            // 
            // bt_parametre
            // 
            this.bt_parametre.FlatAppearance.BorderSize = 0;
            this.bt_parametre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_parametre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_parametre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_parametre.Image = global::csse3.Properties.Resources.icons8_services_30px;
            this.bt_parametre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_parametre.Location = new System.Drawing.Point(-3, 430);
            this.bt_parametre.Name = "bt_parametre";
            this.bt_parametre.Size = new System.Drawing.Size(152, 38);
            this.bt_parametre.TabIndex = 8;
            this.bt_parametre.Text = "       Paramètres";
            this.bt_parametre.UseVisualStyleBackColor = true;
            this.bt_parametre.Click += new System.EventHandler(this.bt_parametre_Click);
            // 
            // bt_Conge
            // 
            this.bt_Conge.FlatAppearance.BorderSize = 0;
            this.bt_Conge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Conge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Conge.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Conge.Image = global::csse3.Properties.Resources.icons8_attendance_30px1;
            this.bt_Conge.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Conge.Location = new System.Drawing.Point(0, 371);
            this.bt_Conge.Name = "bt_Conge";
            this.bt_Conge.Size = new System.Drawing.Size(152, 38);
            this.bt_Conge.TabIndex = 7;
            this.bt_Conge.Text = "       Congé";
            this.bt_Conge.UseVisualStyleBackColor = true;
            this.bt_Conge.Click += new System.EventHandler(this.bt_Conge_Click);
            // 
            // bt_Formateur
            // 
            this.bt_Formateur.FlatAppearance.BorderSize = 0;
            this.bt_Formateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Formateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Formateur.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Formateur.Image = global::csse3.Properties.Resources.icons8_user_group_30px;
            this.bt_Formateur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Formateur.Location = new System.Drawing.Point(-3, 300);
            this.bt_Formateur.Name = "bt_Formateur";
            this.bt_Formateur.Size = new System.Drawing.Size(152, 38);
            this.bt_Formateur.TabIndex = 6;
            this.bt_Formateur.Text = "       Employé";
            this.bt_Formateur.UseVisualStyleBackColor = true;
            this.bt_Formateur.Click += new System.EventHandler(this.bt_Formateur_Click);
            // 
            // bt_Equipe
            // 
            this.bt_Equipe.FlatAppearance.BorderSize = 0;
            this.bt_Equipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Equipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Equipe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Equipe.Image = global::csse3.Properties.Resources.icons8_conference_24px;
            this.bt_Equipe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Equipe.Location = new System.Drawing.Point(-3, 169);
            this.bt_Equipe.Name = "bt_Equipe";
            this.bt_Equipe.Size = new System.Drawing.Size(152, 39);
            this.bt_Equipe.TabIndex = 5;
            this.bt_Equipe.Text = "       Equipe";
            this.bt_Equipe.UseVisualStyleBackColor = true;
            this.bt_Equipe.Click += new System.EventHandler(this.bt_Equipe_Click);
            // 
            // bt_Evenement
            // 
            this.bt_Evenement.FlatAppearance.BorderSize = 0;
            this.bt_Evenement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Evenement.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Evenement.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Evenement.Image = global::csse3.Properties.Resources.icons8_calendar_6_24px;
            this.bt_Evenement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Evenement.Location = new System.Drawing.Point(0, 232);
            this.bt_Evenement.Name = "bt_Evenement";
            this.bt_Evenement.Size = new System.Drawing.Size(152, 38);
            this.bt_Evenement.TabIndex = 3;
            this.bt_Evenement.Text = "       Evénements";
            this.bt_Evenement.UseVisualStyleBackColor = true;
            this.bt_Evenement.Click += new System.EventHandler(this.bt_Evenement_Click);
            // 
            // bt_agenda
            // 
            this.bt_agenda.FlatAppearance.BorderSize = 0;
            this.bt_agenda.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_agenda.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.bt_agenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_agenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_agenda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_agenda.Image = global::csse3.Properties.Resources.icons8_calendar_30_24px;
            this.bt_agenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_agenda.Location = new System.Drawing.Point(-3, 99);
            this.bt_agenda.Name = "bt_agenda";
            this.bt_agenda.Size = new System.Drawing.Size(148, 38);
            this.bt_agenda.TabIndex = 2;
            this.bt_agenda.Text = "       Agenda";
            this.bt_agenda.UseVisualStyleBackColor = true;
            this.bt_agenda.Click += new System.EventHandler(this.bt_agenda_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(3, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(152, 1);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::csse3.Properties.Resources.icons8_male_user_100px;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(149, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(145, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(873, 510);
            this.panel2.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Location = new System.Drawing.Point(1, 113);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(166, 83);
            this.panel4.TabIndex = 18;
            this.panel4.Visible = false;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Image = global::csse3.Properties.Resources.icons8_calendar_30_24px;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 33);
            this.button3.TabIndex = 4;
            this.button3.Text = "       Aujourd\'hui";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::csse3.Properties.Resources.icons8_calendar_30_24px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "       Agenda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel7.Controls.Add(this.bt_ChangeMP);
            this.panel7.Controls.Add(this.bt_Deconncte);
            this.panel7.Location = new System.Drawing.Point(0, 427);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(169, 83);
            this.panel7.TabIndex = 17;
            this.panel7.Visible = false;
            // 
            // bt_ChangeMP
            // 
            this.bt_ChangeMP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.bt_ChangeMP.FlatAppearance.BorderSize = 0;
            this.bt_ChangeMP.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.bt_ChangeMP.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.bt_ChangeMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ChangeMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ChangeMP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_ChangeMP.Image = global::csse3.Properties.Resources.icons8_services_30px;
            this.bt_ChangeMP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_ChangeMP.Location = new System.Drawing.Point(-2, 3);
            this.bt_ChangeMP.Name = "bt_ChangeMP";
            this.bt_ChangeMP.Size = new System.Drawing.Size(168, 38);
            this.bt_ChangeMP.TabIndex = 11;
            this.bt_ChangeMP.Text = "           Change de Mot de passe";
            this.bt_ChangeMP.UseVisualStyleBackColor = false;
            this.bt_ChangeMP.Click += new System.EventHandler(this.bt_ChangeMP_Click);
            // 
            // bt_Deconncte
            // 
            this.bt_Deconncte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.bt_Deconncte.FlatAppearance.BorderSize = 0;
            this.bt_Deconncte.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.bt_Deconncte.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.bt_Deconncte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Deconncte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Deconncte.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Deconncte.Image = global::csse3.Properties.Resources.icons8_shutdown_24px;
            this.bt_Deconncte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Deconncte.Location = new System.Drawing.Point(6, 50);
            this.bt_Deconncte.Name = "bt_Deconncte";
            this.bt_Deconncte.Size = new System.Drawing.Size(157, 38);
            this.bt_Deconncte.TabIndex = 13;
            this.bt_Deconncte.Text = "   Déconnécté";
            this.bt_Deconncte.UseVisualStyleBackColor = false;
            this.bt_Deconncte.Click += new System.EventHandler(this.bt_Deconncte_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::csse3.Properties.Resources.Directeur;
            this.pictureBox1.Location = new System.Drawing.Point(115, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(658, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Directeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1018, 557);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pa_menuGlobal);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Directeur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Directeur";
            this.Load += new System.EventHandler(this.Directeur_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pi_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi_menu)).EndInit();
            this.pa_menuGlobal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pi_menu;
        private System.Windows.Forms.Panel pa_menuGlobal;
        private System.Windows.Forms.Button bt_parametre;
        private System.Windows.Forms.Button bt_Conge;
        private System.Windows.Forms.Button bt_Formateur;
        private System.Windows.Forms.Button bt_Equipe;
        private System.Windows.Forms.Button bt_Evenement;
        private System.Windows.Forms.Button bt_agenda;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button bt_Fermer;
        private System.Windows.Forms.Button bt_restaurer;
        private System.Windows.Forms.PictureBox pi_max;
        private System.Windows.Forms.PictureBox pi_min;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button bt_ChangeMP;
        private System.Windows.Forms.Button bt_Deconncte;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}