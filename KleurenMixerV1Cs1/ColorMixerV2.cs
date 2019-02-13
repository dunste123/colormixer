using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KleurenMixerV1Cs1.Controls;

namespace KleurenMixerV1Cs1
{
    public partial class ColorMixerV2 : Form
    {
        public ColorMixerV2()
        {
            InitializeComponent();
        }

        private void BtnAddControl_Click(object sender, EventArgs e)
        {
            var panel = this.pnlControlsDste;
            var lightTypes = new UcLightTypes();
            var controls = panel.Controls;

            if (controls.Count == 0)
            {
                controls.Add(lightTypes);
            } else
            {
                lightTypes.Top = lightTypes.Height * controls.Count;
                controls.Add(lightTypes);
            }
        }
    }
}
