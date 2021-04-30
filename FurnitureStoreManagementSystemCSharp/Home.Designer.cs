namespace FurnitureStoreManagementSystemCSharp
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPurchasedDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSaledDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchDataToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductToolStripMenuItem,
            this.addCustomerToolStripMenuItem,
            this.purchaseToolStripMenuItem,
            this.saleToolStripMenuItem,
            this.searchProductToolStripMenuItem,
            this.viewCustomerToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(670, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addProductToolStripMenuItem
            // 
            this.addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            this.addProductToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.addProductToolStripMenuItem.Text = "Додати продукт";
            this.addProductToolStripMenuItem.Click += new System.EventHandler(this.addProductToolStripMenuItem_Click);
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.addCustomerToolStripMenuItem.Text = "Додати покупця";
            this.addCustomerToolStripMenuItem.Click += new System.EventHandler(this.addCustomerToolStripMenuItem_Click);
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPurchasedDataToolStripMenuItem,
            this.searchDataToolStripMenuItem});
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.purchaseToolStripMenuItem.Text = "Покупка";
            // 
            // addPurchasedDataToolStripMenuItem
            // 
            this.addPurchasedDataToolStripMenuItem.Name = "addPurchasedDataToolStripMenuItem";
            this.addPurchasedDataToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.addPurchasedDataToolStripMenuItem.Text = "Додати дані покупки";
            this.addPurchasedDataToolStripMenuItem.Click += new System.EventHandler(this.addPurchasedDataToolStripMenuItem_Click);
            // 
            // searchDataToolStripMenuItem
            // 
            this.searchDataToolStripMenuItem.Name = "searchDataToolStripMenuItem";
            this.searchDataToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.searchDataToolStripMenuItem.Text = "Пошук даних";
            this.searchDataToolStripMenuItem.Click += new System.EventHandler(this.searchDataToolStripMenuItem_Click);
            // 
            // saleToolStripMenuItem
            // 
            this.saleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSaledDataToolStripMenuItem,
            this.searchDataToolStripMenuItem1});
            this.saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            this.saleToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.saleToolStripMenuItem.Text = "Продаж";
            // 
            // addSaledDataToolStripMenuItem
            // 
            this.addSaledDataToolStripMenuItem.Name = "addSaledDataToolStripMenuItem";
            this.addSaledDataToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.addSaledDataToolStripMenuItem.Text = "Добавити дані продажу";
            this.addSaledDataToolStripMenuItem.Click += new System.EventHandler(this.addSaledDataToolStripMenuItem_Click);
            // 
            // searchDataToolStripMenuItem1
            // 
            this.searchDataToolStripMenuItem1.Name = "searchDataToolStripMenuItem1";
            this.searchDataToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.searchDataToolStripMenuItem1.Text = "Пошук даних";
            this.searchDataToolStripMenuItem1.Click += new System.EventHandler(this.searchDataToolStripMenuItem1_Click);
            // 
            // searchProductToolStripMenuItem
            // 
            this.searchProductToolStripMenuItem.Name = "searchProductToolStripMenuItem";
            this.searchProductToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.searchProductToolStripMenuItem.Text = "Пошук продукту";
            this.searchProductToolStripMenuItem.Click += new System.EventHandler(this.searchProductToolStripMenuItem_Click);
            // 
            // viewCustomerToolStripMenuItem
            // 
            this.viewCustomerToolStripMenuItem.Name = "viewCustomerToolStripMenuItem";
            this.viewCustomerToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.viewCustomerToolStripMenuItem.Text = "Переглянути покупців";
            this.viewCustomerToolStripMenuItem.Click += new System.EventHandler(this.viewCustomerToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.exitToolStripMenuItem.Text = "Вихід";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 469);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPurchasedDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSaledDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchDataToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem searchProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}