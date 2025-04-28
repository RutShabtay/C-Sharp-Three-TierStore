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
            manager = new Button();
            seller = new Button();
            pandoraLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pandoraLogo).BeginInit();
            SuspendLayout();
            // 
            // manager
            // 
            manager.Location = new Point(611, 309);
            manager.Name = "manager";
            manager.Size = new Size(123, 50);
            manager.TabIndex = 0;
            manager.Text = "מנהל";
            manager.UseVisualStyleBackColor = true;
            manager.Click += manager_Click;
            // 
            // seller
            // 
            seller.Location = new Point(611, 365);
            seller.Name = "seller";
            seller.Size = new Size(123, 50);
            seller.TabIndex = 1;
            seller.Text = "קופאי";
            seller.UseVisualStyleBackColor = true;
            seller.Click += seller_Click;
            // 
            // pandoraLogo
            // 
            pandoraLogo.BackColor = Color.White;
            pandoraLogo.Image = Properties.Resources.logo_png_removebg_preview;
            pandoraLogo.Location = new Point(65, 332);
            pandoraLogo.Name = "pandoraLogo";
            pandoraLogo.Size = new Size(246, 70);
            pandoraLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            pandoraLogo.TabIndex = 2;
            pandoraLogo.TabStop = false;
            pandoraLogo.Click += pictureBox1_Click;
            // 
            // PandoraHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.תכשיטי_PANDORA_צילום_יחצ_חול_3_1_1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(pandoraLogo);
            Controls.Add(seller);
            Controls.Add(manager);
            Name = "PandoraHome";
            Text = "  ";
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