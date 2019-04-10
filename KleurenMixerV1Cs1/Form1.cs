using System;
using System.Drawing;
using System.Windows.Forms;
using Dmx512UsbRs485;

public partial class Form1 : Form {
    private int buffSize = 512;
    private int strobe = 0;
    private int fadeSpeed = 128;
    private Dmx512UsbRs485Driver dmxDriver = new Dmx512UsbRs485Driver();
    private Random random = new Random();

    public Form1() {
        InitializeComponent();
        Text = "ColorMixer By duncte123";
    }

    private void CbboxPortSelect_SelectedIndexChanged(object sender, EventArgs e) {
        dmxDriver.DmxToDefault(cboxPortSelect.Text);
        cboxTimerDSte.Start();
        cboxInterval.Text = cboxTimerDSte.Interval + "";
    }

    private void cboxInterval_SelectedIndexChanged(object sender, EventArgs e) {
        cboxTimerDSte.Interval = Convert.ToInt32(cboxInterval.Text);
    }

    private void CboxTimer_Tick(object sender, EventArgs e) {
        if (pnlTimer.BackColor == Color.White) {
            pnlTimer.BackColor = Color.Lime;
        } else {
            pnlTimer.BackColor = Color.White;
        }
        GetData();
        dmxDriver.DmxSendCommand(buffSize);
    }

    private void ChangePbBlue(int val)  {
        pbBlue.BackColor = Color.FromArgb(0, 0, val);
    }

    private void ChangePbGreen(int val) {
        pbGreen.BackColor = Color.FromArgb(0, val, 0);
    }

    private void ChangePbRed(int val)  {
        pbRed.BackColor = Color.FromArgb(val, 0, 0);
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
        for (int i = 0; i < dmxDriver.NrOfPorts; i++) {
            Console.WriteLine("hello");
            cboxPortSelect.Items.Add(dmxDriver.PortNameAt(i));
        }
    }

    private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)  {
        tbRed.Text = random.Next(0, 0xff).ToString();
        tbGreen.Text = random.Next(0, 0xff).ToString();
        tbBlue.Text = random.Next(0, 0xff).ToString();
    }

    private void GetData() {
        dmxDriver.DmxLoadBuffer(1, (byte) trbRed.Value, buffSize);
        dmxDriver.DmxLoadBuffer(2, (byte) trbGreen.Value, buffSize);
        dmxDriver.DmxLoadBuffer(3, (byte) trbBlue.Value, buffSize);

        // color stepper val = color
        dmxDriver.DmxLoadBuffer(4, 0, buffSize);
			
        // shutter = 0 - 255
        dmxDriver.DmxLoadBuffer(5, (byte) trbStrobeDSte.Value, buffSize);

        // fader val = fade speed
        dmxDriver.DmxLoadBuffer(6, 0, buffSize);
        if (cbStartFade.Checked)
        {
            dmxDriver.DmxLoadBuffer(6, (byte) trbFadeSpeedDSte.Value, buffSize);
        }
    }


    private void Mix(int r, int g, int b) {
        pbMixer.BackColor = Color.FromArgb(r, g, b);
    }

    private void Mix(string r, string g, string b) {
        Mix(Convert.ToInt32(r), Convert.ToInt32(g), Convert.ToInt32(b));
    }

    private void ResetBtn_Click(object sender, EventArgs e) {
        tbRed.Text = "0";
        tbGreen.Text = "0";
        tbBlue.Text = "0";
        tbFinal.Text = "0";
        trbStrobeDSte.Value = 0;
        trbFadeSpeedDSte.Value = trbFadeSpeedDSte.Minimum;
        cbStartFade.Checked = false;
        cbRed.Checked = false;
        cbGreen.Checked = false;
        cbBlue.Checked = false;
    }

    private void TbBlue_TextChanged(object sender, EventArgs e)  {
        trbBlue.Value = CheckNumber(CheckInput(tbBlue.Text));
        ChangePbBlue(trbBlue.Value);
        Mix(trbRed.Value, trbGreen.Value, trbBlue.Value);
    }

    private void TbFinal_TextChanged(object sender, EventArgs e) {
        if (cbRed.Checked) {
            tbRed.Text = CheckInput(tbFinal.Text);
        }
        if (cbGreen.Checked) {
            tbGreen.Text = CheckInput(tbFinal.Text);
        }
        if (cbBlue.Checked) {
            tbBlue.Text = CheckInput(tbFinal.Text);
        }
        trbFinal.Value = CheckNumber(CheckInput(tbFinal.Text));
    }

    private void TbGreen_TextChanged(object sender, EventArgs e) {
        trbGreen.Value = CheckNumber(CheckInput(tbGreen.Text));
        ChangePbGreen(trbGreen.Value);
        Mix(trbRed.Value, trbGreen.Value, trbBlue.Value);
    }

    private void TbRed_TextChanged(object sender, EventArgs e) {
        trbRed.Value = CheckNumber(CheckInput(tbRed.Text));
        ChangePbRed(trbRed.Value);
        Mix(trbRed.Value, trbGreen.Value, trbBlue.Value);
    }

    private void trbBlue_Scroll(object sender, EventArgs e) {
        tbBlue.Text = Convert.ToString(trbBlue.Value);
    }

    private void TrbFinal_scroll(object sender, EventArgs e) {
        int input = trbFinal.Value;
        tbFinal.Text = CheckInput(input);
    }

    private void TrbGreen_Scroll(object sender, EventArgs e) {
        tbGreen.Text = Convert.ToString(trbGreen.Value);
    }

    private void TrbRed_Scroll(object sender, EventArgs e) {
        tbRed.Text = Convert.ToString(trbRed.Value);
    }

    private void TrbStrobeDSte_Scroll(object sender, EventArgs e)
    {
        strobe = trbStrobeDSte.Value;
    }

    private void TrbFadeSpeedDSte_Scroll(object sender, EventArgs e)
    {
        fadeSpeed = trbFadeSpeedDSte.Value;
    }
}