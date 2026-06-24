using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ShimikaTill_Reborn.InputNumberForm;

namespace ShimikaTill_Reborn
{
    public partial class SelectDiscountDialog : Form
    {
        public SelectDiscountDialog()
        {
            InitializeComponent();
        }

        private void SelectDiscountExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AmountButton_Click(object sender, EventArgs e) //金額
        {
            var mainForm = this.Owner as MainForm;

            var form = new InputNumberForm(mainForm, InputMode.DiscountAmount);
            form.SetMessage("割引する額を\n入力してください。");
            form.ShowDialog();

            this.Close();
        }

        private void RatioButton_Click(object sender, EventArgs e) //割合
        {
            var mainForm = this.Owner as MainForm;

            var form = new InputNumberForm(mainForm, InputMode.DiscountRatio);
            form.SetMessage("割引する割合（パーセント）を\n入力してください。");
            form.ShowDialog();

            this.Close();
        }
    }
}
