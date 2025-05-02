namespace UI
{
    partial class ProductsMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsMenu));
            filterCategory = new ComboBox();
            label11 = new Label();
            productsList = new ListBox();
            add = new TabControl();
            addCustomer = new TabPage();
            amountInput = new NumericUpDown();
            amountLable = new Label();
            categoryInput = new ComboBox();
            category = new Label();
            addProduct = new Button();
            priceInput = new NumericUpDown();
            nameProductInput = new TextBox();
            priceLable = new Label();
            nameProductLable = new Label();
            update = new TabPage();
            searchBtn = new Button();
            codeProductInput = new TextBox();
            label5 = new Label();
            amount = new NumericUpDown();
            label1 = new Label();
            categoryUpdate = new ComboBox();
            label2 = new Label();
            updateBtn = new Button();
            price = new NumericUpDown();
            nameProduct = new TextBox();
            label3 = new Label();
            label4 = new Label();
            delete = new TabPage();
            deleteBtn = new Button();
            codeInputToDelete = new TextBox();
            codeProductToDelete = new Label();
            detailProduct = new TabPage();
            detailProductOne = new ListBox();
            showDetailsProduct = new Button();
            idProductSearch = new TextBox();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            add.SuspendLayout();
            addCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)amountInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)priceInput).BeginInit();
            update.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)amount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)price).BeginInit();
            delete.SuspendLayout();
            detailProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // filterCategory
            // 
            filterCategory.Anchor = AnchorStyles.Right;
            filterCategory.FormattingEnabled = true;
            filterCategory.Items.AddRange(new object[] { "Necklaces ", "Bracelets", "Earrings", "Rings", "Watches      " });
            filterCategory.Location = new Point(89, 21);
            filterCategory.Margin = new Padding(3, 2, 3, 2);
            filterCategory.Name = "filterCategory";
            filterCategory.Size = new Size(181, 23);
            filterCategory.TabIndex = 11;
            filterCategory.SelectedIndexChanged += filterCategory_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new Point(220, 24);
            label11.Name = "label11";
            label11.Size = new Size(89, 15);
            label11.TabIndex = 10;
            label11.Text = "סנן לפי קטגוריה";
            // 
            // productsList
            // 
            productsList.Anchor = AnchorStyles.Right;
            productsList.FormattingEnabled = true;
            productsList.ItemHeight = 15;
            productsList.Location = new Point(77, 51);
            productsList.Margin = new Padding(2);
            productsList.Name = "productsList";
            productsList.Size = new Size(288, 244);
            productsList.TabIndex = 8;
            productsList.SelectedIndexChanged += productsList_SelectedIndexChanged;
            // 
            // add
            // 
            add.Anchor = AnchorStyles.Left;
            add.Controls.Add(addCustomer);
            add.Controls.Add(update);
            add.Controls.Add(delete);
            add.Controls.Add(detailProduct);
            add.Location = new Point(353, 11);
            add.Margin = new Padding(3, 2, 3, 2);
            add.Name = "add";
            add.RightToLeft = RightToLeft.Yes;
            add.RightToLeftLayout = true;
            add.SelectedIndex = 0;
            add.Size = new Size(510, 286);
            add.TabIndex = 9;
            // 
            // addCustomer
            // 
            addCustomer.Controls.Add(amountInput);
            addCustomer.Controls.Add(amountLable);
            addCustomer.Controls.Add(categoryInput);
            addCustomer.Controls.Add(category);
            addCustomer.Controls.Add(addProduct);
            addCustomer.Controls.Add(priceInput);
            addCustomer.Controls.Add(nameProductInput);
            addCustomer.Controls.Add(priceLable);
            addCustomer.Controls.Add(nameProductLable);
            addCustomer.Location = new Point(4, 24);
            addCustomer.Margin = new Padding(3, 2, 3, 2);
            addCustomer.Name = "addCustomer";
            addCustomer.Padding = new Padding(3, 2, 3, 2);
            addCustomer.Size = new Size(502, 258);
            addCustomer.TabIndex = 0;
            addCustomer.Text = "הוספה";
            addCustomer.UseVisualStyleBackColor = true;
            // 
            // amountInput
            // 
            amountInput.Location = new Point(134, 127);
            amountInput.Margin = new Padding(3, 2, 3, 2);
            amountInput.Name = "amountInput";
            amountInput.Size = new Size(115, 23);
            amountInput.TabIndex = 8;
            // 
            // amountLable
            // 
            amountLable.AutoSize = true;
            amountLable.Location = new Point(289, 132);
            amountLable.Name = "amountLable";
            amountLable.Size = new Size(34, 15);
            amountLable.TabIndex = 7;
            amountLable.Text = "כמות";
            // 
            // categoryInput
            // 
            categoryInput.FormattingEnabled = true;
            categoryInput.Items.AddRange(new object[] { "Necklaces ", "Bracelets", "Rings    ", "Earrings  ", "Watches      " });
            categoryInput.Location = new Point(133, 83);
            categoryInput.Margin = new Padding(3, 2, 3, 2);
            categoryInput.Name = "categoryInput";
            categoryInput.Size = new Size(117, 23);
            categoryInput.TabIndex = 6;
            // 
            // category
            // 
            category.AutoSize = true;
            category.Location = new Point(277, 84);
            category.Name = "category";
            category.Size = new Size(49, 15);
            category.TabIndex = 5;
            category.Text = "קטגוריה";
            // 
            // addProduct
            // 
            addProduct.Location = new Point(190, 176);
            addProduct.Margin = new Padding(3, 2, 3, 2);
            addProduct.Name = "addProduct";
            addProduct.Size = new Size(85, 20);
            addProduct.TabIndex = 4;
            addProduct.Text = "שמור";
            addProduct.UseVisualStyleBackColor = true;
            addProduct.Click += addProduct_Click;
            // 
            // priceInput
            // 
            priceInput.Location = new Point(133, 104);
            priceInput.Margin = new Padding(3, 2, 3, 2);
            priceInput.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            priceInput.Name = "priceInput";
            priceInput.Size = new Size(115, 23);
            priceInput.TabIndex = 3;
            // 
            // nameProductInput
            // 
            nameProductInput.Location = new Point(152, 56);
            nameProductInput.Margin = new Padding(3, 2, 3, 2);
            nameProductInput.Name = "nameProductInput";
            nameProductInput.Size = new Size(97, 23);
            nameProductInput.TabIndex = 2;
            // 
            // priceLable
            // 
            priceLable.AutoSize = true;
            priceLable.Location = new Point(290, 109);
            priceLable.Name = "priceLable";
            priceLable.Size = new Size(33, 15);
            priceLable.TabIndex = 1;
            priceLable.Text = "מחיר";
            // 
            // nameProductLable
            // 
            nameProductLable.AutoSize = true;
            nameProductLable.Location = new Point(274, 58);
            nameProductLable.Name = "nameProductLable";
            nameProductLable.Size = new Size(52, 15);
            nameProductLable.TabIndex = 0;
            nameProductLable.Text = "שם מוצר";
            // 
            // update
            // 
            update.Controls.Add(searchBtn);
            update.Controls.Add(codeProductInput);
            update.Controls.Add(label5);
            update.Controls.Add(amount);
            update.Controls.Add(label1);
            update.Controls.Add(categoryUpdate);
            update.Controls.Add(label2);
            update.Controls.Add(updateBtn);
            update.Controls.Add(price);
            update.Controls.Add(nameProduct);
            update.Controls.Add(label3);
            update.Controls.Add(label4);
            update.Location = new Point(4, 24);
            update.Margin = new Padding(3, 2, 3, 2);
            update.Name = "update";
            update.Padding = new Padding(3, 2, 3, 2);
            update.Size = new Size(502, 258);
            update.TabIndex = 1;
            update.Text = "עדכון";
            update.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(21, 16);
            searchBtn.Margin = new Padding(2);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(65, 25);
            searchBtn.TabIndex = 20;
            searchBtn.Text = "חפש";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // codeProductInput
            // 
            codeProductInput.Location = new Point(149, 41);
            codeProductInput.Margin = new Padding(3, 2, 3, 2);
            codeProductInput.Name = "codeProductInput";
            codeProductInput.Size = new Size(92, 23);
            codeProductInput.TabIndex = 19;
            codeProductInput.TextChanged += codeProductInput_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(253, 44);
            label5.Name = "label5";
            label5.Size = new Size(122, 15);
            label5.TabIndex = 18;
            label5.Text = "הכנס קוד מוצר לעידכון";
            // 
            // amount
            // 
            amount.Location = new Point(151, 146);
            amount.Margin = new Padding(3, 2, 3, 2);
            amount.Name = "amount";
            amount.Size = new Size(115, 23);
            amount.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(309, 154);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 16;
            label1.Text = "כמות";
            // 
            // categoryUpdate
            // 
            categoryUpdate.FormattingEnabled = true;
            categoryUpdate.Items.AddRange(new object[] { "Necklaces ", "Bracelets", "Rings    ", "Earrings  ", "Watches      " });
            categoryUpdate.Location = new Point(149, 103);
            categoryUpdate.Margin = new Padding(3, 2, 3, 2);
            categoryUpdate.Name = "categoryUpdate";
            categoryUpdate.Size = new Size(117, 23);
            categoryUpdate.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(297, 106);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 14;
            label2.Text = "קטגוריה";
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(217, 198);
            updateBtn.Margin = new Padding(3, 2, 3, 2);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(85, 27);
            updateBtn.TabIndex = 13;
            updateBtn.Text = "עדכן";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // price
            // 
            price.Location = new Point(151, 122);
            price.Margin = new Padding(3, 2, 3, 2);
            price.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            price.Name = "price";
            price.Size = new Size(115, 23);
            price.TabIndex = 12;
            // 
            // nameProduct
            // 
            nameProduct.Location = new Point(169, 79);
            nameProduct.Margin = new Padding(3, 2, 3, 2);
            nameProduct.Name = "nameProduct";
            nameProduct.Size = new Size(97, 23);
            nameProduct.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(310, 130);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 10;
            label3.Text = "מחיר";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(297, 79);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 9;
            label4.Text = "שם מוצר";
            // 
            // delete
            // 
            delete.Controls.Add(deleteBtn);
            delete.Controls.Add(codeInputToDelete);
            delete.Controls.Add(codeProductToDelete);
            delete.Location = new Point(4, 24);
            delete.Margin = new Padding(3, 2, 3, 2);
            delete.Name = "delete";
            delete.Padding = new Padding(3, 2, 3, 2);
            delete.Size = new Size(502, 258);
            delete.TabIndex = 2;
            delete.Text = "מחיקה";
            delete.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(196, 171);
            deleteBtn.Margin = new Padding(3, 2, 3, 2);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(96, 26);
            deleteBtn.TabIndex = 2;
            deleteBtn.Text = "מחיקה";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // codeInputToDelete
            // 
            codeInputToDelete.Location = new Point(195, 79);
            codeInputToDelete.Margin = new Padding(3, 2, 3, 2);
            codeInputToDelete.Name = "codeInputToDelete";
            codeInputToDelete.Size = new Size(97, 23);
            codeInputToDelete.TabIndex = 1;
            // 
            // codeProductToDelete
            // 
            codeProductToDelete.AutoSize = true;
            codeProductToDelete.Location = new Point(185, 59);
            codeProductToDelete.Name = "codeProductToDelete";
            codeProductToDelete.Size = new Size(125, 15);
            codeProductToDelete.TabIndex = 0;
            codeProductToDelete.Text = "הקש קוד מוצר למחיקה";
            // 
            // detailProduct
            // 
            detailProduct.Controls.Add(detailProductOne);
            detailProduct.Controls.Add(showDetailsProduct);
            detailProduct.Controls.Add(idProductSearch);
            detailProduct.Controls.Add(label10);
            detailProduct.Location = new Point(4, 24);
            detailProduct.Margin = new Padding(3, 2, 3, 2);
            detailProduct.Name = "detailProduct";
            detailProduct.Size = new Size(502, 258);
            detailProduct.TabIndex = 3;
            detailProduct.Text = "פרטי מוצר";
            detailProduct.UseVisualStyleBackColor = true;
            // 
            // detailProductOne
            // 
            detailProductOne.FormattingEnabled = true;
            detailProductOne.ItemHeight = 15;
            detailProductOne.Location = new Point(113, 145);
            detailProductOne.Margin = new Padding(3, 2, 3, 2);
            detailProductOne.Name = "detailProductOne";
            detailProductOne.RightToLeft = RightToLeft.No;
            detailProductOne.Size = new Size(233, 79);
            detailProductOne.TabIndex = 9;
            // 
            // showDetailsProduct
            // 
            showDetailsProduct.Location = new Point(188, 115);
            showDetailsProduct.Margin = new Padding(3, 2, 3, 2);
            showDetailsProduct.Name = "showDetailsProduct";
            showDetailsProduct.Size = new Size(105, 24);
            showDetailsProduct.TabIndex = 8;
            showDetailsProduct.Text = "הצג פרטי מוצר";
            showDetailsProduct.UseVisualStyleBackColor = true;
            showDetailsProduct.Click += showDetailsProduct_Click;
            // 
            // idProductSearch
            // 
            idProductSearch.Location = new Point(138, 45);
            idProductSearch.Margin = new Padding(3, 2, 3, 2);
            idProductSearch.Name = "idProductSearch";
            idProductSearch.Size = new Size(97, 23);
            idProductSearch.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(241, 49);
            label10.Name = "label10";
            label10.Size = new Size(83, 15);
            label10.TabIndex = 6;
            label10.Text = "הכנס קוד מוצר";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ImageToStl_com_pandora_logo;
            pictureBox1.Location = new Point(65, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(226, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // ProductsMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 234, 231);
            ClientSize = new Size(873, 338);
            Controls.Add(pictureBox1);
            Controls.Add(filterCategory);
            Controls.Add(label11);
            Controls.Add(productsList);
            Controls.Add(add);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "ProductsMenu";
            Text = "ProductsMenu";
            WindowState = FormWindowState.Maximized;
            Load += ProductsMenu_Load;
            add.ResumeLayout(false);
            addCustomer.ResumeLayout(false);
            addCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)amountInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)priceInput).EndInit();
            update.ResumeLayout(false);
            update.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)amount).EndInit();
            ((System.ComponentModel.ISupportInitialize)price).EndInit();
            delete.ResumeLayout(false);
            delete.PerformLayout();
            detailProduct.ResumeLayout(false);
            detailProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox filterCategory;
        private Label label11;
        private ListBox productsList;
        private TabControl add;
        private TabPage addCustomer;
        private NumericUpDown amountInput;
        private Label amountLable;
        private ComboBox categoryInput;
        private Label category;
        private Button addProduct;
        private NumericUpDown priceInput;
        private TextBox nameProductInput;
        private Label priceLable;
        private Label nameProductLable;
        private TabPage update;
        private Button searchBtn;
        private TextBox codeProductInput;
        private Label label5;
        private NumericUpDown amount;
        private Label label1;
        private ComboBox categoryUpdate;
        private Label label2;
        private Button updateBtn;
        private NumericUpDown price;
        private TextBox nameProduct;
        private Label label3;
        private Label label4;
        private TabPage delete;
        private Button deleteBtn;
        private TextBox codeInputToDelete;
        private Label codeProductToDelete;
        private TabPage detailProduct;
        private ListBox detailProductOne;
        private Button showDetailsProduct;
        private TextBox idProductSearch;
        private Label label10;
        private PictureBox pictureBox1;
    }
}