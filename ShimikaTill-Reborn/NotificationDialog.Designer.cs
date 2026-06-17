namespace ShimikaTill_Reborn
{
    partial class NotificationDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NotificationDialogLabel = new System.Windows.Forms.Label();
            this.NotificationDialogButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NotificationDialogLabel
            // 
            this.NotificationDialogLabel.AutoSize = true;
            this.NotificationDialogLabel.BackColor = System.Drawing.Color.Transparent;
            this.NotificationDialogLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NotificationDialogLabel.Location = new System.Drawing.Point(108, 38);
            this.NotificationDialogLabel.Name = "NotificationDialogLabel";
            this.NotificationDialogLabel.Size = new System.Drawing.Size(122, 16);
            this.NotificationDialogLabel.TabIndex = 0;
            this.NotificationDialogLabel.Text = "NotificationDialog";
            // 
            // NotificationDialogButton
            // 
            this.NotificationDialogButton.BackColor = System.Drawing.Color.Transparent;
            this.NotificationDialogButton.BackgroundImage = global::ShimikaTill_Reborn.Properties.Resources.button_grey;
            this.NotificationDialogButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NotificationDialogButton.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NotificationDialogButton.Location = new System.Drawing.Point(293, 97);
            this.NotificationDialogButton.Name = "NotificationDialogButton";
            this.NotificationDialogButton.Size = new System.Drawing.Size(85, 31);
            this.NotificationDialogButton.TabIndex = 1;
            this.NotificationDialogButton.Text = "OK";
            this.NotificationDialogButton.UseVisualStyleBackColor = false;
            this.NotificationDialogButton.Click += new System.EventHandler(this.NotificationDialogButton_Click);
            // 
            // NotificationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShimikaTill_Reborn.Properties.Resources.dialog;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(380, 130);
            this.Controls.Add(this.NotificationDialogButton);
            this.Controls.Add(this.NotificationDialogLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotificationDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NotificationDialog";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NotificationDialogLabel;
        private System.Windows.Forms.Button NotificationDialogButton;
    }
}