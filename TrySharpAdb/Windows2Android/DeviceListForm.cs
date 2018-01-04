using SharpAdbClient;
using System;
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
                deviceListBox.DataSource = AdbClient.Instance.GetDevices();
                deviceListBox.DisplayMember = "Model";
                deviceListBox.Invalidate();
            };
            if (deviceListBox.InvokeRequired)
                deviceListBox.Invoke(callback);
            else
                callback();
        }
        
        private void deviceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var device = deviceListBox.SelectedItem as DeviceData;
            modelTextBox.Text = device.Model;
            serialTextBox.Text = device.Serial;
            productTextBox.Text = device.Product;
            statusTextBox.Text = device.State.ToString();
        }

        private async  void connectButton_Click(object sender, EventArgs e)
        {
            var device = deviceListBox.SelectedItem as DeviceData;
            screenForm = new ScreenForm();
            await screenForm.SetDevice(device);
        }
    }
}
