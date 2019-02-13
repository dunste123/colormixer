using KleurenMixerV1Cs1.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KleurenMixerV1Cs1
{
    public partial class ColorMixerV2 : Form
    {
        private UcLightTypes[] lightTypesArray = new UcLightTypes[100];

        public ColorMixerV2()
        {
            InitializeComponent();

            this.tcMainDste.SelectedTab = this.tbLightControlDste;
        }

        private void BtnAddControl_Click(object sender, EventArgs e)
        {
            var panel = this.pnlStepsDste;
            var lightTypes = new UcLightTypes();
            var controls = panel.Controls;
            var count = controls.Count;

            if (count % 2 == 0)
            {
                lightTypes.BackColor = Color.DarkOrange;
            }
            else
            {
                lightTypes.BackColor = Color.DarkBlue;
            }

            lightTypes.Top = lightTypes.Height * count;

            lightTypesArray[count] = lightTypes;

            controls.Add(lightTypes);
        }
    }
}
