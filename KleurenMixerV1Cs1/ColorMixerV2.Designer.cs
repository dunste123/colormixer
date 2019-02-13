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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAddControlDste = new System.Windows.Forms.Button();
            this.pnlControlsDste = new System.Windows.Forms.Panel();
            this.tcMainDste.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMainDste
            // 
            this.tcMainDste.Controls.Add(this.tabPage1);
            this.tcMainDste.Controls.Add(this.tabPage2);
            this.tcMainDste.Location = new System.Drawing.Point(12, 12);
            this.tcMainDste.Name = "tcMainDste";
            this.tcMainDste.SelectedIndex = 0;
            this.tcMainDste.Size = new System.Drawing.Size(776, 426);
            this.tcMainDste.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pnlControlsDste);
            this.tabPage2.Controls.Add(this.btnAddControlDste);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Light control";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAddControlDste
            // 
            this.btnAddControlDste.Location = new System.Drawing.Point(7, 7);
            this.btnAddControlDste.Name = "btnAddControlDste";
            this.btnAddControlDste.Size = new System.Drawing.Size(112, 45);
            this.btnAddControlDste.TabIndex = 0;
            this.btnAddControlDste.Text = "Add control";
            this.btnAddControlDste.UseVisualStyleBackColor = true;
            this.btnAddControlDste.Click += new System.EventHandler(this.BtnAddControl_Click);
            // 
            // pnlControlsDste
            // 
            this.pnlControlsDste.AutoScroll = true;
            this.pnlControlsDste.Location = new System.Drawing.Point(126, 7);
            this.pnlControlsDste.Name = "pnlControlsDste";
            this.pnlControlsDste.Size = new System.Drawing.Size(435, 387);
            this.pnlControlsDste.TabIndex = 1;
            // 
            // ColorMixerV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcMainDste);
            this.Name = "ColorMixerV2";
            this.Text = "ColorMixerV2";
            this.tcMainDste.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMainDste;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAddControlDste;
        private System.Windows.Forms.Panel pnlControlsDste;
    }
}