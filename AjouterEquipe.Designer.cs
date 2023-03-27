
namespace csse3
{
    partial class AjouterEquipe
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
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_employe = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_Annuler = new System.Windows.Forms.Button();
            this.bt_Valider = new System.Windows.Forms.Button();
            this.txt_nbr = new System.Windows.Forms.TextBox();
            this.txt_NomEquipe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cb_Formation = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 52);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::csse3.Properties.Resources.icons8_user_group_30px;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(81, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(173, 31);
            this.label15.TabIndex = 49;
            this.label15.Text = "Nouvel Equipe";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.cb_Formation);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cb_employe);
            this.panel2.Controls.Add(this.bt_Annuler);
            this.panel2.Controls.Add(this.bt_Valider);
            this.panel2.Controls.Add(this.txt_nbr);
            this.panel2.Controls.Add(this.txt_NomEquipe);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(917, 488);
            this.panel2.TabIndex = 1;
            // 
            // cb_employe
            // 
            this.cb_employe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cb_employe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_employe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_employe.ForeColor = System.Drawing.SystemColors.Info;
            this.cb_employe.FormattingEnabled = true;
            this.cb_employe.Location = new System.Drawing.Point(435, 312);
            this.cb_employe.Name = "cb_employe";
            this.cb_employe.Size = new System.Drawing.Size(280, 24);
            this.cb_employe.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(215, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 34);
            this.label1.TabIndex = 60;
            this.label1.Text = "Employé :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(203, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 34);
            this.label5.TabIndex = 56;
            this.label5.Text = "Formation :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
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
            this.bt_Annuler.Location = new System.Drawing.Point(503, 457);
            this.bt_Annuler.Name = "bt_Annuler";
            this.bt_Annuler.Size = new System.Drawing.Size(127, 28);
            this.bt_Annuler.TabIndex = 55;
            this.bt_Annuler.Text = "Annuler";
            this.bt_Annuler.UseVisualStyleBackColor = false;
            this.bt_Annuler.Click += new System.EventHandler(this.bt_Annuler_Click);
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
            this.bt_Valider.Location = new System.Drawing.Point(288, 457);
            this.bt_Valider.Name = "bt_Valider";
            this.bt_Valider.Size = new System.Drawing.Size(127, 28);
            this.bt_Valider.TabIndex = 54;
            this.bt_Valider.Text = "Valider";
            this.bt_Valider.UseVisualStyleBackColor = false;
            this.bt_Valider.Click += new System.EventHandler(this.bt_Valider_Click);
            // 
            // txt_nbr
            // 
            this.txt_nbr.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_nbr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nbr.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_nbr.Location = new System.Drawing.Point(435, 135);
            this.txt_nbr.Multiline = true;
            this.txt_nbr.Name = "txt_nbr";
            this.txt_nbr.Size = new System.Drawing.Size(280, 24);
            this.txt_nbr.TabIndex = 53;
            // 
            // txt_NomEquipe
            // 
            this.txt_NomEquipe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_NomEquipe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_NomEquipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NomEquipe.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_NomEquipe.Location = new System.Drawing.Point(433, 50);
            this.txt_NomEquipe.Multiline = true;
            this.txt_NomEquipe.Name = "txt_NomEquipe";
            this.txt_NomEquipe.Size = new System.Drawing.Size(282, 20);
            this.txt_NomEquipe.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(165, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 29);
            this.label4.TabIndex = 50;
            this.label4.Text = "Nombre Membres D\'Equipe :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(203, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 34);
            this.label2.TabIndex = 49;
            this.label2.Text = "Nom Equipe :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Location = new System.Drawing.Point(433, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(282, 1);
            this.panel3.TabIndex = 63;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel4.Location = new System.Drawing.Point(435, 161);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(282, 1);
            this.panel4.TabIndex = 64;
            // 
            // cb_Formation
            // 
            this.cb_Formation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cb_Formation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Formation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Formation.ForeColor = System.Drawing.SystemColors.Info;
            this.cb_Formation.FormattingEnabled = true;
            this.cb_Formation.Location = new System.Drawing.Point(433, 221);
            this.cb_Formation.Name = "cb_Formation";
            this.cb_Formation.Size = new System.Drawing.Size(280, 24);
            this.cb_Formation.TabIndex = 65;
            // 
            // AjouterEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 540);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AjouterEquipe";
            this.Text = "AjouterEquipe";
            this.Load += new System.EventHandler(this.AjouterEquipe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_Annuler;
        private System.Windows.Forms.Button bt_Valider;
        private System.Windows.Forms.TextBox txt_nbr;
        private System.Windows.Forms.TextBox txt_NomEquipe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_employe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cb_Formation;
    }
}