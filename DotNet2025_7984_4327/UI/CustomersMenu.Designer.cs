﻿namespace UI
{
    partial class CustomersMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersMenu));
            filterByPhone = new TextBox();
            label11 = new Label();
            customersList = new ListBox();
            add = new TabControl();
            addCustomer = new TabPage();
            addButton = new Button();
            CustomerAddressInput = new TextBox();
            CustomerTelInput = new TextBox();
            label6 = new Label();
            label7 = new Label();
            CustomerIdInput = new TextBox();
            label8 = new Label();
            CustomerNameInput = new TextBox();
            label9 = new Label();
            update = new TabPage();
            addressCustomerUpdate = new TextBox();
            phoneCustomerUpdate = new TextBox();
            label1 = new Label();
            label2 = new Label();
            idCustomerUpdate = new TextBox();
            label3 = new Label();
            nameCustomerUpdate = new TextBox();
            label4 = new Label();
            searchBtnCustomerUpdate = new Button();
            codeCustomerInput = new TextBox();
            label5 = new Label();
            updateBtnCustomer = new Button();
            delete = new TabPage();
            deleteBtnCustomer = new Button();
            codeCustomerInputToDelete = new TextBox();
            codeCustomerToDelete = new Label();
            detailsCustomer = new TabPage();
            detailCustomer = new ListBox();
            showDetailsCustomer = new Button();
            idCustomerDisplay = new TextBox();
            label10 = new Label();
            customerList = new Label();
            pictureBox1 = new PictureBox();
            add.SuspendLayout();
            addCustomer.SuspendLayout();
            update.SuspendLayout();
            delete.SuspendLayout();
            detailsCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // filterByPhone
            // 
            filterByPhone.Anchor = AnchorStyles.Right;
            filterByPhone.Location = new Point(228, 139);
            filterByPhone.Margin = new Padding(3, 2, 3, 2);
            filterByPhone.Name = "filterByPhone";
            filterByPhone.Size = new Size(145, 23);
            filterByPhone.TabIndex = 9;
            filterByPhone.TextChanged += filterByPhone_TextChanged;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new Point(377, 143);
            label11.Name = "label11";
            label11.Size = new Size(110, 15);
            label11.TabIndex = 8;
            label11.Text = "סנן לפי מספר טלפון";
            // 
            // customersList
            // 
            customersList.Anchor = AnchorStyles.Right;
            customersList.FormattingEnabled = true;
            customersList.ItemHeight = 15;
            customersList.Location = new Point(227, 174);
            customersList.Margin = new Padding(2);
            customersList.Name = "customersList";
            customersList.Size = new Size(260, 244);
            customersList.TabIndex = 6;
            customersList.SelectedIndexChanged += customersList_SelectedIndexChanged;
            // 
            // add
            // 
            add.Anchor = AnchorStyles.Left;
            add.Controls.Add(addCustomer);
            add.Controls.Add(update);
            add.Controls.Add(delete);
            add.Controls.Add(detailsCustomer);
            add.Location = new Point(444, 104);
            add.Margin = new Padding(3, 2, 3, 2);
            add.Name = "add";
            add.RightToLeft = RightToLeft.Yes;
            add.RightToLeftLayout = true;
            add.SelectedIndex = 0;
            add.Size = new Size(434, 316);
            add.TabIndex = 7;
            // 
            // addCustomer
            // 
            addCustomer.Controls.Add(addButton);
            addCustomer.Controls.Add(CustomerAddressInput);
            addCustomer.Controls.Add(CustomerTelInput);
            addCustomer.Controls.Add(label6);
            addCustomer.Controls.Add(label7);
            addCustomer.Controls.Add(CustomerIdInput);
            addCustomer.Controls.Add(label8);
            addCustomer.Controls.Add(CustomerNameInput);
            addCustomer.Controls.Add(label9);
            addCustomer.Location = new Point(4, 24);
            addCustomer.Margin = new Padding(3, 2, 3, 2);
            addCustomer.Name = "addCustomer";
            addCustomer.Padding = new Padding(3, 2, 3, 2);
            addCustomer.Size = new Size(426, 288);
            addCustomer.TabIndex = 0;
            addCustomer.Text = "הוספה";
            addCustomer.UseVisualStyleBackColor = true;
            addCustomer.Click += addCustomer_Click;
            // 
            // addButton
            // 
            addButton.ImeMode = ImeMode.NoControl;
            addButton.Location = new Point(171, 174);
            addButton.Margin = new Padding(3, 2, 3, 2);
            addButton.Name = "addButton";
            addButton.Size = new Size(101, 37);
            addButton.TabIndex = 17;
            addButton.Text = "הוספה";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // CustomerAddressInput
            // 
            CustomerAddressInput.Location = new Point(133, 107);
            CustomerAddressInput.Margin = new Padding(3, 2, 3, 2);
            CustomerAddressInput.Name = "CustomerAddressInput";
            CustomerAddressInput.Size = new Size(83, 23);
            CustomerAddressInput.TabIndex = 16;
            CustomerAddressInput.TextChanged += CustomerAddressInput_TextChanged;
            // 
            // CustomerTelInput
            // 
            CustomerTelInput.Location = new Point(133, 130);
            CustomerTelInput.Margin = new Padding(3, 2, 3, 2);
            CustomerTelInput.Name = "CustomerTelInput";
            CustomerTelInput.Size = new Size(83, 23);
            CustomerTelInput.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(236, 134);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 14;
            label6.Text = "טלפון";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ImeMode = ImeMode.NoControl;
            label7.Location = new Point(236, 110);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 13;
            label7.Text = "כתובת";
            // 
            // CustomerIdInput
            // 
            CustomerIdInput.Location = new Point(133, 85);
            CustomerIdInput.Margin = new Padding(3, 2, 3, 2);
            CustomerIdInput.Name = "CustomerIdInput";
            CustomerIdInput.Size = new Size(83, 23);
            CustomerIdInput.TabIndex = 12;
            CustomerIdInput.TextChanged += CustomerIdInput_TextChanged;
            CustomerIdInput.KeyPress += CustomerIdInput_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ImeMode = ImeMode.NoControl;
            label8.Location = new Point(236, 86);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 11;
            label8.Text = "מספר זהות";
            // 
            // CustomerNameInput
            // 
            CustomerNameInput.Location = new Point(133, 63);
            CustomerNameInput.Margin = new Padding(3, 2, 3, 2);
            CustomerNameInput.Name = "CustomerNameInput";
            CustomerNameInput.Size = new Size(83, 23);
            CustomerNameInput.TabIndex = 10;
            CustomerNameInput.KeyPress += CustomerNameInput_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ImeMode = ImeMode.NoControl;
            label9.Location = new Point(236, 67);
            label9.Name = "label9";
            label9.Size = new Size(61, 15);
            label9.TabIndex = 9;
            label9.Text = "שם הלקוח";
            // 
            // update
            // 
            update.Controls.Add(addressCustomerUpdate);
            update.Controls.Add(phoneCustomerUpdate);
            update.Controls.Add(label1);
            update.Controls.Add(label2);
            update.Controls.Add(idCustomerUpdate);
            update.Controls.Add(label3);
            update.Controls.Add(nameCustomerUpdate);
            update.Controls.Add(label4);
            update.Controls.Add(searchBtnCustomerUpdate);
            update.Controls.Add(codeCustomerInput);
            update.Controls.Add(label5);
            update.Controls.Add(updateBtnCustomer);
            update.Location = new Point(4, 24);
            update.Margin = new Padding(3, 2, 3, 2);
            update.Name = "update";
            update.Padding = new Padding(3, 2, 3, 2);
            update.Size = new Size(426, 288);
            update.TabIndex = 1;
            update.Text = "עדכון";
            update.UseVisualStyleBackColor = true;
            // 
            // addressCustomerUpdate
            // 
            addressCustomerUpdate.Location = new Point(151, 130);
            addressCustomerUpdate.Margin = new Padding(3, 2, 3, 2);
            addressCustomerUpdate.Name = "addressCustomerUpdate";
            addressCustomerUpdate.Size = new Size(83, 23);
            addressCustomerUpdate.TabIndex = 28;
            // 
            // phoneCustomerUpdate
            // 
            phoneCustomerUpdate.Location = new Point(151, 156);
            phoneCustomerUpdate.Margin = new Padding(3, 2, 3, 2);
            phoneCustomerUpdate.Name = "phoneCustomerUpdate";
            phoneCustomerUpdate.Size = new Size(83, 23);
            phoneCustomerUpdate.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(254, 160);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 26;
            label1.Text = "טלפון";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(254, 133);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 25;
            label2.Text = "כתובת";
            // 
            // idCustomerUpdate
            // 
            idCustomerUpdate.Location = new Point(151, 108);
            idCustomerUpdate.Margin = new Padding(3, 2, 3, 2);
            idCustomerUpdate.Name = "idCustomerUpdate";
            idCustomerUpdate.Size = new Size(83, 23);
            idCustomerUpdate.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(254, 109);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 23;
            label3.Text = "מספר זהות";
            // 
            // nameCustomerUpdate
            // 
            nameCustomerUpdate.Location = new Point(151, 86);
            nameCustomerUpdate.Margin = new Padding(3, 2, 3, 2);
            nameCustomerUpdate.Name = "nameCustomerUpdate";
            nameCustomerUpdate.Size = new Size(83, 23);
            nameCustomerUpdate.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(254, 90);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 21;
            label4.Text = "שם הלקוח";
            // 
            // searchBtnCustomerUpdate
            // 
            searchBtnCustomerUpdate.Location = new Point(10, 9);
            searchBtnCustomerUpdate.Margin = new Padding(2);
            searchBtnCustomerUpdate.Name = "searchBtnCustomerUpdate";
            searchBtnCustomerUpdate.Size = new Size(65, 23);
            searchBtnCustomerUpdate.TabIndex = 20;
            searchBtnCustomerUpdate.Text = "חפש לקוח";
            searchBtnCustomerUpdate.UseVisualStyleBackColor = true;
            searchBtnCustomerUpdate.Click += searchBtnCustomerUpdate_Click;
            // 
            // codeCustomerInput
            // 
            codeCustomerInput.Location = new Point(98, 56);
            codeCustomerInput.Margin = new Padding(3, 2, 3, 2);
            codeCustomerInput.Name = "codeCustomerInput";
            codeCustomerInput.Size = new Size(92, 23);
            codeCustomerInput.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(205, 60);
            label5.Name = "label5";
            label5.Size = new Size(120, 15);
            label5.TabIndex = 18;
            label5.Text = "הכנס קוד לקוח לעדכון";
            // 
            // updateBtnCustomer
            // 
            updateBtnCustomer.Location = new Point(169, 203);
            updateBtnCustomer.Margin = new Padding(3, 2, 3, 2);
            updateBtnCustomer.Name = "updateBtnCustomer";
            updateBtnCustomer.Size = new Size(85, 30);
            updateBtnCustomer.TabIndex = 13;
            updateBtnCustomer.Text = "עדכן";
            updateBtnCustomer.UseVisualStyleBackColor = true;
            updateBtnCustomer.Click += updateBtnCustomer_Click;
            // 
            // delete
            // 
            delete.Controls.Add(deleteBtnCustomer);
            delete.Controls.Add(codeCustomerInputToDelete);
            delete.Controls.Add(codeCustomerToDelete);
            delete.Location = new Point(4, 24);
            delete.Margin = new Padding(3, 2, 3, 2);
            delete.Name = "delete";
            delete.Padding = new Padding(3, 2, 3, 2);
            delete.Size = new Size(426, 288);
            delete.TabIndex = 2;
            delete.Text = "מחיקה";
            delete.UseVisualStyleBackColor = true;
            // 
            // deleteBtnCustomer
            // 
            deleteBtnCustomer.Location = new Point(166, 182);
            deleteBtnCustomer.Margin = new Padding(3, 2, 3, 2);
            deleteBtnCustomer.Name = "deleteBtnCustomer";
            deleteBtnCustomer.Size = new Size(96, 26);
            deleteBtnCustomer.TabIndex = 2;
            deleteBtnCustomer.Text = "מחיקה";
            deleteBtnCustomer.UseVisualStyleBackColor = true;
            deleteBtnCustomer.Click += deleteBtnCustomer_Click;
            // 
            // codeCustomerInputToDelete
            // 
            codeCustomerInputToDelete.Location = new Point(166, 85);
            codeCustomerInputToDelete.Margin = new Padding(3, 2, 3, 2);
            codeCustomerInputToDelete.Name = "codeCustomerInputToDelete";
            codeCustomerInputToDelete.Size = new Size(97, 23);
            codeCustomerInputToDelete.TabIndex = 1;
            // 
            // codeCustomerToDelete
            // 
            codeCustomerToDelete.AutoSize = true;
            codeCustomerToDelete.Location = new Point(135, 58);
            codeCustomerToDelete.Name = "codeCustomerToDelete";
            codeCustomerToDelete.Size = new Size(171, 15);
            codeCustomerToDelete.TabIndex = 0;
            codeCustomerToDelete.Text = "הקש תעודת זהות למחיקת לקוח";
            // 
            // detailsCustomer
            // 
            detailsCustomer.Controls.Add(detailCustomer);
            detailsCustomer.Controls.Add(showDetailsCustomer);
            detailsCustomer.Controls.Add(idCustomerDisplay);
            detailsCustomer.Controls.Add(label10);
            detailsCustomer.Location = new Point(4, 24);
            detailsCustomer.Margin = new Padding(3, 2, 3, 2);
            detailsCustomer.Name = "detailsCustomer";
            detailsCustomer.Size = new Size(426, 288);
            detailsCustomer.TabIndex = 3;
            detailsCustomer.Text = "פרטי לקוח ";
            detailsCustomer.UseVisualStyleBackColor = true;
            // 
            // detailCustomer
            // 
            detailCustomer.FormattingEnabled = true;
            detailCustomer.ItemHeight = 15;
            detailCustomer.Location = new Point(120, 118);
            detailCustomer.Margin = new Padding(3, 2, 3, 2);
            detailCustomer.Name = "detailCustomer";
            detailCustomer.RightToLeft = RightToLeft.No;
            detailCustomer.Size = new Size(199, 124);
            detailCustomer.TabIndex = 5;
            // 
            // showDetailsCustomer
            // 
            showDetailsCustomer.Location = new Point(120, 78);
            showDetailsCustomer.Margin = new Padding(3, 2, 3, 2);
            showDetailsCustomer.Name = "showDetailsCustomer";
            showDetailsCustomer.Size = new Size(199, 25);
            showDetailsCustomer.TabIndex = 4;
            showDetailsCustomer.Text = "הצג פרטי לקוח👆";
            showDetailsCustomer.UseVisualStyleBackColor = true;
            showDetailsCustomer.Click += showDetailsCustomer_Click;
            // 
            // idCustomerDisplay
            // 
            idCustomerDisplay.Location = new Point(120, 35);
            idCustomerDisplay.Margin = new Padding(3, 2, 3, 2);
            idCustomerDisplay.Name = "idCustomerDisplay";
            idCustomerDisplay.Size = new Size(97, 23);
            idCustomerDisplay.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(232, 39);
            label10.Name = "label10";
            label10.Size = new Size(99, 15);
            label10.TabIndex = 2;
            label10.Text = "הכנס תעודת זהות";
            // 
            // customerList
            // 
            customerList.Anchor = AnchorStyles.Right;
            customerList.AutoSize = true;
            customerList.Location = new Point(360, 167);
            customerList.Name = "customerList";
            customerList.Size = new Size(75, 15);
            customerList.TabIndex = 10;
            customerList.Text = "customerList";
            customerList.Click += label12_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ImageToStl_com_pandora_logo;
            pictureBox1.Location = new Point(100, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(226, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // CustomersMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 234, 231);
            ClientSize = new Size(983, 590);
            Controls.Add(pictureBox1);
            Controls.Add(customerList);
            Controls.Add(filterByPhone);
            Controls.Add(label11);
            Controls.Add(customersList);
            Controls.Add(add);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "CustomersMenu";
            Text = "CustomersMenu";
            WindowState = FormWindowState.Maximized;
            Load += CustomersMenu_Load;
            add.ResumeLayout(false);
            addCustomer.ResumeLayout(false);
            addCustomer.PerformLayout();
            update.ResumeLayout(false);
            update.PerformLayout();
            delete.ResumeLayout(false);
            delete.PerformLayout();
            detailsCustomer.ResumeLayout(false);
            detailsCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox filterByPhone;
        private Label label11;
        private ListBox customersList;
        private TabControl add;
        private TabPage addCustomer;
        private Button addButton;
        private TextBox CustomerAddressInput;
        private TextBox CustomerTelInput;
        private Label label6;
        private Label label7;
        private TextBox CustomerIdInput;
        private Label label8;
        private TextBox CustomerNameInput;
        private Label label9;
        private TabPage update;
        private TextBox addressCustomerUpdate;
        private TextBox phoneCustomerUpdate;
        private Label label1;
        private Label label2;
        private TextBox idCustomerUpdate;
        private Label label3;
        private TextBox nameCustomerUpdate;
        private Label label4;
        private Button searchBtnCustomerUpdate;
        private TextBox codeCustomerInput;
        private Label label5;
        private Button updateBtnCustomer;
        private TabPage delete;
        private Button deleteBtnCustomer;
        private TextBox codeCustomerInputToDelete;
        private Label codeCustomerToDelete;
        private TabPage detailsCustomer;
        private ListBox detailCustomer;
        private Button showDetailsCustomer;
        private TextBox idCustomerDisplay;
        private Label label10;
        private Label customerList;
        private PictureBox pictureBox1;
    }
}