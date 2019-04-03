using System;

/**
 * https://www.bax-shop.nl/downloads/products/9000-0004-8917/ayra_ero_540_led_rgb_movinghead_manual.pdf
 */
namespace KleurenMixerV1Cs1.Controls
{
    public partial class UcMovingHeadSliders: LightSerializerDSte 
    {
        private static readonly int[] _dmxRange = { 7, 12 };

        public UcMovingHeadSliders()
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
                new object[2] { 7,  this.XAxisDMXValue },
                new object[2] { 8,  this.YAxisDMXValue },
                new object[2] { 9,  this.DimmerStrobeDMXValue },
                new object[2] { 10, this.ColorDMXValue },
                new object[2] { 11, this.GoboDMXValue },
                new object[2] { 12, 0 },
            };
        }

        public bool Shown { get; set; }
        
        public int XAxisDMXValue {
            get => this.trbXDSte.Value;
            set => this.trbXDSte.Value = value;
        }
        
        public int YAxisDMXValue
        {
            get => this.trbYDSte.Value;
            set => this.trbYDSte.Value = value;
        }
        
        public int DimmerStrobeDMXValue
        {
            get => this.trbDmStrbDSte.Value;
            set => this.trbDmStrbDSte.Value = value;
        }

        public int ColorDMXValue
        {
            get => this.trbColorDSte.Value;
            set => this.trbColorDSte.Value = value;
        }

        public int GoboDMXValue {
            get => this.trbGoboDSte.Value;
            set => this.trbGoboDSte.Value = value;
        }
        

        private void BtnResetDSte_Click(object sender, EventArgs e)
        {
            this.XAxisDMXValue = 0;
            this.YAxisDMXValue = 0;
            this.DimmerStrobeDMXValue = 0;
            this.ColorDMXValue = 0;
            this.GoboDMXValue = 0;
        }
    }
}
