using System;
using System.IO;
using System.Collections.Generic;
using System.Data.SQLite;
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
                CreateDatabase();
                Thread.Sleep(500); // ここは仮で秒数設定してます。
            }
            Application.Run(new MainForm());
        }
        private static void CreateDatabase()
        {
            if (!File.Exists("Products.db"))
            {
                SQLiteConnection.CreateFile("Products.db");

                using (var con = new SQLiteConnection("Data Source=Products.db"))
                {
                    con.Open();
                    string sql = @"
                    CREATE TABLE Products (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Barcode TEXT NOT NULL,
                        Name TEXT NOT NULL,
                        Price INTEGER NOT NULL,
                        Tax INTEGER NOT NULL,
                        Check20 INTEGER NOT NULL
                    );

                    INSERT INTO Products (Barcode, Name, Price, Tax, Check20) VALUES ('4901234567001', 'ビール', 198, 10, 1);
                    INSERT INTO Products (Barcode, Name, Price, Tax, Check20) VALUES ('4901234567002', 'タバコ', 580, 10, 1);
                    INSERT INTO Products (Barcode, Name, Price, Tax, Check20) VALUES ('4901234567003', 'トマト', 150, 8, 0);
                    INSERT INTO Products (Barcode, Name, Price, Tax, Check20) VALUES ('4901234567004', 'イカ', 200, 8, 0);
                ";

                    using (var cmd = new SQLiteCommand(sql, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
