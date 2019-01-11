using Dmx512UsbRs485;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KleurenMixerV1Cs1 {

    public partial class Form1 : Form {
        private int buffSize = 512;
        private Dmx512UsbRs485Driver dmxDriver = new Dmx512UsbRs485Driver();
        private Random random = new Random();

        public Form1() {
            InitializeComponent();
            this.Text = "ColorMixer By duncte123";
        }

        private void cbboxPortSelect_SelectedIndexChanged(object sender, EventArgs e) {
            this.dmxDriver.DmxToDefault(this.cboxPortSelect.Text);
            this.cboxTimer.Start();
            this.cboxInterval.Text = this.cboxTimer.Interval + "";
        }

        private void cboxInterval_SelectedIndexChanged(object sender, EventArgs e) {
            this.cboxTimer.Interval = Convert.ToInt32(this.cboxInterval.Text);
        }

        private void cboxTimer_Tick(object sender, EventArgs e) {
            if (this.pnlTimer.BackColor == Color.White) {
                this.pnlTimer.BackColor = Color.Lime;
            } else {
                this.pnlTimer.BackColor = Color.White;
            }
            this.getData();
            this.dmxDriver.DmxSendCommand(this.buffSize);
        }

        private void changePbBlue(int val)  {
            this.pbBlue.BackColor = Color.FromArgb(0, 0, val);
        }

        private void changePbGreen(int val) {
            this.pbGreen.BackColor = Color.FromArgb(0, val, 0);
        }

        private void changePbRed(int val)  {
            this.pbRed.BackColor = Color.FromArgb(val, 0, 0);
        }

        private string checkInput(object input) {
            string str = Convert.ToString(input);
            switch (str)
            {
                case null:
                case "":
                    return "0";
            }
            return str;
        }

        private int checkNumber(object numberToCheck) {
            int num = Convert.ToInt32(numberToCheck);
            if (num > 255) {
                return 255;
            } else if (num < 0) {
                return 0;
            }
            return num;
        }

        private void Form1_Load(object sender, EventArgs e) {
            Console.WriteLine("loaded");
            for (int i = 0; i < this.dmxDriver.NrOfPorts; i++) {
                Console.WriteLine("hello");
                this.cboxPortSelect.Items.Add(this.dmxDriver.PortNameAt(i));
            }
        }

        private void form1_MouseDoubleClick(object sender, MouseEventArgs e)  {
            this.tbRed.Text = this.random.Next(0, 0xff).ToString();
            this.tbGreen.Text = this.random.Next(0, 0xff).ToString();
            this.tbBlue.Text = this.random.Next(0, 0xff).ToString();
        }

        private void getData() {
            this.dmxDriver.DmxLoadBuffer(1, (byte) this.trbRed.Value, this.buffSize);
            this.dmxDriver.DmxLoadBuffer(2, (byte) this.trbGreen.Value, this.buffSize);
            this.dmxDriver.DmxLoadBuffer(3, (byte) this.trbBlue.Value, this.buffSize);
            this.dmxDriver.DmxLoadBuffer(4, 0, this.buffSize);
            this.dmxDriver.DmxLoadBuffer(5, 0, this.buffSize);
            this.dmxDriver.DmxLoadBuffer(6, 0, this.buffSize);
            if (this.cbStartFade.Checked) {
                this.dmxDriver.DmxLoadBuffer(5, 128, this.buffSize);
                this.dmxDriver.DmxLoadBuffer(6, 128, this.buffSize);
            }
        }


        private void mix(int r, int g, int b) {
            this.pbMixer.BackColor = Color.FromArgb(r, g, b);
        }

        private void mix(string r, string g, string b) {
            this.pbMixer.BackColor = Color.FromArgb(Convert.ToInt32(r), Convert.ToInt32(g), Convert.ToInt32(b));
        }

        private void resetBtn_Click(object sender, EventArgs e) {
            this.tbRed.Text = "0";
            this.tbGreen.Text = "0";
            this.tbBlue.Text = "0";
            this.tbFinal.Text = "0";
            this.cbStartFade.Checked = false;
        }

        private void tbBlue_TextChanged(object sender, EventArgs e)  {
            this.trbBlue.Value = this.checkNumber(this.checkInput(this.tbBlue.Text));
            this.changePbBlue(this.trbBlue.Value);
            this.mix(this.trbRed.Value, this.trbGreen.Value, this.trbBlue.Value);
        }

        private void tbFinal_TextChanged(object sender, EventArgs e) {
            if (this.cbRed.Checked) {
                this.tbRed.Text = this.checkInput(this.tbFinal.Text);
            }
            if (this.cbGreen.Checked) {
                this.tbGreen.Text = this.checkInput(this.tbFinal.Text);
            }
            if (this.cbBlue.Checked) {
                this.tbBlue.Text = this.checkInput(this.tbFinal.Text);
            }
            this.trbFinal.Value = this.checkNumber(this.checkInput(this.tbFinal.Text));
        }

        private void tbGreen_TextChanged(object sender, EventArgs e) {
            this.trbGreen.Value = this.checkNumber(this.checkInput(this.tbGreen.Text));
            this.changePbGreen(this.trbGreen.Value);
            this.mix(this.trbRed.Value, this.trbGreen.Value, this.trbBlue.Value);
        }

        private void tbRed_TextChanged(object sender, EventArgs e) {
            this.trbRed.Value = this.checkNumber(this.checkInput(this.tbRed.Text));
            this.changePbRed(this.trbRed.Value);
            this.mix(this.trbRed.Value, this.trbGreen.Value, this.trbBlue.Value);
        }

        private void trbBlue_Scroll(object sender, EventArgs e) {
            this.tbBlue.Text = Convert.ToString(this.trbBlue.Value);
        }

        private void trbFinal_scroll(object sender, EventArgs e) {
            int input = this.trbFinal.Value;
            this.tbFinal.Text = this.checkInput(input);
        }

        private void trbGreen_Scroll(object sender, EventArgs e) {
            this.tbGreen.Text = Convert.ToString(this.trbGreen.Value);
        }

        private void trbRed_Scroll(object sender, EventArgs e) {
            this.tbRed.Text = Convert.ToString(this.trbRed.Value);
        }


        //private void InitializeComponent(bool flag) {
        //    this.components = new System.ComponentModel.Container();
        //    this.trbRed = new System.Windows.Forms.TrackBar();
        //    this.trbGreen = new System.Windows.Forms.TrackBar();
        //    this.trbBlue = new System.Windows.Forms.TrackBar();
        //    this.tbRed = new System.Windows.Forms.TextBox();
        //    this.tbGreen = new System.Windows.Forms.TextBox();
        //    this.tbBlue = new System.Windows.Forms.TextBox();
        //    this.label1 = new System.Windows.Forms.Label();
        //    this.label2 = new System.Windows.Forms.Label();
        //    this.label3 = new System.Windows.Forms.Label();
        //    this.resetBtn = new System.Windows.Forms.Button();
        //    this.pbMixer = new System.Windows.Forms.PictureBox();
        //    this.pbRed = new System.Windows.Forms.PictureBox();
        //    this.pbGreen = new System.Windows.Forms.PictureBox();
        //    this.pbBlue = new System.Windows.Forms.PictureBox();
        //    this.trbFinal = new System.Windows.Forms.TrackBar();
        //    this.label4 = new System.Windows.Forms.Label();
        //    this.tbFinal = new System.Windows.Forms.TextBox();
        //    this.cbRed = new System.Windows.Forms.CheckBox();
        //    this.cbGreen = new System.Windows.Forms.CheckBox();
        //    this.cbBlue = new System.Windows.Forms.CheckBox();
        //    this.label5 = new System.Windows.Forms.Label();
        //    this.label6 = new System.Windows.Forms.Label();
        //    this.cboxPortSelect = new System.Windows.Forms.ComboBox();
        //    this.cboxInterval = new System.Windows.Forms.ComboBox();
        //    this.label7 = new System.Windows.Forms.Label();
        //    this.label8 = new System.Windows.Forms.Label();
        //    this.cboxTimer = new System.Windows.Forms.Timer(this.components);
        //    this.pnlTimer = new System.Windows.Forms.Panel();
        //    this.cbStartFade = new System.Windows.Forms.CheckBox();
        //    ((System.ComponentModel.ISupportInitialize)(this.trbRed)).BeginInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.trbGreen)).BeginInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.trbBlue)).BeginInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.pbMixer)).BeginInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.pbRed)).BeginInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.pbGreen)).BeginInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.pbBlue)).BeginInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.trbFinal)).BeginInit();
        //    this.SuspendLayout();

        //     trbRed

        //    this.trbRed.Location = new System.Drawing.Point(61, 36);
        //    this.trbRed.Maximum = 255;
        //    this.trbRed.Name = "trbRed";
        //    this.trbRed.Size = new System.Drawing.Size(242, 45);
        //    this.trbRed.TabIndex = 0;
        //    this.trbRed.TabStop = false;
        //    this.trbRed.TickStyle = System.Windows.Forms.TickStyle.None;
        //    this.trbRed.Scroll += new System.EventHandler(this.trbRed_Scroll);

        //     trbGreen

        //    this.trbGreen.Location = new System.Drawing.Point(61, 87);
        //    this.trbGreen.Maximum = 255;
        //    this.trbGreen.Name = "trbGreen";
        //    this.trbGreen.Size = new System.Drawing.Size(242, 45);
        //    this.trbGreen.TabIndex = 1;
        //    this.trbGreen.TabStop = false;
        //    this.trbGreen.TickStyle = System.Windows.Forms.TickStyle.None;
        //    this.trbGreen.Scroll += new System.EventHandler(this.trbGreen_Scroll);

        //     trbBlue

        //    this.trbBlue.Location = new System.Drawing.Point(61, 138);
        //    this.trbBlue.Maximum = 255;
        //    this.trbBlue.Name = "trbBlue";
        //    this.trbBlue.Size = new System.Drawing.Size(242, 45);
        //    this.trbBlue.TabIndex = 2;
        //    this.trbBlue.TabStop = false;
        //    this.trbBlue.TickStyle = System.Windows.Forms.TickStyle.None;
        //    this.trbBlue.Scroll += new System.EventHandler(this.trbBlue_Scroll);

        //     tbRed

        //    this.tbRed.Location = new System.Drawing.Point(354, 36);
        //    this.tbRed.Name = "tbRed";
        //    this.tbRed.Size = new System.Drawing.Size(54, 20);
        //    this.tbRed.TabIndex = 4;
        //    this.tbRed.TabStop = false;
        //    this.tbRed.Text = "0";
        //    this.tbRed.TextChanged += new System.EventHandler(this.tbRed_TextChanged);

        //     tbGreen

        //    this.tbGreen.Location = new System.Drawing.Point(354, 87);
        //    this.tbGreen.Name = "tbGreen";
        //    this.tbGreen.Size = new System.Drawing.Size(54, 20);
        //    this.tbGreen.TabIndex = 4;
        //    this.tbGreen.TabStop = false;
        //    this.tbGreen.Text = "0";
        //    this.tbGreen.TextChanged += new System.EventHandler(this.tbGreen_TextChanged);

        //     tbBlue

        //    this.tbBlue.Location = new System.Drawing.Point(354, 138);
        //    this.tbBlue.Name = "tbBlue";
        //    this.tbBlue.Size = new System.Drawing.Size(54, 20);
        //    this.tbBlue.TabIndex = 4;
        //    this.tbBlue.TabStop = false;
        //    this.tbBlue.Text = "0";
        //    this.tbBlue.TextChanged += new System.EventHandler(this.tbBlue_TextChanged);

        //     label1

        //    this.label1.AutoSize = true;
        //    this.label1.Location = new System.Drawing.Point(19, 36);
        //    this.label1.Name = "label1";
        //    this.label1.Size = new System.Drawing.Size(27, 13);
        //    this.label1.TabIndex = 5;
        //    this.label1.Text = "Red";

        //     label2

        //    this.label2.AutoSize = true;
        //    this.label2.Location = new System.Drawing.Point(19, 87);
        //    this.label2.Name = "label2";
        //    this.label2.Size = new System.Drawing.Size(36, 13);
        //    this.label2.TabIndex = 6;
        //    this.label2.Text = "Green";

        //     label3

        //    this.label3.AutoSize = true;
        //    this.label3.Location = new System.Drawing.Point(19, 138);
        //    this.label3.Name = "label3";
        //    this.label3.Size = new System.Drawing.Size(28, 13);
        //    this.label3.TabIndex = 7;
        //    this.label3.Text = "Blue";

        //     resetBtn

        //    this.resetBtn.Location = new System.Drawing.Point(428, 266);
        //    this.resetBtn.Name = "resetBtn";
        //    this.resetBtn.Size = new System.Drawing.Size(113, 23);
        //    this.resetBtn.TabIndex = 8;
        //    this.resetBtn.TabStop = false;
        //    this.resetBtn.Text = "Reset";
        //    this.resetBtn.UseVisualStyleBackColor = true;
        //    this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);

        //     pbMixer

        //    this.pbMixer.BackColor = System.Drawing.Color.Black;
        //    this.pbMixer.Location = new System.Drawing.Point(547, 25);
        //    this.pbMixer.Name = "pbMixer";
        //    this.pbMixer.Size = new System.Drawing.Size(53, 264);
        //    this.pbMixer.TabIndex = 9;
        //    this.pbMixer.TabStop = false;

        //     pbRed

        //    this.pbRed.BackColor = System.Drawing.Color.Black;
        //    this.pbRed.Location = new System.Drawing.Point(428, 36);
        //    this.pbRed.Name = "pbRed";
        //    this.pbRed.Size = new System.Drawing.Size(54, 20);
        //    this.pbRed.TabIndex = 10;
        //    this.pbRed.TabStop = false;

        //     pbGreen

        //    this.pbGreen.BackColor = System.Drawing.Color.Black;
        //    this.pbGreen.Location = new System.Drawing.Point(428, 87);
        //    this.pbGreen.Name = "pbGreen";
        //    this.pbGreen.Size = new System.Drawing.Size(54, 20);
        //    this.pbGreen.TabIndex = 11;
        //    this.pbGreen.TabStop = false;

        //     pbBlue

        //    this.pbBlue.BackColor = System.Drawing.Color.Black;
        //    this.pbBlue.Location = new System.Drawing.Point(428, 138);
        //    this.pbBlue.Name = "pbBlue";
        //    this.pbBlue.Size = new System.Drawing.Size(54, 20);
        //    this.pbBlue.TabIndex = 12;
        //    this.pbBlue.TabStop = false;

        //     trbFinal

        //    this.trbFinal.Location = new System.Drawing.Point(61, 209);
        //    this.trbFinal.Maximum = 255;
        //    this.trbFinal.Name = "trbFinal";
        //    this.trbFinal.Size = new System.Drawing.Size(361, 45);
        //    this.trbFinal.TabIndex = 13;
        //    this.trbFinal.TabStop = false;
        //    this.trbFinal.TickStyle = System.Windows.Forms.TickStyle.Both;
        //    this.trbFinal.Scroll += new System.EventHandler(this.trbFinal_scroll);

        //     label4

        //    this.label4.AutoSize = true;
        //    this.label4.Location = new System.Drawing.Point(19, 209);
        //    this.label4.Name = "label4";
        //    this.label4.Size = new System.Drawing.Size(30, 13);
        //    this.label4.TabIndex = 14;
        //    this.label4.Text = "RGB";

        //     tbFinal

        //    this.tbFinal.Location = new System.Drawing.Point(428, 209);
        //    this.tbFinal.Name = "tbFinal";
        //    this.tbFinal.Size = new System.Drawing.Size(54, 20);
        //    this.tbFinal.TabIndex = 15;
        //    this.tbFinal.TabStop = false;
        //    this.tbFinal.Text = "0";
        //    this.tbFinal.TextChanged += new System.EventHandler(this.tbFinal_TextChanged);

        //     cbRed

        //    this.cbRed.AutoSize = true;
        //    this.cbRed.Location = new System.Drawing.Point(310, 38);
        //    this.cbRed.Name = "cbRed";
        //    this.cbRed.Size = new System.Drawing.Size(15, 14);
        //    this.cbRed.TabIndex = 16;
        //    this.cbRed.TabStop = false;
        //    this.cbRed.UseVisualStyleBackColor = true;

        //     cbGreen

        //    this.cbGreen.AutoSize = true;
        //    this.cbGreen.Location = new System.Drawing.Point(310, 89);
        //    this.cbGreen.Name = "cbGreen";
        //    this.cbGreen.Size = new System.Drawing.Size(15, 14);
        //    this.cbGreen.TabIndex = 17;
        //    this.cbGreen.TabStop = false;
        //    this.cbGreen.UseVisualStyleBackColor = true;

        //     cbBlue

        //    this.cbBlue.AutoSize = true;
        //    this.cbBlue.Location = new System.Drawing.Point(310, 140);
        //    this.cbBlue.Name = "cbBlue";
        //    this.cbBlue.Size = new System.Drawing.Size(15, 14);
        //    this.cbBlue.TabIndex = 18;
        //    this.cbBlue.TabStop = false;
        //    this.cbBlue.UseVisualStyleBackColor = true;

        //     label5

        //    this.label5.AutoSize = true;
        //    this.label5.Location = new System.Drawing.Point(297, 9);
        //    this.label5.Name = "label5";
        //    this.label5.Size = new System.Drawing.Size(37, 13);
        //    this.label5.TabIndex = 19;
        //    this.label5.Text = "Select";

        //     label6

        //    this.label6.AutoSize = true;
        //    this.label6.Location = new System.Drawing.Point(478, 9);
        //    this.label6.Name = "label6";
        //    this.label6.Size = new System.Drawing.Size(72, 13);
        //    this.label6.TabIndex = 20;
        //    this.label6.Text = "Output Colour";

        //     cboxPortSelect

        //    this.cboxPortSelect.FormattingEnabled = true;
        //    this.cboxPortSelect.Location = new System.Drawing.Point(61, 268);
        //    this.cboxPortSelect.Name = "cboxPortSelect";
        //    this.cboxPortSelect.Size = new System.Drawing.Size(112, 21);
        //    this.cboxPortSelect.TabIndex = 21;
        //    this.cboxPortSelect.TabStop = false;
        //    this.cboxPortSelect.Text = "Select Comport";
        //    this.cboxPortSelect.SelectedIndexChanged += new System.EventHandler(this.cbboxPortSelect_SelectedIndexChanged);

        //     cboxInterval

        //    this.cboxInterval.FormattingEnabled = true;
        //    this.cboxInterval.Items.AddRange(new object[] {
        //    "10",
        //    "25",
        //    "50",
        //    "100",
        //    "250",
        //    "500",
        //    "1000"});
        //    this.cboxInterval.Location = new System.Drawing.Point(254, 268);
        //    this.cboxInterval.Name = "cboxInterval";
        //    this.cboxInterval.Size = new System.Drawing.Size(62, 21);
        //    this.cboxInterval.TabIndex = 22;
        //    this.cboxInterval.TabStop = false;
        //    this.cboxInterval.SelectedIndexChanged += new System.EventHandler(this.cboxInterval_SelectedIndexChanged);

        //     label7

        //    this.label7.AutoSize = true;
        //    this.label7.Location = new System.Drawing.Point(26, 271);
        //    this.label7.Name = "label7";
        //    this.label7.Size = new System.Drawing.Size(29, 13);
        //    this.label7.TabIndex = 23;
        //    this.label7.Text = "Port:";

        //     label8

        //    this.label8.AutoSize = true;
        //    this.label8.Location = new System.Drawing.Point(207, 271);
        //    this.label8.Name = "label8";
        //    this.label8.Size = new System.Drawing.Size(41, 13);
        //    this.label8.TabIndex = 24;
        //    this.label8.Text = "Timing:";

        //     cboxTimer

        //    this.cboxTimer.Tick += new System.EventHandler(this.cboxTimer_Tick);

        //     pnlTimer

        //    this.pnlTimer.BackColor = System.Drawing.Color.White;
        //    this.pnlTimer.Location = new System.Drawing.Point(333, 268);
        //    this.pnlTimer.Name = "pnlTimer";
        //    this.pnlTimer.Size = new System.Drawing.Size(20, 21);
        //    this.pnlTimer.TabIndex = 26;

        //     cbStartFade

        //    this.cbStartFade.AutoSize = true;
        //    this.cbStartFade.Location = new System.Drawing.Point(441, 243);
        //    this.cbStartFade.Name = "cbStartFade";
        //    this.cbStartFade.Size = new System.Drawing.Size(75, 17);
        //    this.cbStartFade.TabIndex = 27;
        //    this.cbStartFade.Text = "Start Fade";
        //    this.cbStartFade.UseVisualStyleBackColor = true;

        //     Form1

        //    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    this.ClientSize = new System.Drawing.Size(612, 301);
        //    this.Controls.Add(this.cbStartFade);
        //    this.Controls.Add(this.pnlTimer);
        //    this.Controls.Add(this.label8);
        //    this.Controls.Add(this.label7);
        //    this.Controls.Add(this.cboxInterval);
        //    this.Controls.Add(this.cboxPortSelect);
        //    this.Controls.Add(this.label6);
        //    this.Controls.Add(this.label5);
        //    this.Controls.Add(this.cbBlue);
        //    this.Controls.Add(this.cbGreen);
        //    this.Controls.Add(this.cbRed);
        //    this.Controls.Add(this.tbFinal);
        //    this.Controls.Add(this.label4);
        //    this.Controls.Add(this.trbFinal);
        //    this.Controls.Add(this.pbBlue);
        //    this.Controls.Add(this.pbGreen);
        //    this.Controls.Add(this.pbRed);
        //    this.Controls.Add(this.pbMixer);
        //    this.Controls.Add(this.resetBtn);
        //    this.Controls.Add(this.label3);
        //    this.Controls.Add(this.label2);
        //    this.Controls.Add(this.label1);
        //    this.Controls.Add(this.tbBlue);
        //    this.Controls.Add(this.tbGreen);
        //    this.Controls.Add(this.tbRed);
        //    this.Controls.Add(this.trbBlue);
        //    this.Controls.Add(this.trbGreen);
        //    this.Controls.Add(this.trbRed);
        //    this.MaximizeBox = false;
        //    this.MaximumSize = new System.Drawing.Size(628, 340);
        //    this.MinimumSize = new System.Drawing.Size(628, 340);
        //    this.Name = "Form1";
        //    this.Text = "KleurMixer";
        //    this.Load += new System.EventHandler(this.Form1_Load);
        //    this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.form1_MouseDoubleClick);
        //    ((System.ComponentModel.ISupportInitialize)(this.trbRed)).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.trbGreen)).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.trbBlue)).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.pbMixer)).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.pbRed)).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.pbGreen)).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.pbBlue)).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.trbFinal)).EndInit();
        //    this.ResumeLayout(false);
        //    this.PerformLayout();

        //}
    }
}

