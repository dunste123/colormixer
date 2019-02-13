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

        private void Mix()
        {
            this.Mix(this.trbRedDste.Value, this.trbGreenDste.Value, this.trbBlueDste.Value);
        }

        private void Mix(int r, int g, int b)
        {
            this.pbOutputColorDste.BackColor = Color.FromArgb(r, g, b);
        }

        private void TrackBarScroll(object sender, EventArgs e)
        {
            this.Mix();
        }
    }
}
