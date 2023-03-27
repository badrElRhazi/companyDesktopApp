
namespace csse3
{
    partial class GestionEquipe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.DGV_Equipe1 = new System.Windows.Forms.DataGridView();
            this.cb_Formation = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_imprimer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Equipe1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(953, 44);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(71, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestion Des Equipe";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::csse3.Properties.Resources.icons8_user_group_30px;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bt_imprimer);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.DGV_Equipe1);
            this.panel3.Controls.Add(this.cb_Formation);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(953, 482);
            this.panel3.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Adhérents inscrits :";
            // 
            // DGV_Equipe1
            // 
            this.DGV_Equipe1.AllowUserToAddRows = false;
            this.DGV_Equipe1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGV_Equipe1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DGV_Equipe1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Equipe1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Equipe1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_Equipe1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_Equipe1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGV_Equipe1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.DGV_Equipe1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Equipe1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DGV_Equipe1.ColumnHeadersHeight = 50;
            this.DGV_Equipe1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Equipe1.DefaultCellStyle = dataGridViewCellStyle8;
            this.DGV_Equipe1.EnableHeadersVisualStyles = false;
            this.DGV_Equipe1.GridColor = System.Drawing.SystemColors.Control;
            this.DGV_Equipe1.Location = new System.Drawing.Point(9, 88);
            this.DGV_Equipe1.Name = "DGV_Equipe1";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Equipe1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DGV_Equipe1.RowHeadersVisible = false;
            this.DGV_Equipe1.RowHeadersWidth = 30;
            this.DGV_Equipe1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(10);
            this.DGV_Equipe1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DGV_Equipe1.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(30, 0, 15, 0);
            this.DGV_Equipe1.RowTemplate.Height = 30;
            this.DGV_Equipe1.ShowCellErrors = false;
            this.DGV_Equipe1.ShowRowErrors = false;
            this.DGV_Equipe1.Size = new System.Drawing.Size(938, 362);
            this.DGV_Equipe1.TabIndex = 22;
            this.DGV_Equipe1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Equipe1_CellContentClick_1);
            // 
            // cb_Formation
            // 
            this.cb_Formation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cb_Formation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Formation.ForeColor = System.Drawing.SystemColors.Info;
            this.cb_Formation.FormattingEnabled = true;
            this.cb_Formation.Location = new System.Drawing.Point(90, 12);
            this.cb_Formation.Name = "cb_Formation";
            this.cb_Formation.Size = new System.Drawing.Size(274, 21);
            this.cb_Formation.TabIndex = 21;
            this.cb_Formation.SelectedIndexChanged += new System.EventHandler(this.cb_Formation_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(6, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Formation:";
            // 
            // bt_imprimer
            // 
            this.bt_imprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_imprimer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt_imprimer.FlatAppearance.BorderSize = 0;
            this.bt_imprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_imprimer.Location = new System.Drawing.Point(854, 450);
            this.bt_imprimer.Name = "bt_imprimer";
            this.bt_imprimer.Size = new System.Drawing.Size(93, 32);
            this.bt_imprimer.TabIndex = 24;
            this.bt_imprimer.Text = "Imprimer";
            this.bt_imprimer.UseVisualStyleBackColor = false;
            this.bt_imprimer.Click += new System.EventHandler(this.bt_imprimer_Click_1);
            // 
            // GestionEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(953, 526);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionEquipe";
            this.Text = "GestionEquipe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestionEquipe_FormClosing);
            this.Load += new System.EventHandler(this.GestionEquipe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Equipe1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bt_imprimer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGV_Equipe1;
        private System.Windows.Forms.ComboBox cb_Formation;
        private System.Windows.Forms.Label label3;
    }
}