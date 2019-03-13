namespace KleurenMixerV1Cs1
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
            this.CbTimingDSte = new System.Windows.Forms.ComboBox();
            this.PnlTimerDSte = new System.Windows.Forms.Panel();
            this.CbPortDSte = new System.Windows.Forms.ComboBox();
            this.LblTimingDste = new System.Windows.Forms.Label();
            this.LblPortDSte = new System.Windows.Forms.Label();
            this.tbLightControlDste = new System.Windows.Forms.TabPage();
            this.btnLoadShowDSte = new System.Windows.Forms.Button();
            this.btnSaveShowDSte = new System.Windows.Forms.Button();
            this.btnNextStepDste = new System.Windows.Forms.Button();
            this.pnlMixerDste = new System.Windows.Forms.Panel();
            this.pnlStepsDste = new System.Windows.Forms.Panel();
            this.btnAddControlDste = new System.Windows.Forms.Button();
            this.CBoxTimerDSte = new System.Windows.Forms.Timer(this.components);
            this.BtnClearStepDSte = new System.Windows.Forms.Button();
            this.tcMainDste.SuspendLayout();
            this.tpSettingsDste.SuspendLayout();
            this.tbLightControlDste.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMainDste
            // 
            this.tcMainDste.Controls.Add(this.tpSettingsDste);
            this.tcMainDste.Controls.Add(this.tbLightControlDste);
            this.tcMainDste.Location = new System.Drawing.Point(12, 12);
            this.tcMainDste.Name = "tcMainDste";
            this.tcMainDste.SelectedIndex = 0;
            this.tcMainDste.Size = new System.Drawing.Size(1021, 426);
            this.tcMainDste.TabIndex = 0;
            // 
            // tpSettingsDste
            // 
            this.tpSettingsDste.Controls.Add(this.CbTimingDSte);
            this.tpSettingsDste.Controls.Add(this.PnlTimerDSte);
            this.tpSettingsDste.Controls.Add(this.CbPortDSte);
            this.tpSettingsDste.Controls.Add(this.LblTimingDste);
            this.tpSettingsDste.Controls.Add(this.LblPortDSte);
            this.tpSettingsDste.Location = new System.Drawing.Point(4, 22);
            this.tpSettingsDste.Name = "tpSettingsDste";
            this.tpSettingsDste.Padding = new System.Windows.Forms.Padding(3);
            this.tpSettingsDste.Size = new System.Drawing.Size(1013, 400);
            this.tpSettingsDste.TabIndex = 0;
            this.tpSettingsDste.Text = "Settings";
            this.tpSettingsDste.UseVisualStyleBackColor = true;
            // 
            // CbTimingDSte
            // 
            this.CbTimingDSte.FormattingEnabled = true;
            this.CbTimingDSte.Items.AddRange(new object[] {
            "10",
            "25",
            "50",
            "100",
            "250",
            "500",
            "1000"});
            this.CbTimingDSte.Location = new System.Drawing.Point(106, 150);
            this.CbTimingDSte.Name = "CbTimingDSte";
            this.CbTimingDSte.Size = new System.Drawing.Size(121, 21);
            this.CbTimingDSte.TabIndex = 28;
            this.CbTimingDSte.TabStop = false;
            this.CbTimingDSte.SelectedIndexChanged += new System.EventHandler(this.CbTimingDSte_SelectedIndexChanged);
            // 
            // PnlTimerDSte
            // 
            this.PnlTimerDSte.BackColor = System.Drawing.Color.White;
            this.PnlTimerDSte.Location = new System.Drawing.Point(261, 150);
            this.PnlTimerDSte.Name = "PnlTimerDSte";
            this.PnlTimerDSte.Size = new System.Drawing.Size(20, 21);
            this.PnlTimerDSte.TabIndex = 27;
            // 
            // CbPortDSte
            // 
            this.CbPortDSte.FormattingEnabled = true;
            this.CbPortDSte.Location = new System.Drawing.Point(94, 98);
            this.CbPortDSte.Name = "CbPortDSte";
            this.CbPortDSte.Size = new System.Drawing.Size(121, 21);
            this.CbPortDSte.TabIndex = 1;
            this.CbPortDSte.Text = "Select Comport";
            this.CbPortDSte.SelectedIndexChanged += new System.EventHandler(this.CbPortDSte_SelectedIndexChanged);
            // 
            // LblTimingDste
            // 
            this.LblTimingDste.AutoSize = true;
            this.LblTimingDste.Location = new System.Drawing.Point(56, 150);
            this.LblTimingDste.Name = "LblTimingDste";
            this.LblTimingDste.Size = new System.Drawing.Size(44, 13);
            this.LblTimingDste.TabIndex = 0;
            this.LblTimingDste.Text = "Timing: ";
            // 
            // LblPortDSte
            // 
            this.LblPortDSte.AutoSize = true;
            this.LblPortDSte.Location = new System.Drawing.Point(56, 98);
            this.LblPortDSte.Name = "LblPortDSte";
            this.LblPortDSte.Size = new System.Drawing.Size(32, 13);
            this.LblPortDSte.TabIndex = 0;
            this.LblPortDSte.Text = "Port: ";
            // 
            // tbLightControlDste
            // 
            this.tbLightControlDste.Controls.Add(this.btnLoadShowDSte);
            this.tbLightControlDste.Controls.Add(this.btnSaveShowDSte);
            this.tbLightControlDste.Controls.Add(this.BtnClearStepDSte);
            this.tbLightControlDste.Controls.Add(this.btnNextStepDste);
            this.tbLightControlDste.Controls.Add(this.pnlMixerDste);
            this.tbLightControlDste.Controls.Add(this.pnlStepsDste);
            this.tbLightControlDste.Controls.Add(this.btnAddControlDste);
            this.tbLightControlDste.Location = new System.Drawing.Point(4, 22);
            this.tbLightControlDste.Name = "tbLightControlDste";
            this.tbLightControlDste.Padding = new System.Windows.Forms.Padding(3);
            this.tbLightControlDste.Size = new System.Drawing.Size(1013, 400);
            this.tbLightControlDste.TabIndex = 1;
            this.tbLightControlDste.Text = "Light control";
            this.tbLightControlDste.UseVisualStyleBackColor = true;
            // 
            // btnLoadShowDSte
            // 
            this.btnLoadShowDSte.Location = new System.Drawing.Point(7, 349);
            this.btnLoadShowDSte.Name = "btnLoadShowDSte";
            this.btnLoadShowDSte.Size = new System.Drawing.Size(112, 45);
            this.btnLoadShowDSte.TabIndex = 3;
            this.btnLoadShowDSte.Text = "Load Show";
            this.btnLoadShowDSte.UseVisualStyleBackColor = true;
            this.btnLoadShowDSte.Click += new System.EventHandler(this.BtnLoadShowDSte_Click);
            // 
            // btnSaveShowDSte
            // 
            this.btnSaveShowDSte.Location = new System.Drawing.Point(7, 298);
            this.btnSaveShowDSte.Name = "btnSaveShowDSte";
            this.btnSaveShowDSte.Size = new System.Drawing.Size(112, 45);
            this.btnSaveShowDSte.TabIndex = 3;
            this.btnSaveShowDSte.Text = "Save Show";
            this.btnSaveShowDSte.UseVisualStyleBackColor = true;
            this.btnSaveShowDSte.Click += new System.EventHandler(this.BtnSaveShowDSte_Click);
            // 
            // btnNextStepDste
            // 
            this.btnNextStepDste.Location = new System.Drawing.Point(7, 58);
            this.btnNextStepDste.Name = "btnNextStepDste";
            this.btnNextStepDste.Size = new System.Drawing.Size(112, 45);
            this.btnNextStepDste.TabIndex = 3;
            this.btnNextStepDste.Text = "Next Step";
            this.btnNextStepDste.UseVisualStyleBackColor = true;
            this.btnNextStepDste.Click += new System.EventHandler(this.BtnNextStepDste_Click);
            // 
            // pnlMixerDste
            // 
            this.pnlMixerDste.Location = new System.Drawing.Point(600, 7);
            this.pnlMixerDste.Name = "pnlMixerDste";
            this.pnlMixerDste.Size = new System.Drawing.Size(407, 387);
            this.pnlMixerDste.TabIndex = 2;
            // 
            // pnlStepsDste
            // 
            this.pnlStepsDste.AutoScroll = true;
            this.pnlStepsDste.Location = new System.Drawing.Point(126, 7);
            this.pnlStepsDste.Name = "pnlStepsDste";
            this.pnlStepsDste.Size = new System.Drawing.Size(468, 387);
            this.pnlStepsDste.TabIndex = 1;
            // 
            // btnAddControlDste
            // 
            this.btnAddControlDste.Location = new System.Drawing.Point(7, 7);
            this.btnAddControlDste.Name = "btnAddControlDste";
            this.btnAddControlDste.Size = new System.Drawing.Size(112, 45);
            this.btnAddControlDste.TabIndex = 0;
            this.btnAddControlDste.Text = "Add Step";
            this.btnAddControlDste.UseVisualStyleBackColor = true;
            this.btnAddControlDste.Click += new System.EventHandler(this.BtnAddControl_Click);
            // 
            // CBoxTimerDSte
            // 
            this.CBoxTimerDSte.Tick += new System.EventHandler(this.CBoxTimerDSte_Tick);
            // 
            // BtnClearStepDSte
            // 
            this.BtnClearStepDSte.Location = new System.Drawing.Point(8, 109);
            this.BtnClearStepDSte.Name = "BtnClearStepDSte";
            this.BtnClearStepDSte.Size = new System.Drawing.Size(112, 45);
            this.BtnClearStepDSte.TabIndex = 3;
            this.BtnClearStepDSte.Text = "Clear Step";
            this.BtnClearStepDSte.UseVisualStyleBackColor = true;
            this.BtnClearStepDSte.Click += new System.EventHandler(this.BtnClearStepDSte_Click);
            // 
            // ColorMixerV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 450);
            this.Controls.Add(this.tcMainDste);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ColorMixerV2";
            this.Text = "ColorMixerV2";
            this.Load += new System.EventHandler(this.ColorMixerV2_Load);
            this.tcMainDste.ResumeLayout(false);
            this.tpSettingsDste.ResumeLayout(false);
            this.tpSettingsDste.PerformLayout();
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
    }
}