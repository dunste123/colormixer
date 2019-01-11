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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.pbMixer = new System.Windows.Forms.PictureBox();
            this.pbRed = new System.Windows.Forms.PictureBox();
            this.pbGreen = new System.Windows.Forms.PictureBox();
            this.pbBlue = new System.Windows.Forms.PictureBox();
            this.trbFinal = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFinal = new System.Windows.Forms.TextBox();
            this.cbRed = new System.Windows.Forms.CheckBox();
            this.cbGreen = new System.Windows.Forms.CheckBox();
            this.cbBlue = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboxPortSelect = new System.Windows.Forms.ComboBox();
            this.cboxInterval = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboxTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlTimer = new System.Windows.Forms.Panel();
            this.cbStartFade = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMixer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbFinal)).BeginInit();
            this.SuspendLayout();
            // 
            // trbRed
            // 
            this.trbRed.Location = new System.Drawing.Point(81, 44);
            this.trbRed.Margin = new System.Windows.Forms.Padding(4);
            this.trbRed.Maximum = 255;
            this.trbRed.Name = "trbRed";
            this.trbRed.Size = new System.Drawing.Size(323, 56);
            this.trbRed.TabIndex = 0;
            this.trbRed.TabStop = false;
            this.trbRed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbRed.Scroll += new System.EventHandler(this.trbRed_Scroll);
            // 
            // trbGreen
            // 
            this.trbGreen.Location = new System.Drawing.Point(81, 107);
            this.trbGreen.Margin = new System.Windows.Forms.Padding(4);
            this.trbGreen.Maximum = 255;
            this.trbGreen.Name = "trbGreen";
            this.trbGreen.Size = new System.Drawing.Size(323, 56);
            this.trbGreen.TabIndex = 1;
            this.trbGreen.TabStop = false;
            this.trbGreen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbGreen.Scroll += new System.EventHandler(this.trbGreen_Scroll);
            // 
            // trbBlue
            // 
            this.trbBlue.Location = new System.Drawing.Point(81, 170);
            this.trbBlue.Margin = new System.Windows.Forms.Padding(4);
            this.trbBlue.Maximum = 255;
            this.trbBlue.Name = "trbBlue";
            this.trbBlue.Size = new System.Drawing.Size(323, 56);
            this.trbBlue.TabIndex = 2;
            this.trbBlue.TabStop = false;
            this.trbBlue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbBlue.Scroll += new System.EventHandler(this.trbBlue_Scroll);
            // 
            // tbRed
            // 
            this.tbRed.Location = new System.Drawing.Point(472, 44);
            this.tbRed.Margin = new System.Windows.Forms.Padding(4);
            this.tbRed.Name = "tbRed";
            this.tbRed.Size = new System.Drawing.Size(71, 22);
            this.tbRed.TabIndex = 4;
            this.tbRed.TabStop = false;
            this.tbRed.Text = "0";
            this.tbRed.TextChanged += new System.EventHandler(this.tbRed_TextChanged);
            // 
            // tbGreen
            // 
            this.tbGreen.Location = new System.Drawing.Point(472, 107);
            this.tbGreen.Margin = new System.Windows.Forms.Padding(4);
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.Size = new System.Drawing.Size(71, 22);
            this.tbGreen.TabIndex = 4;
            this.tbGreen.TabStop = false;
            this.tbGreen.Text = "0";
            this.tbGreen.TextChanged += new System.EventHandler(this.tbGreen_TextChanged);
            // 
            // tbBlue
            // 
            this.tbBlue.Location = new System.Drawing.Point(472, 170);
            this.tbBlue.Margin = new System.Windows.Forms.Padding(4);
            this.tbBlue.Name = "tbBlue";
            this.tbBlue.Size = new System.Drawing.Size(71, 22);
            this.tbBlue.TabIndex = 4;
            this.tbBlue.TabStop = false;
            this.tbBlue.Text = "0";
            this.tbBlue.TextChanged += new System.EventHandler(this.tbBlue_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Blue";
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(571, 327);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(4);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(151, 28);
            this.resetBtn.TabIndex = 8;
            this.resetBtn.TabStop = false;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // pbMixer
            // 
            this.pbMixer.BackColor = System.Drawing.Color.Black;
            this.pbMixer.Location = new System.Drawing.Point(729, 31);
            this.pbMixer.Margin = new System.Windows.Forms.Padding(4);
            this.pbMixer.Name = "pbMixer";
            this.pbMixer.Size = new System.Drawing.Size(71, 325);
            this.pbMixer.TabIndex = 9;
            this.pbMixer.TabStop = false;
            // 
            // pbRed
            // 
            this.pbRed.BackColor = System.Drawing.Color.Black;
            this.pbRed.Location = new System.Drawing.Point(571, 44);
            this.pbRed.Margin = new System.Windows.Forms.Padding(4);
            this.pbRed.Name = "pbRed";
            this.pbRed.Size = new System.Drawing.Size(72, 25);
            this.pbRed.TabIndex = 10;
            this.pbRed.TabStop = false;
            // 
            // pbGreen
            // 
            this.pbGreen.BackColor = System.Drawing.Color.Black;
            this.pbGreen.Location = new System.Drawing.Point(571, 107);
            this.pbGreen.Margin = new System.Windows.Forms.Padding(4);
            this.pbGreen.Name = "pbGreen";
            this.pbGreen.Size = new System.Drawing.Size(72, 25);
            this.pbGreen.TabIndex = 11;
            this.pbGreen.TabStop = false;
            // 
            // pbBlue
            // 
            this.pbBlue.BackColor = System.Drawing.Color.Black;
            this.pbBlue.Location = new System.Drawing.Point(571, 170);
            this.pbBlue.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlue.Name = "pbBlue";
            this.pbBlue.Size = new System.Drawing.Size(72, 25);
            this.pbBlue.TabIndex = 12;
            this.pbBlue.TabStop = false;
            // 
            // trbFinal
            // 
            this.trbFinal.Location = new System.Drawing.Point(81, 257);
            this.trbFinal.Margin = new System.Windows.Forms.Padding(4);
            this.trbFinal.Maximum = 255;
            this.trbFinal.Name = "trbFinal";
            this.trbFinal.Size = new System.Drawing.Size(481, 56);
            this.trbFinal.TabIndex = 13;
            this.trbFinal.TabStop = false;
            this.trbFinal.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trbFinal.Scroll += new System.EventHandler(this.trbFinal_scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 257);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "RGB";
            // 
            // tbFinal
            // 
            this.tbFinal.Location = new System.Drawing.Point(571, 257);
            this.tbFinal.Margin = new System.Windows.Forms.Padding(4);
            this.tbFinal.Name = "tbFinal";
            this.tbFinal.Size = new System.Drawing.Size(71, 22);
            this.tbFinal.TabIndex = 15;
            this.tbFinal.TabStop = false;
            this.tbFinal.Text = "0";
            this.tbFinal.TextChanged += new System.EventHandler(this.tbFinal_TextChanged);
            // 
            // cbRed
            // 
            this.cbRed.AutoSize = true;
            this.cbRed.Location = new System.Drawing.Point(413, 47);
            this.cbRed.Margin = new System.Windows.Forms.Padding(4);
            this.cbRed.Name = "cbRed";
            this.cbRed.Size = new System.Drawing.Size(18, 17);
            this.cbRed.TabIndex = 16;
            this.cbRed.TabStop = false;
            this.cbRed.UseVisualStyleBackColor = true;
            // 
            // cbGreen
            // 
            this.cbGreen.AutoSize = true;
            this.cbGreen.Location = new System.Drawing.Point(413, 110);
            this.cbGreen.Margin = new System.Windows.Forms.Padding(4);
            this.cbGreen.Name = "cbGreen";
            this.cbGreen.Size = new System.Drawing.Size(18, 17);
            this.cbGreen.TabIndex = 17;
            this.cbGreen.TabStop = false;
            this.cbGreen.UseVisualStyleBackColor = true;
            // 
            // cbBlue
            // 
            this.cbBlue.AutoSize = true;
            this.cbBlue.Location = new System.Drawing.Point(413, 172);
            this.cbBlue.Margin = new System.Windows.Forms.Padding(4);
            this.cbBlue.Name = "cbBlue";
            this.cbBlue.Size = new System.Drawing.Size(18, 17);
            this.cbBlue.TabIndex = 18;
            this.cbBlue.TabStop = false;
            this.cbBlue.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Select";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(637, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Output Colour";
            // 
            // cboxPortSelect
            // 
            this.cboxPortSelect.FormattingEnabled = true;
            this.cboxPortSelect.Location = new System.Drawing.Point(81, 330);
            this.cboxPortSelect.Margin = new System.Windows.Forms.Padding(4);
            this.cboxPortSelect.Name = "cboxPortSelect";
            this.cboxPortSelect.Size = new System.Drawing.Size(148, 24);
            this.cboxPortSelect.TabIndex = 21;
            this.cboxPortSelect.TabStop = false;
            this.cboxPortSelect.Text = "Select Comport";
            this.cboxPortSelect.SelectedIndexChanged += new System.EventHandler(this.cbboxPortSelect_SelectedIndexChanged);
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
            this.cboxInterval.Location = new System.Drawing.Point(339, 330);
            this.cboxInterval.Margin = new System.Windows.Forms.Padding(4);
            this.cboxInterval.Name = "cboxInterval";
            this.cboxInterval.Size = new System.Drawing.Size(81, 24);
            this.cboxInterval.TabIndex = 22;
            this.cboxInterval.TabStop = false;
            this.cboxInterval.SelectedIndexChanged += new System.EventHandler(this.cboxInterval_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 334);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Port:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(276, 334);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Timing:";
            // 
            // cboxTimer
            // 
            this.cboxTimer.Tick += new System.EventHandler(this.cboxTimer_Tick);
            // 
            // pnlTimer
            // 
            this.pnlTimer.BackColor = System.Drawing.Color.White;
            this.pnlTimer.Location = new System.Drawing.Point(444, 330);
            this.pnlTimer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTimer.Name = "pnlTimer";
            this.pnlTimer.Size = new System.Drawing.Size(27, 26);
            this.pnlTimer.TabIndex = 26;
            // 
            // cbStartFade
            // 
            this.cbStartFade.AutoSize = true;
            this.cbStartFade.Location = new System.Drawing.Point(588, 299);
            this.cbStartFade.Margin = new System.Windows.Forms.Padding(4);
            this.cbStartFade.Name = "cbStartFade";
            this.cbStartFade.Size = new System.Drawing.Size(96, 21);
            this.cbStartFade.TabIndex = 27;
            this.cbStartFade.Text = "Start Fade";
            this.cbStartFade.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 361);
            this.Controls.Add(this.cbStartFade);
            this.Controls.Add(this.pnlTimer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboxInterval);
            this.Controls.Add(this.cboxPortSelect);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbBlue);
            this.Controls.Add(this.cbGreen);
            this.Controls.Add(this.cbRed);
            this.Controls.Add(this.tbFinal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trbFinal);
            this.Controls.Add(this.pbBlue);
            this.Controls.Add(this.pbGreen);
            this.Controls.Add(this.pbRed);
            this.Controls.Add(this.pbMixer);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBlue);
            this.Controls.Add(this.tbGreen);
            this.Controls.Add(this.tbRed);
            this.Controls.Add(this.trbBlue);
            this.Controls.Add(this.trbGreen);
            this.Controls.Add(this.trbRed);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(831, 408);
            this.MinimumSize = new System.Drawing.Size(831, 408);
            this.Name = "Form1";
            this.Text = "KleurMixer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.form1_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.trbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMixer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbFinal)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbMixer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pbBlue;
        private System.Windows.Forms.PictureBox pbGreen;
        private System.Windows.Forms.PictureBox pbRed;
        private System.Windows.Forms.Panel pnlTimer;
        private System.Windows.Forms.CheckBox cbBlue;
        private System.Windows.Forms.CheckBox cbGreen;
        private System.Windows.Forms.ComboBox cboxInterval;
        private System.Windows.Forms.ComboBox cboxPortSelect;
        private System.Windows.Forms.Timer cboxTimer;
        private System.Windows.Forms.CheckBox cbRed;
        private System.Windows.Forms.CheckBox cbStartFade;
        private System.Windows.Forms.Button resetBtn;

    }
}

