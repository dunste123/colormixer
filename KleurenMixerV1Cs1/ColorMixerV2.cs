using Dmx512UsbRs485;
using KleurenMixerV1Cs1.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using static KleurenMixerV1Cs1.Controls.UcLightTypes;

namespace KleurenMixerV1Cs1
{
    public partial class ColorMixerV2 : Form
    {
        private List<UcLightTypes> lightTypesArray = new List<UcLightTypes>();
        private int prevItem = -1;
        private int currentStep = -1;
        private int prevStep = -1;

        private readonly int buffSize = 512;
        private readonly Dmx512UsbRs485Driver dmxDriver = new Dmx512UsbRs485Driver();

        public ColorMixerV2()
        {
            InitializeComponent();

            //this.tcMainDste.SelectedTab = this.tbLightControlDste;
        }

        private void ColorMixerV2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dmxDriver.NrOfPorts; i++)
            {
                this.CbPortDSte.Items.Add(this.dmxDriver.PortNameAt(i));
            }
        }

        #region button listeners
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

            lightTypes.BackColor = this.GetColorForStep(count);

            if (count > 0)
            {
                var prevType = lightTypesArray[count - 1];

                lightTypes.Top = prevType.Bottom + 5;
            }

            lightTypes.ArrayIndex = count;
            lightTypes.SliderControlSet += OnLightTypeSliderControlChanged;

            lightTypesArray.Add(lightTypes);

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

            if (this.currentStep >= this.lightTypesArray.Count)
            {
                this.currentStep = 0;
            }

            var selected = this.GetSelectedLightTypeOrNull(true);

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

                prev.BackColor = this.GetColorForStep(prev.ArrayIndex);
            }

            this.prevStep = selected.ArrayIndex;

            selected.BackColor = Color.GreenYellow;
        }

        private void BtnClearStepDSte_Click(object sender, EventArgs e)
        {
            var selected = this.GetSelectedLightTypeOrNull();

            if (selected == null)
            {
                return;
            }

            selected.BackColor = this.GetColorForStep(selected.ArrayIndex);
            this.currentStep = -1;
        }

        private void BtnSaveShowDSte_Click(object sender, EventArgs e)
        {
            var fld = new SaveFileDialog()
            {
                Title = "Save settings",
                FileName = "ColorMixer-" + DateTime.Now.ToString("MM-dd-yyyy_hh-mm-ss") + ".cm",
                Filter = "Color Mixer Files|*.cm|All Files|*.*"
            };

            if (fld.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<UcLightTypes>));

                using (TextWriter textWriter = new StreamWriter(fld.FileName))
                {
                    xs.Serialize(textWriter, lightTypesArray);
                }
            }
        }

        private void BtnLoadShowDSte_Click(object sender, EventArgs e)
        {
            var fld = new OpenFileDialog()
            {
                Title = "Select file to load",
                Filter = "Color Mixer Files|*.cm|All Files|*.*"
            };

            if (fld.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<UcLightTypes>));
                using (Stream fileStream = File.OpenRead(fld.FileName))
                {
                    List<UcLightTypes> test = (List<UcLightTypes>)xs.Deserialize(fileStream);

                    foreach (UcLightTypes lightTypes in test)
                    {
                        this.AddLightType(lightTypes);

                        Console.WriteLine(lightTypes.ArrayIndex);
                    }
                }
            }
        }
        #endregion

        #region drop down handlers
        private void CbTimingDSte_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CBoxTimerDSte.Interval = Convert.ToInt32(this.CbTimingDSte.Text);
        }

        private void CbPortDSte_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dmxDriver.DmxToDefault(this.CbPortDSte.Text);
            this.CBoxTimerDSte.Start();
            this.CbTimingDSte.Text = this.CBoxTimerDSte.Interval + "";
        }
        #endregion

        #region dmx handler
        private void CBoxTimerDSte_Tick(object sender, EventArgs e)
        {
            if (this.PnlTimerDSte.BackColor == Color.White)
            {
                this.PnlTimerDSte.BackColor = Color.Lime;
            }
            else
            {
                this.PnlTimerDSte.BackColor = Color.White;
            }

            this.SendData();
            this.dmxDriver.DmxSendCommand(this.buffSize);
        }

        private void SendData()
        {
            var item = this.GetSelectedLightTypeOrNull();

            if (item == null)
            {
                this.dmxDriver.DmxLoadBuffer(1, 0, this.buffSize);
                this.dmxDriver.DmxLoadBuffer(2, 0, this.buffSize);
                this.dmxDriver.DmxLoadBuffer(3, 0, this.buffSize);

                // color stepper val = color
                this.dmxDriver.DmxLoadBuffer(4, 0, this.buffSize);

                // shutter = 0 - 255
                this.dmxDriver.DmxLoadBuffer(5, 0, this.buffSize);

                // fader val = fade speed
                this.dmxDriver.DmxLoadBuffer(6, 0, this.buffSize);

                return;
            }

            if (item.Par56SlidersEnabled)
            {
                var selectedPar56Sliders = item.Par56Sliders;

                this.dmxDriver.DmxLoadBuffer(1, (byte)selectedPar56Sliders.RedValue, this.buffSize);
                this.dmxDriver.DmxLoadBuffer(2, (byte)selectedPar56Sliders.GreenValue, this.buffSize);
                this.dmxDriver.DmxLoadBuffer(3, (byte)selectedPar56Sliders.BlueValue, this.buffSize);

                // color stepper val = color
                this.dmxDriver.DmxLoadBuffer(4, 0, this.buffSize);

                // shutter = 0 - 255
                this.dmxDriver.DmxLoadBuffer(5, (byte)selectedPar56Sliders.StrobeValue, this.buffSize);

                // fader val = fade speed
                this.dmxDriver.DmxLoadBuffer(6, 0, this.buffSize);

                //if (this.cbStartFade.Checked)
                //{
                //    this.dmxDriver.DmxLoadBuffer(6, (byte)this.trbFadeSpeedDSte.Value, this.buffSize);
                //}
            }
        }
        #endregion

        #region utils
        private Color GetColorForStep(int index)
        {
            if (index % 2 == 0)
            {
                return Color.DarkOrange;
            }
            else
            {
                return Color.CornflowerBlue;
            }
        }

        private UcLightTypes GetSelectedLightTypeOrNull()
        {
            return this.GetSelectedLightTypeOrNull(false);
        }

        private UcLightTypes GetSelectedLightTypeOrNull(bool withCountCheck)
        {
            if (this.lightTypesArray.Count == 0 || this.currentStep < 0)
            {
                return null;
            }

            if (withCountCheck && this.currentStep >= this.lightTypesArray.Count)
            {
                return null;
            }

            return this.lightTypesArray[this.currentStep];
        }
        #endregion
    }
}
