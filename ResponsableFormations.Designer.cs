
namespace csse3
{
    partial class ResponsableFormations
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pi_min = new System.Windows.Forms.PictureBox();
            this.pi_max = new System.Windows.Forms.PictureBox();
            this.bt_restaurer = new System.Windows.Forms.Button();
            this.bt_Fermer = new System.Windows.Forms.Button();
            this.pi_menu = new System.Windows.Forms.PictureBox();
            this.pa_menuGlobal = new System.Windows.Forms.Panel();
            this.bt_Convention = new System.Windows.Forms.Button();
            this.bt_Evenement = new System.Windows.Forms.Button();
            this.bt_salle = new System.Windows.Forms.Button();
            this.bt_Formation = new System.Windows.Forms.Button();
            this.bt_Equipe = new System.Windows.Forms.Button();
            this.bt_parametre = new System.Windows.Forms.Button();
            this.bt_Agenda = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_ModifierEquipe = new System.Windows.Forms.Button();
            this.bt_AjouterEquipe = new System.Windows.Forms.Button();
            this.pa_sousMenu = new System.Windows.Forms.Panel();
            this.bt_ModifierEve = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.bt_ConsulterConvention = new System.Windows.Forms.Button();
            this.NouveauConvention = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.bt_ChangeMP = new System.Windows.Forms.Button();
            this.bt_Deconncte = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.bt_ajouterSalle = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bt_modifierFormation = new System.Windows.Forms.Button();
            this.bt_ajouterFormaion = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bt_Adherent = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pi_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi_menu)).BeginInit();
            this.pa_menuGlobal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.pa_sousMenu.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1140, 44);
            this.panel1.TabIndex = 0;
            // 
            // pi_min
            // 
            this.pi_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pi_min.Image = global::csse3.Properties.Resources.icons8_group_objects_80px;
            this.pi_min.Location = new System.Drawing.Point(1073, 17);
            this.pi_min.Name = "pi_min";
            this.pi_min.Size = new System.Drawing.Size(30, 30);
            this.pi_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pi_min.TabIndex = 16;
            this.pi_min.TabStop = false;
            this.pi_min.Visible = false;
            this.pi_min.Click += new System.EventHandler(this.pi_min_Click);
            // 
            // pi_max
            // 
            this.pi_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pi_max.Image = global::csse3.Properties.Resources.icons8_rounded_square_24px;
            this.pi_max.Location = new System.Drawing.Point(1073, 12);
            this.pi_max.Name = "pi_max";
            this.pi_max.Size = new System.Drawing.Size(30, 30);
            this.pi_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pi_max.TabIndex = 15;
            this.pi_max.TabStop = false;
            this.pi_max.Click += new System.EventHandler(this.pi_max_Click);
            // 
            // bt_restaurer
            // 
            this.bt_restaurer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_restaurer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_restaurer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_restaurer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_restaurer.Location = new System.Drawing.Point(1037, 12);
            this.bt_restaurer.Name = "bt_restaurer";
            this.bt_restaurer.Size = new System.Drawing.Size(30, 30);
            this.bt_restaurer.TabIndex = 14;
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
            this.bt_Fermer.Location = new System.Drawing.Point(1107, 11);
            this.bt_Fermer.Name = "bt_Fermer";
            this.bt_Fermer.Size = new System.Drawing.Size(30, 30);
            this.bt_Fermer.TabIndex = 13;
            this.bt_Fermer.Text = "X";
            this.bt_Fermer.UseVisualStyleBackColor = true;
            this.bt_Fermer.Click += new System.EventHandler(this.bt_Fermer_Click);
            // 
            // pi_menu
            // 
            this.pi_menu.Image = global::csse3.Properties.Resources.icons8_menu_50px_1;
            this.pi_menu.Location = new System.Drawing.Point(12, 12);
            this.pi_menu.Name = "pi_menu";
            this.pi_menu.Size = new System.Drawing.Size(30, 30);
            this.pi_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pi_menu.TabIndex = 12;
            this.pi_menu.TabStop = false;
            this.pi_menu.Click += new System.EventHandler(this.pi_menu_Click);
            // 
            // pa_menuGlobal
            // 
            this.pa_menuGlobal.AutoScroll = true;
            this.pa_menuGlobal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pa_menuGlobal.Controls.Add(this.bt_Adherent);
            this.pa_menuGlobal.Controls.Add(this.bt_Convention);
            this.pa_menuGlobal.Controls.Add(this.bt_Evenement);
            this.pa_menuGlobal.Controls.Add(this.bt_salle);
            this.pa_menuGlobal.Controls.Add(this.bt_Formation);
            this.pa_menuGlobal.Controls.Add(this.bt_Equipe);
            this.pa_menuGlobal.Controls.Add(this.bt_parametre);
            this.pa_menuGlobal.Controls.Add(this.bt_Agenda);
            this.pa_menuGlobal.Controls.Add(this.panel3);
            this.pa_menuGlobal.Controls.Add(this.pictureBox2);
            this.pa_menuGlobal.Dock = System.Windows.Forms.DockStyle.Left;
            this.pa_menuGlobal.Location = new System.Drawing.Point(0, 44);
            this.pa_menuGlobal.Name = "pa_menuGlobal";
            this.pa_menuGlobal.Size = new System.Drawing.Size(152, 548);
            this.pa_menuGlobal.TabIndex = 0;
            // 
            // bt_Convention
            // 
            this.bt_Convention.FlatAppearance.BorderSize = 0;
            this.bt_Convention.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.bt_Convention.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.bt_Convention.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Convention.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Convention.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Convention.Image = global::csse3.Properties.Resources.icons8_handshake_24px;
            this.bt_Convention.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Convention.Location = new System.Drawing.Point(15, 193);
            this.bt_Convention.Name = "bt_Convention";
            this.bt_Convention.Size = new System.Drawing.Size(137, 38);
            this.bt_Convention.TabIndex = 12;
            this.bt_Convention.Text = "         Conventions";
            this.bt_Convention.UseVisualStyleBackColor = true;
            this.bt_Convention.Click += new System.EventHandler(this.bt_Convention_Click);
            // 
            // bt_Evenement
            // 
            this.bt_Evenement.FlatAppearance.BorderSize = 0;
            this.bt_Evenement.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.bt_Evenement.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.bt_Evenement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Evenement.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Evenement.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Evenement.Image = global::csse3.Properties.Resources.icons8_calendar_6_24px;
            this.bt_Evenement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Evenement.Location = new System.Drawing.Point(12, 248);
            this.bt_Evenement.Name = "bt_Evenement";
            this.bt_Evenement.Size = new System.Drawing.Size(143, 38);
            this.bt_Evenement.TabIndex = 11;
            this.bt_Evenement.Text = "          Evénements";
            this.bt_Evenement.UseVisualStyleBackColor = true;
            this.bt_Evenement.Click += new System.EventHandler(this.bt_Evenement_Click);
            // 
            // bt_salle
            // 
            this.bt_salle.FlatAppearance.BorderSize = 0;
            this.bt_salle.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.bt_salle.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.bt_salle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_salle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_salle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_salle.Image = global::csse3.Properties.Resources.icons8_class_24px;
            this.bt_salle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_salle.Location = new System.Drawing.Point(12, 356);
            this.bt_salle.Name = "bt_salle";
            this.bt_salle.Size = new System.Drawing.Size(143, 38);
            this.bt_salle.TabIndex = 18;
            this.bt_salle.Text = "       Salle";
            this.bt_salle.UseVisualStyleBackColor = true;
            this.bt_salle.Click += new System.EventHandler(this.bt_salle_Click);
            // 
            // bt_Formation
            // 
            this.bt_Formation.FlatAppearance.BorderSize = 0;
            this.bt_Formation.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.bt_Formation.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.bt_Formation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Formation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Formation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Formation.Image = global::csse3.Properties.Resources.icons8_moleskine_26px;
            this.bt_Formation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Formation.Location = new System.Drawing.Point(12, 301);
            this.bt_Formation.Name = "bt_Formation";
            this.bt_Formation.Size = new System.Drawing.Size(143, 38);
            this.bt_Formation.TabIndex = 17;
            this.bt_Formation.Text = "       Formation";
            this.bt_Formation.UseVisualStyleBackColor = true;
            this.bt_Formation.Click += new System.EventHandler(this.bt_Formation_Click);
            // 
            // bt_Equipe
            // 
            this.bt_Equipe.FlatAppearance.BorderSize = 0;
            this.bt_Equipe.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.bt_Equipe.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.bt_Equipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Equipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Equipe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Equipe.Image = global::csse3.Properties.Resources.icons8_conference_24px;
            this.bt_Equipe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Equipe.Location = new System.Drawing.Point(12, 139);
            this.bt_Equipe.Name = "bt_Equipe";
            this.bt_Equipe.Size = new System.Drawing.Size(143, 39);
            this.bt_Equipe.TabIndex = 6;
            this.bt_Equipe.Text = "       Equipe";
            this.bt_Equipe.UseVisualStyleBackColor = true;
            this.bt_Equipe.Click += new System.EventHandler(this.bt_Equipe_Click);
            this.bt_Equipe.MouseLeave += new System.EventHandler(this.bt_Equipe_MouseLeave);
            this.bt_Equipe.MouseHover += new System.EventHandler(this.bt_Equipe_MouseHover);
            // 
            // bt_parametre
            // 
            this.bt_parametre.FlatAppearance.BorderSize = 0;
            this.bt_parametre.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.bt_parametre.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.bt_parametre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_parametre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_parametre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_parametre.Image = global::csse3.Properties.Resources.icons8_services_30px;
            this.bt_parametre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_parametre.Location = new System.Drawing.Point(12, 459);
            this.bt_parametre.Name = "bt_parametre";
            this.bt_parametre.Size = new System.Drawing.Size(143, 42);
            this.bt_parametre.TabIndex = 10;
            this.bt_parametre.Text = "       Paramètres";
            this.bt_parametre.UseVisualStyleBackColor = true;
            this.bt_parametre.Click += new System.EventHandler(this.bt_parametre_Click);
            // 
            // bt_Agenda
            // 
            this.bt_Agenda.FlatAppearance.BorderSize = 0;
            this.bt_Agenda.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.bt_Agenda.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.bt_Agenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Agenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Agenda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Agenda.Image = global::csse3.Properties.Resources.icons8_calendar_30_24px;
            this.bt_Agenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Agenda.Location = new System.Drawing.Point(15, 85);
            this.bt_Agenda.Name = "bt_Agenda";
            this.bt_Agenda.Size = new System.Drawing.Size(140, 38);
            this.bt_Agenda.TabIndex = 4;
            this.bt_Agenda.Text = "       Agenda";
            this.bt_Agenda.UseVisualStyleBackColor = true;
            this.bt_Agenda.Click += new System.EventHandler(this.bt_Agenda_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(6, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(152, 1);
            this.panel3.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::csse3.Properties.Resources.icons8_male_user_100px;
            this.pictureBox2.Location = new System.Drawing.Point(6, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(149, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel2.Controls.Add(this.bt_ModifierEquipe);
            this.panel2.Controls.Add(this.bt_AjouterEquipe);
            this.panel2.Location = new System.Drawing.Point(0, 139);
            this.panel2.MaximumSize = new System.Drawing.Size(214, 222);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 70);
            this.panel2.TabIndex = 16;
            this.panel2.Visible = false;
            // 
            // bt_ModifierEquipe
            // 
            this.bt_ModifierEquipe.FlatAppearance.BorderSize = 0;
            this.bt_ModifierEquipe.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.bt_ModifierEquipe.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.bt_ModifierEquipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ModifierEquipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ModifierEquipe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_ModifierEquipe.Image = global::csse3.Properties.Resources.icons8_conference_24px;
            this.bt_ModifierEquipe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_ModifierEquipe.Location = new System.Drawing.Point(0, 35);
            this.bt_ModifierEquipe.Name = "bt_ModifierEquipe";
            this.bt_ModifierEquipe.Size = new System.Drawing.Size(140, 36);
            this.bt_ModifierEquipe.TabIndex = 17;
            this.bt_ModifierEquipe.Text = "     Consulte Equipe";
            this.bt_ModifierEquipe.UseVisualStyleBackColor = true;
            this.bt_ModifierEquipe.Click += new System.EventHandler(this.bt_ModifierEquipe_Click);
            // 
            // bt_AjouterEquipe
            // 
            this.bt_AjouterEquipe.FlatAppearance.BorderSize = 0;
            this.bt_AjouterEquipe.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.bt_AjouterEquipe.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.bt_AjouterEquipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AjouterEquipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_AjouterEquipe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_AjouterEquipe.Image = global::csse3.Properties.Resources.icons8_conference_24px;
            this.bt_AjouterEquipe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_AjouterEquipe.Location = new System.Drawing.Point(0, 0);
            this.bt_AjouterEquipe.Name = "bt_AjouterEquipe";
            this.bt_AjouterEquipe.Size = new System.Drawing.Size(140, 35);
            this.bt_AjouterEquipe.TabIndex = 17;
            this.bt_AjouterEquipe.Text = "    Nouveau  Equipe";
            this.bt_AjouterEquipe.UseVisualStyleBackColor = true;
            this.bt_AjouterEquipe.Click += new System.EventHandler(this.bt_AjouterEquipe_Click);
            // 
            // pa_sousMenu
            // 
            this.pa_sousMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pa_sousMenu.Controls.Add(this.bt_ModifierEve);
            this.pa_sousMenu.Location = new System.Drawing.Point(0, 258);
            this.pa_sousMenu.Name = "pa_sousMenu";
            this.pa_sousMenu.Size = new System.Drawing.Size(158, 48);
            this.pa_sousMenu.TabIndex = 15;
            this.pa_sousMenu.Visible = false;
            this.pa_sousMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pa_sousMenu_Paint);
            // 
            // bt_ModifierEve
            // 
            this.bt_ModifierEve.FlatAppearance.BorderSize = 0;
            this.bt_ModifierEve.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.bt_ModifierEve.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.bt_ModifierEve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ModifierEve.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ModifierEve.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_ModifierEve.Image = global::csse3.Properties.Resources.icons8_calendar_6_24px;
            this.bt_ModifierEve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_ModifierEve.Location = new System.Drawing.Point(0, 9);
            this.bt_ModifierEve.Name = "bt_ModifierEve";
            this.bt_ModifierEve.Size = new System.Drawing.Size(152, 28);
            this.bt_ModifierEve.TabIndex = 13;
            this.bt_ModifierEve.Text = "    Consulter  Evénements";
            this.bt_ModifierEve.UseVisualStyleBackColor = true;
            this.bt_ModifierEve.Click += new System.EventHandler(this.bt_ModifierEve_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.pa_sousMenu);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(152, 44);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(988, 548);
            this.panel4.TabIndex = 16;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel9.Controls.Add(this.button3);
            this.panel9.Controls.Add(this.button1);
            this.panel9.Location = new System.Drawing.Point(-5, 77);
            this.panel9.MaximumSize = new System.Drawing.Size(214, 222);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(165, 67);
            this.panel9.TabIndex = 23;
            this.panel9.Visible = false;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Image = global::csse3.Properties.Resources.icons8_calendar_30_24px;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(6, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 28);
            this.button3.TabIndex = 6;
            this.button3.Text = "       Aujourd\'hui";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::csse3.Properties.Resources.icons8_calendar_30_24px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "       Agenda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel8.Controls.Add(this.bt_ConsulterConvention);
            this.panel8.Controls.Add(this.NouveauConvention);
            this.panel8.Location = new System.Drawing.Point(-5, 193);
            this.panel8.MaximumSize = new System.Drawing.Size(214, 222);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(165, 69);
            this.panel8.TabIndex = 22;
            this.panel8.Visible = false;
            // 
            // bt_ConsulterConvention
            // 
            this.bt_ConsulterConvention.FlatAppearance.BorderSize = 0;
            this.bt_ConsulterConvention.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.bt_ConsulterConvention.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.bt_ConsulterConvention.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ConsulterConvention.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ConsulterConvention.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_ConsulterConvention.Image = global::csse3.Properties.Resources.icons8_handshake_24px;
            this.bt_ConsulterConvention.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_ConsulterConvention.Location = new System.Drawing.Point(0, 36);
            this.bt_ConsulterConvention.Name = "bt_ConsulterConvention";
            this.bt_ConsulterConvention.Size = new System.Drawing.Size(168, 31);
            this.bt_ConsulterConvention.TabIndex = 23;
            this.bt_ConsulterConvention.Text = "      Consulter Conventions";
            this.bt_ConsulterConvention.UseVisualStyleBackColor = true;
            this.bt_ConsulterConvention.Click += new System.EventHandler(this.bt_ConsulterConvention_Click);
            // 
            // NouveauConvention
            // 
            this.NouveauConvention.FlatAppearance.BorderSize = 0;
            this.NouveauConvention.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.NouveauConvention.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.NouveauConvention.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NouveauConvention.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NouveauConvention.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NouveauConvention.Image = global::csse3.Properties.Resources.icons8_handshake_24px;
            this.NouveauConvention.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NouveauConvention.Location = new System.Drawing.Point(3, 3);
            this.NouveauConvention.Name = "NouveauConvention";
            this.NouveauConvention.Size = new System.Drawing.Size(159, 27);
            this.NouveauConvention.TabIndex = 24;
            this.NouveauConvention.Text = "      Nouveau Conventions";
            this.NouveauConvention.UseVisualStyleBackColor = true;
            this.NouveauConvention.Click += new System.EventHandler(this.NouveauConvention_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel7.Controls.Add(this.bt_ChangeMP);
            this.panel7.Controls.Add(this.bt_Deconncte);
            this.panel7.Location = new System.Drawing.Point(0, 463);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(167, 82);
            this.panel7.TabIndex = 21;
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
            this.bt_Deconncte.Location = new System.Drawing.Point(6, 38);
            this.bt_Deconncte.Name = "bt_Deconncte";
            this.bt_Deconncte.Size = new System.Drawing.Size(157, 38);
            this.bt_Deconncte.TabIndex = 13;
            this.bt_Deconncte.Text = "   Déconnécté";
            this.bt_Deconncte.UseVisualStyleBackColor = false;
            this.bt_Deconncte.Click += new System.EventHandler(this.bt_Deconncte_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel6.Controls.Add(this.bt_ajouterSalle);
            this.panel6.Controls.Add(this.button5);
            this.panel6.Location = new System.Drawing.Point(-6, 356);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(167, 73);
            this.panel6.TabIndex = 20;
            this.panel6.Visible = false;
            // 
            // bt_ajouterSalle
            // 
            this.bt_ajouterSalle.FlatAppearance.BorderSize = 0;
            this.bt_ajouterSalle.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.bt_ajouterSalle.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.bt_ajouterSalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ajouterSalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ajouterSalle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_ajouterSalle.Image = global::csse3.Properties.Resources.icons8_class_24px;
            this.bt_ajouterSalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_ajouterSalle.Location = new System.Drawing.Point(0, 3);
            this.bt_ajouterSalle.Name = "bt_ajouterSalle";
            this.bt_ajouterSalle.Size = new System.Drawing.Size(167, 33);
            this.bt_ajouterSalle.TabIndex = 21;
            this.bt_ajouterSalle.Text = "       Nouvel  Salle";
            this.bt_ajouterSalle.UseVisualStyleBackColor = true;
            this.bt_ajouterSalle.Click += new System.EventHandler(this.bt_ajouterSalle_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Image = global::csse3.Properties.Resources.icons8_class_24px;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(3, 42);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(164, 27);
            this.button5.TabIndex = 22;
            this.button5.Text = "       Consulter  Salle";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::csse3.Properties.Resources.Responsable;
            this.pictureBox1.Location = new System.Drawing.Point(161, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(754, 318);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel5.Controls.Add(this.bt_modifierFormation);
            this.panel5.Controls.Add(this.bt_ajouterFormaion);
            this.panel5.Location = new System.Drawing.Point(-3, 301);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(167, 75);
            this.panel5.TabIndex = 18;
            this.panel5.Visible = false;
            // 
            // bt_modifierFormation
            // 
            this.bt_modifierFormation.FlatAppearance.BorderSize = 0;
            this.bt_modifierFormation.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.bt_modifierFormation.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.bt_modifierFormation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_modifierFormation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_modifierFormation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_modifierFormation.Image = global::csse3.Properties.Resources.icons8_moleskine_26px;
            this.bt_modifierFormation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_modifierFormation.Location = new System.Drawing.Point(-3, 36);
            this.bt_modifierFormation.Name = "bt_modifierFormation";
            this.bt_modifierFormation.Size = new System.Drawing.Size(161, 34);
            this.bt_modifierFormation.TabIndex = 20;
            this.bt_modifierFormation.Text = "    Consulter Formation";
            this.bt_modifierFormation.UseVisualStyleBackColor = true;
            this.bt_modifierFormation.Click += new System.EventHandler(this.bt_modifierFormation_Click);
            // 
            // bt_ajouterFormaion
            // 
            this.bt_ajouterFormaion.FlatAppearance.BorderSize = 0;
            this.bt_ajouterFormaion.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.bt_ajouterFormaion.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.bt_ajouterFormaion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ajouterFormaion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ajouterFormaion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_ajouterFormaion.Image = global::csse3.Properties.Resources.icons8_moleskine_26px;
            this.bt_ajouterFormaion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_ajouterFormaion.Location = new System.Drawing.Point(-3, 0);
            this.bt_ajouterFormaion.Name = "bt_ajouterFormaion";
            this.bt_ajouterFormaion.Size = new System.Drawing.Size(152, 30);
            this.bt_ajouterFormaion.TabIndex = 19;
            this.bt_ajouterFormaion.Text = "      Nouveau Formation";
            this.bt_ajouterFormaion.UseVisualStyleBackColor = true;
            this.bt_ajouterFormaion.Click += new System.EventHandler(this.bt_ajouterFormaion_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bt_Adherent
            // 
            this.bt_Adherent.FlatAppearance.BorderSize = 0;
            this.bt_Adherent.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.bt_Adherent.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.bt_Adherent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Adherent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Adherent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Adherent.Image = global::csse3.Properties.Resources.icons8_user_group_30px;
            this.bt_Adherent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Adherent.Location = new System.Drawing.Point(12, 400);
            this.bt_Adherent.Name = "bt_Adherent";
            this.bt_Adherent.Size = new System.Drawing.Size(143, 39);
            this.bt_Adherent.TabIndex = 24;
            this.bt_Adherent.Text = "       Adhérents";
            this.bt_Adherent.UseVisualStyleBackColor = true;
            this.bt_Adherent.Click += new System.EventHandler(this.bt_Adherent_Click);
            // 
            // ResponsableFormations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 592);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pa_menuGlobal);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResponsableFormations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResponsableFormations";
            this.Load += new System.EventHandler(this.ResponsableFormations_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pi_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi_menu)).EndInit();
            this.pa_menuGlobal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pa_sousMenu.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pa_menuGlobal;
        private System.Windows.Forms.PictureBox pi_menu;
        private System.Windows.Forms.PictureBox pi_min;
        private System.Windows.Forms.PictureBox pi_max;
        private System.Windows.Forms.Button bt_restaurer;
        private System.Windows.Forms.Button bt_Fermer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bt_Agenda;
        private System.Windows.Forms.Button bt_parametre;
        private System.Windows.Forms.Button bt_Equipe;
        private System.Windows.Forms.Button bt_Convention;
        private System.Windows.Forms.Button bt_Evenement;
        private System.Windows.Forms.Button bt_ModifierEve;
        private System.Windows.Forms.Panel pa_sousMenu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_ModifierEquipe;
        private System.Windows.Forms.Button bt_AjouterEquipe;
        private System.Windows.Forms.Button bt_Formation;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button bt_modifierFormation;
        private System.Windows.Forms.Button bt_ajouterFormaion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_salle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button bt_ajouterSalle;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button bt_ChangeMP;
        private System.Windows.Forms.Button bt_Deconncte;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button bt_ConsulterConvention;
        private System.Windows.Forms.Button NouveauConvention;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_Adherent;
    }
}