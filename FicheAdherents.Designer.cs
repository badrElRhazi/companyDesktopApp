
namespace csse3
{
    partial class FicheAdherents
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_Imprimer1 = new System.Windows.Forms.Button();
            this.cb_equipe = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.bt_Imprimer1);
            this.panel2.Controls.Add(this.cb_equipe);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(242, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(423, 254);
            this.panel2.TabIndex = 22;
            // 
            // bt_Imprimer1
            // 
            this.bt_Imprimer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Imprimer1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt_Imprimer1.FlatAppearance.BorderSize = 0;
            this.bt_Imprimer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Imprimer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Imprimer1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Imprimer1.Location = new System.Drawing.Point(51, 205);
            this.bt_Imprimer1.Name = "bt_Imprimer1";
            this.bt_Imprimer1.Size = new System.Drawing.Size(330, 35);
            this.bt_Imprimer1.TabIndex = 21;
            this.bt_Imprimer1.Text = "Imprimer";
            this.bt_Imprimer1.UseVisualStyleBackColor = false;
            this.bt_Imprimer1.Click += new System.EventHandler(this.bt_Imprimer1_Click);
            // 
            // cb_equipe
            // 
            this.cb_equipe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_equipe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cb_equipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_equipe.ForeColor = System.Drawing.SystemColors.Info;
            this.cb_equipe.FormattingEnabled = true;
            this.cb_equipe.Location = new System.Drawing.Point(90, 123);
            this.cb_equipe.Name = "cb_equipe";
            this.cb_equipe.Size = new System.Drawing.Size(274, 21);
            this.cb_equipe.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(15, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Equipe :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(123, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "Impression Fiche\r\n     Adhérents";
            // 
            // FicheAdherents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "FicheAdherents";
            this.Text = "FicheAdherents";
            this.Load += new System.EventHandler(this.FicheAdherents_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_Imprimer1;
        private System.Windows.Forms.ComboBox cb_equipe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}