namespace Controls
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
            ((System.ComponentModel.ISupportInitialize)(this.trbRedDste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbGreenDste)).BeginInit();
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
            // UcPar56Sliders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblGreenDste);
            this.Controls.Add(this.lblRedDste);
            this.Controls.Add(this.trbGreenDste);
            this.Controls.Add(this.trbRedDste);
            this.Name = "UcPar56Sliders";
            this.Size = new System.Drawing.Size(401, 360);
            ((System.ComponentModel.ISupportInitialize)(this.trbRedDste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbGreenDste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trbRedDste;
        private System.Windows.Forms.Label lblRedDste;
        private System.Windows.Forms.TrackBar trbGreenDste;
        private System.Windows.Forms.Label lblGreenDste;
    }
}
