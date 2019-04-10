namespace DMXControl.Controls
{
    partial class UcPar56Sliders
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.trbRedDste = new System.Windows.Forms.TrackBar();
            this.lblRedDste = new System.Windows.Forms.Label();
            this.trbGreenDste = new System.Windows.Forms.TrackBar();
            this.lblGreenDste = new System.Windows.Forms.Label();
            this.lblBlueDste = new System.Windows.Forms.Label();
            this.trbBlueDste = new System.Windows.Forms.TrackBar();
            this.pbOutputColorDste = new System.Windows.Forms.PictureBox();
            this.lblStrobeDste = new System.Windows.Forms.Label();
            this.trbStrobeDste = new System.Windows.Forms.TrackBar();
            this.btnResetDSte = new System.Windows.Forms.Button();
            this.lblStatusDSte = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trbRedDste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbGreenDste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBlueDste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutputColorDste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbStrobeDste)).BeginInit();
            this.SuspendLayout();
            // 
            // trbRedDste
            // 
            this.trbRedDste.Location = new System.Drawing.Point(53, 10);
            this.trbRedDste.Maximum = 255;
            this.trbRedDste.Name = "trbRedDste";
            this.trbRedDste.Size = new System.Drawing.Size(228, 45);
            this.trbRedDste.TabIndex = 0;
            this.trbRedDste.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbRedDste.Scroll += new System.EventHandler(this.TrackBarScroll);
            // 
            // lblRedDste
            // 
            this.lblRedDste.AutoSize = true;
            this.lblRedDste.Location = new System.Drawing.Point(20, 15);
            this.lblRedDste.Name = "lblRedDste";
            this.lblRedDste.Size = new System.Drawing.Size(27, 13);
            this.lblRedDste.TabIndex = 1;
            this.lblRedDste.Text = "Red";
            // 
            // trbGreenDste
            // 
            this.trbGreenDste.Location = new System.Drawing.Point(53, 61);
            this.trbGreenDste.Maximum = 255;
            this.trbGreenDste.Name = "trbGreenDste";
            this.trbGreenDste.Size = new System.Drawing.Size(228, 45);
            this.trbGreenDste.TabIndex = 0;
            this.trbGreenDste.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbGreenDste.Scroll += new System.EventHandler(this.TrackBarScroll);
            // 
            // lblGreenDste
            // 
            this.lblGreenDste.AutoSize = true;
            this.lblGreenDste.Location = new System.Drawing.Point(12, 66);
            this.lblGreenDste.Name = "lblGreenDste";
            this.lblGreenDste.Size = new System.Drawing.Size(36, 13);
            this.lblGreenDste.TabIndex = 1;
            this.lblGreenDste.Text = "Green";
            // 
            // lblBlueDste
            // 
            this.lblBlueDste.AutoSize = true;
            this.lblBlueDste.Location = new System.Drawing.Point(12, 117);
            this.lblBlueDste.Name = "lblBlueDste";
            this.lblBlueDste.Size = new System.Drawing.Size(28, 13);
            this.lblBlueDste.TabIndex = 3;
            this.lblBlueDste.Text = "Blue";
            // 
            // trbBlueDste
            // 
            this.trbBlueDste.Location = new System.Drawing.Point(53, 112);
            this.trbBlueDste.Maximum = 255;
            this.trbBlueDste.Name = "trbBlueDste";
            this.trbBlueDste.Size = new System.Drawing.Size(228, 45);
            this.trbBlueDste.TabIndex = 2;
            this.trbBlueDste.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbBlueDste.Scroll += new System.EventHandler(this.TrackBarScroll);
            // 
            // pbOutputColorDste
            // 
            this.pbOutputColorDste.BackColor = System.Drawing.Color.Black;
            this.pbOutputColorDste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbOutputColorDste.Location = new System.Drawing.Point(297, 10);
            this.pbOutputColorDste.Name = "pbOutputColorDste";
            this.pbOutputColorDste.Size = new System.Drawing.Size(92, 147);
            this.pbOutputColorDste.TabIndex = 10;
            this.pbOutputColorDste.TabStop = false;
            // 
            // lblStrobeDste
            // 
            this.lblStrobeDste.AutoSize = true;
            this.lblStrobeDste.Location = new System.Drawing.Point(12, 181);
            this.lblStrobeDste.Name = "lblStrobeDste";
            this.lblStrobeDste.Size = new System.Drawing.Size(38, 13);
            this.lblStrobeDste.TabIndex = 12;
            this.lblStrobeDste.Text = "Strobe";
            // 
            // trbStrobeDste
            // 
            this.trbStrobeDste.Location = new System.Drawing.Point(53, 176);
            this.trbStrobeDste.Maximum = 255;
            this.trbStrobeDste.Name = "trbStrobeDste";
            this.trbStrobeDste.Size = new System.Drawing.Size(228, 45);
            this.trbStrobeDste.TabIndex = 11;
            this.trbStrobeDste.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // btnResetDSte
            // 
            this.btnResetDSte.Location = new System.Drawing.Point(297, 163);
            this.btnResetDSte.Name = "btnResetDSte";
            this.btnResetDSte.Size = new System.Drawing.Size(92, 58);
            this.btnResetDSte.TabIndex = 13;
            this.btnResetDSte.Text = "Reset";
            this.btnResetDSte.UseVisualStyleBackColor = true;
            this.btnResetDSte.Click += new System.EventHandler(this.BtnResetDSte_Click);
            // 
            // lblStatusDSte
            // 
            this.lblStatusDSte.AutoSize = true;
            this.lblStatusDSte.Location = new System.Drawing.Point(12, 247);
            this.lblStatusDSte.Name = "lblStatusDSte";
            this.lblStatusDSte.Size = new System.Drawing.Size(146, 13);
            this.lblStatusDSte.TabIndex = 15;
            this.lblStatusDSte.Text = "idk what this status should do";
            // 
            // UcPar56Sliders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblStatusDSte);
            this.Controls.Add(this.btnResetDSte);
            this.Controls.Add(this.lblStrobeDste);
            this.Controls.Add(this.trbStrobeDste);
            this.Controls.Add(this.pbOutputColorDste);
            this.Controls.Add(this.lblBlueDste);
            this.Controls.Add(this.trbBlueDste);
            this.Controls.Add(this.lblGreenDste);
            this.Controls.Add(this.lblRedDste);
            this.Controls.Add(this.trbGreenDste);
            this.Controls.Add(this.trbRedDste);
            this.Name = "UcPar56Sliders";
            this.Size = new System.Drawing.Size(401, 360);
            ((System.ComponentModel.ISupportInitialize)(this.trbRedDste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbGreenDste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBlueDste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutputColorDste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbStrobeDste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trbRedDste;
        private System.Windows.Forms.Label lblRedDste;
        private System.Windows.Forms.TrackBar trbGreenDste;
        private System.Windows.Forms.Label lblGreenDste;
        private System.Windows.Forms.Label lblBlueDste;
        private System.Windows.Forms.TrackBar trbBlueDste;
        private System.Windows.Forms.PictureBox pbOutputColorDste;
        private System.Windows.Forms.Label lblStrobeDste;
        private System.Windows.Forms.TrackBar trbStrobeDste;
        private System.Windows.Forms.Button btnResetDSte;
        private System.Windows.Forms.Label lblStatusDSte;
    }
}
