using SharpAdbClient;
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
            screenForm = new ScreenForm();

            Log.LogOutput = new DebugLogOutput();
            Log.Level = LogLevel.Verbose;

            monitor = new DeviceMonitor(new AdbSocket(new IPEndPoint(IPAddress.Loopback, AdbClient.AdbServerPort)));
            monitor.DeviceConnected += this.OnDeviceConnected;
            monitor.DeviceDisconnected += this.OnDeviceDisconnected;
            monitor.Start();
        }

        void OnDeviceConnected(object sender, DeviceDataEventArgs e)
        {
            deviceGridView.DataSource = AdbClient.Instance.GetDevices();
            deviceGridView.Invalidate();
        }

        void OnDeviceDisconnected(object sender, DeviceDataEventArgs e)
        {
            deviceGridView.DataSource = AdbClient.Instance.GetDevices();
            deviceGridView.Invalidate();
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

        private void deviceGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= deviceGridView.RowCount)
                return;
            screenForm.SetDevice(deviceGridView.Rows[e.RowIndex].DataBoundItem as DeviceData);
            screenForm.Show();
        }
    }
}
