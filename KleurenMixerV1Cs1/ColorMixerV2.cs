using Dmx512UsbRs485;
using KleurenMixerV1Cs1.Controls;
using KleurenMixerV1Cs1.Serializers;
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

            this.tcMainDste.SelectedTab = this.tbLightControlDste;
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
        
        private void BtnDupeStepDSte_Click(object sender, EventArgs e)
        {

            if ((this.lightTypesArray.Count - 1) < 0)
            {
                MessageBox.Show("Please add at least one step", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            var type = this.lightTypesArray[this.lightTypesArray.Count - 1];

            if (type == null)
            {
                MessageBox.Show("No previous step to copy from", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            var lightTypes = new UcLightTypes();

            if (type.Par56SlidersDSte != null)
            {
                var newPar = new UcPar56Sliders();

                newPar.Shown = false;
                newPar.RedDMXValue = type.Par56SlidersDSte.RedDMXValue;
                newPar.GreenDMXValue = type.Par56SlidersDSte.GreenDMXValue;
                newPar.BlueDMXValue = type.Par56SlidersDSte.BlueDMXValue;
                newPar.StrobeDMXValue = type.Par56SlidersDSte.StrobeDMXValue;

                lightTypes.Par56SlidersDSte = newPar;
            }

            lightTypes.Par56SlidersEnabledDSte = type.Par56SlidersEnabledDSte;

            if (type.MovingHeadSlidersDSte != null)
            {
                var newHead = new UcMovingHeadSliders();

                newHead.Shown = false;
                newHead.XAxisDMXValue = type.MovingHeadSlidersDSte.XAxisDMXValue;
                newHead.YAxisDMXValue = type.MovingHeadSlidersDSte.YAxisDMXValue;
                newHead.DimmerStrobeDMXValue = type.MovingHeadSlidersDSte.DimmerStrobeDMXValue;
                newHead.ColorDMXValue = type.MovingHeadSlidersDSte.ColorDMXValue;
                newHead.GoboDMXValue = type.MovingHeadSlidersDSte.GoboDMXValue;

                lightTypes.MovingHeadSlidersDSte = newHead;
            }

            lightTypes.MovingHeadSlidersEnabledDSte = type.MovingHeadSlidersEnabledDSte;

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

            lightTypes.ArrayIndexDSte = count;
            lightTypes.SliderControlSet += OnLightTypeSliderControlChanged;

            lightTypesArray.Add(lightTypes);

            controls.Add(lightTypes);

            this.CheckStepsForAutoStep();
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
            this.NextStep();
        }

        private void BtnPrevStepDSte_Click(object sender, EventArgs e)
        {
            this.currentStep--;

            if (this.currentStep < 0)
            {
                this.currentStep = this.lightTypesArray.Count - 1;
            }

            var selected = this.GetSelectedLightTypeOrNull(true);

            if (selected == null && this.currentStep == 0)
            {
                return;
            }

            if (selected == null)
            {
                this.currentStep = -1;
                this.BtnPrevStepDSte_Click(sender, e);

                return;
            }

            if (this.prevStep > -1)
            {
                var prev = this.lightTypesArray[this.prevStep];

                prev.BackColor = this.GetColorForStep(prev.ArrayIndexDSte);
            }

            this.prevStep = selected.ArrayIndexDSte;

            selected.BackColor = Color.GreenYellow;

        }

        private void BtnClearStepDSte_Click(object sender, EventArgs e)
        {
            var selected = this.GetSelectedLightTypeOrNull();

            if (selected == null)
            {
                return;
            }

            selected.BackColor = this.GetColorForStep(selected.ArrayIndexDSte);
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
                this.pnlStepsDste.Controls.Clear();

                XmlSerializer xs = new XmlSerializer(typeof(List<UcLightTypes>));
                using (Stream fileStream = File.OpenRead(fld.FileName))
                {
                    List<UcLightTypes> test = (List<UcLightTypes>)xs.Deserialize(fileStream);

                    foreach (UcLightTypes lightTypes in test)
                    {
                        this.AddLightType(lightTypes);

                        Console.WriteLine(lightTypes.ArrayIndexDSte);
                    }
                }

                this.CheckStepsForAutoStep();
            }
        }

        private void BtnStartAutoDSte_Click(object sender, EventArgs e)
        {
            this.tmrShowStepperDSte.Start();
        }

        private void BtnStopAutoDSte_Click(object sender, EventArgs e)
        {
            this.tmrShowStepperDSte.Stop();
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

        private void CbAutoStepCounter_SelectedIndexChanged(object sender, EventArgs e)
        {
            var text = this.CbAutoStepCounter.Text.ToLower();

            if (text == "off")
            {
                this.tmrShowStepperDSte.Stop();
                this.pnlShowStepper.BackColor = Color.White;
            }
            else
            {
                var interval = Double.Parse(text) * 1000;
                this.tmrShowStepperDSte.Interval = (int) interval;
                this.tmrShowStepperDSte.Start();
            }
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
                for (int i = 1; i < this.buffSize; i++)
                {
                    this.dmxDriver.DmxLoadBuffer(i, 0, this.buffSize);
                }

                return;
            }

            if (item.Par56SlidersEnabledDSte)
            {
                this.SendDMXCommands(item.Par56SlidersDSte);
            }

            if (item.MovingHeadSlidersEnabledDSte)
            {
                this.SendDMXCommands(item.MovingHeadSlidersDSte);
            }
        }

        private void SendDMXCommands(ILightSerializer light)
        {
            var range = light.GetDMXRange();
            var values = light.GetDMXValues();

            for (int i = range[0]; i <= range[1]; i++)
            {
                var data = values[i];

                this.dmxDriver.DmxLoadBuffer((int)data[0], (byte)data[1], this.buffSize);
            }
        }

        // Auto stepper

        private void TmrShowStepperDSte_Tick(object sender, EventArgs e)
        {
            if (this.pnlShowStepper.BackColor == Color.White)
            {
                this.pnlShowStepper.BackColor = Color.Lime;
            }
            else
            {
                this.pnlShowStepper.BackColor = Color.White;
            }

            this.NextStep();
        }
        #endregion

        #region utils
        private Color GetColorForStep(int index)
        {
            return index % 2 == 0 ? Color.DarkOrange : Color.CornflowerBlue;
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

        private void CheckStepsForAutoStep()
        {
            var count = this.lightTypesArray.Count;
            var box = this.CbAutoStepCounter;

            box.Items.Clear();
            box.Items.Add("Off");

            if (count > 1)
            {

                for (double i = 0.1D; i <= 4D; i = Math.Round(i + 0.1, 1, MidpointRounding.AwayFromZero))
                {
                    box.Items.Add(i);
                }
            }
        }

        private void NextStep() {
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
                this.NextStep();

                return;
            }

            if (this.prevStep > -1)
            {
                var prev = this.lightTypesArray[this.prevStep];

                prev.BackColor = this.GetColorForStep(prev.ArrayIndexDSte);
            }

            this.prevStep = selected.ArrayIndexDSte;

            selected.BackColor = Color.GreenYellow;
        }
        #endregion
    }
}
