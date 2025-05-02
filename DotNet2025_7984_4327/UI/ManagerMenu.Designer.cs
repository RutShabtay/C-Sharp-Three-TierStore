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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerMenu));
            sales = new Button();
            products = new Button();
            pictureBox1 = new PictureBox();
            customers = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // sales
            // 
            sales.Anchor = AnchorStyles.Left;
            sales.Location = new Point(398, 97);
            sales.Margin = new Padding(3, 2, 3, 2);
            sales.Name = "sales";
            sales.Size = new Size(265, 101);
            sales.TabIndex = 5;
            sales.Text = "מבצעים";
            sales.UseVisualStyleBackColor = true;
            sales.Click += sales_Click;
            // 
            // products
            // 
            products.Anchor = AnchorStyles.Right;
            products.Location = new Point(74, 97);
            products.Margin = new Padding(3, 2, 3, 2);
            products.Name = "products";
            products.Size = new Size(253, 101);
            products.TabIndex = 4;
            products.Text = "מוצרים";
            products.UseVisualStyleBackColor = true;
            products.Click += products_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ImageToStl_com_pandora_logo;
            pictureBox1.Location = new Point(40, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(226, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // customers
            // 
            customers.Anchor = AnchorStyles.None;
            customers.Location = new Point(222, 97);
            customers.Margin = new Padding(3, 2, 3, 2);
            customers.Name = "customers";
            customers.Size = new Size(261, 101);
            customers.TabIndex = 3;
            customers.Text = "לקוחות";
            customers.UseVisualStyleBackColor = true;
            customers.Click += customers_Click;
            // 
            // ManagerMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 234, 231);
            ClientSize = new Size(700, 338);
            Controls.Add(pictureBox1);
            Controls.Add(sales);
            Controls.Add(products);
            Controls.Add(customers);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "ManagerMenu";
            Text = "ManagerMenu";
            WindowState = FormWindowState.Maximized;
            Load += ManagerMenu_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button sales;
        private Button products;
        private PictureBox pictureBox1;
        private Button customers;
    }
}