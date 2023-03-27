
namespace csse3
{
    partial class FormNouveauEmploye
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.cb_fonction = new System.Windows.Forms.ComboBox();
            this.txt_specialite = new System.Windows.Forms.TextBox();
            this.lb_Specialite = new System.Windows.Forms.Label();
            this.lb_fonction = new System.Windows.Forms.Label();
            this.cb_poste = new System.Windows.Forms.ComboBox();
            this.txt_diplome = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Annuler = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_mdp = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_cin = new System.Windows.Forms.TextBox();
            this.txtx_email = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Adresse = new System.Windows.Forms.TextBox();
            this.txt_lieuN = new System.Windows.Forms.TextBox();
            this.txt_Nom = new System.Windows.Forms.TextBox();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.date_n = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bt_Valider = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cb_fonction);
            this.panel3.Controls.Add(this.txt_specialite);
            this.panel3.Controls.Add(this.lb_Specialite);
            this.panel3.Controls.Add(this.lb_fonction);
            this.panel3.Controls.Add(this.cb_poste);
            this.panel3.Controls.Add(this.txt_diplome);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.bt_Annuler);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(981, 543);
            this.panel3.TabIndex = 35;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // cb_fonction
            // 
            this.cb_fonction.FormattingEnabled = true;
            this.cb_fonction.Location = new System.Drawing.Point(682, 258);
            this.cb_fonction.Name = "cb_fonction";
            this.cb_fonction.Size = new System.Drawing.Size(226, 21);
            this.cb_fonction.TabIndex = 65;
            this.cb_fonction.Visible = false;
            // 
            // txt_specialite
            // 
            this.txt_specialite.BackColor = System.Drawing.SystemColors.Control;
            this.txt_specialite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_specialite.Location = new System.Drawing.Point(682, 209);
            this.txt_specialite.Name = "txt_specialite";
            this.txt_specialite.Size = new System.Drawing.Size(226, 20);
            this.txt_specialite.TabIndex = 64;
            this.txt_specialite.Visible = false;
            // 
            // lb_Specialite
            // 
            this.lb_Specialite.AutoSize = true;
            this.lb_Specialite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Specialite.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_Specialite.Location = new System.Drawing.Point(568, 214);
            this.lb_Specialite.Name = "lb_Specialite";
            this.lb_Specialite.Size = new System.Drawing.Size(61, 15);
            this.lb_Specialite.TabIndex = 63;
            this.lb_Specialite.Text = "Spécialité";
            this.lb_Specialite.Visible = false;
            // 
            // lb_fonction
            // 
            this.lb_fonction.AutoSize = true;
            this.lb_fonction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fonction.Location = new System.Drawing.Point(568, 264);
            this.lb_fonction.Name = "lb_fonction";
            this.lb_fonction.Size = new System.Drawing.Size(57, 15);
            this.lb_fonction.TabIndex = 62;
            this.lb_fonction.Text = "Fonction:";
            this.lb_fonction.Visible = false;
            // 
            // cb_poste
            // 
            this.cb_poste.FormattingEnabled = true;
            this.cb_poste.Location = new System.Drawing.Point(682, 160);
            this.cb_poste.Name = "cb_poste";
            this.cb_poste.Size = new System.Drawing.Size(226, 21);
            this.cb_poste.TabIndex = 61;
            this.cb_poste.SelectedIndexChanged += new System.EventHandler(this.cb_poste_SelectedIndexChanged_1);
            // 
            // txt_diplome
            // 
            this.txt_diplome.BackColor = System.Drawing.SystemColors.Control;
            this.txt_diplome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_diplome.Location = new System.Drawing.Point(682, 116);
            this.txt_diplome.Name = "txt_diplome";
            this.txt_diplome.Size = new System.Drawing.Size(226, 20);
            this.txt_diplome.TabIndex = 60;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(568, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 15);
            this.label12.TabIndex = 59;
            this.label12.Text = "Poste:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(564, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 15);
            this.label11.TabIndex = 58;
            this.label11.Text = "Diplome:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(981, 42);
            this.panel2.TabIndex = 47;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::csse3.Properties.Resources.icons8_male_user_32px;
            this.pictureBox1.Location = new System.Drawing.Point(3, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(103, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(235, 32);
            this.label15.TabIndex = 48;
            this.label15.Text = "Nouveau Employé";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(575, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 31);
            this.label1.TabIndex = 38;
            this.label1.Text = "Informations Professionnel :";
            // 
            // bt_Annuler
            // 
            this.bt_Annuler.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_Annuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_Annuler.FlatAppearance.BorderSize = 0;
            this.bt_Annuler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.bt_Annuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.bt_Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Annuler.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bt_Annuler.Location = new System.Drawing.Point(549, 512);
            this.bt_Annuler.Name = "bt_Annuler";
            this.bt_Annuler.Size = new System.Drawing.Size(127, 28);
            this.bt_Annuler.TabIndex = 37;
            this.bt_Annuler.Text = "Annuler";
            this.bt_Annuler.UseVisualStyleBackColor = false;
            this.bt_Annuler.Click += new System.EventHandler(this.bt_Annuler_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txt_mdp);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txt_cin);
            this.panel1.Controls.Add(this.txtx_email);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txt_Adresse);
            this.panel1.Controls.Add(this.txt_lieuN);
            this.panel1.Controls.Add(this.txt_Nom);
            this.panel1.Controls.Add(this.txt_prenom);
            this.panel1.Controls.Add(this.txt_tel);
            this.panel1.Controls.Add(this.date_n);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.bt_Valider);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 500);
            this.panel1.TabIndex = 37;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txt_mdp
            // 
            this.txt_mdp.BackColor = System.Drawing.SystemColors.Control;
            this.txt_mdp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mdp.Location = new System.Drawing.Point(153, 425);
            this.txt_mdp.Name = "txt_mdp";
            this.txt_mdp.PasswordChar = '*';
            this.txt_mdp.Size = new System.Drawing.Size(226, 20);
            this.txt_mdp.TabIndex = 76;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(34, 430);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 18);
            this.label13.TabIndex = 75;
            this.label13.Text = "Mot De Passe :";
            // 
            // txt_cin
            // 
            this.txt_cin.BackColor = System.Drawing.SystemColors.Control;
            this.txt_cin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cin.Location = new System.Drawing.Point(153, 369);
            this.txt_cin.Name = "txt_cin";
            this.txt_cin.Size = new System.Drawing.Size(226, 20);
            this.txt_cin.TabIndex = 74;
            // 
            // txtx_email
            // 
            this.txtx_email.BackColor = System.Drawing.SystemColors.Control;
            this.txtx_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtx_email.Location = new System.Drawing.Point(153, 323);
            this.txtx_email.Name = "txtx_email";
            this.txtx_email.Size = new System.Drawing.Size(226, 20);
            this.txtx_email.TabIndex = 73;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(34, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 18);
            this.label9.TabIndex = 72;
            this.label9.Text = "Email";
            // 
            // txt_Adresse
            // 
            this.txt_Adresse.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Adresse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Adresse.Location = new System.Drawing.Point(153, 230);
            this.txt_Adresse.Name = "txt_Adresse";
            this.txt_Adresse.Size = new System.Drawing.Size(227, 20);
            this.txt_Adresse.TabIndex = 70;
            // 
            // txt_lieuN
            // 
            this.txt_lieuN.BackColor = System.Drawing.SystemColors.Control;
            this.txt_lieuN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lieuN.Location = new System.Drawing.Point(155, 189);
            this.txt_lieuN.Name = "txt_lieuN";
            this.txt_lieuN.Size = new System.Drawing.Size(225, 20);
            this.txt_lieuN.TabIndex = 69;
            // 
            // txt_Nom
            // 
            this.txt_Nom.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Nom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Nom.Location = new System.Drawing.Point(154, 68);
            this.txt_Nom.Name = "txt_Nom";
            this.txt_Nom.Size = new System.Drawing.Size(226, 20);
            this.txt_Nom.TabIndex = 68;
            // 
            // txt_prenom
            // 
            this.txt_prenom.BackColor = System.Drawing.SystemColors.Control;
            this.txt_prenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_prenom.Location = new System.Drawing.Point(154, 108);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(226, 20);
            this.txt_prenom.TabIndex = 67;
            // 
            // txt_tel
            // 
            this.txt_tel.BackColor = System.Drawing.SystemColors.Control;
            this.txt_tel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tel.Location = new System.Drawing.Point(154, 271);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(226, 20);
            this.txt_tel.TabIndex = 71;
            // 
            // date_n
            // 
            this.date_n.Location = new System.Drawing.Point(154, 148);
            this.date_n.Name = "date_n";
            this.date_n.Size = new System.Drawing.Size(229, 20);
            this.date_n.TabIndex = 66;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(34, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 18);
            this.label8.TabIndex = 64;
            this.label8.Text = "Adresse:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(9, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 18);
            this.label7.TabIndex = 63;
            this.label7.Text = "Lieu De Naissance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(34, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 18);
            this.label6.TabIndex = 62;
            this.label6.Text = "Nom:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(34, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 61;
            this.label5.Text = "Prénom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(9, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 18);
            this.label4.TabIndex = 60;
            this.label4.Text = "Date De Naissance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(34, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 65;
            this.label3.Text = "Télephone:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(34, 374);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 18);
            this.label10.TabIndex = 59;
            this.label10.Text = "CIN:";
            // 
            // bt_Valider
            // 
            this.bt_Valider.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_Valider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_Valider.FlatAppearance.BorderSize = 0;
            this.bt_Valider.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt_Valider.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt_Valider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Valider.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bt_Valider.Location = new System.Drawing.Point(337, 469);
            this.bt_Valider.Name = "bt_Valider";
            this.bt_Valider.Size = new System.Drawing.Size(127, 28);
            this.bt_Valider.TabIndex = 36;
            this.bt_Valider.Text = "Valider";
            this.bt_Valider.UseVisualStyleBackColor = false;
            this.bt_Valider.Click += new System.EventHandler(this.bt_Valider_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(53, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Informations Personnel:";
            // 
            // FormNouveauEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 543);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNouveauEmploye";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNouveauEmploye";
            this.Load += new System.EventHandler(this.FormNouveauEmploye_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bt_Annuler;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_Valider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cb_fonction;
        private System.Windows.Forms.TextBox txt_specialite;
        private System.Windows.Forms.Label lb_Specialite;
        private System.Windows.Forms.Label lb_fonction;
        private System.Windows.Forms.ComboBox cb_poste;
        private System.Windows.Forms.TextBox txt_diplome;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtx_email;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Adresse;
        private System.Windows.Forms.TextBox txt_lieuN;
        private System.Windows.Forms.TextBox txt_Nom;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.DateTimePicker date_n;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_mdp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_cin;
    }
}