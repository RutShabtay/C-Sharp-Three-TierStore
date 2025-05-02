namespace UI
{
    partial class PandoraHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PandoraHome));
            manager = new Button();
            seller = new Button();
            pandoraLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pandoraLogo).BeginInit();
            SuspendLayout();
            // 
            // manager
            // 
            manager.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            manager.Location = new Point(679, 349);
            manager.Margin = new Padding(3, 2, 3, 2);
            manager.Name = "manager";
            manager.Size = new Size(186, 86);
            manager.TabIndex = 0;
            manager.Text = "מנהל";
            manager.UseVisualStyleBackColor = true;
            manager.Click += manager_Click;
            // 
            // seller
            // 
            seller.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            seller.Location = new Point(679, 446);
            seller.Margin = new Padding(3, 2, 3, 2);
            seller.Name = "seller";
            seller.Size = new Size(186, 86);
            seller.TabIndex = 1;
            seller.Text = "קופאי";
            seller.UseVisualStyleBackColor = true;
            seller.Click += seller_Click;
            // 
            // pandoraLogo
            // 
            pandoraLogo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pandoraLogo.BackColor = Color.White;
            pandoraLogo.Image = (Image)resources.GetObject("pandoraLogo.Image");
            pandoraLogo.Location = new Point(96, 368);
            pandoraLogo.Margin = new Padding(1);
            pandoraLogo.Name = "pandoraLogo";
            pandoraLogo.Size = new Size(593, 110);
            pandoraLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pandoraLogo.TabIndex = 2;
            pandoraLogo.TabStop = false;
            pandoraLogo.Click += pictureBox1_Click;
            // 
            // PandoraHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.תכשיטי_PANDORA_צילום_יחצ_חול_3_1_1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(989, 575);
            Controls.Add(pandoraLogo);
            Controls.Add(seller);
            Controls.Add(manager);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "PandoraHome";
            Text = "  ";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pandoraLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button manager;
        private Button seller;
        private PictureBox pandoraLogo;
    }
}