namespace UI
{
    partial class OrderToCustomer
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
            orderBtn = new Button();
            inputId = new TextBox();
            customerId = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // orderBtn
            // 
            orderBtn.Location = new Point(325, 273);
            orderBtn.Margin = new Padding(3, 2, 3, 2);
            orderBtn.Name = "orderBtn";
            orderBtn.Size = new Size(129, 44);
            orderBtn.TabIndex = 7;
            orderBtn.Text = "התחל הזמנה👆";
            orderBtn.UseVisualStyleBackColor = true;
            orderBtn.Click += orderBtn_Click;
            // 
            // inputId
            // 
            inputId.Location = new Point(279, 183);
            inputId.Margin = new Padding(3, 2, 3, 2);
            inputId.Name = "inputId";
            inputId.Size = new Size(110, 27);
            inputId.TabIndex = 6;
            // 
            // customerId
            // 
            customerId.AutoSize = true;
            customerId.Location = new Point(415, 187);
            customerId.Name = "customerId";
            customerId.Size = new Size(121, 20);
            customerId.TabIndex = 5;
            customerId.Text = "תעודת זהות לקוח";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(335, 49);
            label1.Name = "label1";
            label1.Size = new Size(144, 20);
            label1.TabIndex = 4;
            label1.Text = "הזמנת מוצרים ללקוח";
            // 
            // OrderToCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(orderBtn);
            Controls.Add(inputId);
            Controls.Add(customerId);
            Controls.Add(label1);
            Name = "OrderToCustomer";
            Text = "OrderToCustomer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button orderBtn;
        private TextBox inputId;
        private Label customerId;
        private Label label1;
    }
}