using DMXControl.Serializers;
using System;

/*
 * https://www.bax-shop.nl/downloads/products/9000-0004-8917/ayra_ero_540_led_rgb_movinghead_manual.pdf
 */
namespace DMXControl.Controls
{
    public partial class UcMovingHeadSliders : LightSerializerDSte
    {
        public UcMovingHeadSliders(int startAddress) : base(startAddress)
        {
            InitializeComponent();
        }

        public override int[] GetDmxValues()
        {
            return new[]
            {
                XAxisDMXValue, // dmx channel 1
                YAxisDMXValue, // dmx channel 2
                DimmerStrobeDMXValue, // dmx channel 3
                ColorDMXValue, // dmx channel 4
                GoboDMXValue, // dmx channel 5
                0, // dmx channel 6
            };
        }

        public bool Shown { get; set; }

        public int XAxisDMXValue
        {
            get => trbXDSte.Value;
            set => trbXDSte.Value = value;
        }

        public int YAxisDMXValue
        {
            get => trbYDSte.Value;
            set => trbYDSte.Value = value;
        }

        public int DimmerStrobeDMXValue
        {
            get => trbDmStrbDSte.Value;
            set => trbDmStrbDSte.Value = value;
        }

        public int ColorDMXValue
        {
            get => trbColorDSte.Value;
            set => trbColorDSte.Value = value;
        }

        public int GoboDMXValue
        {
            get => trbGoboDSte.Value;
            set => trbGoboDSte.Value = value;
        }

        private void BtnResetDSte_Click(object sender, EventArgs e)
        {
            XAxisDMXValue = 0;
            YAxisDMXValue = 0;
            DimmerStrobeDMXValue = 0;
            ColorDMXValue = 0;
            GoboDMXValue = 0;
        }
    }
}