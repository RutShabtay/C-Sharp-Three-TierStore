namespace UI
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            label6 = new Label();
            label5 = new Label();
            helloName = new TextBox();
            label4 = new Label();
            listProduct = new ListBox();
            sumOrder = new TextBox();
            label3 = new Label();
            endOrder = new Button();
            add = new TabControl();
            addProduct = new TabPage();
            addProductToOrder = new Button();
            amountToOrderProduct = new NumericUpDown();
            label1 = new Label();
            codeProductToAdd = new TextBox();
            label2 = new Label();
            deleteProduct = new TabPage();
            deleteFromOrder = new Button();
            codeProductInputTםDelete = new TextBox();
            nameProductLable = new Label();
            myOrder = new ListBox();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            add.SuspendLayout();
            addProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)amountToOrderProduct).BeginInit();
            deleteProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(204, -39);
            label6.Name = "label6";
            label6.Size = new Size(103, 20);
            label6.TabIndex = 33;
            label6.Text = "רשימת מוצרים";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(554, 53);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 32;
            label5.Text = "הסל שלי";
            // 
            // helloName
            // 
            helloName.Anchor = AnchorStyles.Top;
            helloName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            helloName.Location = new Point(678, 41);
            helloName.Name = "helloName";
            helloName.ReadOnly = true;
            helloName.RightToLeft = RightToLeft.Yes;
            helloName.Size = new Size(110, 31);
            helloName.TabIndex = 31;
            helloName.TextChanged += helloName_TextChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Shantell Sans Medium", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(784, 42);
            label4.Name = "label4";
            label4.Size = new Size(80, 31);
            label4.TabIndex = 30;
            label4.Text = "שלום ל";
            // 
            // listProduct
            // 
            listProduct.Anchor = AnchorStyles.Left;
            listProduct.FormattingEnabled = true;
            listProduct.ItemHeight = 20;
            listProduct.Location = new Point(1252, 61);
            listProduct.Name = "listProduct";
            listProduct.Size = new Size(297, 484);
            listProduct.TabIndex = 29;
            // 
            // sumOrder
            // 
            sumOrder.Anchor = AnchorStyles.Bottom;
            sumOrder.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            sumOrder.Location = new Point(625, 507);
            sumOrder.Name = "sumOrder";
            sumOrder.ReadOnly = true;
            sumOrder.Size = new Size(164, 30);
            sumOrder.TabIndex = 28;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(798, 507);
            label3.Name = "label3";
            label3.Size = new Size(133, 28);
            label3.TabIndex = 27;
            label3.Text = "סכום לתשלום";
            // 
            // endOrder
            // 
            endOrder.Anchor = AnchorStyles.Bottom;
            endOrder.Location = new Point(574, 543);
            endOrder.Name = "endOrder";
            endOrder.Size = new Size(383, 69);
            endOrder.TabIndex = 26;
            endOrder.Text = "סיום הזמנה";
            endOrder.UseVisualStyleBackColor = true;
            endOrder.Click += endOrder_Click;
            // 
            // add
            // 
            add.Anchor = AnchorStyles.Left;
            add.Controls.Add(addProduct);
            add.Controls.Add(deleteProduct);
            add.Location = new Point(740, 108);
            add.Name = "add";
            add.RightToLeft = RightToLeft.Yes;
            add.RightToLeftLayout = true;
            add.SelectedIndex = 0;
            add.Size = new Size(456, 438);
            add.TabIndex = 25;
            // 
            // addProduct
            // 
            addProduct.Controls.Add(label6);
            addProduct.Controls.Add(addProductToOrder);
            addProduct.Controls.Add(amountToOrderProduct);
            addProduct.Controls.Add(label1);
            addProduct.Controls.Add(codeProductToAdd);
            addProduct.Controls.Add(label2);
            addProduct.Location = new Point(4, 29);
            addProduct.Name = "addProduct";
            addProduct.Padding = new Padding(3);
            addProduct.Size = new Size(448, 405);
            addProduct.TabIndex = 2;
            addProduct.Text = "הוספת מוצר";
            addProduct.UseVisualStyleBackColor = true;
            // 
            // addProductToOrder
            // 
            addProductToOrder.Location = new Point(119, 342);
            addProductToOrder.Name = "addProductToOrder";
            addProductToOrder.Size = new Size(224, 37);
            addProductToOrder.TabIndex = 19;
            addProductToOrder.Text = "הוסף להזמנה";
            addProductToOrder.UseVisualStyleBackColor = true;
            addProductToOrder.Click += addProductToOrder_Click;
            // 
            // amountToOrderProduct
            // 
            amountToOrderProduct.Location = new Point(107, 166);
            amountToOrderProduct.Name = "amountToOrderProduct";
            amountToOrderProduct.Size = new Size(131, 27);
            amountToOrderProduct.TabIndex = 18;
            amountToOrderProduct.ValueChanged += amountToOrderProduct_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(256, 169);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 17;
            label1.Text = "כמות להזמנה";
            // 
            // codeProductToAdd
            // 
            codeProductToAdd.Location = new Point(128, 121);
            codeProductToAdd.Name = "codeProductToAdd";
            codeProductToAdd.Size = new Size(110, 27);
            codeProductToAdd.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(272, 124);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 15;
            label2.Text = "קוד מוצר";
            // 
            // deleteProduct
            // 
            deleteProduct.Controls.Add(deleteFromOrder);
            deleteProduct.Controls.Add(codeProductInputTםDelete);
            deleteProduct.Controls.Add(nameProductLable);
            deleteProduct.Location = new Point(4, 29);
            deleteProduct.Name = "deleteProduct";
            deleteProduct.Size = new Size(448, 405);
            deleteProduct.TabIndex = 3;
            deleteProduct.Text = "מחיקת מוצר";
            deleteProduct.UseVisualStyleBackColor = true;
            // 
            // deleteFromOrder
            // 
            deleteFromOrder.Location = new Point(127, 234);
            deleteFromOrder.Name = "deleteFromOrder";
            deleteFromOrder.Size = new Size(205, 37);
            deleteFromOrder.TabIndex = 14;
            deleteFromOrder.Text = "מחק מההזמנה";
            deleteFromOrder.UseVisualStyleBackColor = true;
            deleteFromOrder.Click += deleteFromOrder_Click;
            // 
            // codeProductInputTםDelete
            // 
            codeProductInputTםDelete.Location = new Point(124, 97);
            codeProductInputTםDelete.Name = "codeProductInputTםDelete";
            codeProductInputTםDelete.Size = new Size(110, 27);
            codeProductInputTםDelete.TabIndex = 11;
            // 
            // nameProductLable
            // 
            nameProductLable.AutoSize = true;
            nameProductLable.Location = new Point(267, 100);
            nameProductLable.Name = "nameProductLable";
            nameProductLable.Size = new Size(65, 20);
            nameProductLable.TabIndex = 10;
            nameProductLable.Text = "קוד מוצר";
            // 
            // myOrder
            // 
            myOrder.Anchor = AnchorStyles.Left;
            myOrder.FormattingEnabled = true;
            myOrder.ItemHeight = 20;
            myOrder.Location = new Point(341, 58);
            myOrder.Name = "myOrder";
            myOrder.Size = new Size(294, 484);
            myOrder.TabIndex = 24;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ImageToStl_com_pandora_logo;
            pictureBox1.Location = new Point(42, 39);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(258, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(1436, 48);
            label7.Name = "label7";
            label7.Size = new Size(103, 20);
            label7.TabIndex = 34;
            label7.Text = "רשימת מוצרים";
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 234, 231);
            ClientSize = new Size(1580, 667);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(listProduct);
            Controls.Add(label5);
            Controls.Add(helloName);
            Controls.Add(label4);
            Controls.Add(sumOrder);
            Controls.Add(label3);
            Controls.Add(endOrder);
            Controls.Add(add);
            Controls.Add(myOrder);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "OrderForm";
            Text = "OrderForm";
            WindowState = FormWindowState.Maximized;
            Load += OrderForm_Load;
            add.ResumeLayout(false);
            addProduct.ResumeLayout(false);
            addProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)amountToOrderProduct).EndInit();
            deleteProduct.ResumeLayout(false);
            deleteProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private TextBox helloName;
        private Label label4;
        private ListBox listProduct;
        private TextBox sumOrder;
        private Label label3;
        private Button endOrder;
        private TabControl add;
        private TabPage addProduct;
        private Button addProductToOrder;
        private NumericUpDown amountToOrderProduct;
        private Label label1;
        private TextBox codeProductToAdd;
        private Label label2;
        private TabPage deleteProduct;
        private Button deleteFromOrder;
        private TextBox codeProductInputTםDelete;
        private Label nameProductLable;
        private ListBox myOrder;
        private PictureBox pictureBox1;
        private Label label7;
    }
}