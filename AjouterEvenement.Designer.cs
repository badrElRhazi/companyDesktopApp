
namespace csse3
{
    partial class AjouterEvenement
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_employe = new System.Windows.Forms.ComboBox();
            this.lb_salle = new System.Windows.Forms.Label();
            this.rb_Exterieur = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rb_intérieur = new System.Windows.Forms.RadioButton();
            this.bt_Valider = new System.Windows.Forms.Button();
            this.txt_nomEv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.bt_Annuler = new System.Windows.Forms.Button();
            this.txt_dure = new System.Windows.Forms.TextBox();
            this.txt_prix = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_salle = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 48);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::csse3.Properties.Resources.icons8_calendar_6_24px;
            this.pictureBox1.Location = new System.Drawing.Point(7, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nouveau Evénement";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.cb_employe);
            this.panel2.Controls.Add(this.lb_salle);
            this.panel2.Controls.Add(this.rb_Exterieur);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.rb_intérieur);
            this.panel2.Controls.Add(this.bt_Valider);
            this.panel2.Controls.Add(this.txt_nomEv);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 402);
            this.panel2.TabIndex = 7;
            // 
            // cb_employe
            // 
            this.cb_employe.FormattingEnabled = true;
            this.cb_employe.Location = new System.Drawing.Point(197, 191);
            this.cb_employe.Name = "cb_employe";
            this.cb_employe.Size = new System.Drawing.Size(194, 21);
            this.cb_employe.TabIndex = 52;
            // 
            // lb_salle
            // 
            this.lb_salle.AutoSize = true;
            this.lb_salle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_salle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_salle.Location = new System.Drawing.Point(16, 192);
            this.lb_salle.Name = "lb_salle";
            this.lb_salle.Size = new System.Drawing.Size(82, 20);
            this.lb_salle.TabIndex = 51;
            this.lb_salle.Text = "Employe:";
            // 
            // rb_Exterieur
            // 
            this.rb_Exterieur.AutoSize = true;
            this.rb_Exterieur.Location = new System.Drawing.Point(327, 123);
            this.rb_Exterieur.Name = "rb_Exterieur";
            this.rb_Exterieur.Size = new System.Drawing.Size(66, 17);
            this.rb_Exterieur.TabIndex = 48;
            this.rb_Exterieur.TabStop = true;
            this.rb_Exterieur.Text = "Extérieur";
            this.rb_Exterieur.UseVisualStyleBackColor = true;
            this.rb_Exterieur.CheckedChanged += new System.EventHandler(this.rb_Exterieur_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(193, 256);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 45;
            // 
            // rb_intérieur
            // 
            this.rb_intérieur.AutoSize = true;
            this.rb_intérieur.Location = new System.Drawing.Point(180, 123);
            this.rb_intérieur.Name = "rb_intérieur";
            this.rb_intérieur.Size = new System.Drawing.Size(63, 17);
            this.rb_intérieur.TabIndex = 47;
            this.rb_intérieur.TabStop = true;
            this.rb_intérieur.Text = "Intérieur";
            this.rb_intérieur.UseVisualStyleBackColor = true;
            this.rb_intérieur.CheckedChanged += new System.EventHandler(this.rb_intérieur_CheckedChanged_1);
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
            this.bt_Valider.Location = new System.Drawing.Point(276, 370);
            this.bt_Valider.Name = "bt_Valider";
            this.bt_Valider.Size = new System.Drawing.Size(127, 28);
            this.bt_Valider.TabIndex = 46;
            this.bt_Valider.Text = "Valider";
            this.bt_Valider.UseVisualStyleBackColor = false;
            this.bt_Valider.Click += new System.EventHandler(this.bt_Valider_Click);
            // 
            // txt_nomEv
            // 
            this.txt_nomEv.BackColor = System.Drawing.SystemColors.Control;
            this.txt_nomEv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nomEv.Location = new System.Drawing.Point(199, 48);
            this.txt_nomEv.Name = "txt_nomEv";
            this.txt_nomEv.Size = new System.Drawing.Size(196, 20);
            this.txt_nomEv.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(12, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "Type Evénement :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(12, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Nom Evénement :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(12, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Date Evénement";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Control;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Location = new System.Drawing.Point(136, 54);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(226, 20);
            this.textBox7.TabIndex = 27;
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
            this.bt_Annuler.Location = new System.Drawing.Point(431, 418);
            this.bt_Annuler.Name = "bt_Annuler";
            this.bt_Annuler.Size = new System.Drawing.Size(127, 28);
            this.bt_Annuler.TabIndex = 43;
            this.bt_Annuler.Text = "Annuler";
            this.bt_Annuler.UseVisualStyleBackColor = false;
            this.bt_Annuler.Click += new System.EventHandler(this.bt_Annuler_Click);
            // 
            // txt_dure
            // 
            this.txt_dure.BackColor = System.Drawing.SystemColors.Control;
            this.txt_dure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_dure.Location = new System.Drawing.Point(603, 228);
            this.txt_dure.Name = "txt_dure";
            this.txt_dure.Size = new System.Drawing.Size(189, 20);
            this.txt_dure.TabIndex = 41;
            this.txt_dure.Click += new System.EventHandler(this.txt_dure_Click);
            this.txt_dure.TextChanged += new System.EventHandler(this.txt_dure_TextChanged);
            // 
            // txt_prix
            // 
            this.txt_prix.BackColor = System.Drawing.SystemColors.Control;
            this.txt_prix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_prix.Location = new System.Drawing.Point(589, 96);
            this.txt_prix.Name = "txt_prix";
            this.txt_prix.Size = new System.Drawing.Size(187, 20);
            this.txt_prix.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(427, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 20);
            this.label7.TabIndex = 40;
            this.label7.Text = "Prix  Evénement";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(427, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "Durée Evénement";
            // 
            // cb_salle
            // 
            this.cb_salle.FormattingEnabled = true;
            this.cb_salle.Location = new System.Drawing.Point(589, 167);
            this.cb_salle.Name = "cb_salle";
            this.cb_salle.Size = new System.Drawing.Size(194, 21);
            this.cb_salle.TabIndex = 53;
            this.cb_salle.Visible = false;
            // 
            // AjouterEvenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.cb_salle);
            this.Controls.Add(this.bt_Annuler);
            this.Controls.Add(this.txt_dure);
            this.Controls.Add(this.txt_prix);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AjouterEvenement";
            this.Text = "AjouterEvenement";
            this.Load += new System.EventHandler(this.AjouterEvenement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.RadioButton rb_Exterieur;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rb_intérieur;
        private System.Windows.Forms.Button bt_Valider;
        private System.Windows.Forms.TextBox txt_nomEv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_Annuler;
        private System.Windows.Forms.TextBox txt_dure;
        private System.Windows.Forms.TextBox txt_prix;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_employe;
        private System.Windows.Forms.Label lb_salle;
        private System.Windows.Forms.ComboBox cb_salle;
    }
}