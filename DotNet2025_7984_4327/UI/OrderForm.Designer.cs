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
            add.SuspendLayout();
            addProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)amountToOrderProduct).BeginInit();
            deleteProduct.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(671, 56);
            label6.Name = "label6";
            label6.Size = new Size(103, 20);
            label6.TabIndex = 33;
            label6.Text = "רשימת מוצרים";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(79, 59);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 32;
            label5.Text = "הסל שלי";
            // 
            // helloName
            // 
            helloName.Location = new Point(330, 14);
            helloName.Margin = new Padding(3, 2, 3, 2);
            helloName.Name = "helloName";
            helloName.ReadOnly = true;
            helloName.RightToLeft = RightToLeft.Yes;
            helloName.Size = new Size(110, 27);
            helloName.TabIndex = 31;
            helloName.TextChanged += helloName_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(436, 17);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 30;
            label4.Text = "שלום ל";
            // 
            // listProduct
            // 
            listProduct.FormattingEnabled = true;
            listProduct.ItemHeight = 20;
            listProduct.Location = new Point(598, 72);
            listProduct.Margin = new Padding(3, 2, 3, 2);
            listProduct.Name = "listProduct";
            listProduct.Size = new Size(213, 244);
            listProduct.TabIndex = 29;
            // 
            // sumOrder
            // 
            sumOrder.Location = new Point(336, 350);
            sumOrder.Margin = new Padding(3, 2, 3, 2);
            sumOrder.Name = "sumOrder";
            sumOrder.ReadOnly = true;
            sumOrder.Size = new Size(106, 27);
            sumOrder.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(450, 353);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 27;
            label3.Text = "סכום לתשלום";
            // 
            // endOrder
            // 
            endOrder.Location = new Point(270, 389);
            endOrder.Margin = new Padding(3, 2, 3, 2);
            endOrder.Name = "endOrder";
            endOrder.Size = new Size(259, 40);
            endOrder.TabIndex = 26;
            endOrder.Text = "סיום הזמנה";
            endOrder.UseVisualStyleBackColor = true;
            endOrder.Click += endOrder_Click;
            // 
            // add
            // 
            add.Controls.Add(addProduct);
            add.Controls.Add(deleteProduct);
            add.Location = new Point(220, 77);
            add.Margin = new Padding(3, 2, 3, 2);
            add.Name = "add";
            add.RightToLeft = RightToLeft.Yes;
            add.RightToLeftLayout = true;
            add.SelectedIndex = 0;
            add.Size = new Size(376, 242);
            add.TabIndex = 25;
            // 
            // addProduct
            // 
            addProduct.Controls.Add(addProductToOrder);
            addProduct.Controls.Add(amountToOrderProduct);
            addProduct.Controls.Add(label1);
            addProduct.Controls.Add(codeProductToAdd);
            addProduct.Controls.Add(label2);
            addProduct.Location = new Point(4, 29);
            addProduct.Margin = new Padding(3, 2, 3, 2);
            addProduct.Name = "addProduct";
            addProduct.Padding = new Padding(3, 2, 3, 2);
            addProduct.Size = new Size(368, 209);
            addProduct.TabIndex = 2;
            addProduct.Text = "הוספת מוצר";
            addProduct.UseVisualStyleBackColor = true;
            // 
            // addProductToOrder
            // 
            addProductToOrder.Location = new Point(86, 119);
            addProductToOrder.Margin = new Padding(3, 2, 3, 2);
            addProductToOrder.Name = "addProductToOrder";
            addProductToOrder.Size = new Size(224, 38);
            addProductToOrder.TabIndex = 19;
            addProductToOrder.Text = "הוסף להזמנה";
            addProductToOrder.UseVisualStyleBackColor = true;
            addProductToOrder.Click += addProductToOrder_Click;
            // 
            // amountToOrderProduct
            // 
            amountToOrderProduct.Location = new Point(86, 65);
            amountToOrderProduct.Margin = new Padding(3, 2, 3, 2);
            amountToOrderProduct.Name = "amountToOrderProduct";
            amountToOrderProduct.Size = new Size(131, 27);
            amountToOrderProduct.TabIndex = 18;
            amountToOrderProduct.ValueChanged += amountToOrderProduct_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(236, 69);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 17;
            label1.Text = "כמות להזמנה";
            // 
            // codeProductToAdd
            // 
            codeProductToAdd.Location = new Point(107, 22);
            codeProductToAdd.Margin = new Padding(3, 2, 3, 2);
            codeProductToAdd.Name = "codeProductToAdd";
            codeProductToAdd.Size = new Size(110, 27);
            codeProductToAdd.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(252, 27);
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
            deleteProduct.Size = new Size(368, 209);
            deleteProduct.TabIndex = 3;
            deleteProduct.Text = "מחיקת מוצר";
            deleteProduct.UseVisualStyleBackColor = true;
            // 
            // deleteFromOrder
            // 
            deleteFromOrder.Location = new Point(108, 97);
            deleteFromOrder.Margin = new Padding(3, 2, 3, 2);
            deleteFromOrder.Name = "deleteFromOrder";
            deleteFromOrder.Size = new Size(205, 38);
            deleteFromOrder.TabIndex = 14;
            deleteFromOrder.Text = "מחק מההזמנה";
            deleteFromOrder.UseVisualStyleBackColor = true;
            deleteFromOrder.Click += deleteFromOrder_Click;
            // 
            // codeProductInputTםDelete
            // 
            codeProductInputTםDelete.Location = new Point(108, 49);
            codeProductInputTםDelete.Margin = new Padding(3, 2, 3, 2);
            codeProductInputTםDelete.Name = "codeProductInputTםDelete";
            codeProductInputTםDelete.Size = new Size(110, 27);
            codeProductInputTםDelete.TabIndex = 11;
            // 
            // nameProductLable
            // 
            nameProductLable.AutoSize = true;
            nameProductLable.Location = new Point(250, 52);
            nameProductLable.Name = "nameProductLable";
            nameProductLable.Size = new Size(65, 20);
            nameProductLable.TabIndex = 10;
            nameProductLable.Text = "קוד מוצר";
            // 
            // myOrder
            // 
            myOrder.FormattingEnabled = true;
            myOrder.ItemHeight = 20;
            myOrder.Location = new Point(12, 72);
            myOrder.Margin = new Padding(3, 2, 3, 2);
            myOrder.Name = "myOrder";
            myOrder.Size = new Size(206, 244);
            myOrder.TabIndex = 24;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(helloName);
            Controls.Add(label4);
            Controls.Add(listProduct);
            Controls.Add(sumOrder);
            Controls.Add(label3);
            Controls.Add(endOrder);
            Controls.Add(add);
            Controls.Add(myOrder);
            Name = "OrderForm";
            Text = "OrderForm";
            Load += OrderForm_Load;
            add.ResumeLayout(false);
            addProduct.ResumeLayout(false);
            addProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)amountToOrderProduct).EndInit();
            deleteProduct.ResumeLayout(false);
            deleteProduct.PerformLayout();
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
    }
}