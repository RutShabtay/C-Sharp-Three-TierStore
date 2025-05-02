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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderToCustomer));
            orderBtn = new Button();
            inputId = new TextBox();
            customerId = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // orderBtn
            // 
            orderBtn.Anchor = AnchorStyles.Top;
            orderBtn.Location = new Point(175, 630);
            orderBtn.Name = "orderBtn";
            orderBtn.Size = new Size(371, 107);
            orderBtn.TabIndex = 7;
            orderBtn.Text = "התחל הזמנה👆";
            orderBtn.UseVisualStyleBackColor = true;
            orderBtn.Click += orderBtn_Click;
            // 
            // inputId
            // 
            inputId.Anchor = AnchorStyles.Top;
            inputId.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            inputId.Location = new Point(214, 362);
            inputId.Name = "inputId";
            inputId.Size = new Size(145, 39);
            inputId.TabIndex = 6;
            // 
            // customerId
            // 
            customerId.Anchor = AnchorStyles.Top;
            customerId.AutoSize = true;
            customerId.Font = new Font("Shantell Sans", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            customerId.Location = new Point(366, 367);
            customerId.Name = "customerId";
            customerId.Size = new Size(180, 33);
            customerId.TabIndex = 5;
            customerId.Text = "תעודת זהות לקוח";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.Font = new Font("Shantell Sans", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(258, 163);
            label1.Name = "label1";
            label1.Size = new Size(303, 52);
            label1.TabIndex = 4;
            label1.Text = "הזמנת מוצרים ללקוח";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ImageToStl_com_pandora_logo;
            pictureBox1.Location = new Point(52, 68);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(258, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // OrderToCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 234, 231);
            ClientSize = new Size(800, 725);
            Controls.Add(pictureBox1);
            Controls.Add(orderBtn);
            Controls.Add(inputId);
            Controls.Add(customerId);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "OrderToCustomer";
            Text = "OrderToCustomer";
            WindowState = FormWindowState.Maximized;
            Load += OrderToCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button orderBtn;
        private TextBox inputId;
        private Label customerId;
        private Label label1;
        private PictureBox pictureBox1;
    }
}