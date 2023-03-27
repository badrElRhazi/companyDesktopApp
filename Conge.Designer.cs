
namespace csse3
{
    partial class Conge
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
            this.bt_annulerConge = new System.Windows.Forms.Button();
            this.cb_employe = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_duree = new System.Windows.Forms.TextBox();
            this.Date_Fin = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.Date_Debut = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(797, 44);
            this.panel1.TabIndex = 2;
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
            this.panel2.Size = new System.Drawing.Size(557, 452);
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
            this.bt_Annuler.Location = new System.Drawing.Point(280, 417);
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
            this.bt_Valider.Location = new System.Drawing.Point(102, 417);
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
            this.pictureBox1.Image = global::csse3.Properties.Resources.icons8_archive_folder_30px_1;
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
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(54, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Congé";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.bt_annulerConge);
            this.panel3.Controls.Add(this.cb_employe);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txt_duree);
            this.panel3.Controls.Add(this.Date_Fin);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.Date_Debut);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(797, 450);
            this.panel3.TabIndex = 3;
            // 
            // bt_annulerConge
            // 
            this.bt_annulerConge.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_annulerConge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_annulerConge.FlatAppearance.BorderSize = 0;
            this.bt_annulerConge.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.bt_annulerConge.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.bt_annulerConge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_annulerConge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_annulerConge.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bt_annulerConge.Location = new System.Drawing.Point(429, 422);
            this.bt_annulerConge.Name = "bt_annulerConge";
            this.bt_annulerConge.Size = new System.Drawing.Size(127, 28);
            this.bt_annulerConge.TabIndex = 39;
            this.bt_annulerConge.Text = "Annuler";
            this.bt_annulerConge.UseVisualStyleBackColor = false;
            this.bt_annulerConge.Click += new System.EventHandler(this.bt_annulerConge_Click);
            // 
            // cb_employe
            // 
            this.cb_employe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_employe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cb_employe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_employe.ForeColor = System.Drawing.SystemColors.Menu;
            this.cb_employe.FormattingEnabled = true;
            this.cb_employe.Location = new System.Drawing.Point(360, 35);
            this.cb_employe.Name = "cb_employe";
            this.cb_employe.Size = new System.Drawing.Size(251, 21);
            this.cb_employe.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(186, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 24);
            this.label8.TabIndex = 42;
            this.label8.Text = "Nombre Congé :";
            this.label8.Visible = false;
            // 
            // txt_duree
            // 
            this.txt_duree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_duree.Location = new System.Drawing.Point(392, 351);
            this.txt_duree.Name = "txt_duree";
            this.txt_duree.Size = new System.Drawing.Size(219, 20);
            this.txt_duree.TabIndex = 41;
            this.txt_duree.Visible = false;
            // 
            // Date_Fin
            // 
            this.Date_Fin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Date_Fin.Location = new System.Drawing.Point(360, 261);
            this.Date_Fin.Name = "Date_Fin";
            this.Date_Fin.Size = new System.Drawing.Size(251, 20);
            this.Date_Fin.TabIndex = 40;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(230, 419);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 28);
            this.button2.TabIndex = 38;
            this.button2.Text = "Valider";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Date_Debut
            // 
            this.Date_Debut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Date_Debut.Location = new System.Drawing.Point(360, 149);
            this.Date_Debut.Name = "Date_Debut";
            this.Date_Debut.Size = new System.Drawing.Size(251, 20);
            this.Date_Debut.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(211, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Date Début:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(215, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "Date Fin :";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(211, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 24);
            this.label10.TabIndex = 43;
            this.label10.Text = "Employé :";
            // 
            // Conge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 494);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Conge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conge";
            this.Load += new System.EventHandler(this.Conge_Load);
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
        private System.Windows.Forms.TextBox txt_duree;
        private System.Windows.Forms.DateTimePicker Date_Fin;
        private System.Windows.Forms.Button bt_annulerConge;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker Date_Debut;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_employe;
    }
}