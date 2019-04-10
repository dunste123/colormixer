using System;
using System.Drawing;
using DMXControl.Serializers;

/**
 * https://manuals.coolblue.nl/a1/showtec-led-par-56-short-eco.pdf
 */
namespace DMXControl.Controls
{
    public partial class UcPar56Sliders : LightSerializerDSte
    {
        private static readonly int[] DmxRange = {1, 6};

        public UcPar56Sliders()
        {
            InitializeComponent();
        }

        public override int[] GetDmxRange()
        {
            return DmxRange;
        }

        public override int[][] GetDmxValues()
        {
            return new[]
            {
                new[] {1, RedDMXValue},
                new[] {2, GreenDMXValue},
                new[] {3, BlueDMXValue},
                new[] {4, 0},
                new[] {5, StrobeDMXValue},
                new[] {6, 0}
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