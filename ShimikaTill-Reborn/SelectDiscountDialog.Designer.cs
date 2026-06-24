namespace ShimikaTill_Reborn
{
    partial class SelectDiscountDialog
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
            this.DiscountDialogLabel = new System.Windows.Forms.Label();
            this.SelectDiscountExitButton = new System.Windows.Forms.Button();
            this.AmountButton = new System.Windows.Forms.Button();
            this.RatioButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DiscountDialogLabel
            // 
            this.DiscountDialogLabel.AutoSize = true;
            this.DiscountDialogLabel.BackColor = System.Drawing.Color.Transparent;
            this.DiscountDialogLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DiscountDialogLabel.Location = new System.Drawing.Point(108, 38);
            this.DiscountDialogLabel.Name = "DiscountDialogLabel";
            this.DiscountDialogLabel.Size = new System.Drawing.Size(185, 16);
            this.DiscountDialogLabel.TabIndex = 0;
            this.DiscountDialogLabel.Text = "値引方法を選択してください";
            // 
            // SelectDiscountExitButton
            // 
            this.SelectDiscountExitButton.BackgroundImage = global::ShimikaTill_Reborn.Properties.Resources.close;
            this.SelectDiscountExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SelectDiscountExitButton.Location = new System.Drawing.Point(343, 2);
            this.SelectDiscountExitButton.Name = "SelectDiscountExitButton";
            this.SelectDiscountExitButton.Size = new System.Drawing.Size(35, 35);
            this.SelectDiscountExitButton.TabIndex = 1;
            this.SelectDiscountExitButton.UseVisualStyleBackColor = true;
            this.SelectDiscountExitButton.Click += new System.EventHandler(this.SelectDiscountExitButton_Click);
            // 
            // AmountButton
            // 
            this.AmountButton.BackgroundImage = global::ShimikaTill_Reborn.Properties.Resources.button_grey;
            this.AmountButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AmountButton.Location = new System.Drawing.Point(202, 97);
            this.AmountButton.Name = "AmountButton";
            this.AmountButton.Size = new System.Drawing.Size(85, 31);
            this.AmountButton.TabIndex = 2;
            this.AmountButton.Text = "金額";
            this.AmountButton.UseVisualStyleBackColor = true;
            this.AmountButton.Click += new System.EventHandler(this.AmountButton_Click);
            // 
            // RatioButton
            // 
            this.RatioButton.BackgroundImage = global::ShimikaTill_Reborn.Properties.Resources.button_grey;
            this.RatioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RatioButton.Location = new System.Drawing.Point(293, 97);
            this.RatioButton.Name = "RatioButton";
            this.RatioButton.Size = new System.Drawing.Size(85, 31);
            this.RatioButton.TabIndex = 3;
            this.RatioButton.Text = "割合";
            this.RatioButton.UseVisualStyleBackColor = true;
            this.RatioButton.Click += new System.EventHandler(this.RatioButton_Click);
            // 
            // SelectDiscountDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShimikaTill_Reborn.Properties.Resources.InfoDialog;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(380, 130);
            this.Controls.Add(this.RatioButton);
            this.Controls.Add(this.AmountButton);
            this.Controls.Add(this.SelectDiscountExitButton);
            this.Controls.Add(this.DiscountDialogLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectDiscountDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SelectDiscountDialog";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DiscountDialogLabel;
        private System.Windows.Forms.Button SelectDiscountExitButton;
        private System.Windows.Forms.Button AmountButton;
        private System.Windows.Forms.Button RatioButton;
    }
}