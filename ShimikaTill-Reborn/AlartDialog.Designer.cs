namespace ShimikaTill_Reborn
{
    partial class AlartDialog
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
            this.AlartDialogLabel = new System.Windows.Forms.Label();
            this.AlartYESButton = new System.Windows.Forms.Button();
            this.AlartNOButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AlartDialogLabel
            // 
            this.AlartDialogLabel.AutoSize = true;
            this.AlartDialogLabel.BackColor = System.Drawing.Color.Transparent;
            this.AlartDialogLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AlartDialogLabel.Location = new System.Drawing.Point(108, 38);
            this.AlartDialogLabel.Name = "AlartDialogLabel";
            this.AlartDialogLabel.Size = new System.Drawing.Size(79, 16);
            this.AlartDialogLabel.TabIndex = 0;
            this.AlartDialogLabel.Text = "AlartDialog";
            // 
            // AlartYESButton
            // 
            this.AlartYESButton.BackColor = System.Drawing.Color.Transparent;
            this.AlartYESButton.BackgroundImage = global::ShimikaTill_Reborn.Properties.Resources.button_grey;
            this.AlartYESButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AlartYESButton.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AlartYESButton.Location = new System.Drawing.Point(202, 97);
            this.AlartYESButton.Name = "AlartYESButton";
            this.AlartYESButton.Size = new System.Drawing.Size(85, 31);
            this.AlartYESButton.TabIndex = 1;
            this.AlartYESButton.Text = "はい";
            this.AlartYESButton.UseVisualStyleBackColor = false;
            this.AlartYESButton.Click += new System.EventHandler(this.AlartYESButton_Click);
            // 
            // AlartNOButton
            // 
            this.AlartNOButton.BackColor = System.Drawing.Color.Transparent;
            this.AlartNOButton.BackgroundImage = global::ShimikaTill_Reborn.Properties.Resources.button_grey;
            this.AlartNOButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AlartNOButton.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AlartNOButton.Location = new System.Drawing.Point(293, 97);
            this.AlartNOButton.Name = "AlartNOButton";
            this.AlartNOButton.Size = new System.Drawing.Size(85, 31);
            this.AlartNOButton.TabIndex = 2;
            this.AlartNOButton.Text = "いいえ";
            this.AlartNOButton.UseVisualStyleBackColor = false;
            this.AlartNOButton.Click += new System.EventHandler(this.AlartNOButton_Click);
            // 
            // AlartDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShimikaTill_Reborn.Properties.Resources.dialog;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(380, 130);
            this.Controls.Add(this.AlartNOButton);
            this.Controls.Add(this.AlartYESButton);
            this.Controls.Add(this.AlartDialogLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlartDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AlartDialog";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AlartDialogLabel;
        private System.Windows.Forms.Button AlartYESButton;
        private System.Windows.Forms.Button AlartNOButton;
    }
}