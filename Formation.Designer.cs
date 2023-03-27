
namespace csse3
{
    partial class Formation
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rb_versement = new System.Windows.Forms.RadioButton();
            this.rb_virement = new System.Windows.Forms.RadioButton();
            this.rb_cheque = new System.Windows.Forms.RadioButton();
            this.bt_Valider = new System.Windows.Forms.Button();
            this.lb_Regelement = new System.Windows.Forms.Label();
            this.txt_secteur = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_Annuler = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 45);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(63, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Formation";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::csse3.Properties.Resources.icons8_attendance_30px1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.bt_Annuler);
            this.panel2.Controls.Add(this.rb_versement);
            this.panel2.Controls.Add(this.rb_virement);
            this.panel2.Controls.Add(this.rb_cheque);
            this.panel2.Controls.Add(this.bt_Valider);
            this.panel2.Controls.Add(this.lb_Regelement);
            this.panel2.Controls.Add(this.txt_secteur);
            this.panel2.Controls.Add(this.txt_nom);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(436, 411);
            this.panel2.TabIndex = 1;
            // 
            // rb_versement
            // 
            this.rb_versement.AutoSize = true;
            this.rb_versement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_versement.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rb_versement.Location = new System.Drawing.Point(342, 256);
            this.rb_versement.Name = "rb_versement";
            this.rb_versement.Size = new System.Drawing.Size(91, 20);
            this.rb_versement.TabIndex = 52;
            this.rb_versement.TabStop = true;
            this.rb_versement.Text = "Versement";
            this.rb_versement.UseVisualStyleBackColor = true;
            this.rb_versement.CheckedChanged += new System.EventHandler(this.rb_versement_CheckedChanged);
            // 
            // rb_virement
            // 
            this.rb_virement.AutoSize = true;
            this.rb_virement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_virement.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rb_virement.Location = new System.Drawing.Point(253, 256);
            this.rb_virement.Name = "rb_virement";
            this.rb_virement.Size = new System.Drawing.Size(79, 20);
            this.rb_virement.TabIndex = 51;
            this.rb_virement.TabStop = true;
            this.rb_virement.Text = "Virement";
            this.rb_virement.UseVisualStyleBackColor = true;
            this.rb_virement.CheckedChanged += new System.EventHandler(this.rb_virement_CheckedChanged);
            // 
            // rb_cheque
            // 
            this.rb_cheque.AutoSize = true;
            this.rb_cheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_cheque.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rb_cheque.Location = new System.Drawing.Point(174, 256);
            this.rb_cheque.Name = "rb_cheque";
            this.rb_cheque.Size = new System.Drawing.Size(73, 20);
            this.rb_cheque.TabIndex = 50;
            this.rb_cheque.TabStop = true;
            this.rb_cheque.Text = "Chéque";
            this.rb_cheque.UseVisualStyleBackColor = true;
            this.rb_cheque.CheckedChanged += new System.EventHandler(this.rb_cheque_CheckedChanged);
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
            this.bt_Valider.Location = new System.Drawing.Point(23, 380);
            this.bt_Valider.Name = "bt_Valider";
            this.bt_Valider.Size = new System.Drawing.Size(127, 28);
            this.bt_Valider.TabIndex = 53;
            this.bt_Valider.Text = " Valider";
            this.bt_Valider.UseVisualStyleBackColor = false;
            this.bt_Valider.Click += new System.EventHandler(this.bt_Valider_Click);
            // 
            // lb_Regelement
            // 
            this.lb_Regelement.AutoSize = true;
            this.lb_Regelement.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_Regelement.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Regelement.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_Regelement.Location = new System.Drawing.Point(3, 256);
            this.lb_Regelement.Name = "lb_Regelement";
            this.lb_Regelement.Size = new System.Drawing.Size(165, 19);
            this.lb_Regelement.TabIndex = 49;
            this.lb_Regelement.Text = "Type de Reglement :";
            // 
            // txt_secteur
            // 
            this.txt_secteur.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_secteur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_secteur.ForeColor = System.Drawing.SystemColors.Menu;
            this.txt_secteur.Location = new System.Drawing.Point(153, 167);
            this.txt_secteur.Name = "txt_secteur";
            this.txt_secteur.Size = new System.Drawing.Size(280, 13);
            this.txt_secteur.TabIndex = 47;
            // 
            // txt_nom
            // 
            this.txt_nom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_nom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nom.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txt_nom.Location = new System.Drawing.Point(155, 84);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(278, 13);
            this.txt_nom.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(8, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 19);
            this.label4.TabIndex = 44;
            this.label4.Text = "Secteurd\'activité:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(7, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 19);
            this.label3.TabIndex = 43;
            this.label3.Text = "Nom Formation :";
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
            this.bt_Annuler.Location = new System.Drawing.Point(239, 379);
            this.bt_Annuler.Name = "bt_Annuler";
            this.bt_Annuler.Size = new System.Drawing.Size(127, 31);
            this.bt_Annuler.TabIndex = 40;
            this.bt_Annuler.Text = "Annuler";
            this.bt_Annuler.UseVisualStyleBackColor = false;
            this.bt_Annuler.Click += new System.EventHandler(this.bt_Annuler_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::csse3.Properties.Resources.formation;
            this.pictureBox2.Location = new System.Drawing.Point(439, 75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(418, 293);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Location = new System.Drawing.Point(150, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(283, 1);
            this.panel3.TabIndex = 54;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Location = new System.Drawing.Point(153, 182);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(283, 1);
            this.panel4.TabIndex = 55;
            // 
            // Formation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(857, 452);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formation";
            this.Load += new System.EventHandler(this.Formation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rb_versement;
        private System.Windows.Forms.RadioButton rb_virement;
        private System.Windows.Forms.RadioButton rb_cheque;
        private System.Windows.Forms.Button bt_Valider;
        private System.Windows.Forms.Label lb_Regelement;
        private System.Windows.Forms.TextBox txt_secteur;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_Annuler;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}