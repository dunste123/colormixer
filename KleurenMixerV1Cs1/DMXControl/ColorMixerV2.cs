using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using Dmx512UsbRs485;
using DMXControl.Controls;
using DMXControl.Serializers;

namespace DMXControl
{
    public partial class ColorMixerV2 : Form
    {
        private readonly List<UcLightTypes> lightTypesArray = new List<UcLightTypes>();
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
            for (var i = 0; i < dmxDriver.NrOfPorts; i++)
            {
                CbPortDSte.Items.Add(dmxDriver.PortNameAt(i));
            }
        }

        #region button listeners
        private void BtnAddControl_Click(object sender, EventArgs e)
        {
            var lightTypes = new UcLightTypes();

            AddLightType(lightTypes);
        }
        
        private void BtnDupeStepDSte_Click(object sender, EventArgs e)
        {

            if (lightTypesArray.Count - 1 < 0)
            {
                MessageBox.Show(@"Please add at least one step", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            var type = lightTypesArray[lightTypesArray.Count - 1];

            if (type == null)
            {
                MessageBox.Show(@"No previous step to copy from", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            var lightTypes = new UcLightTypes();

            if (type.Par56SlidersDSte != null)
            {
                var newPar = new UcPar56Sliders
                {
                    Shown = false,
                    RedDMXValue = type.Par56SlidersDSte.RedDMXValue,
                    GreenDMXValue = type.Par56SlidersDSte.GreenDMXValue,
                    BlueDMXValue = type.Par56SlidersDSte.BlueDMXValue,
                    StrobeDMXValue = type.Par56SlidersDSte.StrobeDMXValue
                };


                lightTypes.Par56SlidersDSte = newPar;
            }

            lightTypes.Par56SlidersEnabledDSte = type.Par56SlidersEnabledDSte;

            if (type.MovingHeadSlidersDSte != null)
            {
                var newHead = new UcMovingHeadSliders
                {
                    Shown = false,
                    XAxisDMXValue = type.MovingHeadSlidersDSte.XAxisDMXValue,
                    YAxisDMXValue = type.MovingHeadSlidersDSte.YAxisDMXValue,
                    DimmerStrobeDMXValue = type.MovingHeadSlidersDSte.DimmerStrobeDMXValue,
                    ColorDMXValue = type.MovingHeadSlidersDSte.ColorDMXValue,
                    GoboDMXValue = type.MovingHeadSlidersDSte.GoboDMXValue
                };


                lightTypes.MovingHeadSlidersDSte = newHead;
            }

            lightTypes.MovingHeadSlidersEnabledDSte = type.MovingHeadSlidersEnabledDSte;

            AddLightType(lightTypes);
        }

        private void AddLightType(UcLightTypes lightTypes)
        {
            var panel = pnlStepsDste;
            var controls = panel.Controls;
            var count = controls.Count;

            lightTypes.BackColor = GetColorForStep(count);

            if (count > 0)
            {
                var prevType = lightTypesArray[count - 1];

                lightTypes.Top = prevType.Bottom + 5;
            }

            lightTypes.ArrayIndexDSte = count;
            lightTypes.SliderControlSet += OnLightTypeSliderControlChanged;

            lightTypesArray.Add(lightTypes);

            controls.Add(lightTypes);

            CheckStepsForAutoStep();
        }

        private void OnLightTypeSliderControlChanged(object sender, UcLightTypes.LightTypeEventArgs e)
        {
            if (prevItem > -1)
            {
                lightTypesArray[prevItem].HideAllControls();
            }

            prevItem = e.ArrayIndex;

            SetSliderControl(e.Control);
        }

        private void SetSliderControl(Control control)
        {
            var controls = pnlMixerDste.Controls;

            controls.Clear();

            if (control != null)
            {
                controls.Add(control);
            }
        }

        private void BtnNextStepDste_Click(object sender, EventArgs e)
        {
            NextStep();
        }

        private void BtnPrevStepDSte_Click(object sender, EventArgs e)
        {
            currentStep--;

            if (currentStep < 0)
            {
                currentStep = lightTypesArray.Count - 1;
            }

            var selected = GetSelectedLightTypeOrNull(true);

            if (selected == null && currentStep == 0)
            {
                return;
            }

            if (selected == null)
            {
                currentStep = -1;
                BtnPrevStepDSte_Click(sender, e);

                return;
            }

            if (prevStep > -1)
            {
                var prev = lightTypesArray[prevStep];

                prev.BackColor = GetColorForStep(prev.ArrayIndexDSte);
            }

            prevStep = selected.ArrayIndexDSte;

            selected.BackColor = Color.GreenYellow;

        }

        private void BtnClearStepDSte_Click(object sender, EventArgs e)
        {
            var selected = GetSelectedLightTypeOrNull();

            if (selected == null)
            {
                return;
            }

            selected.BackColor = GetColorForStep(selected.ArrayIndexDSte);
            currentStep = -1;
        }

        private void BtnSaveShowDSte_Click(object sender, EventArgs e)
        {
            var fld = new SaveFileDialog
            {
                Title = @"Save settings",
                FileName = "ColorMixer-" + DateTime.Now.ToString("MM-dd-yyyy_hh-mm-ss") + ".cm",
                Filter = @"Color Mixer Files|*.cm|All Files|*.*"
            };

            if (fld.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            
            var xs = new XmlSerializer(typeof(List<UcLightTypes>));

            using (TextWriter textWriter = new StreamWriter(fld.FileName))
            {
                xs.Serialize(textWriter, lightTypesArray);
            }
        }

        private void BtnLoadShowDSte_Click(object sender, EventArgs e)
        {
            var fld = new OpenFileDialog
            {
                Title = @"Select file to load",
                Filter = @"Color Mixer Files|*.cm|All Files|*.*"
            };

            if (fld.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            
            pnlStepsDste.Controls.Clear();

            var xs = new XmlSerializer(typeof(List<UcLightTypes>));
            using (Stream fileStream = File.OpenRead(fld.FileName))
            {
                var test = (List<UcLightTypes>)xs.Deserialize(fileStream);

                foreach (var lightTypes in test)
                {
                    AddLightType(lightTypes);

                    Console.WriteLine(lightTypes.ArrayIndexDSte);
                }
            }

            CheckStepsForAutoStep();
        }

        private void BtnStartAutoDSte_Click(object sender, EventArgs e)
        {
            tmrShowStepperDSte.Start();
        }

        private void BtnStopAutoDSte_Click(object sender, EventArgs e)
        {
            tmrShowStepperDSte.Stop();
        }
        #endregion

        #region drop down handlers
        private void CbTimingDSte_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBoxTimerDSte.Interval = Convert.ToInt32(CbTimingDSte.Text);
        }

        private void CbPortDSte_SelectedIndexChanged(object sender, EventArgs e)
        {
            dmxDriver.DmxToDefault(CbPortDSte.Text);
            CBoxTimerDSte.Start();
            CbTimingDSte.Text = CBoxTimerDSte.Interval + "";
        }

        private void CbAutoStepCounter_SelectedIndexChanged(object sender, EventArgs e)
        {
            var text = CbAutoStepCounter.Text.ToLower();

            if (text == "off")
            {
                tmrShowStepperDSte.Stop();
                pnlShowStepper.BackColor = Color.White;
            }
            else
            {
                var interval = double.Parse(text) * 1000;
                tmrShowStepperDSte.Interval = (int) interval;
                tmrShowStepperDSte.Start();
            }
        }
        #endregion

        #region dmx handler
        private void CBoxTimerDSte_Tick(object sender, EventArgs e)
        {
            PnlTimerDSte.BackColor = PnlTimerDSte.BackColor == Color.White ? Color.Lime : Color.White;

            SendData();
            dmxDriver.DmxSendCommand(buffSize);
        }

        private void SendData()
        {
            var step = GetSelectedLightTypeOrNull();

            if (step == null)
            {
                for (var i = 1; i < buffSize; i++)
                {
                    dmxDriver.DmxLoadBuffer(i, 0, buffSize);
                }

                return;
            }

            if (step.Par56SlidersEnabledDSte)
            {
                SendDmxCommands(step.Par56SlidersDSte);
            }

            if (step.MovingHeadSlidersEnabledDSte)
            {
                SendDmxCommands(step.MovingHeadSlidersDSte);
            }
        }

        private void SendDmxCommands(ILightSerializer light)
        {
            var range = light.GetDmxRange();
            var values = light.GetDmxValues();

            for (var dmxAddress = range[0]; dmxAddress <= range[1]; dmxAddress++)
            {
                var data = values[dmxAddress - range[0]];

                dmxDriver.DmxLoadBuffer(dmxAddress, (byte)data, buffSize);
            }
        }

        // Auto stepper

        private void TmrShowStepperDSte_Tick(object sender, EventArgs e)
        {
            pnlShowStepper.BackColor = pnlShowStepper.BackColor == Color.White ? Color.Lime : Color.White;

            NextStep();
        }
        #endregion

        #region utils
        private static Color GetColorForStep(int index)
        {
            return index % 2 == 0 ? Color.DarkOrange : Color.CornflowerBlue;
        }

        private UcLightTypes GetSelectedLightTypeOrNull(bool withCountCheck = false)
        {
            if (lightTypesArray.Count == 0 || currentStep < 0)
            {
                return null;
            }

            if (withCountCheck && currentStep >= lightTypesArray.Count)
            {
                return null;
            }

            return lightTypesArray[currentStep];
        }

        private void CheckStepsForAutoStep()
        {
            var count = lightTypesArray.Count;
            var box = CbAutoStepCounter;

            box.Items.Clear();
            box.Items.Add("Off");

            if (count <= 1)
            {
                return;
            }
            
            for (var i = 0.1D; i <= 4D; i = Math.Round(i + 0.1, 1, MidpointRounding.AwayFromZero))
            {
                box.Items.Add(i);
            }
        }

        private void NextStep() {
            currentStep++;

            if (currentStep >= lightTypesArray.Count)
            {
                currentStep = 0;
            }

            var selected = GetSelectedLightTypeOrNull(true);

            if (selected == null && currentStep == 0)
            {
                return;
            }

            if (selected == null)
            {
                currentStep = -1;
                NextStep();

                return;
            }

            if (prevStep > -1)
            {
                var prev = lightTypesArray[prevStep];

                prev.BackColor = GetColorForStep(prev.ArrayIndexDSte);
            }

            prevStep = selected.ArrayIndexDSte;

            selected.BackColor = Color.GreenYellow;
        }
        #endregion
    }
}
