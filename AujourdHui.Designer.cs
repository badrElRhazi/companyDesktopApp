
namespace csse3
{
    partial class AujourdHui
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_Agenda = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_Date = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_valider = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Agenda)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 82);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(372, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aujourd\'hui";
            // 
            // DGV_Agenda
            // 
            this.DGV_Agenda.AllowUserToAddRows = false;
            this.DGV_Agenda.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGV_Agenda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Agenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Agenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Agenda.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_Agenda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGV_Agenda.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.DGV_Agenda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Agenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Agenda.ColumnHeadersHeight = 50;
            this.DGV_Agenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Agenda.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Agenda.EnableHeadersVisualStyles = false;
            this.DGV_Agenda.GridColor = System.Drawing.SystemColors.Control;
            this.DGV_Agenda.Location = new System.Drawing.Point(12, 113);
            this.DGV_Agenda.Name = "DGV_Agenda";
            this.DGV_Agenda.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Agenda.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_Agenda.RowHeadersVisible = false;
            this.DGV_Agenda.RowHeadersWidth = 30;
            this.DGV_Agenda.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(10);
            this.DGV_Agenda.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_Agenda.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(30, 0, 15, 0);
            this.DGV_Agenda.RowTemplate.Height = 50;
            this.DGV_Agenda.Size = new System.Drawing.Size(1018, 392);
            this.DGV_Agenda.TabIndex = 14;
            this.DGV_Agenda.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(25, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 39);
            this.label5.TabIndex = 26;
            this.label5.Text = "Employé:\r\n";
            // 
            // cb_Date
            // 
            this.cb_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Date.FormattingEnabled = true;
            this.cb_Date.Location = new System.Drawing.Point(247, 68);
            this.cb_Date.Name = "cb_Date";
            this.cb_Date.Size = new System.Drawing.Size(277, 32);
            this.cb_Date.TabIndex = 25;
            this.cb_Date.SelectedIndexChanged += new System.EventHandler(this.cb_Date_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.bt_valider);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cb_Date);
            this.panel2.Location = new System.Drawing.Point(221, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(569, 195);
            this.panel2.TabIndex = 27;
            // 
            // bt_valider
            // 
            this.bt_valider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_valider.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt_valider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_valider.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_valider.Location = new System.Drawing.Point(237, 141);
            this.bt_valider.Name = "bt_valider";
            this.bt_valider.Size = new System.Drawing.Size(155, 38);
            this.bt_valider.TabIndex = 27;
            this.bt_valider.Text = "Valider";
            this.bt_valider.UseVisualStyleBackColor = false;
            this.bt_valider.Click += new System.EventHandler(this.bt_valider_Click);
            // 
            // AujourdHui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 517);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DGV_Agenda);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AujourdHui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AujourdHui";
            this.Load += new System.EventHandler(this.AujourdHui_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Agenda)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_Agenda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_Date;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_valider;
    }
}