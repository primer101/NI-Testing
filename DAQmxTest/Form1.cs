using NationalInstruments;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;
using NationalInstruments.DAQmx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAQmxTest
{
    public partial class frmDAQmxTest : Form
    {
        public frmDAQmxTest()
        {
            InitializeComponent();
        }

        private void frmDAQmxTest_Load(object sender, EventArgs e)
        {
            cbxDevices.Items.AddRange(DaqSystem.Local.Devices);
            cbxChannels.Items.AddRange(DaqSystem.Local.GetPhysicalChannels(PhysicalChannelTypes.AI, PhysicalChannelAccess.External));
           
            using (var tempTask = DaqSystem.Local.LoadTask("MyTemperatureTask"))
            {
                AnalogSingleChannelReader reader = new AnalogSingleChannelReader(tempTask.Stream);
                tempTask.Start();
                IAsyncResult async = reader.BeginReadWaveform(-1, null, null);
                AnalogWaveform<double> waveform = reader.EndReadWaveform(async);
                waveform.Timing = WaveformTiming.CreateWithRegularInterval(TimeSpan.FromSeconds(3), DateTime.Now);
                xAxis1.MajorDivisions.LabelFormat = new FormatString(FormatStringMode.DateTime, "h:mm:ss tt");
                waveformGraphTemp.PlotWaveform(waveform, 
                    new AnalogWaveformPlotOptions(AnalogWaveformPlotDisplayMode.Time, 
                    AnalogWaveformPlotScaleMode.Raw));
                tempTask.Stop();
            }
            
        }
    }
}
