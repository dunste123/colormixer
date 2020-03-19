namespace DMXControl
{
    partial class ColorMixerV2
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
            this.components = new System.ComponentModel.Container();
            this.tcMainDste = new System.Windows.Forms.TabControl();
            this.tpSettingsDste = new System.Windows.Forms.TabPage();
            this.TBStepperDSte = new System.Windows.Forms.TrackBar();
            this.CbAutoStepCounter = new System.Windows.Forms.ComboBox();
            this.autoStepperLblDSte = new System.Windows.Forms.Label();
            this.CbTimingDSte = new System.Windows.Forms.ComboBox();
            this.pnlShowStepper = new System.Windows.Forms.Panel();
            this.PnlTimerDSte = new System.Windows.Forms.Panel();
            this.CbPortDSte = new System.Windows.Forms.ComboBox();
            this.LblTimingDste = new System.Windows.Forms.Label();
            this.LblPortDSte = new System.Windows.Forms.Label();
            this.tbLightControlDste = new System.Windows.Forms.TabPage();
            this.btnLoadShowDSte = new System.Windows.Forms.Button();
            this.btnSaveShowDSte = new System.Windows.Forms.Button();
            this.btnStopAutoDSte = new System.Windows.Forms.Button();
            this.btnStartAutoDSte = new System.Windows.Forms.Button();
            this.btnDupeStepDSte = new System.Windows.Forms.Button();
            this.BtnClearStepDSte = new System.Windows.Forms.Button();
            this.btnPrevStepDSte = new System.Windows.Forms.Button();
            this.btnNextStepDste = new System.Windows.Forms.Button();
            this.pnlMixerDste = new System.Windows.Forms.Panel();
            this.pnlStepsDste = new System.Windows.Forms.Panel();
            this.btnAddControlDste = new System.Windows.Forms.Button();
            this.CBoxTimerDSte = new System.Windows.Forms.Timer(this.components);
            this.tmrShowStepperDSte = new System.Windows.Forms.Timer(this.components);
            this.tcMainDste.SuspendLayout();
            this.tpSettingsDste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.TBStepperDSte)).BeginInit();
            this.tbLightControlDste.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMainDste
            // 
            this.tcMainDste.Controls.Add(this.tpSettingsDste);
            this.tcMainDste.Controls.Add(this.tbLightControlDste);
            this.tcMainDste.Location = new System.Drawing.Point(14, 14);
            this.tcMainDste.Name = "tcMainDste";
            this.tcMainDste.SelectedIndex = 0;
            this.tcMainDste.Size = new System.Drawing.Size(1191, 492);
            this.tcMainDste.TabIndex = 0;
            // 
            // tpSettingsDste
            // 
            this.tpSettingsDste.Controls.Add(this.TBStepperDSte);
            this.tpSettingsDste.Controls.Add(this.CbAutoStepCounter);
            this.tpSettingsDste.Controls.Add(this.autoStepperLblDSte);
            this.tpSettingsDste.Controls.Add(this.CbTimingDSte);
            this.tpSettingsDste.Controls.Add(this.pnlShowStepper);
            this.tpSettingsDste.Controls.Add(this.PnlTimerDSte);
            this.tpSettingsDste.Controls.Add(this.CbPortDSte);
            this.tpSettingsDste.Controls.Add(this.LblTimingDste);
            this.tpSettingsDste.Controls.Add(this.LblPortDSte);
            this.tpSettingsDste.Location = new System.Drawing.Point(4, 24);
            this.tpSettingsDste.Name = "tpSettingsDste";
            this.tpSettingsDste.Padding = new System.Windows.Forms.Padding(3);
            this.tpSettingsDste.Size = new System.Drawing.Size(1183, 464);
            this.tpSettingsDste.TabIndex = 0;
            this.tpSettingsDste.Text = "Settings";
            this.tpSettingsDste.UseVisualStyleBackColor = true;
            // 
            // TBStepperDSte
            // 
            this.TBStepperDSte.Location = new System.Drawing.Point(520, 163);
            this.TBStepperDSte.Maximum = 40;
            this.TBStepperDSte.Name = "TBStepperDSte";
            this.TBStepperDSte.Size = new System.Drawing.Size(302, 45);
            this.TBStepperDSte.TabIndex = 31;
            this.TBStepperDSte.TabStop = false;
            this.TBStepperDSte.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TBStepperDSte.Scroll += new System.EventHandler(this.TBStepperDSte_Scroll);
            // 
            // CbAutoStepCounter
            // 
            this.CbAutoStepCounter.FormattingEnabled = true;
            this.CbAutoStepCounter.Items.AddRange(new object[] {"off"});
            this.CbAutoStepCounter.Location = new System.Drawing.Point(682, 108);
            this.CbAutoStepCounter.Name = "CbAutoStepCounter";
            this.CbAutoStepCounter.Size = new System.Drawing.Size(140, 23);
            this.CbAutoStepCounter.TabIndex = 30;
            this.CbAutoStepCounter.Text = "off";
            this.CbAutoStepCounter.SelectedIndexChanged +=
                new System.EventHandler(this.CbAutoStepCounter_SelectedIndexChanged);
            // 
            // autoStepperLblDSte
            // 
            this.autoStepperLblDSte.AutoSize = true;
            this.autoStepperLblDSte.Location = new System.Drawing.Point(591, 112);
            this.autoStepperLblDSte.Name = "autoStepperLblDSte";
            this.autoStepperLblDSte.Size = new System.Drawing.Size(79, 15);
            this.autoStepperLblDSte.TabIndex = 29;
            this.autoStepperLblDSte.Text = "Audo Stepper";
            // 
            // CbTimingDSte
            // 
            this.CbTimingDSte.FormattingEnabled = true;
            this.CbTimingDSte.Items.AddRange(new object[] {"10", "25", "50", "100", "250", "500", "1000"});
            this.CbTimingDSte.Location = new System.Drawing.Point(124, 173);
            this.CbTimingDSte.Name = "CbTimingDSte";
            this.CbTimingDSte.Size = new System.Drawing.Size(140, 23);
            this.CbTimingDSte.TabIndex = 28;
            this.CbTimingDSte.TabStop = false;
            this.CbTimingDSte.SelectedIndexChanged += new System.EventHandler(this.CbTimingDSte_SelectedIndexChanged);
            // 
            // pnlShowStepper
            // 
            this.pnlShowStepper.BackColor = System.Drawing.Color.White;
            this.pnlShowStepper.Location = new System.Drawing.Point(848, 108);
            this.pnlShowStepper.Name = "pnlShowStepper";
            this.pnlShowStepper.Size = new System.Drawing.Size(23, 24);
            this.pnlShowStepper.TabIndex = 27;
            // 
            // PnlTimerDSte
            // 
            this.PnlTimerDSte.BackColor = System.Drawing.Color.White;
            this.PnlTimerDSte.Location = new System.Drawing.Point(304, 173);
            this.PnlTimerDSte.Name = "PnlTimerDSte";
            this.PnlTimerDSte.Size = new System.Drawing.Size(23, 24);
            this.PnlTimerDSte.TabIndex = 27;
            // 
            // CbPortDSte
            // 
            this.CbPortDSte.FormattingEnabled = true;
            this.CbPortDSte.Location = new System.Drawing.Point(110, 113);
            this.CbPortDSte.Name = "CbPortDSte";
            this.CbPortDSte.Size = new System.Drawing.Size(140, 23);
            this.CbPortDSte.TabIndex = 1;
            this.CbPortDSte.Text = "Select Comport";
            this.CbPortDSte.SelectedIndexChanged += new System.EventHandler(this.CbPortDSte_SelectedIndexChanged);
            // 
            // LblTimingDste
            // 
            this.LblTimingDste.AutoSize = true;
            this.LblTimingDste.Location = new System.Drawing.Point(65, 173);
            this.LblTimingDste.Name = "LblTimingDste";
            this.LblTimingDste.Size = new System.Drawing.Size(50, 15);
            this.LblTimingDste.TabIndex = 0;
            this.LblTimingDste.Text = "Timing: ";
            // 
            // LblPortDSte
            // 
            this.LblPortDSte.AutoSize = true;
            this.LblPortDSte.Location = new System.Drawing.Point(65, 113);
            this.LblPortDSte.Name = "LblPortDSte";
            this.LblPortDSte.Size = new System.Drawing.Size(35, 15);
            this.LblPortDSte.TabIndex = 0;
            this.LblPortDSte.Text = "Port: ";
            // 
            // tbLightControlDste
            // 
            this.tbLightControlDste.Controls.Add(this.btnLoadShowDSte);
            this.tbLightControlDste.Controls.Add(this.btnSaveShowDSte);
            this.tbLightControlDste.Controls.Add(this.btnStopAutoDSte);
            this.tbLightControlDste.Controls.Add(this.btnStartAutoDSte);
            this.tbLightControlDste.Controls.Add(this.btnDupeStepDSte);
            this.tbLightControlDste.Controls.Add(this.BtnClearStepDSte);
            this.tbLightControlDste.Controls.Add(this.btnPrevStepDSte);
            this.tbLightControlDste.Controls.Add(this.btnNextStepDste);
            this.tbLightControlDste.Controls.Add(this.pnlMixerDste);
            this.tbLightControlDste.Controls.Add(this.pnlStepsDste);
            this.tbLightControlDste.Controls.Add(this.btnAddControlDste);
            this.tbLightControlDste.Location = new System.Drawing.Point(4, 22);
            this.tbLightControlDste.Name = "tbLightControlDste";
            this.tbLightControlDste.Padding = new System.Windows.Forms.Padding(3);
            this.tbLightControlDste.Size = new System.Drawing.Size(1183, 466);
            this.tbLightControlDste.TabIndex = 1;
            this.tbLightControlDste.Text = "Light control";
            this.tbLightControlDste.UseVisualStyleBackColor = true;
            // 
            // btnLoadShowDSte
            // 
            this.btnLoadShowDSte.Location = new System.Drawing.Point(8, 417);
            this.btnLoadShowDSte.Name = "btnLoadShowDSte";
            this.btnLoadShowDSte.Size = new System.Drawing.Size(131, 38);
            this.btnLoadShowDSte.TabIndex = 3;
            this.btnLoadShowDSte.Text = "Load Show";
            this.btnLoadShowDSte.UseVisualStyleBackColor = true;
            this.btnLoadShowDSte.Click += new System.EventHandler(this.BtnLoadShowDSte_Click);
            // 
            // btnSaveShowDSte
            // 
            this.btnSaveShowDSte.Location = new System.Drawing.Point(7, 370);
            this.btnSaveShowDSte.Name = "btnSaveShowDSte";
            this.btnSaveShowDSte.Size = new System.Drawing.Size(131, 39);
            this.btnSaveShowDSte.TabIndex = 3;
            this.btnSaveShowDSte.Text = "Save Show";
            this.btnSaveShowDSte.UseVisualStyleBackColor = true;
            this.btnSaveShowDSte.Click += new System.EventHandler(this.BtnSaveShowDSte_Click);
            // 
            // btnStopAutoDSte
            // 
            this.btnStopAutoDSte.Location = new System.Drawing.Point(72, 243);
            this.btnStopAutoDSte.Name = "btnStopAutoDSte";
            this.btnStopAutoDSte.Size = new System.Drawing.Size(65, 52);
            this.btnStopAutoDSte.TabIndex = 3;
            this.btnStopAutoDSte.Text = "Stop Auto";
            this.btnStopAutoDSte.UseVisualStyleBackColor = true;
            this.btnStopAutoDSte.Click += new System.EventHandler(this.BtnStopAutoDSte_Click);
            // 
            // btnStartAutoDSte
            // 
            this.btnStartAutoDSte.Location = new System.Drawing.Point(7, 243);
            this.btnStartAutoDSte.Name = "btnStartAutoDSte";
            this.btnStartAutoDSte.Size = new System.Drawing.Size(65, 52);
            this.btnStartAutoDSte.TabIndex = 3;
            this.btnStartAutoDSte.Text = "Start Auto";
            this.btnStartAutoDSte.UseVisualStyleBackColor = true;
            this.btnStartAutoDSte.Click += new System.EventHandler(this.BtnStartAutoDSte_Click);
            // 
            // btnDupeStepDSte
            // 
            this.btnDupeStepDSte.Location = new System.Drawing.Point(7, 302);
            this.btnDupeStepDSte.Name = "btnDupeStepDSte";
            this.btnDupeStepDSte.Size = new System.Drawing.Size(131, 52);
            this.btnDupeStepDSte.TabIndex = 3;
            this.btnDupeStepDSte.Text = "Copy Step";
            this.btnDupeStepDSte.UseVisualStyleBackColor = true;
            this.btnDupeStepDSte.Click += new System.EventHandler(this.BtnDupeStepDSte_Click);
            // 
            // BtnClearStepDSte
            // 
            this.BtnClearStepDSte.Location = new System.Drawing.Point(7, 185);
            this.BtnClearStepDSte.Name = "BtnClearStepDSte";
            this.BtnClearStepDSte.Size = new System.Drawing.Size(131, 52);
            this.BtnClearStepDSte.TabIndex = 3;
            this.BtnClearStepDSte.Text = "Clear Step";
            this.BtnClearStepDSte.UseVisualStyleBackColor = true;
            this.BtnClearStepDSte.Click += new System.EventHandler(this.BtnClearStepDSte_Click);
            // 
            // btnPrevStepDSte
            // 
            this.btnPrevStepDSte.Location = new System.Drawing.Point(7, 126);
            this.btnPrevStepDSte.Name = "btnPrevStepDSte";
            this.btnPrevStepDSte.Size = new System.Drawing.Size(131, 52);
            this.btnPrevStepDSte.TabIndex = 3;
            this.btnPrevStepDSte.Text = "Prev Step";
            this.btnPrevStepDSte.UseVisualStyleBackColor = true;
            this.btnPrevStepDSte.Click += new System.EventHandler(this.BtnPrevStepDSte_Click);
            // 
            // btnNextStepDste
            // 
            this.btnNextStepDste.Location = new System.Drawing.Point(8, 67);
            this.btnNextStepDste.Name = "btnNextStepDste";
            this.btnNextStepDste.Size = new System.Drawing.Size(131, 52);
            this.btnNextStepDste.TabIndex = 3;
            this.btnNextStepDste.Text = "Next Step";
            this.btnNextStepDste.UseVisualStyleBackColor = true;
            this.btnNextStepDste.Click += new System.EventHandler(this.BtnNextStepDste_Click);
            // 
            // pnlMixerDste
            // 
            this.pnlMixerDste.Location = new System.Drawing.Point(700, 8);
            this.pnlMixerDste.Name = "pnlMixerDste";
            this.pnlMixerDste.Size = new System.Drawing.Size(475, 447);
            this.pnlMixerDste.TabIndex = 2;
            // 
            // pnlStepsDste
            // 
            this.pnlStepsDste.AutoScroll = true;
            this.pnlStepsDste.Location = new System.Drawing.Point(147, 8);
            this.pnlStepsDste.Name = "pnlStepsDste";
            this.pnlStepsDste.Size = new System.Drawing.Size(546, 447);
            this.pnlStepsDste.TabIndex = 1;
            // 
            // btnAddControlDste
            // 
            this.btnAddControlDste.Location = new System.Drawing.Point(8, 8);
            this.btnAddControlDste.Name = "btnAddControlDste";
            this.btnAddControlDste.Size = new System.Drawing.Size(131, 52);
            this.btnAddControlDste.TabIndex = 0;
            this.btnAddControlDste.Text = "Add Step";
            this.btnAddControlDste.UseVisualStyleBackColor = true;
            this.btnAddControlDste.Click += new System.EventHandler(this.BtnAddControl_Click);
            // 
            // CBoxTimerDSte
            // 
            this.CBoxTimerDSte.Tick += new System.EventHandler(this.CBoxTimerDSte_Tick);
            // 
            // tmrShowStepperDSte
            // 
            this.tmrShowStepperDSte.Tick += new System.EventHandler(this.TmrShowStepperDSte_Tick);
            // 
            // ColorMixerV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 519);
            this.Controls.Add(this.tcMainDste);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ColorMixerV2";
            this.Text = "ColorMixerV2";
            this.Load += new System.EventHandler(this.ColorMixerV2_Load);
            this.tcMainDste.ResumeLayout(false);
            this.tpSettingsDste.ResumeLayout(false);
            this.tpSettingsDste.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.TBStepperDSte)).EndInit();
            this.tbLightControlDste.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tcMainDste;
        private System.Windows.Forms.TabPage tpSettingsDste;
        private System.Windows.Forms.TabPage tbLightControlDste;
        private System.Windows.Forms.Button btnAddControlDste;
        private System.Windows.Forms.Panel pnlStepsDste;
        private System.Windows.Forms.Panel pnlMixerDste;
        private System.Windows.Forms.Button btnNextStepDste;
        private System.Windows.Forms.Button btnLoadShowDSte;
        private System.Windows.Forms.Button btnSaveShowDSte;
        private System.Windows.Forms.Label LblPortDSte;
        private System.Windows.Forms.Label LblTimingDste;
        private System.Windows.Forms.ComboBox CbPortDSte;
        private System.Windows.Forms.Panel PnlTimerDSte;
        private System.Windows.Forms.Timer CBoxTimerDSte;
        private System.Windows.Forms.ComboBox CbTimingDSte;
        private System.Windows.Forms.Button BtnClearStepDSte;
        private System.Windows.Forms.Button btnPrevStepDSte;
        private System.Windows.Forms.Label autoStepperLblDSte;
        private System.Windows.Forms.Timer tmrShowStepperDSte;
        private System.Windows.Forms.ComboBox CbAutoStepCounter;
        private System.Windows.Forms.Panel pnlShowStepper;
        private System.Windows.Forms.Button btnStopAutoDSte;
        private System.Windows.Forms.Button btnStartAutoDSte;
        private System.Windows.Forms.Button btnDupeStepDSte;
        private System.Windows.Forms.TrackBar TBStepperDSte;
    }
}
