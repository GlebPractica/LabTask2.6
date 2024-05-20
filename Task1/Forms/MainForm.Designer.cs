namespace Task1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BttnShowProducts = new System.Windows.Forms.Button();
            this.BttnShowCart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BttnShowProducts
            // 
            this.BttnShowProducts.Location = new System.Drawing.Point(12, 12);
            this.BttnShowProducts.Name = "BttnShowProducts";
            this.BttnShowProducts.Size = new System.Drawing.Size(358, 53);
            this.BttnShowProducts.TabIndex = 0;
            this.BttnShowProducts.Text = "Продукты";
            this.BttnShowProducts.UseVisualStyleBackColor = true;
            this.BttnShowProducts.Click += new System.EventHandler(this.BttnShowProducts_Click);
            // 
            // BttnShowCart
            // 
            this.BttnShowCart.Location = new System.Drawing.Point(12, 71);
            this.BttnShowCart.Name = "BttnShowCart";
            this.BttnShowCart.Size = new System.Drawing.Size(358, 53);
            this.BttnShowCart.TabIndex = 1;
            this.BttnShowCart.Text = "Корзина";
            this.BttnShowCart.UseVisualStyleBackColor = true;
            this.BttnShowCart.Click += new System.EventHandler(this.BttnShowCart_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 137);
            this.Controls.Add(this.BttnShowCart);
            this.Controls.Add(this.BttnShowProducts);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задание";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BttnShowProducts;
        private System.Windows.Forms.Button BttnShowCart;
    }
}

