using System;
using System.Drawing;

/**
 * https://manuals.coolblue.nl/a1/showtec-led-par-56-short-eco.pdf
 */
namespace KleurenMixerV1Cs1.Controls
{
    public partial class UcPar56Sliders : LightSerializerDSte 
    {
        private static readonly int[] _dmxRange = { 1, 6 };
        
        public UcPar56Sliders()
        {
            InitializeComponent();
        }

        public override int[] GetDMXRange()
        {
            return _dmxRange;
        }

        public override object[][] GetDMXValues()
        {
            return new object[6][] {
                new object[2] { 1, this.RedDMXValue },
                new object[2] { 2, this.GreenDMXValue },
                new object[2] { 3, this.BlueDMXValue },
                new object[2] { 4, 0 },
                new object[2] { 5, this.StrobeDMXValue },
                new object[2] { 6, 0 },
            };
        }

        public bool Shown { get; set; }

        public int RedDMXValue
        {
            get => this.trbRedDste.Value;
            set => this.trbRedDste.Value = value;
        }

        public int GreenDMXValue
        {
            get => this.trbGreenDste.Value;
            set => this.trbGreenDste.Value = value;
        }

        public int BlueDMXValue
        {
            get => this.trbBlueDste.Value;
            set => this.trbBlueDste.Value = value;
        }

        public int StrobeDMXValue
        {
            get => this.trbStrobeDste.Value;
            set => this.trbStrobeDste.Value = value;
        }

        private void Mix()
        {
            this.Mix(this.RedDMXValue, this.GreenDMXValue, this.BlueDMXValue);
        }

        private void Mix(int r, int g, int b)
        {
            this.pbOutputColorDste.BackColor = Color.FromArgb(r, g, b);
        }

        private void TrackBarScroll(object sender, EventArgs e)
        {
            this.Mix();
        }

        private void BtnResetDSte_Click(object sender, EventArgs e)
        {
            this.RedDMXValue = 0;
            this.GreenDMXValue = 0;
            this.BlueDMXValue = 0;
            this.StrobeDMXValue = 0;

            this.Mix();
        }

        override public void AfterReading()
        {
            this.Mix();
        }
    }
}
