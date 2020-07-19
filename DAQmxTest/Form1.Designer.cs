namespace DAQmxTest
{
    partial class frmDAQmxTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxDevices = new System.Windows.Forms.ComboBox();
            this.llblDevices = new System.Windows.Forms.Label();
            this.cbxChannels = new System.Windows.Forms.ComboBox();
            this.lblChannels = new System.Windows.Forms.Label();
            this.waveformGraphTemp = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot1 = new NationalInstruments.UI.WaveformPlot();
            this.xAxis1 = new NationalInstruments.UI.XAxis();
            this.yAxis1 = new NationalInstruments.UI.YAxis();
            this.legend1 = new NationalInstruments.UI.WindowsForms.Legend();
            this.legendItem1 = new NationalInstruments.UI.LegendItem();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraphTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.legend1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxDevices
            // 
            this.cbxDevices.FormattingEnabled = true;
            this.cbxDevices.Location = new System.Drawing.Point(51, 83);
            this.cbxDevices.Name = "cbxDevices";
            this.cbxDevices.Size = new System.Drawing.Size(121, 21);
            this.cbxDevices.TabIndex = 0;
            // 
            // llblDevices
            // 
            this.llblDevices.AutoSize = true;
            this.llblDevices.Location = new System.Drawing.Point(48, 67);
            this.llblDevices.Name = "llblDevices";
            this.llblDevices.Size = new System.Drawing.Size(46, 13);
            this.llblDevices.TabIndex = 1;
            this.llblDevices.Text = "Devices";
            // 
            // cbxChannels
            // 
            this.cbxChannels.FormattingEnabled = true;
            this.cbxChannels.Location = new System.Drawing.Point(190, 83);
            this.cbxChannels.Name = "cbxChannels";
            this.cbxChannels.Size = new System.Drawing.Size(121, 21);
            this.cbxChannels.TabIndex = 2;
            // 
            // lblChannels
            // 
            this.lblChannels.AutoSize = true;
            this.lblChannels.Location = new System.Drawing.Point(190, 64);
            this.lblChannels.Name = "lblChannels";
            this.lblChannels.Size = new System.Drawing.Size(51, 13);
            this.lblChannels.TabIndex = 3;
            this.lblChannels.Text = "Channels";
            // 
            // waveformGraphTemp
            // 
            this.waveformGraphTemp.Caption = "Temperature";
            this.waveformGraphTemp.Location = new System.Drawing.Point(352, 39);
            this.waveformGraphTemp.Name = "waveformGraphTemp";
            this.waveformGraphTemp.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot1});
            this.waveformGraphTemp.Size = new System.Drawing.Size(638, 370);
            this.waveformGraphTemp.TabIndex = 4;
            this.waveformGraphTemp.UseColorGenerator = true;
            this.waveformGraphTemp.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis1});
            this.waveformGraphTemp.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis1});
            // 
            // waveformPlot1
            // 
            this.waveformPlot1.XAxis = this.xAxis1;
            this.waveformPlot1.YAxis = this.yAxis1;
            // 
            // xAxis1
            // 
            this.xAxis1.Caption = "Time";
            this.xAxis1.Range = new NationalInstruments.UI.Range(0D, 4D);
            // 
            // yAxis1
            // 
            this.yAxis1.Caption = "Temperature(°C)";
            this.yAxis1.Range = new NationalInstruments.UI.Range(0D, 100D);
            // 
            // legend1
            // 
            this.legend1.Items.AddRange(new NationalInstruments.UI.LegendItem[] {
            this.legendItem1});
            this.legend1.Location = new System.Drawing.Point(996, 39);
            this.legend1.Name = "legend1";
            this.legend1.Size = new System.Drawing.Size(138, 108);
            this.legend1.TabIndex = 5;
            // 
            // legendItem1
            // 
            this.legendItem1.Source = this.waveformPlot1;
            this.legendItem1.Text = "Temperature Ch0";
            // 
            // frmDAQmxTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 551);
            this.Controls.Add(this.legend1);
            this.Controls.Add(this.waveformGraphTemp);
            this.Controls.Add(this.lblChannels);
            this.Controls.Add(this.cbxChannels);
            this.Controls.Add(this.llblDevices);
            this.Controls.Add(this.cbxDevices);
            this.Name = "frmDAQmxTest";
            this.Text = "DAQmx Test";
            this.Load += new System.EventHandler(this.frmDAQmxTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraphTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.legend1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxDevices;
        private System.Windows.Forms.Label llblDevices;
        private System.Windows.Forms.ComboBox cbxChannels;
        private System.Windows.Forms.Label lblChannels;
        private NationalInstruments.UI.WindowsForms.WaveformGraph waveformGraphTemp;
        private NationalInstruments.UI.WaveformPlot waveformPlot1;
        private NationalInstruments.UI.XAxis xAxis1;
        private NationalInstruments.UI.YAxis yAxis1;
        private NationalInstruments.UI.WindowsForms.Legend legend1;
        private NationalInstruments.UI.LegendItem legendItem1;
    }
}

