namespace ShimikaTill_Reborn
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.datetimer = new System.Windows.Forms.Timer(this.components);
            this.GOAccounting = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.GOSettings = new System.Windows.Forms.Button();
            this.InputJAN = new System.Windows.Forms.TextBox();
            this.ListProducts = new System.Windows.Forms.ListView();
            this.ProductsName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UntiPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Subtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Notification = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.SystemColors.Window;
            this.labelDate.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelDate.Location = new System.Drawing.Point(14, 23);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(87, 16);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "0000/00/00";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.SystemColors.Window;
            this.labelTime.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTime.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTime.Location = new System.Drawing.Point(12, 46);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(92, 24);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "00:00:00";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GOAccounting
            // 
            this.GOAccounting.BackgroundImage = global::ShimikaTill_Reborn.Properties.Resources.button;
            this.GOAccounting.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GOAccounting.ForeColor = System.Drawing.SystemColors.Window;
            this.GOAccounting.Location = new System.Drawing.Point(667, 509);
            this.GOAccounting.Name = "GOAccounting";
            this.GOAccounting.Size = new System.Drawing.Size(118, 54);
            this.GOAccounting.TabIndex = 2;
            this.GOAccounting.Text = "会計";
            this.GOAccounting.UseVisualStyleBackColor = true;
            this.GOAccounting.Click += new System.EventHandler(this.GOAccounting_Click);
            // 
            // bt1
            // 
            this.bt1.BackgroundImage = global::ShimikaTill_Reborn.Properties.Resources.button_orange;
            this.bt1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bt1.Location = new System.Drawing.Point(4, 125);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(95, 40);
            this.bt1.TabIndex = 3;
            this.bt1.Text = "値引";
            this.bt1.UseVisualStyleBackColor = true;
            // 
            // bt2
            // 
            this.bt2.BackgroundImage = global::ShimikaTill_Reborn.Properties.Resources.button_yellow;
            this.bt2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bt2.Location = new System.Drawing.Point(4, 175);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(95, 40);
            this.bt2.TabIndex = 4;
            this.bt2.Text = "手動登録";
            this.bt2.UseVisualStyleBackColor = true;
            // 
            // bt3
            // 
            this.bt3.BackgroundImage = global::ShimikaTill_Reborn.Properties.Resources.button_blue;
            this.bt3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bt3.Location = new System.Drawing.Point(4, 225);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(95, 40);
            this.bt3.TabIndex = 5;
            this.bt3.Text = "売上管理";
            this.bt3.UseVisualStyleBackColor = true;
            // 
            // bt4
            // 
            this.bt4.BackgroundImage = global::ShimikaTill_Reborn.Properties.Resources.button_red;
            this.bt4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bt4.Location = new System.Drawing.Point(4, 275);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(95, 40);
            this.bt4.TabIndex = 6;
            this.bt4.Text = "取消";
            this.bt4.UseVisualStyleBackColor = true;
            // 
            // bt5
            // 
            this.bt5.BackgroundImage = global::ShimikaTill_Reborn.Properties.Resources.button_red1;
            this.bt5.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bt5.Location = new System.Drawing.Point(4, 325);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(95, 40);
            this.bt5.TabIndex = 7;
            this.bt5.Text = "返品/返金";
            this.bt5.UseVisualStyleBackColor = true;
            // 
            // GOSettings
            // 
            this.GOSettings.BackgroundImage = global::ShimikaTill_Reborn.Properties.Resources.button_grey;
            this.GOSettings.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GOSettings.Location = new System.Drawing.Point(4, 434);
            this.GOSettings.Name = "GOSettings";
            this.GOSettings.Size = new System.Drawing.Size(95, 40);
            this.GOSettings.TabIndex = 8;
            this.GOSettings.Text = "設定";
            this.GOSettings.UseVisualStyleBackColor = true;
            // 
            // InputJAN
            // 
            this.InputJAN.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.InputJAN.Location = new System.Drawing.Point(7, 517);
            this.InputJAN.MaxLength = 13;
            this.InputJAN.Name = "InputJAN";
            this.InputJAN.Size = new System.Drawing.Size(654, 36);
            this.InputJAN.TabIndex = 9;
            // 
            // ListProducts
            // 
            this.ListProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductsName,
            this.UntiPrice,
            this.Quantity,
            this.Subtotal});
            this.ListProducts.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ListProducts.FullRowSelect = true;
            this.ListProducts.GridLines = true;
            this.ListProducts.HideSelection = false;
            this.ListProducts.Location = new System.Drawing.Point(118, 103);
            this.ListProducts.Name = "ListProducts";
            this.ListProducts.Size = new System.Drawing.Size(654, 367);
            this.ListProducts.TabIndex = 10;
            this.ListProducts.UseCompatibleStateImageBehavior = false;
            this.ListProducts.View = System.Windows.Forms.View.Details;
            // 
            // ProductsName
            // 
            this.ProductsName.Text = "商品名";
            this.ProductsName.Width = 350;
            // 
            // UntiPrice
            // 
            this.UntiPrice.Text = "単価";
            this.UntiPrice.Width = 100;
            // 
            // Quantity
            // 
            this.Quantity.Text = "数量";
            this.Quantity.Width = 75;
            // 
            // Subtotal
            // 
            this.Subtotal.Text = "小計";
            this.Subtotal.Width = 125;
            // 
            // Notification
            // 
            this.Notification.AutoSize = true;
            this.Notification.BackColor = System.Drawing.SystemColors.Window;
            this.Notification.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Notification.Location = new System.Drawing.Point(126, 21);
            this.Notification.Name = "Notification";
            this.Notification.Size = new System.Drawing.Size(122, 24);
            this.Notification.TabIndex = 11;
            this.Notification.Text = "Notification";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShimikaTill_Reborn.Properties.Resources.BackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Notification);
            this.Controls.Add(this.ListProducts);
            this.Controls.Add(this.InputJAN);
            this.Controls.Add(this.GOSettings);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.GOAccounting);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelDate);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShimikaTill";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer datetimer;
        private System.Windows.Forms.Button GOAccounting;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button GOSettings;
        private System.Windows.Forms.TextBox InputJAN;
        private System.Windows.Forms.ListView ListProducts;
        private System.Windows.Forms.ColumnHeader ProductsName;
        private System.Windows.Forms.ColumnHeader UntiPrice;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Subtotal;
        private System.Windows.Forms.Label Notification;
    }
}

