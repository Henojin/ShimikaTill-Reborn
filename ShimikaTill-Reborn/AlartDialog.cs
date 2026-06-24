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
    public partial class AlartDialog : Form
    {
        public bool Result { get; private set; } = false;
        public AlartDialog()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            SystemSounds.Exclamation.Play();
        }

        public void SetMessage(string message)
        {
            AlartDialogLabel.Text = message;
        }

        private void AlartYESButton_Click(object sender, EventArgs e)
        {
            Result = true;
            this.Close();
        }

        private void AlartNOButton_Click(object sender, EventArgs e)
        {
            Result = false;
            this.Close();
        }
    }
}
