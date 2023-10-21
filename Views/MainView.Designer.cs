namespace Supermarket_mvp.Views
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            Pnl1 = new Panel();
            BtnPayMode = new Button();
            PBox1 = new PictureBox();
            BtnExit = new Button();
            Pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBox1).BeginInit();
            SuspendLayout();
            // 
            // Pnl1
            // 
            Pnl1.Controls.Add(BtnExit);
            Pnl1.Controls.Add(BtnPayMode);
            Pnl1.Controls.Add(PBox1);
            Pnl1.Dock = DockStyle.Left;
            Pnl1.Location = new Point(0, 0);
            Pnl1.Name = "Pnl1";
            Pnl1.Size = new Size(200, 450);
            Pnl1.TabIndex = 0;
            // 
            // BtnPayMode
            // 
            BtnPayMode.BackgroundImageLayout = ImageLayout.Zoom;
            BtnPayMode.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BtnPayMode.Image = (Image)resources.GetObject("BtnPayMode.Image");
            BtnPayMode.Location = new Point(3, 68);
            BtnPayMode.Name = "BtnPayMode";
            BtnPayMode.Size = new Size(194, 79);
            BtnPayMode.TabIndex = 1;
            BtnPayMode.UseVisualStyleBackColor = true;
            // 
            // PBox1
            // 
            PBox1.Image = (Image)resources.GetObject("PBox1.Image");
            PBox1.Location = new Point(3, 12);
            PBox1.Name = "PBox1";
            PBox1.Size = new Size(194, 50);
            PBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PBox1.TabIndex = 0;
            PBox1.TabStop = false;
            // 
            // BtnExit
            // 
            BtnExit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BtnExit.Image = (Image)resources.GetObject("BtnExit.Image");
            BtnExit.Location = new Point(3, 368);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(194, 79);
            BtnExit.TabIndex = 2;
            BtnExit.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Pnl1);
            IsMdiContainer = true;
            Name = "MainView";
            Text = "MainView";
            WindowState = FormWindowState.Maximized;
            Load += MainView_Load;
            Pnl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Pnl1;
        private Button BtnPayMode;
        private PictureBox PBox1;
        private Button BtnExit;
    }
}