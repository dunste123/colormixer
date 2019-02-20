using System;
using System.Drawing;
using System.Windows.Forms;

namespace KleurenMixerV1Cs1.Controls
{
    public partial class UcPar56Sliders : UserControl
    {
        public UcPar56Sliders()
        {
            InitializeComponent();
        }

        public bool Shown { get; set; }

        public int RedValue {
            get => this.trbRedDste.Value;
            set => this.trbRedDste.Value = value;
        }

        public int GreenValue
        {
            get => this.trbGreenDste.Value;
            set => this.trbGreenDste.Value = value;
        }

        public int BlueValue
        {
            get => this.trbBlueDste.Value;
            set => this.trbBlueDste.Value = value;
        }

        public int StrobeValue {
            get => this.trbStrobeDste.Value;
            set => this.trbStrobeDste.Value = value;
        }

        private void Mix()
        {
            this.Mix(this.RedValue, this.GreenValue, this.BlueValue);
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
            this.RedValue = 0;
            this.GreenValue = 0;
            this.BlueValue = 0;
            this.StrobeValue = 0;

            this.Mix();
        }
    }
}
