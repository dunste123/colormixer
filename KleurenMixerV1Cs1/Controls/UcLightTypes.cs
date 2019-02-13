using System;
using System.Windows.Forms;

namespace KleurenMixerV1Cs1.Controls
{
    public partial class UcLightTypes : UserControl
    {
        private UcPar56Sliders parSliders = null;
        private int arrayIndex = 0;

        public UcLightTypes()
        {
            InitializeComponent();
        }

        public int ArrayIndex {
            get => this.arrayIndex;
            set {
                this.arrayIndex = value;
                this.lblIndexDste.Text = (value + 1).ToString();
            }
        }

        public UcPar56Sliders GetParSliders()
        {
            return this.parSliders;
        }

        public void HideAllControls()
        {
            if (this.parSliders != null)
            {
                this.parSliders.Shown = false;
            }
        }

        private void BtnPar56Dste_Click(object sender, EventArgs e)
        {
            if (this.parSliders == null)
            {
                this.parSliders = new UcPar56Sliders();
            }

            if (!this.parSliders.Shown)
            {
                this.parSliders.Shown = true;

                var eventArgs = new LightTypeEventArgs();
                eventArgs.ArrayIndex = this.ArrayIndex;
                eventArgs.Control = this.parSliders;

                this.OnSliderControlSet(eventArgs);
            }
        }

        protected virtual void OnSliderControlSet(LightTypeEventArgs e)
        {
            this.SliderControlSet?.Invoke(this, e);
        }

        public event EventHandler<LightTypeEventArgs> SliderControlSet;

        public class LightTypeEventArgs : EventArgs
        {
            public int ArrayIndex { get; set; }
            public Control Control { get; set; }
        }
    }
}
