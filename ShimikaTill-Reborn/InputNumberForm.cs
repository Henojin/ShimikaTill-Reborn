using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ShimikaTill_Reborn
{
    public partial class InputNumberForm : Form
    {
        private MainForm _mainForm;
        public InputNumberForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void InputNumberExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void SetMessage(string message)
        {
            InputNumberLabel.Text = message;
        }

        private void Input1_Click(object sender, EventArgs e)
        {
            InputNumber.Text += "1";
        }

        private void Input2_Click(object sender, EventArgs e)
        {
            InputNumber.Text += "2";
        }

        private void Input3_Click(object sender, EventArgs e)
        {
            InputNumber.Text += "3";
        }

        private void Input4_Click(object sender, EventArgs e)
        {
            InputNumber.Text += "4";
        }

        private void Input5_Click(object sender, EventArgs e)
        {
            InputNumber.Text += "5";
        }

        private void Input6_Click(object sender, EventArgs e)
        {
            InputNumber.Text += "6";
        }

        private void Input7_Click(object sender, EventArgs e)
        {
            InputNumber.Text += "7";
        }

        private void Input8_Click(object sender, EventArgs e)
        {
            InputNumber.Text += "8";
        }

        private void Input9_Click(object sender, EventArgs e)
        {
            InputNumber.Text += "9";
        }

        private void Input0_Click(object sender, EventArgs e)
        {
            InputNumber.Text += "0";
        }

        private void InputBS_Click(object sender, EventArgs e)
        {
            if (InputNumber.Text.Length > 0)
            {
                InputNumber.Text = InputNumber.Text.Substring(0, InputNumber.Text.Length - 1);
            }
        }

        private void InputEnter_Click(object sender, EventArgs e)
        {
            string num = InputNumber.Text.Trim();

            if (num != "")
            {
                _mainForm.SetBarcodeAndScan(num);
            }

            this.Close();
        }

        private void InputNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
