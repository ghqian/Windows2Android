using SharpAdbClient;
using System;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;

namespace Windows2Android
{
    public partial class DeviceListForm : Form
    {
        private DeviceMonitor monitor;
        private ScreenForm screenForm;

        public DeviceListForm()
        {
            InitializeComponent();

            Log.LogOutput = new DebugLogOutput();
            Log.Level = LogLevel.Verbose;

            monitor = new DeviceMonitor(new AdbSocket(new IPEndPoint(IPAddress.Loopback, AdbClient.AdbServerPort)));
            monitor.DeviceChanged += this.OnDeviceChanged;
            monitor.DeviceConnected += this.OnDeviceChanged;
            monitor.DeviceDisconnected += this.OnDeviceChanged;
            monitor.Start();
        }

        private void OnDeviceChanged(object sender, DeviceDataEventArgs e)
        {
            MethodInvoker callback = () =>
            {
                deviceGridView.DataSource = AdbClient.Instance.GetDevices();
                deviceGridView.Invalidate();
            };
            if (deviceGridView.InvokeRequired)
                deviceGridView.Invoke(callback);
            else
                callback();
        }

        private async void deviceGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= deviceGridView.RowCount)
                return;
            screenForm = new ScreenForm();
            await screenForm.SetDevice(deviceGridView.Rows[e.RowIndex].DataBoundItem as DeviceData);
        }

        class DebugLogOutput : ILogOutput
        {
            public void Write(LogLevel.LogLevelInfo logLevel, string tag, string message)
            {
                Debug.WriteLine(message, tag);
            }

            public void WriteAndPromptLog(LogLevel.LogLevelInfo logLevel, string tag, string message)
            {
                Debug.WriteLine(message, tag);
            }
        }
    }
}
