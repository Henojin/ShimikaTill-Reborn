using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ShimikaTill_Reborn.InputNumberForm;
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

        public void SetManualPrice(string num)
        {
            if (!int.TryParse(num, out int price))
                return;

            string name = "商品";
            int quantity = 1;
            int subtotal = price * quantity;

            ListViewItem item = new ListViewItem(name);
            item.SubItems.Add(price.ToString());
            item.SubItems.Add(quantity.ToString());
            item.SubItems.Add(subtotal.ToString());

            item.Tag = 0;

            ListProducts.Items.Add(item);

            UpdateTotals();
        }

        private void datetimer_Tick(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
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

                int taxRate = (int)item.Tag;

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
            if (ListProducts.Items.Count == 0)
            {
                SystemSounds.Hand.Play();
                var dialogError = new NotificationDialog();
                dialogError.SetMessage("商品が1つも登録されていません。");
                dialogError.ShowDialog();
                return;
            }

            SystemSounds.Exclamation.Play();
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
                SystemSounds.Hand.Play();
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
                SystemSounds.Exclamation.Play();
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

            item.Tag = tax;

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
            var form = new InputNumberForm(this, InputNumberForm.InputMode.Barcode);
            form.SetMessage("JANコードを入力してください。");
            form.ShowDialog();

        }
        public void SetBarcodeAndScan(string barcode)
        {
            InputBarcode.Text = barcode;
            ScanBarcode(barcode);
            InputBarcode.Clear();
        }

        private void bt1_Click(object sender, EventArgs e) //値引
        {
            if (ListProducts.SelectedItems.Count == 0)
            {
                SystemSounds.Hand.Play();

                var dialogError = new NotificationDialog();
                dialogError.SetMessage("取り消す商品が選択されていません。");
                dialogError.ShowDialog();
                return;
            }

            var dialog = new SelectDiscountDialog();
            dialog.ShowDialog();
        }

        private void bt2_Click(object sender, EventArgs e) //手動登録
        {
            var form = new InputNumberForm(this, InputMode.ManualPrice);
            form.SetMessage("商品の価格を入力してください。");
            form.ShowDialog();
        }

        private void bt3_Click(object sender, EventArgs e) //売上管理
        {
            var dialog = new NotificationDialog();
            dialog.SetMessage("");
            dialog.ShowDialog();
        }

        private void bt4_Click(object sender, EventArgs e) //取消
        {
            if (ListProducts.SelectedItems.Count == 0)
            {
                SystemSounds.Hand.Play();

                var dialog = new NotificationDialog();
                dialog.SetMessage("取り消す商品が選択されていません。");
                dialog.ShowDialog();
                return;
            }

            SystemSounds.Exclamation.Play();
            var dialog2 = new AlartDialog();
            dialog2.SetMessage("選択した商品を取り消しますか？");
            dialog2.ShowDialog();

            if (dialog2.Result)
            {
                var row = ListProducts.SelectedItems[0];
                ListProducts.Items.Remove(row);
                UpdateTotals();
            }
        }

        private void bt5_Click(object sender, EventArgs e) //返品・返金
        {
            var dialog = new NotificationDialog();
            dialog.SetMessage("");
            dialog.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dialog = new AlartDialog();
            dialog.SetMessage("アプリを終了しますか？");

            var result = dialog.ShowDialog();

            if (dialog.Result == false)
            {
                e.Cancel = true;
            }
        }
    }
}
