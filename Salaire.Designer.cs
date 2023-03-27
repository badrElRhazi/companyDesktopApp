
namespace csse3
{
    partial class Salaire
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_Annuler = new System.Windows.Forms.Button();
            this.bt_Valider = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_annulerD = new System.Windows.Forms.Button();
            this.bt_validerSalaire = new System.Windows.Forms.Button();
            this.ch_effectuer = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ch_Encour = new System.Windows.Forms.CheckBox();
            this.cb_employe1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_prime1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_salaire1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 44);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.bt_Annuler);
            this.panel2.Controls.Add(this.bt_Valider);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(137, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(570, 452);
            this.panel2.TabIndex = 2;
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
            this.bt_Annuler.Location = new System.Drawing.Point(287, 417);
            this.bt_Annuler.Name = "bt_Annuler";
            this.bt_Annuler.Size = new System.Drawing.Size(127, 28);
            this.bt_Annuler.TabIndex = 39;
            this.bt_Annuler.Text = "Annuler";
            this.bt_Annuler.UseVisualStyleBackColor = false;
            // 
            // bt_Valider
            // 
            this.bt_Valider.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_Valider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_Valider.FlatAppearance.BorderSize = 0;
            this.bt_Valider.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.bt_Valider.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.bt_Valider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Valider.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bt_Valider.Location = new System.Drawing.Point(109, 417);
            this.bt_Valider.Name = "bt_Valider";
            this.bt_Valider.Size = new System.Drawing.Size(127, 28);
            this.bt_Valider.TabIndex = 38;
            this.bt_Valider.Text = "Valider";
            this.bt_Valider.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(255, 288);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(409, 198);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(49, 17);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Privé";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(255, 198);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(44, 17);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Etat";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(53, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Id Convention :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(56, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nom Convention :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(255, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(219, 20);
            this.textBox2.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(56, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Type Convention:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(255, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 20);
            this.textBox1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(56, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Date Convention :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::csse3.Properties.Resources.icons8_receive_cash_26px;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(54, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Paiemant Directeur";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.bt_annulerD);
            this.panel3.Controls.Add(this.bt_validerSalaire);
            this.panel3.Controls.Add(this.ch_effectuer);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.ch_Encour);
            this.panel3.Controls.Add(this.cb_employe1);
            this.panel3.Controls.Add(this.dateTimePicker2);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.txt_prime1);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txt_salaire1);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Location = new System.Drawing.Point(0, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(810, 466);
            this.panel3.TabIndex = 5;
            // 
            // bt_annulerD
            // 
            this.bt_annulerD.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_annulerD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_annulerD.FlatAppearance.BorderSize = 0;
            this.bt_annulerD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.bt_annulerD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.bt_annulerD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_annulerD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_annulerD.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bt_annulerD.Location = new System.Drawing.Point(499, 438);
            this.bt_annulerD.Name = "bt_annulerD";
            this.bt_annulerD.Size = new System.Drawing.Size(127, 28);
            this.bt_annulerD.TabIndex = 40;
            this.bt_annulerD.Text = "Annuler";
            this.bt_annulerD.UseVisualStyleBackColor = false;
            this.bt_annulerD.Click += new System.EventHandler(this.bt_annulerD_Click);
            // 
            // bt_validerSalaire
            // 
            this.bt_validerSalaire.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_validerSalaire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_validerSalaire.FlatAppearance.BorderSize = 0;
            this.bt_validerSalaire.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.bt_validerSalaire.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.bt_validerSalaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_validerSalaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_validerSalaire.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bt_validerSalaire.Location = new System.Drawing.Point(246, 435);
            this.bt_validerSalaire.Name = "bt_validerSalaire";
            this.bt_validerSalaire.Size = new System.Drawing.Size(127, 28);
            this.bt_validerSalaire.TabIndex = 39;
            this.bt_validerSalaire.Text = "Valider";
            this.bt_validerSalaire.UseVisualStyleBackColor = false;
            this.bt_validerSalaire.Click += new System.EventHandler(this.bt_validerSalaire_Click);
            // 
            // ch_effectuer
            // 
            this.ch_effectuer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ch_effectuer.AutoSize = true;
            this.ch_effectuer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ch_effectuer.Location = new System.Drawing.Point(499, 342);
            this.ch_effectuer.Name = "ch_effectuer";
            this.ch_effectuer.Size = new System.Drawing.Size(69, 17);
            this.ch_effectuer.TabIndex = 27;
            this.ch_effectuer.Text = "Effectuer";
            this.ch_effectuer.UseVisualStyleBackColor = true;
            this.ch_effectuer.CheckedChanged += new System.EventHandler(this.ch_effectuer_CheckedChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(194, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 22);
            this.label8.TabIndex = 18;
            this.label8.Text = "Prime :";
            // 
            // ch_Encour
            // 
            this.ch_Encour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ch_Encour.AutoSize = true;
            this.ch_Encour.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ch_Encour.Location = new System.Drawing.Point(336, 342);
            this.ch_Encour.Name = "ch_Encour";
            this.ch_Encour.Size = new System.Drawing.Size(67, 17);
            this.ch_Encour.TabIndex = 26;
            this.ch_Encour.Text = "en cours";
            this.ch_Encour.UseVisualStyleBackColor = true;
            this.ch_Encour.CheckedChanged += new System.EventHandler(this.ch_Encour_CheckedChanged);
            // 
            // cb_employe1
            // 
            this.cb_employe1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_employe1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cb_employe1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_employe1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.cb_employe1.FormattingEnabled = true;
            this.cb_employe1.Location = new System.Drawing.Point(293, 23);
            this.cb_employe1.Name = "cb_employe1";
            this.cb_employe1.Size = new System.Drawing.Size(345, 21);
            this.cb_employe1.TabIndex = 23;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker2.Location = new System.Drawing.Point(286, 243);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(352, 20);
            this.dateTimePicker2.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label13.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(181, 336);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 22);
            this.label13.TabIndex = 22;
            this.label13.Text = "Paiment:";
            // 
            // txt_prime1
            // 
            this.txt_prime1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_prime1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_prime1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_prime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prime1.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_prime1.Location = new System.Drawing.Point(289, 164);
            this.txt_prime1.Name = "txt_prime1";
            this.txt_prime1.Size = new System.Drawing.Size(349, 26);
            this.txt_prime1.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(123, 243);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(159, 22);
            this.label12.TabIndex = 20;
            this.label12.Text = "Date De Paiment:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(197, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "Salaire:";
            // 
            // txt_salaire1
            // 
            this.txt_salaire1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_salaire1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_salaire1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_salaire1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salaire1.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_salaire1.Location = new System.Drawing.Point(293, 83);
            this.txt_salaire1.Name = "txt_salaire1";
            this.txt_salaire1.Size = new System.Drawing.Size(345, 26);
            this.txt_salaire1.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(181, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 22);
            this.label10.TabIndex = 16;
            this.label10.Text = "Employé:";
            // 
            // Salaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 510);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Salaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salaire";
            this.Load += new System.EventHandler(this.Salaire_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_Annuler;
        private System.Windows.Forms.Button bt_Valider;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_prime1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_salaire1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cb_employe1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.CheckBox ch_Encour;
        private System.Windows.Forms.CheckBox ch_effectuer;
        private System.Windows.Forms.Button bt_validerSalaire;
        private System.Windows.Forms.Button bt_annulerD;
    }
}