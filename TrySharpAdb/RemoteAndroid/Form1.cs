using SharpAdbClient;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace Windows2Android
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            AdbServer server = new AdbServer();
            var result = server.StartServer(@"C:\Users\dibap\AppData\Local\Android\Sdk\platform-tools\adb.exe", restartServerIfNewer: false);

            var devices = AdbClient.Instance.GetDevices();

            foreach (var device in devices)
            {
                Console.WriteLine(device.Name);
            }
            var monitor = new DeviceMonitor(new AdbSocket(new IPEndPoint(IPAddress.Loopback, AdbClient.AdbServerPort)));
            monitor.DeviceConnected += this.OnDeviceConnected;
            monitor.Start();
        }

        void OnDeviceConnected(object sender, DeviceDataEventArgs e)
        {
            Console.WriteLine($"The device {e.Device.Name} has connected to this PC");
        }

        void UploadFile()
        {
            var device = AdbClient.Instance.GetDevices().First();

            using (SyncService service = new SyncService(new AdbSocket(new IPEndPoint(IPAddress.Loopback, AdbClient.AdbServerPort)), device))
            using (Stream stream = File.OpenRead(@"C:\MyFile.txt"))
            {
                service.Push(stream, "/data/local/tmp/MyFile.txt", 444, DateTime.Now, null, CancellationToken.None);
            }
        }

        void EchoTest()
        {
            var device = AdbClient.Instance.GetDevices().First();
            var receiver = new ConsoleOutputReceiver();

            AdbClient.Instance.ExecuteRemoteCommand("echo Hello, World", device, receiver);

            Console.WriteLine("The device responded:");
            Console.WriteLine(receiver.ToString());
        }
    }
}
