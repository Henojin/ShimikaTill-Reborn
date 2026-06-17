using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShimikaTill_Reborn
{
    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (var splash = new SplashScreen())
            {
                splash.Show();
                splash.Refresh();
                Thread.Sleep(2000); // ここは仮で秒数設定してます。本来はDBの読み込みとかに使いたいです。
            }
            Application.Run(new MainForm());
        }
    }
}
