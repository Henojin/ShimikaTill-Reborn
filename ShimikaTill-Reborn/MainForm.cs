using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ShimikaTill_Reborn
{
    public partial class MainForm : Form
    {
        private bool ageWarningShown = false;
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
            UpdateTotals();
        }

        private void UpdateTotals()
        {
            int TotalItems = 0;
            int SubTotal = 0;
            int Total = 0;

            foreach (ListViewItem item in ListProducts.Items)
            {
                int price = int.Parse(item.SubItems[1].Text);
                int quantity = int.Parse(item.SubItems[2].Text);
                int lineSubtotal = int.Parse(item.SubItems[3].Text);

                SubTotal += lineSubtotal;

                var product = FindProductByBarcode(item.SubItems[0].Text);
                int taxRate = product?.tax ?? 10;

                int taxAmount = price * taxRate / 100;
                int priceWithTax = price + taxAmount;

                Total += priceWithTax * quantity;

                TotalItems += quantity;
            }

            ItemLabel.Text = $"点数：{TotalItems} 点";
            SubTotalLabel.Text = $"小計：{SubTotal} 円";
            TotalLabel.Text = $"合計：{Total} 円";
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            Notification.Text = "ShimikaTillへようこそ！​\nJANコードを入力し、商品を登録してください。";
            /// これはあくまでも仮です
            AddScannedItem("りんご", 120, 1);
            AddScannedItem("バナナ", 80, 2);
        }
        private (string name, int price, int tax, int check20)? FindProductByBarcode(string barcode)
        {
            using (var con = new SQLiteConnection("Data Source=Products.db"))
            {
                con.Open();
                string sql = "SELECT Name, Price, Tax, Check20 FROM Products WHERE Barcode = @Barcode";

                using (var cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Barcode", barcode);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return (
                                reader.GetString(0),
                                reader.GetInt32(1),
                                reader.GetInt32(2),
                                reader.GetInt32(3)
                            );
                        }
                    }
                }
            }

            return null;
        }
        private void GOAccounting_Click(object sender, EventArgs e)
        {
            var dialog = new NotificationDialog();
            // 仮です
            dialog.SetMessage("会計ボタンが押されました。\n登録された商品を削除します。");
            dialog.ShowDialog();
            ListProducts.Items.Clear();
            UpdateTotals();
            ageWarningShown = false;
        }

        private void InputBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string barcode = InputBarcode.Text.Trim();

                if (barcode != "")
                {
                    ScanBarcode(barcode);
                    InputBarcode.Clear();
                }

                e.SuppressKeyPress = true;
            }
        }
        private void ScanBarcode(string barcode)
        {
            var product = FindProductByBarcode(barcode);

            if (product == null)
            {
                var dialog = new NotificationDialog();
                dialog.SetMessage("商品が見つかりません。");
                dialog.ShowDialog();
                return;
            }

            string name = product.Value.name;
            int price = product.Value.price;
            int tax = product.Value.tax;
            int check20 = product.Value.check20;

            if (check20 == 1 && !ageWarningShown)
            {
                var dialog = new NotificationDialog();
                dialog.SetMessage("年齢確認商品です。");
                dialog.ShowDialog();
                ageWarningShown = true;
            }

            int quantity = 1;
            int subtotal = price * quantity;

            foreach (ListViewItem row in ListProducts.Items)
            {
                if (row.SubItems[0].Text == name)
                {
                    int qty = int.Parse(row.SubItems[2].Text) + 1;
                    row.SubItems[2].Text = qty.ToString();

                    int newSubtotal = price * qty;
                    row.SubItems[3].Text = newSubtotal.ToString();

                    UpdateTotals();
                    return;
                }
            }

            ListViewItem item = new ListViewItem(name);
            item.SubItems.Add(price.ToString());
            item.SubItems.Add("1");
            item.SubItems.Add(subtotal.ToString());

            ListProducts.Items.Add(item);

            UpdateTotals();
        }

        private void GOSettings_Click(object sender, EventArgs e)
        {
            var dialog = new NotificationDialog();
            dialog.SetMessage("");
            dialog.ShowDialog();
        }

        private void GoSoftKeyboard_Click(object sender, EventArgs e)
        {
            InputNumberForm InputNumberForm = new InputNumberForm(this);
            InputNumberForm.SetMessage("JANコードを入力してください。");
            InputNumberForm.ShowDialog();
        }
        public void SetBarcodeAndScan(string barcode)
        {
            InputBarcode.Text = barcode;
            ScanBarcode(barcode);
            InputBarcode.Clear();
        }

        private void bt1_Click(object sender, EventArgs e) //値引
        {
            var dialog = new NotificationDialog();
            dialog.SetMessage("");
            dialog.ShowDialog();
        }

        private void bt2_Click(object sender, EventArgs e) //手動登録
        {
            var dialog = new NotificationDialog();
            dialog.SetMessage("");
            dialog.ShowDialog();
        }

        private void bt3_Click(object sender, EventArgs e) //売上管理
        {
            var dialog = new NotificationDialog();
            dialog.SetMessage("");
            dialog.ShowDialog();
        }

        private void bt4_Click(object sender, EventArgs e) //取消
        {
            var dialog = new NotificationDialog();
            dialog.SetMessage("");
            dialog.ShowDialog();
        }

        private void bt5_Click(object sender, EventArgs e) //返品・返金
        {
            var dialog = new NotificationDialog();
            dialog.SetMessage("");
            dialog.ShowDialog();
        }
    }
}
