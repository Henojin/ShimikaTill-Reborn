using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ShimikaTill_Reborn
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            datetimer.Tick += new EventHandler(datetimer_Tick);
            datetimer.Start();
        }

        private void datetimer_Tick(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void AddScannedItem(string ProductsName, int UnitPrice, int Quantity)
        {
            int Subtotal = UnitPrice * Quantity;

            var item = new ListViewItem(ProductsName); // 商品名
            item.SubItems.Add(UnitPrice.ToString());   // 単価
            item.SubItems.Add(Quantity.ToString());    // 数量
            item.SubItems.Add(Subtotal.ToString());    // 小計

            ListProducts.Items.Add(item);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Notification.Text = "ShimikaTillへようこそ！​\nJANコードを入力し、商品を登録してください。";
            /// これはあくまでも仮です
            AddScannedItem("りんご", 120, 1);
            AddScannedItem("バナナ", 80, 2);
        }

        private void GOAccounting_Click(object sender, EventArgs e)
        {
            var dialog = new NotificationDialog();
            dialog.SetMessage("会計ボタンが押されました。\nこれはDialogのテストです。");
            dialog.ShowDialog();
        }
    }
}
