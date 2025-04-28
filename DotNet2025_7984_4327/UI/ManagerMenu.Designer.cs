namespace UI
{
    partial class ManagerMenu
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
            sales = new Button();
            products = new Button();
            customers = new Button();
            SuspendLayout();
            // 
            // sales
            // 
            sales.Location = new Point(84, 152);
            sales.Name = "sales";
            sales.Size = new Size(175, 50);
            sales.TabIndex = 5;
            sales.Text = "מבצעים";
            sales.UseVisualStyleBackColor = true;
            sales.Click += sales_Click;
            // 
            // products
            // 
            products.Location = new Point(313, 152);
            products.Name = "products";
            products.Size = new Size(175, 50);
            products.TabIndex = 4;
            products.Text = "מוצרים";
            products.UseVisualStyleBackColor = true;
            products.Click += products_Click;
            // 
            // customers
            // 
            customers.Location = new Point(531, 152);
            customers.Name = "customers";
            customers.Size = new Size(175, 50);
            customers.TabIndex = 3;
            customers.Text = "לקוחות";
            customers.UseVisualStyleBackColor = true;
            customers.Click += customers_Click;
            // 
            // ManagerMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sales);
            Controls.Add(products);
            Controls.Add(customers);
            Name = "ManagerMenu";
            Text = "ManagerMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button sales;
        private Button products;
        private Button customers;
    }
}