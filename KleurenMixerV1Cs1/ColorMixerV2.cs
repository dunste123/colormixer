﻿using KleurenMixerV1Cs1.Controls;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using static KleurenMixerV1Cs1.Controls.UcLightTypes;

namespace KleurenMixerV1Cs1
{
    public partial class ColorMixerV2 : Form
    {
        private UcLightTypes[] lightTypesArray = new UcLightTypes[100];
        private int prevItem = -1;
        private int currentStep = -1;
        private int prevStep = -1;

        public ColorMixerV2()
        {
            InitializeComponent();

            this.tcMainDste.SelectedTab = this.tbLightControlDste;
        }

        private void BtnAddControl_Click(object sender, EventArgs e)
        {
            var lightTypes = new UcLightTypes();

            this.AddLightType(lightTypes);
        }

        private void AddLightType(UcLightTypes lightTypes)
        {
            var panel = this.pnlStepsDste;
            var controls = panel.Controls;
            var count = controls.Count;

            if (count % 2 == 0)
            {
                lightTypes.BackColor = Color.DarkOrange;
            }
            else
            {
                lightTypes.BackColor = Color.CornflowerBlue;
            }

            if (count > 0)
            {
                var prevType = lightTypesArray[count - 1];

                lightTypes.Top = prevType.Bottom + 5;
            }

            lightTypes.ArrayIndex = count;
            lightTypes.SliderControlSet += OnLightTypeSliderControlChanged;

            lightTypesArray[count] = lightTypes;

            controls.Add(lightTypes);
        }

        public void OnLightTypeSliderControlChanged(object sender, LightTypeEventArgs e)
        {
            if (this.prevItem > -1)
            {
                this.lightTypesArray[this.prevItem].HideAllControls();
            }

            this.prevItem = e.ArrayIndex;

            SetSliderControl(e.Control);
        }

        private void SetSliderControl(Control control)
        {
            var controls = this.pnlMixerDste.Controls;

            controls.Clear();

            if (control != null)
            {
                controls.Add(control);
            }
        }

        private void BtnNextStepDste_Click(object sender, EventArgs e)
        {
            this.currentStep++;

            var selected = this.lightTypesArray[currentStep];

            if (selected == null && this.currentStep == 0)
            {
                return;
            }

            if (selected == null)
            {
                this.currentStep = -1;
                this.BtnNextStepDste_Click(sender, e);

                return;
            }

            if (this.prevStep > -1)
            {
                var prev = this.lightTypesArray[this.prevStep];

                if (prev.ArrayIndex % 2 == 0)
                {
                    prev.BackColor = Color.DarkOrange;
                }
                else
                {
                    prev.BackColor = Color.CornflowerBlue;
                }
            }

            this.prevStep = selected.ArrayIndex;

            selected.BackColor = Color.GreenYellow;
        }

        private void BtnSaveShowDSte_Click(object sender, EventArgs e)
        {
            XmlSerializer xs = new XmlSerializer(typeof(UcLightTypes[]));

            using (TextWriter textWriter = new StreamWriter(@"D:\Serialization.xml"))
            {
                xs.Serialize(textWriter, lightTypesArray);
            }
        }

        private void BtnLoadShowDSte_Click(object sender, EventArgs e)
        {
            XmlSerializer xs = new XmlSerializer(typeof(UcLightTypes[]));
            using (Stream fileStream = File.OpenRead(@"D:\Serialization.xml"))
            {
                UcLightTypes[] test = (UcLightTypes[]) xs.Deserialize(new MemoryStream(System.Text.Encoding.UTF8.GetBytes(File.ReadAllText(@"D:\Serialization.xml"))));

                foreach(UcLightTypes lightTypes in test)
                {
                    this.AddLightType(lightTypes);

                    Console.WriteLine(lightTypes.ArrayIndex);
                }
            }
        }
    }
}
