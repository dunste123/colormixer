namespace KleurenMixerV1Cs1 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.trbRed = new System.Windows.Forms.TrackBar();
            this.trbGreen = new System.Windows.Forms.TrackBar();
            this.trbBlue = new System.Windows.Forms.TrackBar();
            this.tbRed = new System.Windows.Forms.TextBox();
            this.tbGreen = new System.Windows.Forms.TextBox();
            this.tbBlue = new System.Windows.Forms.TextBox();
            this.lblRedDSte = new System.Windows.Forms.Label();
            this.lblGreenDste = new System.Windows.Forms.Label();
            this.lblBlueDste = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.pbMixer = new System.Windows.Forms.PictureBox();
            this.pbRed = new System.Windows.Forms.PictureBox();
            this.pbGreen = new System.Windows.Forms.PictureBox();
            this.pbBlue = new System.Windows.Forms.PictureBox();
            this.trbFinal = new System.Windows.Forms.TrackBar();
            this.lblRGBDSte = new System.Windows.Forms.Label();
            this.tbFinal = new System.Windows.Forms.TextBox();
            this.cbRed = new System.Windows.Forms.CheckBox();
            this.cbGreen = new System.Windows.Forms.CheckBox();
            this.cbBlue = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboxPortSelect = new System.Windows.Forms.ComboBox();
            this.cboxInterval = new System.Windows.Forms.ComboBox();
            this.lblPortDSte = new System.Windows.Forms.Label();
            this.lblTimingDSte = new System.Windows.Forms.Label();
            this.cboxTimerDSte = new System.Windows.Forms.Timer(this.components);
            this.pnlTimer = new System.Windows.Forms.Panel();
            this.cbStartFade = new System.Windows.Forms.CheckBox();
            this.trbStrobeDSte = new System.Windows.Forms.TrackBar();
            this.lblStrobeDSte = new System.Windows.Forms.Label();
            this.trbFadeSpeedDSte = new System.Windows.Forms.TrackBar();
            this.lblFadeModeDSte = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMixer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbStrobeDSte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbFadeSpeedDSte)).BeginInit();
            this.SuspendLayout();
            // 
            // trbRed
            // 
            this.trbRed.Location = new System.Drawing.Point(61, 36);
            this.trbRed.Maximum = 255;
            this.trbRed.Name = "trbRed";
            this.trbRed.Size = new System.Drawing.Size(242, 45);
            this.trbRed.TabIndex = 0;
            this.trbRed.TabStop = false;
            this.trbRed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbRed.Scroll += new System.EventHandler(this.TrbRed_Scroll);
            // 
            // trbGreen
            // 
            this.trbGreen.Location = new System.Drawing.Point(61, 87);
            this.trbGreen.Maximum = 255;
            this.trbGreen.Name = "trbGreen";
            this.trbGreen.Size = new System.Drawing.Size(242, 45);
            this.trbGreen.TabIndex = 1;
            this.trbGreen.TabStop = false;
            this.trbGreen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbGreen.Scroll += new System.EventHandler(this.TrbGreen_Scroll);
            // 
            // trbBlue
            // 
            this.trbBlue.Location = new System.Drawing.Point(61, 138);
            this.trbBlue.Maximum = 255;
            this.trbBlue.Name = "trbBlue";
            this.trbBlue.Size = new System.Drawing.Size(242, 45);
            this.trbBlue.TabIndex = 2;
            this.trbBlue.TabStop = false;
            this.trbBlue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbBlue.Scroll += new System.EventHandler(this.trbBlue_Scroll);
            // 
            // tbRed
            // 
            this.tbRed.Location = new System.Drawing.Point(354, 36);
            this.tbRed.Name = "tbRed";
            this.tbRed.Size = new System.Drawing.Size(54, 20);
            this.tbRed.TabIndex = 4;
            this.tbRed.TabStop = false;
            this.tbRed.Text = "0";
            this.tbRed.TextChanged += new System.EventHandler(this.TbRed_TextChanged);
            // 
            // tbGreen
            // 
            this.tbGreen.Location = new System.Drawing.Point(354, 87);
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.Size = new System.Drawing.Size(54, 20);
            this.tbGreen.TabIndex = 4;
            this.tbGreen.TabStop = false;
            this.tbGreen.Text = "0";
            this.tbGreen.TextChanged += new System.EventHandler(this.TbGreen_TextChanged);
            // 
            // tbBlue
            // 
            this.tbBlue.Location = new System.Drawing.Point(354, 138);
            this.tbBlue.Name = "tbBlue";
            this.tbBlue.Size = new System.Drawing.Size(54, 20);
            this.tbBlue.TabIndex = 4;
            this.tbBlue.TabStop = false;
            this.tbBlue.Text = "0";
            this.tbBlue.TextChanged += new System.EventHandler(this.TbBlue_TextChanged);
            // 
            // lblRedDSte
            // 
            this.lblRedDSte.AutoSize = true;
            this.lblRedDSte.Location = new System.Drawing.Point(19, 36);
            this.lblRedDSte.Name = "lblRedDSte";
            this.lblRedDSte.Size = new System.Drawing.Size(27, 13);
            this.lblRedDSte.TabIndex = 5;
            this.lblRedDSte.Text = "Red";
            // 
            // lblGreenDste
            // 
            this.lblGreenDste.AutoSize = true;
            this.lblGreenDste.Location = new System.Drawing.Point(19, 87);
            this.lblGreenDste.Name = "lblGreenDste";
            this.lblGreenDste.Size = new System.Drawing.Size(36, 13);
            this.lblGreenDste.TabIndex = 6;
            this.lblGreenDste.Text = "Green";
            // 
            // lblBlueDste
            // 
            this.lblBlueDste.AutoSize = true;
            this.lblBlueDste.Location = new System.Drawing.Point(19, 138);
            this.lblBlueDste.Name = "lblBlueDste";
            this.lblBlueDste.Size = new System.Drawing.Size(28, 13);
            this.lblBlueDste.TabIndex = 7;
            this.lblBlueDste.Text = "Blue";
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(428, 365);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(113, 23);
            this.resetBtn.TabIndex = 8;
            this.resetBtn.TabStop = false;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // pbMixer
            // 
            this.pbMixer.BackColor = System.Drawing.Color.Black;
            this.pbMixer.Location = new System.Drawing.Point(547, 25);
            this.pbMixer.Name = "pbMixer";
            this.pbMixer.Size = new System.Drawing.Size(53, 363);
            this.pbMixer.TabIndex = 9;
            this.pbMixer.TabStop = false;
            // 
            // pbRed
            // 
            this.pbRed.BackColor = System.Drawing.Color.Black;
            this.pbRed.Location = new System.Drawing.Point(428, 36);
            this.pbRed.Name = "pbRed";
            this.pbRed.Size = new System.Drawing.Size(54, 20);
            this.pbRed.TabIndex = 10;
            this.pbRed.TabStop = false;
            // 
            // pbGreen
            // 
            this.pbGreen.BackColor = System.Drawing.Color.Black;
            this.pbGreen.Location = new System.Drawing.Point(428, 87);
            this.pbGreen.Name = "pbGreen";
            this.pbGreen.Size = new System.Drawing.Size(54, 20);
            this.pbGreen.TabIndex = 11;
            this.pbGreen.TabStop = false;
            // 
            // pbBlue
            // 
            this.pbBlue.BackColor = System.Drawing.Color.Black;
            this.pbBlue.Location = new System.Drawing.Point(428, 138);
            this.pbBlue.Name = "pbBlue";
            this.pbBlue.Size = new System.Drawing.Size(54, 20);
            this.pbBlue.TabIndex = 12;
            this.pbBlue.TabStop = false;
            // 
            // trbFinal
            // 
            this.trbFinal.Location = new System.Drawing.Point(61, 189);
            this.trbFinal.Maximum = 255;
            this.trbFinal.Name = "trbFinal";
            this.trbFinal.Size = new System.Drawing.Size(361, 45);
            this.trbFinal.TabIndex = 13;
            this.trbFinal.TabStop = false;
            this.trbFinal.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trbFinal.Scroll += new System.EventHandler(this.TrbFinal_scroll);
            // 
            // lblRGBDSte
            // 
            this.lblRGBDSte.AutoSize = true;
            this.lblRGBDSte.Location = new System.Drawing.Point(19, 203);
            this.lblRGBDSte.Name = "lblRGBDSte";
            this.lblRGBDSte.Size = new System.Drawing.Size(30, 13);
            this.lblRGBDSte.TabIndex = 14;
            this.lblRGBDSte.Text = "RGB";
            // 
            // tbFinal
            // 
            this.tbFinal.Location = new System.Drawing.Point(428, 200);
            this.tbFinal.Name = "tbFinal";
            this.tbFinal.Size = new System.Drawing.Size(54, 20);
            this.tbFinal.TabIndex = 15;
            this.tbFinal.TabStop = false;
            this.tbFinal.Text = "0";
            this.tbFinal.TextChanged += new System.EventHandler(this.TbFinal_TextChanged);
            // 
            // cbRed
            // 
            this.cbRed.AutoSize = true;
            this.cbRed.Location = new System.Drawing.Point(310, 38);
            this.cbRed.Name = "cbRed";
            this.cbRed.Size = new System.Drawing.Size(15, 14);
            this.cbRed.TabIndex = 16;
            this.cbRed.TabStop = false;
            this.cbRed.UseVisualStyleBackColor = true;
            // 
            // cbGreen
            // 
            this.cbGreen.AutoSize = true;
            this.cbGreen.Location = new System.Drawing.Point(310, 89);
            this.cbGreen.Name = "cbGreen";
            this.cbGreen.Size = new System.Drawing.Size(15, 14);
            this.cbGreen.TabIndex = 17;
            this.cbGreen.TabStop = false;
            this.cbGreen.UseVisualStyleBackColor = true;
            // 
            // cbBlue
            // 
            this.cbBlue.AutoSize = true;
            this.cbBlue.Location = new System.Drawing.Point(310, 140);
            this.cbBlue.Name = "cbBlue";
            this.cbBlue.Size = new System.Drawing.Size(15, 14);
            this.cbBlue.TabIndex = 18;
            this.cbBlue.TabStop = false;
            this.cbBlue.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Select";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(478, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Output Colour";
            // 
            // cboxPortSelect
            // 
            this.cboxPortSelect.FormattingEnabled = true;
            this.cboxPortSelect.Location = new System.Drawing.Point(61, 367);
            this.cboxPortSelect.Name = "cboxPortSelect";
            this.cboxPortSelect.Size = new System.Drawing.Size(112, 21);
            this.cboxPortSelect.TabIndex = 21;
            this.cboxPortSelect.TabStop = false;
            this.cboxPortSelect.Text = "Select Comport";
            this.cboxPortSelect.SelectedIndexChanged += new System.EventHandler(this.CbboxPortSelect_SelectedIndexChanged);
            // 
            // cboxInterval
            // 
            this.cboxInterval.FormattingEnabled = true;
            this.cboxInterval.Items.AddRange(new object[] {
            "10",
            "25",
            "50",
            "100",
            "250",
            "500",
            "1000"});
            this.cboxInterval.Location = new System.Drawing.Point(254, 367);
            this.cboxInterval.Name = "cboxInterval";
            this.cboxInterval.Size = new System.Drawing.Size(62, 21);
            this.cboxInterval.TabIndex = 22;
            this.cboxInterval.TabStop = false;
            this.cboxInterval.SelectedIndexChanged += new System.EventHandler(this.cboxInterval_SelectedIndexChanged);
            // 
            // lblPortDSte
            // 
            this.lblPortDSte.AutoSize = true;
            this.lblPortDSte.Location = new System.Drawing.Point(26, 370);
            this.lblPortDSte.Name = "lblPortDSte";
            this.lblPortDSte.Size = new System.Drawing.Size(29, 13);
            this.lblPortDSte.TabIndex = 23;
            this.lblPortDSte.Text = "Port:";
            // 
            // lblTimingDSte
            // 
            this.lblTimingDSte.AutoSize = true;
            this.lblTimingDSte.Location = new System.Drawing.Point(207, 370);
            this.lblTimingDSte.Name = "lblTimingDSte";
            this.lblTimingDSte.Size = new System.Drawing.Size(41, 13);
            this.lblTimingDSte.TabIndex = 24;
            this.lblTimingDSte.Text = "Timing:";
            // 
            // cboxTimerDSte
            // 
            this.cboxTimerDSte.Tick += new System.EventHandler(this.CboxTimer_Tick);
            // 
            // pnlTimer
            // 
            this.pnlTimer.BackColor = System.Drawing.Color.White;
            this.pnlTimer.Location = new System.Drawing.Point(333, 367);
            this.pnlTimer.Name = "pnlTimer";
            this.pnlTimer.Size = new System.Drawing.Size(20, 21);
            this.pnlTimer.TabIndex = 26;
            // 
            // cbStartFade
            // 
            this.cbStartFade.AutoSize = true;
            this.cbStartFade.Location = new System.Drawing.Point(444, 322);
            this.cbStartFade.Name = "cbStartFade";
            this.cbStartFade.Size = new System.Drawing.Size(75, 17);
            this.cbStartFade.TabIndex = 27;
            this.cbStartFade.Text = "Start Fade";
            this.cbStartFade.UseVisualStyleBackColor = true;
            // 
            // trbStrobeDSte
            // 
            this.trbStrobeDSte.Location = new System.Drawing.Point(61, 251);
            this.trbStrobeDSte.Maximum = 255;
            this.trbStrobeDSte.Name = "trbStrobeDSte";
            this.trbStrobeDSte.Size = new System.Drawing.Size(361, 45);
            this.trbStrobeDSte.TabIndex = 28;
            this.trbStrobeDSte.TabStop = false;
            this.trbStrobeDSte.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trbStrobeDSte.Scroll += new System.EventHandler(this.TrbStrobeDSte_Scroll);
            // 
            // lblStrobeDSte
            // 
            this.lblStrobeDSte.AutoSize = true;
            this.lblStrobeDSte.Location = new System.Drawing.Point(19, 264);
            this.lblStrobeDSte.Name = "lblStrobeDSte";
            this.lblStrobeDSte.Size = new System.Drawing.Size(38, 13);
            this.lblStrobeDSte.TabIndex = 29;
            this.lblStrobeDSte.Text = "Strobe";
            // 
            // trbFadeSpeedDSte
            // 
            this.trbFadeSpeedDSte.Location = new System.Drawing.Point(76, 309);
            this.trbFadeSpeedDSte.Maximum = 255;
            this.trbFadeSpeedDSte.Minimum = 128;
            this.trbFadeSpeedDSte.Name = "trbFadeSpeedDSte";
            this.trbFadeSpeedDSte.Size = new System.Drawing.Size(361, 45);
            this.trbFadeSpeedDSte.TabIndex = 30;
            this.trbFadeSpeedDSte.TabStop = false;
            this.trbFadeSpeedDSte.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trbFadeSpeedDSte.Value = 128;
            this.trbFadeSpeedDSte.Scroll += new System.EventHandler(this.TrbFadeSpeedDSte_Scroll);
            // 
            // lblFadeModeDSte
            // 
            this.lblFadeModeDSte.AutoSize = true;
            this.lblFadeModeDSte.Location = new System.Drawing.Point(10, 324);
            this.lblFadeModeDSte.Name = "lblFadeModeDSte";
            this.lblFadeModeDSte.Size = new System.Drawing.Size(60, 13);
            this.lblFadeModeDSte.TabIndex = 31;
            this.lblFadeModeDSte.Text = "Fade mode";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 400);
            this.Controls.Add(this.lblFadeModeDSte);
            this.Controls.Add(this.trbFadeSpeedDSte);
            this.Controls.Add(this.lblStrobeDSte);
            this.Controls.Add(this.trbStrobeDSte);
            this.Controls.Add(this.cbStartFade);
            this.Controls.Add(this.pnlTimer);
            this.Controls.Add(this.lblTimingDSte);
            this.Controls.Add(this.lblPortDSte);
            this.Controls.Add(this.cboxInterval);
            this.Controls.Add(this.cboxPortSelect);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbBlue);
            this.Controls.Add(this.cbGreen);
            this.Controls.Add(this.cbRed);
            this.Controls.Add(this.tbFinal);
            this.Controls.Add(this.lblRGBDSte);
            this.Controls.Add(this.trbFinal);
            this.Controls.Add(this.pbBlue);
            this.Controls.Add(this.pbGreen);
            this.Controls.Add(this.pbRed);
            this.Controls.Add(this.pbMixer);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.lblBlueDste);
            this.Controls.Add(this.lblGreenDste);
            this.Controls.Add(this.lblRedDSte);
            this.Controls.Add(this.tbBlue);
            this.Controls.Add(this.tbGreen);
            this.Controls.Add(this.tbRed);
            this.Controls.Add(this.trbBlue);
            this.Controls.Add(this.trbGreen);
            this.Controls.Add(this.trbRed);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(627, 439);
            this.MinimumSize = new System.Drawing.Size(627, 439);
            this.Name = "Form1";
            this.Text = "KleurMixer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.trbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMixer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbStrobeDSte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbFadeSpeedDSte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.TrackBar trbRed;
        private System.Windows.Forms.TrackBar trbGreen;
        private System.Windows.Forms.TrackBar trbBlue;
        private System.Windows.Forms.TrackBar trbFinal;
        private System.Windows.Forms.TextBox tbRed;
        private System.Windows.Forms.TextBox tbGreen;
        private System.Windows.Forms.TextBox tbBlue;
        private System.Windows.Forms.TextBox tbFinal;
        private System.Windows.Forms.Label lblRedDSte;
        private System.Windows.Forms.Label lblGreenDste;
        private System.Windows.Forms.Label lblBlueDste;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbMixer;
        private System.Windows.Forms.Label lblRGBDSte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPortDSte;
        private System.Windows.Forms.Label lblTimingDSte;
        private System.Windows.Forms.PictureBox pbBlue;
        private System.Windows.Forms.PictureBox pbGreen;
        private System.Windows.Forms.PictureBox pbRed;
        private System.Windows.Forms.Panel pnlTimer;
        private System.Windows.Forms.CheckBox cbBlue;
        private System.Windows.Forms.CheckBox cbGreen;
        private System.Windows.Forms.ComboBox cboxInterval;
        private System.Windows.Forms.ComboBox cboxPortSelect;
        private System.Windows.Forms.Timer cboxTimerDSte;
        private System.Windows.Forms.CheckBox cbRed;
        private System.Windows.Forms.CheckBox cbStartFade;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.TrackBar trbStrobeDSte;
        private System.Windows.Forms.Label lblStrobeDSte;
        private System.Windows.Forms.TrackBar trbFadeSpeedDSte;
        private System.Windows.Forms.Label lblFadeModeDSte;
    }
}

