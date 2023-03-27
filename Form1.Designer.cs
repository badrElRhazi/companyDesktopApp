
namespace csse3
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pi_max = new System.Windows.Forms.PictureBox();
            this.pi_min = new System.Windows.Forms.PictureBox();
            this.bt_restaurer = new System.Windows.Forms.Button();
            this.bt_Fermer = new System.Windows.Forms.Button();
            this.pi_menu = new System.Windows.Forms.PictureBox();
            this.pa_menuGlobal = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_agenda = new System.Windows.Forms.Button();
            this.bt_parametre = new System.Windows.Forms.Button();
            this.msjr_employe = new System.Windows.Forms.Button();
            this.bt_formateur = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pa_sousMenu = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.bt_ChangeMP = new System.Windows.Forms.Button();
            this.bt_Deconncte = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.bt_AjouterFormateur = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bt_Secetaire = new System.Windows.Forms.Button();
            this.bt_Agent = new System.Windows.Forms.Button();
            this.bt_Responsable = new System.Windows.Forms.Button();
            this.bt_Directeur = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pi_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi_menu)).BeginInit();
            this.pa_menuGlobal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.pa_sousMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.pi_max);
            this.panel1.Controls.Add(this.pi_min);
            this.panel1.Controls.Add(this.bt_restaurer);
            this.panel1.Controls.Add(this.bt_Fermer);
            this.panel1.Controls.Add(this.pi_menu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1441, 57);
            this.panel1.TabIndex = 0;
            // 
            // pi_max
            // 
            this.pi_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pi_max.Image = global::csse3.Properties.Resources.icons8_rounded_square_24px;
            this.pi_max.Location = new System.Drawing.Point(1337, 12);
            this.pi_max.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pi_max.Name = "pi_max";
            this.pi_max.Size = new System.Drawing.Size(40, 37);
            this.pi_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pi_max.TabIndex = 4;
            this.pi_max.TabStop = false;
            this.pi_max.Click += new System.EventHandler(this.pi_max_Click);
            // 
            // pi_min
            // 
            this.pi_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pi_min.Image = global::csse3.Properties.Resources.icons8_group_objects_80px;
            this.pi_min.Location = new System.Drawing.Point(1337, 12);
            this.pi_min.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pi_min.Name = "pi_min";
            this.pi_min.Size = new System.Drawing.Size(40, 37);
            this.pi_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pi_min.TabIndex = 3;
            this.pi_min.TabStop = false;
            this.pi_min.Visible = false;
            this.pi_min.Click += new System.EventHandler(this.pi_min_Click);
            // 
            // bt_restaurer
            // 
            this.bt_restaurer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_restaurer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_restaurer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_restaurer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_restaurer.Location = new System.Drawing.Point(1289, 12);
            this.bt_restaurer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_restaurer.Name = "bt_restaurer";
            this.bt_restaurer.Size = new System.Drawing.Size(40, 37);
            this.bt_restaurer.TabIndex = 2;
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
            this.bt_Fermer.Location = new System.Drawing.Point(1385, 12);
            this.bt_Fermer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Fermer.Name = "bt_Fermer";
            this.bt_Fermer.Size = new System.Drawing.Size(40, 37);
            this.bt_Fermer.TabIndex = 1;
            this.bt_Fermer.Text = "X";
            this.bt_Fermer.UseVisualStyleBackColor = true;
            this.bt_Fermer.Click += new System.EventHandler(this.bt_Fermer_Click);
            // 
            // pi_menu
            // 
            this.pi_menu.Image = global::csse3.Properties.Resources.icons8_menu_50px_1;
            this.pi_menu.Location = new System.Drawing.Point(4, 12);
            this.pi_menu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pi_menu.Name = "pi_menu";
            this.pi_menu.Size = new System.Drawing.Size(52, 37);
            this.pi_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pi_menu.TabIndex = 1;
            this.pi_menu.TabStop = false;
            this.pi_menu.Click += new System.EventHandler(this.pi_menu_Click);
            // 
            // pa_menuGlobal
            // 
            this.pa_menuGlobal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pa_menuGlobal.Controls.Add(this.pictureBox2);
            this.pa_menuGlobal.Controls.Add(this.panel3);
            this.pa_menuGlobal.Controls.Add(this.bt_agenda);
            this.pa_menuGlobal.Controls.Add(this.bt_parametre);
            this.pa_menuGlobal.Controls.Add(this.msjr_employe);
            this.pa_menuGlobal.Controls.Add(this.bt_formateur);
            this.pa_menuGlobal.Controls.Add(this.button2);
            this.pa_menuGlobal.Dock = System.Windows.Forms.DockStyle.Left;
            this.pa_menuGlobal.Location = new System.Drawing.Point(0, 57);
            this.pa_menuGlobal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pa_menuGlobal.Name = "pa_menuGlobal";
            this.pa_menuGlobal.Size = new System.Drawing.Size(184, 647);
            this.pa_menuGlobal.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::csse3.Properties.Resources.icons8_male_user_100px;
            this.pictureBox2.Location = new System.Drawing.Point(3, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(177, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(4, 81);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(199, 1);
            this.panel3.TabIndex = 2;
            // 
            // bt_agenda
            // 
            this.bt_agenda.FlatAppearance.BorderSize = 0;
            this.bt_agenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_agenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_agenda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_agenda.Image = global::csse3.Properties.Resources.icons8_calendar_30_24px;
            this.bt_agenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_agenda.Location = new System.Drawing.Point(3, 98);
            this.bt_agenda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_agenda.Name = "bt_agenda";
            this.bt_agenda.Size = new System.Drawing.Size(187, 43);
            this.bt_agenda.TabIndex = 6;
            this.bt_agenda.Text = "      Agenda";
            this.bt_agenda.UseVisualStyleBackColor = true;
            this.bt_agenda.Click += new System.EventHandler(this.bt_agenda_Click);
            // 
            // bt_parametre
            // 
            this.bt_parametre.FlatAppearance.BorderSize = 0;
            this.bt_parametre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_parametre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_parametre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_parametre.Image = global::csse3.Properties.Resources.icons8_services_30px;
            this.bt_parametre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_parametre.Location = new System.Drawing.Point(0, 436);
            this.bt_parametre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_parametre.Name = "bt_parametre";
            this.bt_parametre.Size = new System.Drawing.Size(189, 43);
            this.bt_parametre.TabIndex = 5;
            this.bt_parametre.Text = "         Paramètres";
            this.bt_parametre.UseVisualStyleBackColor = true;
            this.bt_parametre.Click += new System.EventHandler(this.bt_parametre_Click);
            // 
            // msjr_employe
            // 
            this.msjr_employe.FlatAppearance.BorderSize = 0;
            this.msjr_employe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.msjr_employe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msjr_employe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.msjr_employe.Image = global::csse3.Properties.Resources.icons8_conference_26px;
            this.msjr_employe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.msjr_employe.Location = new System.Drawing.Point(0, 351);
            this.msjr_employe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.msjr_employe.Name = "msjr_employe";
            this.msjr_employe.Size = new System.Drawing.Size(199, 43);
            this.msjr_employe.TabIndex = 4;
            this.msjr_employe.Text = "       Employées\r\n";
            this.msjr_employe.UseVisualStyleBackColor = true;
            this.msjr_employe.Click += new System.EventHandler(this.Archive_Click);
            // 
            // bt_formateur
            // 
            this.bt_formateur.FlatAppearance.BorderSize = 0;
            this.bt_formateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_formateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_formateur.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_formateur.Image = global::csse3.Properties.Resources.icons8_user_group_30px;
            this.bt_formateur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_formateur.Location = new System.Drawing.Point(0, 261);
            this.bt_formateur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_formateur.Name = "bt_formateur";
            this.bt_formateur.Size = new System.Drawing.Size(199, 43);
            this.bt_formateur.TabIndex = 3;
            this.bt_formateur.Text = "         Formateurs";
            this.bt_formateur.UseVisualStyleBackColor = true;
            this.bt_formateur.Click += new System.EventHandler(this.bt_formateur_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = global::csse3.Properties.Resources.icons8_attendance_30px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 176);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "         Fichiers\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pa_sousMenu);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(184, 57);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1257, 647);
            this.panel2.TabIndex = 14;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pa_sousMenu
            // 
            this.pa_sousMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pa_sousMenu.Controls.Add(this.button6);
            this.pa_sousMenu.Controls.Add(this.button3);
            this.pa_sousMenu.Controls.Add(this.button5);
            this.pa_sousMenu.Controls.Add(this.button4);
            this.pa_sousMenu.Controls.Add(this.button1);
            this.pa_sousMenu.Location = new System.Drawing.Point(0, 181);
            this.pa_sousMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pa_sousMenu.Name = "pa_sousMenu";
            this.pa_sousMenu.Size = new System.Drawing.Size(224, 188);
            this.pa_sousMenu.TabIndex = 21;
            this.pa_sousMenu.Visible = false;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Image = global::csse3.Properties.Resources.icons8_attendance_30px;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 155);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(216, 37);
            this.button6.TabIndex = 8;
            this.button6.Text = "         Lettre d\'Offre\r\n";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Image = global::csse3.Properties.Resources.icons8_attendance_30px;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(4, 111);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(216, 37);
            this.button3.TabIndex = 7;
            this.button3.Text = "         Bordereau\r\n";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Image = global::csse3.Properties.Resources.icons8_attendance_30px;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 37);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(216, 36);
            this.button5.TabIndex = 6;
            this.button5.Text = "         Attestation Salaire\r\n";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Image = global::csse3.Properties.Resources.icons8_attendance_30px;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 4);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(216, 26);
            this.button4.TabIndex = 5;
            this.button4.Text = "         Attestation Congé\r\n";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::csse3.Properties.Resources.icons8_attendance_30px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(4, 80);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "         Attestation Travail\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::csse3.Properties.Resources.MicrosoftTeams_image__3_;
            this.pictureBox1.Location = new System.Drawing.Point(269, 95);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1113, 384);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel7.Controls.Add(this.bt_ChangeMP);
            this.panel7.Controls.Add(this.bt_Deconncte);
            this.panel7.Location = new System.Drawing.Point(0, 436);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(236, 110);
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
            this.bt_ChangeMP.Location = new System.Drawing.Point(-3, 4);
            this.bt_ChangeMP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_ChangeMP.Name = "bt_ChangeMP";
            this.bt_ChangeMP.Size = new System.Drawing.Size(235, 47);
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
            this.bt_Deconncte.Location = new System.Drawing.Point(4, 62);
            this.bt_Deconncte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Deconncte.Name = "bt_Deconncte";
            this.bt_Deconncte.Size = new System.Drawing.Size(239, 47);
            this.bt_Deconncte.TabIndex = 13;
            this.bt_Deconncte.Text = "   Déconnécté";
            this.bt_Deconncte.UseVisualStyleBackColor = false;
            this.bt_Deconncte.Click += new System.EventHandler(this.bt_Deconncte_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel5.Controls.Add(this.button9);
            this.panel5.Controls.Add(this.bt_AjouterFormateur);
            this.panel5.Location = new System.Drawing.Point(0, 261);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(228, 112);
            this.panel5.TabIndex = 19;
            this.panel5.Visible = false;
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.Image = global::csse3.Properties.Resources.icons8_user_group_30px;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(0, 54);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(228, 43);
            this.button9.TabIndex = 22;
            this.button9.Text = "        Cantact Formateurs";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // bt_AjouterFormateur
            // 
            this.bt_AjouterFormateur.FlatAppearance.BorderSize = 0;
            this.bt_AjouterFormateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AjouterFormateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_AjouterFormateur.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_AjouterFormateur.Image = global::csse3.Properties.Resources.icons8_user_group_30px;
            this.bt_AjouterFormateur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_AjouterFormateur.Location = new System.Drawing.Point(0, 4);
            this.bt_AjouterFormateur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_AjouterFormateur.Name = "bt_AjouterFormateur";
            this.bt_AjouterFormateur.Size = new System.Drawing.Size(228, 43);
            this.bt_AjouterFormateur.TabIndex = 20;
            this.bt_AjouterFormateur.Text = "         Nouveau Formateurs";
            this.bt_AjouterFormateur.UseVisualStyleBackColor = true;
            this.bt_AjouterFormateur.Click += new System.EventHandler(this.bt_AjouterFormateur_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel4.Controls.Add(this.bt_Secetaire);
            this.panel4.Controls.Add(this.bt_Agent);
            this.panel4.Controls.Add(this.bt_Responsable);
            this.panel4.Controls.Add(this.bt_Directeur);
            this.panel4.Location = new System.Drawing.Point(0, 98);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(232, 206);
            this.panel4.TabIndex = 18;
            this.panel4.Visible = false;
            // 
            // bt_Secetaire
            // 
            this.bt_Secetaire.FlatAppearance.BorderSize = 0;
            this.bt_Secetaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Secetaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Secetaire.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Secetaire.Image = global::csse3.Properties.Resources.icons8_calendar_30_24px;
            this.bt_Secetaire.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Secetaire.Location = new System.Drawing.Point(0, 144);
            this.bt_Secetaire.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Secetaire.Name = "bt_Secetaire";
            this.bt_Secetaire.Size = new System.Drawing.Size(225, 58);
            this.bt_Secetaire.TabIndex = 22;
            this.bt_Secetaire.Text = "      Conseillere Relation \r\n               Clientéle\r\n";
            this.bt_Secetaire.UseVisualStyleBackColor = true;
            this.bt_Secetaire.Click += new System.EventHandler(this.bt_Secetaire_Click);
            // 
            // bt_Agent
            // 
            this.bt_Agent.FlatAppearance.BorderSize = 0;
            this.bt_Agent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Agent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Agent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Agent.Image = global::csse3.Properties.Resources.icons8_calendar_30_24px;
            this.bt_Agent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Agent.Location = new System.Drawing.Point(1, 101);
            this.bt_Agent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Agent.Name = "bt_Agent";
            this.bt_Agent.Size = new System.Drawing.Size(225, 36);
            this.bt_Agent.TabIndex = 19;
            this.bt_Agent.Text = "      Agent  Administratif";
            this.bt_Agent.UseVisualStyleBackColor = true;
            this.bt_Agent.Click += new System.EventHandler(this.bt_Agent_Click);
            // 
            // bt_Responsable
            // 
            this.bt_Responsable.FlatAppearance.BorderSize = 0;
            this.bt_Responsable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Responsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Responsable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Responsable.Image = global::csse3.Properties.Resources.icons8_calendar_30_24px;
            this.bt_Responsable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Responsable.Location = new System.Drawing.Point(4, 39);
            this.bt_Responsable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Responsable.Name = "bt_Responsable";
            this.bt_Responsable.Size = new System.Drawing.Size(224, 54);
            this.bt_Responsable.TabIndex = 20;
            this.bt_Responsable.Text = "      Responsable    \r\n        Formation \r\n";
            this.bt_Responsable.UseVisualStyleBackColor = true;
            this.bt_Responsable.Click += new System.EventHandler(this.bt_Responsable_Click);
            // 
            // bt_Directeur
            // 
            this.bt_Directeur.FlatAppearance.BorderSize = 0;
            this.bt_Directeur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Directeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Directeur.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Directeur.Image = global::csse3.Properties.Resources.icons8_calendar_30_24px;
            this.bt_Directeur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Directeur.Location = new System.Drawing.Point(3, 0);
            this.bt_Directeur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Directeur.Name = "bt_Directeur";
            this.bt_Directeur.Size = new System.Drawing.Size(225, 43);
            this.bt_Directeur.TabIndex = 21;
            this.bt_Directeur.Text = "      Directeur";
            this.bt_Directeur.UseVisualStyleBackColor = true;
            this.bt_Directeur.Click += new System.EventHandler(this.bt_Directeur_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 704);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pa_menuGlobal);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pi_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi_menu)).EndInit();
            this.pa_menuGlobal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pa_sousMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pi_menu;
        private System.Windows.Forms.Panel pa_menuGlobal;
        private System.Windows.Forms.Button bt_agenda;
        private System.Windows.Forms.Button bt_parametre;
        private System.Windows.Forms.Button msjr_employe;
        private System.Windows.Forms.Button bt_formateur;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pi_max;
        private System.Windows.Forms.PictureBox pi_min;
        private System.Windows.Forms.Button bt_restaurer;
        private System.Windows.Forms.Button bt_Fermer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button bt_ChangeMP;
        private System.Windows.Forms.Button bt_Deconncte;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button bt_Agent;
        private System.Windows.Forms.Button bt_Responsable;
        private System.Windows.Forms.Button bt_Directeur;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button bt_AjouterFormateur;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_Secetaire;
        private System.Windows.Forms.Panel pa_sousMenu;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
    }
}

