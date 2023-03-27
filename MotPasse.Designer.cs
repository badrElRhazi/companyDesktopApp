
namespace csse3
{
    partial class MotPasse
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_cin = new System.Windows.Forms.TextBox();
            this.CIN = new System.Windows.Forms.Label();
            this.txt_mdpActuel = new System.Windows.Forms.TextBox();
            this.txt_nvMdp = new System.Windows.Forms.TextBox();
            this.txt_confirmationnv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_Annuler = new System.Windows.Forms.Button();
            this.bt_confirmer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 54);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::csse3.Properties.Resources.icons8_services_30px;
            this.pictureBox1.Location = new System.Drawing.Point(4, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(72, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Paramétre";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel4.Controls.Add(this.txt_cin);
            this.panel4.Controls.Add(this.CIN);
            this.panel4.Controls.Add(this.txt_mdpActuel);
            this.panel4.Controls.Add(this.txt_nvMdp);
            this.panel4.Controls.Add(this.txt_confirmationnv);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.bt_Annuler);
            this.panel4.Controls.Add(this.bt_confirmer);
            this.panel4.Location = new System.Drawing.Point(80, 53);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(900, 574);
            this.panel4.TabIndex = 3;
            // 
            // txt_cin
            // 
            this.txt_cin.Location = new System.Drawing.Point(451, 43);
            this.txt_cin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cin.Name = "txt_cin";
            this.txt_cin.Size = new System.Drawing.Size(433, 22);
            this.txt_cin.TabIndex = 0;
            // 
            // CIN
            // 
            this.CIN.AutoSize = true;
            this.CIN.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CIN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CIN.Location = new System.Drawing.Point(16, 30);
            this.CIN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CIN.Name = "CIN";
            this.CIN.Size = new System.Drawing.Size(99, 40);
            this.CIN.TabIndex = 50;
            this.CIN.Text = "CIN :";
            // 
            // txt_mdpActuel
            // 
            this.txt_mdpActuel.Location = new System.Drawing.Point(451, 150);
            this.txt_mdpActuel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_mdpActuel.Name = "txt_mdpActuel";
            this.txt_mdpActuel.PasswordChar = '*';
            this.txt_mdpActuel.Size = new System.Drawing.Size(433, 22);
            this.txt_mdpActuel.TabIndex = 1;
            // 
            // txt_nvMdp
            // 
            this.txt_nvMdp.Location = new System.Drawing.Point(451, 241);
            this.txt_nvMdp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nvMdp.Name = "txt_nvMdp";
            this.txt_nvMdp.PasswordChar = '*';
            this.txt_nvMdp.Size = new System.Drawing.Size(437, 22);
            this.txt_nvMdp.TabIndex = 2;
            // 
            // txt_confirmationnv
            // 
            this.txt_confirmationnv.Location = new System.Drawing.Point(451, 384);
            this.txt_confirmationnv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_confirmationnv.Name = "txt_confirmationnv";
            this.txt_confirmationnv.PasswordChar = '*';
            this.txt_confirmationnv.Size = new System.Drawing.Size(433, 22);
            this.txt_confirmationnv.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(16, 358);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(366, 80);
            this.label4.TabIndex = 46;
            this.label4.Text = "Confirmer Le nouveau \r\nmot de passe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(16, 228);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(361, 40);
            this.label3.TabIndex = 45;
            this.label3.Text = "Nouveau mot de passe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(16, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 40);
            this.label2.TabIndex = 44;
            this.label2.Text = "Mot de Passe actuel :";
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
            this.bt_Annuler.Location = new System.Drawing.Point(463, 524);
            this.bt_Annuler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Annuler.Name = "bt_Annuler";
            this.bt_Annuler.Size = new System.Drawing.Size(169, 34);
            this.bt_Annuler.TabIndex = 5;
            this.bt_Annuler.Text = "Annuler";
            this.bt_Annuler.UseVisualStyleBackColor = false;
            this.bt_Annuler.Click += new System.EventHandler(this.bt_Annuler_Click);
            // 
            // bt_confirmer
            // 
            this.bt_confirmer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_confirmer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_confirmer.FlatAppearance.BorderSize = 0;
            this.bt_confirmer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.bt_confirmer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.bt_confirmer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_confirmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_confirmer.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bt_confirmer.Location = new System.Drawing.Point(225, 524);
            this.bt_confirmer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_confirmer.Name = "bt_confirmer";
            this.bt_confirmer.Size = new System.Drawing.Size(169, 34);
            this.bt_confirmer.TabIndex = 4;
            this.bt_confirmer.Text = "Confirmer";
            this.bt_confirmer.UseVisualStyleBackColor = false;
            this.bt_confirmer.Click += new System.EventHandler(this.bt_confirmer_Click);
            // 
            // MotPasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 626);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MotPasse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MotPasse";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button bt_Annuler;
        private System.Windows.Forms.Button bt_confirmer;
        private System.Windows.Forms.TextBox txt_cin;
        private System.Windows.Forms.Label CIN;
        private System.Windows.Forms.TextBox txt_mdpActuel;
        private System.Windows.Forms.TextBox txt_nvMdp;
        private System.Windows.Forms.TextBox txt_confirmationnv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}