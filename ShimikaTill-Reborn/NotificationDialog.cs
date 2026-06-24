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

namespace ShimikaTill_Reborn
{
    public partial class NotificationDialog : Form
    {
        public NotificationDialog()
        {
            InitializeComponent();
        }

        public void SetMessage(string message)
        {
            NotificationDialogLabel.Text = message;
        }

        private void NotificationDialogButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
