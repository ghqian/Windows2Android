using SharpAdbClient;
using System;
using System.Windows.Forms;

namespace Windows2Android
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var server = new AdbServer();
            var result = server.StartServer(@"C:\Users\dibap\AppData\Local\Android\Sdk\platform-tools\adb.exe", restartServerIfNewer: false);

            Application.Run(new DeviceListForm());
        }
    }
}
