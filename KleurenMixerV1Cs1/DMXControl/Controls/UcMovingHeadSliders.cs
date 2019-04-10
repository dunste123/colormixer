using System;
using DMXControl.Serializers;

/**
 * https://www.bax-shop.nl/downloads/products/9000-0004-8917/ayra_ero_540_led_rgb_movinghead_manual.pdf
 */
namespace DMXControl.Controls
{
    public partial class UcMovingHeadSliders : LightSerializerDSte
    {
        private static readonly int[] DmxRange = {7, 12};

        public UcMovingHeadSliders()
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
                new[] {7, XAxisDMXValue},
                new[] {8, YAxisDMXValue},
                new[] {9, DimmerStrobeDMXValue},
                new[] {10, ColorDMXValue},
                new[] {11, GoboDMXValue},
                new[] {12, 0}
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