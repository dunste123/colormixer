namespace DMXControl.Controls
{
    partial class UcMovingHeadSliders
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
            this.trbXDSte = new System.Windows.Forms.TrackBar();
            this.lblRedDste = new System.Windows.Forms.Label();
            this.trbYDSte = new System.Windows.Forms.TrackBar();
            this.lblGreenDste = new System.Windows.Forms.Label();
            this.lblBlueDste = new System.Windows.Forms.Label();
            this.trbDmStrbDSte = new System.Windows.Forms.TrackBar();
            this.lblStrobeDste = new System.Windows.Forms.Label();
            this.trbGoboDSte = new System.Windows.Forms.TrackBar();
            this.btnResetDSte = new System.Windows.Forms.Button();
            this.trbColorDSte = new System.Windows.Forms.TrackBar();
            this.lblYfineDSte = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trbXDSte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbYDSte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbDmStrbDSte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbGoboDSte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbColorDSte)).BeginInit();
            this.SuspendLayout();
            // 
            // trbXDSte
            // 
            this.trbXDSte.Location = new System.Drawing.Point(53, 10);
            this.trbXDSte.Maximum = 255;
            this.trbXDSte.Name = "trbXDSte";
            this.trbXDSte.Size = new System.Drawing.Size(228, 45);
            this.trbXDSte.TabIndex = 0;
            this.trbXDSte.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // lblRedDste
            // 
            this.lblRedDste.AutoSize = true;
            this.lblRedDste.Location = new System.Drawing.Point(8, 10);
            this.lblRedDste.Name = "lblRedDste";
            this.lblRedDste.Size = new System.Drawing.Size(36, 13);
            this.lblRedDste.TabIndex = 1;
            this.lblRedDste.Text = "X Axis";
            // 
            // trbYDSte
            // 
            this.trbYDSte.Location = new System.Drawing.Point(53, 61);
            this.trbYDSte.Maximum = 255;
            this.trbYDSte.Name = "trbYDSte";
            this.trbYDSte.Size = new System.Drawing.Size(228, 45);
            this.trbYDSte.TabIndex = 0;
            this.trbYDSte.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // lblGreenDste
            // 
            this.lblGreenDste.AutoSize = true;
            this.lblGreenDste.Location = new System.Drawing.Point(12, 66);
            this.lblGreenDste.Name = "lblGreenDste";
            this.lblGreenDste.Size = new System.Drawing.Size(36, 13);
            this.lblGreenDste.TabIndex = 1;
            this.lblGreenDste.Text = "Y Axis";
            // 
            // lblBlueDste
            // 
            this.lblBlueDste.AutoSize = true;
            this.lblBlueDste.Location = new System.Drawing.Point(3, 112);
            this.lblBlueDste.Name = "lblBlueDste";
            this.lblBlueDste.Size = new System.Drawing.Size(46, 13);
            this.lblBlueDste.TabIndex = 3;
            this.lblBlueDste.Text = "Dim/Srb";
            // 
            // trbDmStrbDSte
            // 
            this.trbDmStrbDSte.Location = new System.Drawing.Point(53, 112);
            this.trbDmStrbDSte.Maximum = 255;
            this.trbDmStrbDSte.Name = "trbDmStrbDSte";
            this.trbDmStrbDSte.Size = new System.Drawing.Size(228, 45);
            this.trbDmStrbDSte.TabIndex = 2;
            this.trbDmStrbDSte.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // lblStrobeDste
            // 
            this.lblStrobeDste.AutoSize = true;
            this.lblStrobeDste.Location = new System.Drawing.Point(8, 317);
            this.lblStrobeDste.Name = "lblStrobeDste";
            this.lblStrobeDste.Size = new System.Drawing.Size(33, 13);
            this.lblStrobeDste.TabIndex = 12;
            this.lblStrobeDste.Text = "Gobo";
            // 
            // trbGoboDSte
            // 
            this.trbGoboDSte.Location = new System.Drawing.Point(44, 297);
            this.trbGoboDSte.Maximum = 255;
            this.trbGoboDSte.Name = "trbGoboDSte";
            this.trbGoboDSte.Size = new System.Drawing.Size(228, 45);
            this.trbGoboDSte.TabIndex = 11;
            this.trbGoboDSte.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // btnResetDSte
            // 
            this.btnResetDSte.Location = new System.Drawing.Point(297, 284);
            this.btnResetDSte.Name = "btnResetDSte";
            this.btnResetDSte.Size = new System.Drawing.Size(92, 58);
            this.btnResetDSte.TabIndex = 13;
            this.btnResetDSte.Text = "Reset";
            this.btnResetDSte.UseVisualStyleBackColor = true;
            this.btnResetDSte.Click += new System.EventHandler(this.BtnResetDSte_Click);
            // 
            // trbColorDSte
            // 
            this.trbColorDSte.Location = new System.Drawing.Point(53, 163);
            this.trbColorDSte.Maximum = 255;
            this.trbColorDSte.Name = "trbColorDSte";
            this.trbColorDSte.Size = new System.Drawing.Size(228, 45);
            this.trbColorDSte.TabIndex = 2;
            this.trbColorDSte.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // lblYfineDSte
            // 
            this.lblYfineDSte.AutoSize = true;
            this.lblYfineDSte.Location = new System.Drawing.Point(8, 163);
            this.lblYfineDSte.Name = "lblYfineDSte";
            this.lblYfineDSte.Size = new System.Drawing.Size(31, 13);
            this.lblYfineDSte.TabIndex = 3;
            this.lblYfineDSte.Text = "Color";
            // 
            // UcMovingHeadSliders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnResetDSte);
            this.Controls.Add(this.lblStrobeDste);
            this.Controls.Add(this.trbGoboDSte);
            this.Controls.Add(this.lblYfineDSte);
            this.Controls.Add(this.lblBlueDste);
            this.Controls.Add(this.trbColorDSte);
            this.Controls.Add(this.trbDmStrbDSte);
            this.Controls.Add(this.lblGreenDste);
            this.Controls.Add(this.lblRedDste);
            this.Controls.Add(this.trbYDSte);
            this.Controls.Add(this.trbXDSte);
            this.Name = "UcMovingHeadSliders";
            this.Size = new System.Drawing.Size(401, 360);
            ((System.ComponentModel.ISupportInitialize)(this.trbXDSte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbYDSte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbDmStrbDSte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbGoboDSte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbColorDSte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trbXDSte;
        private System.Windows.Forms.Label lblRedDste;
        private System.Windows.Forms.TrackBar trbYDSte;
        private System.Windows.Forms.Label lblGreenDste;
        private System.Windows.Forms.Label lblBlueDste;
        private System.Windows.Forms.TrackBar trbDmStrbDSte;
        private System.Windows.Forms.Label lblStrobeDste;
        private System.Windows.Forms.TrackBar trbGoboDSte;
        private System.Windows.Forms.Button btnResetDSte;
        private System.Windows.Forms.TrackBar trbColorDSte;
        private System.Windows.Forms.Label lblYfineDSte;
    }
}
