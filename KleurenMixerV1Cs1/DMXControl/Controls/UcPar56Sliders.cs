using System;
using System.Drawing;
using DMXControl.Serializers;

/*
 * https://manuals.coolblue.nl/a1/showtec-led-par-56-short-eco.pdf
 */
namespace DMXControl.Controls
{
    public partial class UcPar56Sliders : LightSerializerDSte
    {
        public UcPar56Sliders(int startAddress) : base(startAddress)
        {
            InitializeComponent();
        }

        public override int[] GetDmxValues()
        {
            return new[]
            {
                RedDMXValue, // dmx channel 1
                GreenDMXValue, // dmx channel 2
                BlueDMXValue, // dmx channel 3
                0, // dmx channel 4
                StrobeDMXValue, // dmx channel 5
                0, // dmx channel 6
            };
        }

        public bool Shown { get; set; }

        public int RedDMXValue
        {
            get => trbRedDste.Value;
            set => trbRedDste.Value = value;
        }

        public int GreenDMXValue
        {
            get => trbGreenDste.Value;
            set => trbGreenDste.Value = value;
        }

        public int BlueDMXValue
        {
            get => trbBlueDste.Value;
            set => trbBlueDste.Value = value;
        }

        public int StrobeDMXValue
        {
            get => trbStrobeDste.Value;
            set => trbStrobeDste.Value = value;
        }

        private void Mix()
        {
            Mix(RedDMXValue, GreenDMXValue, BlueDMXValue);
        }

        private void Mix(int r, int g, int b)
        {
            pbOutputColorDste.BackColor = Color.FromArgb(r, g, b);
        }

        private void TrackBarScroll(object sender, EventArgs e)
        {
            Mix();
        }

        private void BtnResetDSte_Click(object sender, EventArgs e)
        {
            RedDMXValue = 0;
            GreenDMXValue = 0;
            BlueDMXValue = 0;
            StrobeDMXValue = 0;

            Mix();
        }

        protected override void AfterReading()
        {
            Mix();
        }
    }
}