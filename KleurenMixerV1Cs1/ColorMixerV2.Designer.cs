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
            this.tcMainDste = new System.Windows.Forms.TabControl();
            this.tpSettingsDste = new System.Windows.Forms.TabPage();
            this.tbLightControlDste = new System.Windows.Forms.TabPage();
            this.btnNextStepDste = new System.Windows.Forms.Button();
            this.pnlMixerDste = new System.Windows.Forms.Panel();
            this.pnlStepsDste = new System.Windows.Forms.Panel();
            this.btnAddControlDste = new System.Windows.Forms.Button();
            this.tcMainDste.SuspendLayout();
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
            this.tpSettingsDste.Location = new System.Drawing.Point(4, 22);
            this.tpSettingsDste.Name = "tpSettingsDste";
            this.tpSettingsDste.Padding = new System.Windows.Forms.Padding(3);
            this.tpSettingsDste.Size = new System.Drawing.Size(1013, 400);
            this.tpSettingsDste.TabIndex = 0;
            this.tpSettingsDste.Text = "Settings";
            this.tpSettingsDste.UseVisualStyleBackColor = true;
            // 
            // tbLightControlDste
            // 
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
            // btnNextStepDste
            // 
            this.btnNextStepDste.Location = new System.Drawing.Point(7, 67);
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
            this.tcMainDste.ResumeLayout(false);
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
    }
}