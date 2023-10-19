namespace Supermarket_mvp.Views
{
    partial class PayModeview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayModeview));
            panel1 = new Panel();
            PctPayMode = new PictureBox();
            LblPayMode = new Label();
            Tbc = new TabControl();
            tabPagePayModeList = new TabPage();
            BtnEdit = new Button();
            BtnDelete = new Button();
            BtnClose = new Button();
            BtnNew = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            TxtSearch = new TextBox();
            LblSearchPayMode = new Label();
            tabPagePayModeDetail = new TabPage();
            LblPayModeId = new Label();
            TxtModeId = new TextBox();
            TxtPayModeName = new TextBox();
            LblPayModeName = new Label();
            TxtPayModeObs = new TextBox();
            LblPayModeObs = new Label();
            BtnCancel = new Button();
            BtnSave = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PctPayMode).BeginInit();
            Tbc.SuspendLayout();
            tabPagePayModeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPagePayModeDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(PctPayMode);
            panel1.Controls.Add(LblPayMode);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // PctPayMode
            // 
            PctPayMode.Image = (Image)resources.GetObject("PctPayMode.Image");
            PctPayMode.InitialImage = null;
            PctPayMode.Location = new Point(16, 4);
            PctPayMode.Name = "PctPayMode";
            PctPayMode.Size = new Size(83, 93);
            PctPayMode.SizeMode = PictureBoxSizeMode.Zoom;
            PctPayMode.TabIndex = 1;
            PctPayMode.TabStop = false;
            // 
            // LblPayMode
            // 
            LblPayMode.BackColor = Color.Transparent;
            LblPayMode.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            LblPayMode.Location = new Point(105, 30);
            LblPayMode.Name = "LblPayMode";
            LblPayMode.Size = new Size(154, 47);
            LblPayMode.TabIndex = 0;
            LblPayMode.Text = "Pay Mode";
            LblPayMode.Click += label1_Click;
            // 
            // Tbc
            // 
            Tbc.Controls.Add(tabPagePayModeList);
            Tbc.Controls.Add(tabPagePayModeDetail);
            Tbc.Dock = DockStyle.Fill;
            Tbc.Location = new Point(0, 100);
            Tbc.Name = "Tbc";
            Tbc.SelectedIndex = 0;
            Tbc.Size = new Size(800, 350);
            Tbc.TabIndex = 1;
            // 
            // tabPagePayModeList
            // 
            tabPagePayModeList.Controls.Add(BtnEdit);
            tabPagePayModeList.Controls.Add(BtnDelete);
            tabPagePayModeList.Controls.Add(BtnClose);
            tabPagePayModeList.Controls.Add(BtnNew);
            tabPagePayModeList.Controls.Add(dataGridView1);
            tabPagePayModeList.Controls.Add(button1);
            tabPagePayModeList.Controls.Add(TxtSearch);
            tabPagePayModeList.Controls.Add(LblSearchPayMode);
            tabPagePayModeList.Location = new Point(4, 24);
            tabPagePayModeList.Name = "tabPagePayModeList";
            tabPagePayModeList.Padding = new Padding(3);
            tabPagePayModeList.Size = new Size(792, 322);
            tabPagePayModeList.TabIndex = 0;
            tabPagePayModeList.Text = "Pay Mode List";
            tabPagePayModeList.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = (Image)resources.GetObject("BtnEdit.Image");
            BtnEdit.Location = new Point(571, 150);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(141, 44);
            BtnEdit.TabIndex = 7;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = (Image)resources.GetObject("BtnDelete.Image");
            BtnDelete.Location = new Point(571, 200);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(141, 44);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Image = (Image)resources.GetObject("BtnClose.Image");
            BtnClose.Location = new Point(571, 250);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(141, 44);
            BtnClose.TabIndex = 5;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Image = (Image)resources.GetObject("BtnNew.Image");
            BtnNew.Location = new Point(571, 100);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(141, 44);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(514, 251);
            dataGridView1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(491, 24);
            button1.Name = "button1";
            button1.Size = new Size(39, 41);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(16, 34);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.Size = new Size(469, 23);
            TxtSearch.TabIndex = 1;
            TxtSearch.Text = "Data to search";
            // 
            // LblSearchPayMode
            // 
            LblSearchPayMode.AutoSize = true;
            LblSearchPayMode.Location = new Point(16, 16);
            LblSearchPayMode.Name = "LblSearchPayMode";
            LblSearchPayMode.Size = new Size(98, 15);
            LblSearchPayMode.TabIndex = 0;
            LblSearchPayMode.Text = "Search Pay Mode";
            // 
            // tabPagePayModeDetail
            // 
            tabPagePayModeDetail.Controls.Add(BtnSave);
            tabPagePayModeDetail.Controls.Add(BtnCancel);
            tabPagePayModeDetail.Controls.Add(TxtPayModeObs);
            tabPagePayModeDetail.Controls.Add(LblPayModeObs);
            tabPagePayModeDetail.Controls.Add(TxtPayModeName);
            tabPagePayModeDetail.Controls.Add(LblPayModeName);
            tabPagePayModeDetail.Controls.Add(TxtModeId);
            tabPagePayModeDetail.Controls.Add(LblPayModeId);
            tabPagePayModeDetail.Location = new Point(4, 24);
            tabPagePayModeDetail.Name = "tabPagePayModeDetail";
            tabPagePayModeDetail.Padding = new Padding(3);
            tabPagePayModeDetail.Size = new Size(792, 322);
            tabPagePayModeDetail.TabIndex = 1;
            tabPagePayModeDetail.Text = "Pay Mode Detail";
            tabPagePayModeDetail.UseVisualStyleBackColor = true;
            // 
            // LblPayModeId
            // 
            LblPayModeId.AutoSize = true;
            LblPayModeId.Location = new Point(12, 12);
            LblPayModeId.Name = "LblPayModeId";
            LblPayModeId.Size = new Size(73, 15);
            LblPayModeId.TabIndex = 0;
            LblPayModeId.Text = "Pay Mode Id";
            // 
            // TxtModeId
            // 
            TxtModeId.Location = new Point(12, 30);
            TxtModeId.Name = "TxtModeId";
            TxtModeId.Size = new Size(100, 23);
            TxtModeId.TabIndex = 1;
            // 
            // TxtPayModeName
            // 
            TxtPayModeName.Location = new Point(12, 86);
            TxtPayModeName.Name = "TxtPayModeName";
            TxtPayModeName.Size = new Size(212, 23);
            TxtPayModeName.TabIndex = 3;
            // 
            // LblPayModeName
            // 
            LblPayModeName.AutoSize = true;
            LblPayModeName.Location = new Point(12, 68);
            LblPayModeName.Name = "LblPayModeName";
            LblPayModeName.Size = new Size(95, 15);
            LblPayModeName.TabIndex = 2;
            LblPayModeName.Text = "Pay Mode Name";
            // 
            // TxtPayModeObs
            // 
            TxtPayModeObs.Location = new Point(12, 143);
            TxtPayModeObs.Multiline = true;
            TxtPayModeObs.Name = "TxtPayModeObs";
            TxtPayModeObs.Size = new Size(212, 70);
            TxtPayModeObs.TabIndex = 5;
            TxtPayModeObs.Text = "Pay Mode Observation";
            // 
            // LblPayModeObs
            // 
            LblPayModeObs.AutoSize = true;
            LblPayModeObs.Location = new Point(12, 125);
            LblPayModeObs.Name = "LblPayModeObs";
            LblPayModeObs.Size = new Size(127, 15);
            LblPayModeObs.TabIndex = 4;
            LblPayModeObs.Text = "Pay Mode Observation";
            // 
            // BtnCancel
            // 
            BtnCancel.Image = (Image)resources.GetObject("BtnCancel.Image");
            BtnCancel.Location = new Point(136, 234);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(88, 44);
            BtnCancel.TabIndex = 6;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = (Image)resources.GetObject("BtnSave.Image");
            BtnSave.Location = new Point(12, 234);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(83, 44);
            BtnSave.TabIndex = 7;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // PayModeview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Tbc);
            Controls.Add(panel1);
            Name = "PayModeview";
            Text = "Pay Mode Management";
            Load += PayModeview_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PctPayMode).EndInit();
            Tbc.ResumeLayout(false);
            tabPagePayModeList.ResumeLayout(false);
            tabPagePayModeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPagePayModeDetail.ResumeLayout(false);
            tabPagePayModeDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label LblPayMode;
        private PictureBox PctPayMode;
        private TabControl Tbc;
        private TabPage tabPagePayModeList;
        private TabPage tabPagePayModeDetail;
        private Button button1;
        private TextBox TxtSearch;
        private Label LblSearchPayMode;
        private DataGridView dataGridView1;
        private Button BtnEdit;
        private Button BtnDelete;
        private Button BtnClose;
        private Button BtnNew;
        private Label LblPayModeId;
        private TextBox TxtPayModeObs;
        private Label LblPayModeObs;
        private TextBox TxtPayModeName;
        private Label LblPayModeName;
        private TextBox TxtModeId;
        private Button BtnSave;
        private Button BtnCancel;
    }
}