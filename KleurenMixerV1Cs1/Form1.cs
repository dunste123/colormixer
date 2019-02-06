using Dmx512UsbRs485;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KleurenMixerV1Cs1 {

    public partial class Form1 : Form {
        private int buffSize = 512;
        private int strobe = 0;
        private int fadeSpeed = 128;
        private Dmx512UsbRs485Driver dmxDriver = new Dmx512UsbRs485Driver();
        private Random random = new Random();

        public Form1() {
            InitializeComponent();
            this.Text = "ColorMixer By duncte123";
        }

        private void CbboxPortSelect_SelectedIndexChanged(object sender, EventArgs e) {
            this.dmxDriver.DmxToDefault(this.cboxPortSelect.Text);
            this.cboxTimer.Start();
            this.cboxInterval.Text = this.cboxTimer.Interval + "";
        }

        private void cboxInterval_SelectedIndexChanged(object sender, EventArgs e) {
            this.cboxTimer.Interval = Convert.ToInt32(this.cboxInterval.Text);
        }

        private void CboxTimer_Tick(object sender, EventArgs e) {
            if (this.pnlTimer.BackColor == Color.White) {
                this.pnlTimer.BackColor = Color.Lime;
            } else {
                this.pnlTimer.BackColor = Color.White;
            }
            this.GetData();
            this.dmxDriver.DmxSendCommand(this.buffSize);
        }

        private void ChangePbBlue(int val)  {
            this.pbBlue.BackColor = Color.FromArgb(0, 0, val);
        }

        private void ChangePbGreen(int val) {
            this.pbGreen.BackColor = Color.FromArgb(0, val, 0);
        }

        private void ChangePbRed(int val)  {
            this.pbRed.BackColor = Color.FromArgb(val, 0, 0);
        }

        private string CheckInput(object input) {
            string str = Convert.ToString(input);
            switch (str)
            {
                case null:
                case "":
                    return "0";
            }
            return str;
        }

        private int CheckNumber(object numberToCheck) {
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

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)  {
            this.tbRed.Text = this.random.Next(0, 0xff).ToString();
            this.tbGreen.Text = this.random.Next(0, 0xff).ToString();
            this.tbBlue.Text = this.random.Next(0, 0xff).ToString();
        }

        private void GetData() {
            this.dmxDriver.DmxLoadBuffer(1, (byte) this.trbRed.Value, this.buffSize);
            this.dmxDriver.DmxLoadBuffer(2, (byte) this.trbGreen.Value, this.buffSize);
            this.dmxDriver.DmxLoadBuffer(3, (byte) this.trbBlue.Value, this.buffSize);

            // color stepper val = color
            this.dmxDriver.DmxLoadBuffer(4, 0, this.buffSize);
			
			// shutter = 0 - 255
            this.dmxDriver.DmxLoadBuffer(5, (byte) this.trbStrobeDSte.Value, this.buffSize);

            // fader val = fade speed
            this.dmxDriver.DmxLoadBuffer(6, 0, this.buffSize);
            if (this.cbStartFade.Checked)
            {
                this.dmxDriver.DmxLoadBuffer(6, (byte) this.trbFadeSpeedDSte.Value, this.buffSize);
            }
        }


        private void Mix(int r, int g, int b) {
            this.pbMixer.BackColor = Color.FromArgb(r, g, b);
        }

        private void Mix(string r, string g, string b) {
            this.Mix(Convert.ToInt32(r), Convert.ToInt32(g), Convert.ToInt32(b));
        }

        private void ResetBtn_Click(object sender, EventArgs e) {
            this.tbRed.Text = "0";
            this.tbGreen.Text = "0";
            this.tbBlue.Text = "0";
            this.tbFinal.Text = "0";
            this.trbStrobeDSte.Value = 0;
            this.trbFadeSpeedDSte.Value = this.trbFadeSpeedDSte.Minimum;
            this.cbStartFade.Checked = false;
			this.cbRed.Checked = false;
			this.cbGreen.Checked = false;
			this.cbBlue.Checked = false;
        }

        private void TbBlue_TextChanged(object sender, EventArgs e)  {
            this.trbBlue.Value = this.CheckNumber(this.CheckInput(this.tbBlue.Text));
            this.ChangePbBlue(this.trbBlue.Value);
            this.Mix(this.trbRed.Value, this.trbGreen.Value, this.trbBlue.Value);
        }

        private void TbFinal_TextChanged(object sender, EventArgs e) {
            if (this.cbRed.Checked) {
                this.tbRed.Text = this.CheckInput(this.tbFinal.Text);
            }
            if (this.cbGreen.Checked) {
                this.tbGreen.Text = this.CheckInput(this.tbFinal.Text);
            }
            if (this.cbBlue.Checked) {
                this.tbBlue.Text = this.CheckInput(this.tbFinal.Text);
            }
            this.trbFinal.Value = this.CheckNumber(this.CheckInput(this.tbFinal.Text));
        }

        private void TbGreen_TextChanged(object sender, EventArgs e) {
            this.trbGreen.Value = this.CheckNumber(this.CheckInput(this.tbGreen.Text));
            this.ChangePbGreen(this.trbGreen.Value);
            this.Mix(this.trbRed.Value, this.trbGreen.Value, this.trbBlue.Value);
        }

        private void TbRed_TextChanged(object sender, EventArgs e) {
            this.trbRed.Value = this.CheckNumber(this.CheckInput(this.tbRed.Text));
            this.ChangePbRed(this.trbRed.Value);
            this.Mix(this.trbRed.Value, this.trbGreen.Value, this.trbBlue.Value);
        }

        private void trbBlue_Scroll(object sender, EventArgs e) {
            this.tbBlue.Text = Convert.ToString(this.trbBlue.Value);
        }

        private void TrbFinal_scroll(object sender, EventArgs e) {
            int input = this.trbFinal.Value;
            this.tbFinal.Text = this.CheckInput(input);
        }

        private void TrbGreen_Scroll(object sender, EventArgs e) {
            this.tbGreen.Text = Convert.ToString(this.trbGreen.Value);
        }

        private void TrbRed_Scroll(object sender, EventArgs e) {
            this.tbRed.Text = Convert.ToString(this.trbRed.Value);
        }

        private void TrbStrobeDSte_Scroll(object sender, EventArgs e)
        {
            this.strobe = this.trbStrobeDSte.Value;
        }

        private void TrbFadeSpeedDSte_Scroll(object sender, EventArgs e)
        {
            this.fadeSpeed = this.trbFadeSpeedDSte.Value;
        }
    }
}

