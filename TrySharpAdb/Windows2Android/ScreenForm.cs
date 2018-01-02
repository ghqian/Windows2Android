using SharpAdbClient;
using SharpAdbClient.DeviceCommands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows2Android
{
    public partial class ScreenForm : Form
    {
        private DeviceData device;
        private Dictionary<string, string> props;
        private int touchHeight;
        private int touchWidth;
        private int minicapPort = 3131;
        private int minitouchPort = 1111;
        private TcpSocket minicapSocket;
        private TcpSocket minitouchSocket;

        private float ratioWidth = 1.0f;
        private float ratioHeight = 1.0f;

        public void SetDevice(DeviceData device)
        {
            this.device = device;
            props = DeviceExtensions.GetProperties(device);

            string sdk = props["ro.build.version.sdk"];
            string abi = props["ro.product.cpu.abi"];

            UploadFile($".\\resource\\minitouch\\{abi}\\bin\\minitouch", "/data/local/tmp/minitouch");
            UploadFile($".\\resource\\minicap\\{abi}\\bin\\minicap", "/data/local/tmp/minicap");
            UploadFile($".\\resource\\minicap\\{abi}\\lib\\android-{sdk}\\minicap.so", "/data/local/tmp/minicap.so");
            UploadFile($".\\resource\\minirev\\{abi}\\minirev", "/data/local/tmp/minirev");
        }

        private void UploadFile(string source, string target)
        {
            using (SyncService service = new SyncService(new AdbSocket(new IPEndPoint(IPAddress.Loopback, AdbClient.AdbServerPort)), device))
            using (Stream stream = File.OpenRead(source))
            {
                service.Push(stream, target, 0xFFFF, DateTime.Now, null, CancellationToken.None);
            }
        }

        public ScreenForm()
        {
            InitializeComponent();
        }

        public class StartMinicapReceiver : IShellOutputReceiver
        {
            public bool ParsesErrors => false;

            public void AddOutput(string line)
            {
                Debug.WriteLine(line);
                if (line.Contains("bytes for JPG encoder"))
                {
                }
            }

            public void Flush()
            {
                throw new NotImplementedException();
            }
        }

        public class StartMinitouchReceiver : IShellOutputReceiver
        {
            public ScreenForm screenFrom;
            public bool ParsesErrors => false;

            public void AddOutput(string line)
            {
                Debug.WriteLine(line);
                if (line.Contains("touch device"))
                {
                    string pattern = "([0-9]+)x([0-9]+)";
                    Match match = Regex.Match(line, pattern);
                    if (match.Success)
                    {
                        Debug.WriteLine(match.Groups[1] + " " + match.Groups[2]);
                        screenFrom.touchWidth = int.Parse(match.Groups[1].Value);
                        screenFrom.touchHeight = int.Parse(match.Groups[2].Value);
                    }
                }
            }

            public void Flush()
            {
            }
        }

        private async void ScreenForm_Load(object sender, EventArgs e)
        {
            var image = await AdbClient.Instance.GetFrameBufferAsync(device, CancellationToken.None);
            int height = image.Height;
            int width = image.Width;

            var minicapReceiver = new StartMinicapReceiver();
            string cmd = $"LD_LIBRARY_PATH=/data/local/tmp /data/local/tmp/minicap -P {width}x{height}@{width / 2}x{height / 2}/0";
            AdbClient.Instance.ExecuteRemoteCommandAsync(cmd, device, minicapReceiver, CancellationToken.None, int.MaxValue);

            var minitouchReceiver = new StartMinitouchReceiver();
            minitouchReceiver.screenFrom = this;
            AdbClient.Instance.ExecuteRemoteCommandAsync("/data/local/tmp/minitouch", device, minitouchReceiver, CancellationToken.None, int.MaxValue);
        }

        class Banner
        {
            public int version = 0;
            public int length = 0;
            public int pid = 0;

            public int realWidth = 0;
            public int realHeight = 0;
            public int virtualWidth = 0;
            public int virtualHeight = 0;
            public int orientation = 0;
            public int quirks = 0;
        }

        private async Task Screencast()
        {
            minicapSocket = new TcpSocket();
            minicapSocket.Connect(new IPEndPoint(IPAddress.Loopback, minicapPort));
            var stream = minicapSocket.GetStream();
            byte[] frameBody = new byte[0];
            byte[] chunk = new byte[0xFFFF];
            int offset = 0;
            int readBannerBytes = 0;
            int bannerLength = 2;

            int readFrameBytes = 0;
            int frameBodyLength = 0;
            var banner = new Banner();

            while (true)
            {
                if (!stream.CanRead)
                {
                    Thread.Sleep(100);
                    continue;
                }
                int len = await stream.ReadAsync(chunk, offset, chunk.Length);
                for (int cursor = 0; cursor < len;)
                {
                    if (readBannerBytes < bannerLength)
                    {
                        switch (readBannerBytes)
                        {
                            case 0:
                                // version
                                banner.version = chunk[cursor];
                                break;
                            case 1:
                                banner.length = bannerLength = chunk[cursor];
                                break;
                            case 2:
                            case 3:
                            case 4:
                            case 5:
                                // pid
                                banner.pid +=
                                  (chunk[cursor] << ((readBannerBytes - 2) * 8)) >> 0;
                                break;
                            case 6:
                            case 7:
                            case 8:
                            case 9:
                                // real width
                                banner.realWidth +=
                                  (chunk[cursor] << ((readBannerBytes - 6) * 8)) >> 0;
                                break;
                            case 10:
                            case 11:
                            case 12:
                            case 13:
                                // real height
                                banner.realHeight +=
                                  (chunk[cursor] << ((readBannerBytes - 10) * 8)) >> 0;
                                break;
                            case 14:
                            case 15:
                            case 16:
                            case 17:
                                // virtual width
                                banner.virtualWidth +=
                                  (chunk[cursor] << ((readBannerBytes - 14) * 8)) >> 0;
                                break;
                            case 18:
                            case 19:
                            case 20:
                            case 21:
                                // virtual height
                                banner.virtualHeight +=
                                  (chunk[cursor] << ((readBannerBytes - 18) * 8)) >> 0;
                                break;
                            case 22:
                                // orientation
                                banner.orientation += chunk[cursor] * 90;
                                break;
                            case 23:
                                // quirks
                                banner.quirks = chunk[cursor];
                                break;

                            default:
                                break;
                        }
                        cursor++;
                        readBannerBytes++;
                    }
                    else if (readFrameBytes < 4)
                    {
                        frameBodyLength += (chunk[cursor] << (readFrameBytes * 8)) >> 0;
                        cursor++;
                        readFrameBytes++;
                        //Debug.WriteLine($"headerbyte{readFrameBytes}(val={frameBodyLength})");
                    }
                    else
                    {
                        if (len - cursor >= frameBodyLength)
                        {
                            //Debug.WriteLine($"bodyfin(len={frameBodyLength},cursor={cursor})");

                            frameBody = frameBody.Concat(chunk.Skip(cursor).Take(frameBodyLength)).ToArray();

                            // Sanity check for JPG header, only here for debugging purposes.
                            if (frameBody[0] != 0xFF || frameBody[1] != 0xD8)
                            {
                                Debug.WriteLine("Frame body does not start with JPG header");

                                throw new Exception();
                            }
                            Image image = Image.FromStream(new MemoryStream(frameBody));
                            this.AutoSize = true;
                            pictureBox1.Image = image;

                            cursor += frameBodyLength;
                            frameBodyLength = readFrameBytes = 0;
                            frameBody = new byte[0];
                        }
                        else
                        {
                            //Debug.WriteLine($"body(len={len - cursor})");

                            frameBody = frameBody.Concat(chunk.Skip(cursor).Take(len - cursor)).ToArray();

                            frameBodyLength -= len - cursor;
                            readFrameBytes += len - cursor;
                            cursor = len;
                        }
                    }
                }
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            AdbClient.Instance.CreateForward(device, ForwardSpec.Parse($"tcp:{minitouchPort}"),
                ForwardSpec.Parse("localabstract:minitouch"), true);
            AdbClient.Instance.CreateForward(device, ForwardSpec.Parse($"tcp:{minicapPort}"),
                ForwardSpec.Parse("localabstract:minicap"), true);
            Screencast();
            minitouchSocket = new TcpSocket();
            minitouchSocket.Connect(new IPEndPoint(IPAddress.Loopback, minitouchPort));
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            int x = e.X * touchWidth / pictureBox1.Width;
            int y = e.Y * touchHeight / pictureBox1.Height;
            string cmd = $"d 0 {x} {y} 50\n";
            //Debug.WriteLine(cmd);
            byte[] bytes = AdbClient.Encoding.GetBytes(cmd);
            minitouchSocket.Send(bytes, 0, bytes.Length, SocketFlags.None);
            bytes = AdbClient.Encoding.GetBytes("c\n");
            minitouchSocket.Send(bytes, 0, bytes.Length, SocketFlags.None);
            this.pictureBox1.MouseMove += this.pictureBox1_MouseMove;

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            string cmd = "u\n";
            //Debug.WriteLine(cmd);
            byte[] bytes = AdbClient.Encoding.GetBytes(cmd);
            minitouchSocket.Send(bytes, 0, bytes.Length, SocketFlags.None);
            bytes = AdbClient.Encoding.GetBytes("c\n");
            minitouchSocket.Send(bytes, 0, bytes.Length, SocketFlags.None);
            this.pictureBox1.MouseMove -= this.pictureBox1_MouseMove;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.X * touchWidth / pictureBox1.Width;
            int y = e.Y * touchHeight / pictureBox1.Height;
            string cmd = $"m 0 {x} {y} 50\n";
            //Debug.WriteLine(cmd);
            byte[] bytes = AdbClient.Encoding.GetBytes(cmd);
            minitouchSocket.Send(bytes, 0, bytes.Length, SocketFlags.None);
            bytes = AdbClient.Encoding.GetBytes("c\n");
            minitouchSocket.Send(bytes, 0, bytes.Length, SocketFlags.None);
        }
    }
}
