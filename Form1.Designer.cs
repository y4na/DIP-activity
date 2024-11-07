using System.IO;

namespace ImageProcessing
{
    partial class Form1
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
            topPanel = new Panel();
            saveBtn = new Button();
            minimizeBtn = new Button();
            maximizeBtn = new Button();
            exitBtn = new Button();
            nameLbl = new Label();
            fileMenu = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            bottomPanel = new Panel();
            rotleftBtn = new Button();
            histogramBtn = new Button();
            rotrightBtn = new Button();
            resetBtn = new Button();
            expandsidePanel = new Panel();
            dragimgBtn = new Button();
            mainPbox = new PictureBox();
            topPanel.SuspendLayout();
            fileMenu.SuspendLayout();
            bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainPbox).BeginInit();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(29, 33, 37);
            topPanel.Controls.Add(saveBtn);
            topPanel.Controls.Add(minimizeBtn);
            topPanel.Controls.Add(maximizeBtn);
            topPanel.Controls.Add(exitBtn);
            topPanel.Controls.Add(nameLbl);
            topPanel.Controls.Add(fileMenu);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1170, 35);
            topPanel.TabIndex = 0;
            topPanel.MouseDown += topPanel_MouseDown;
            // 
            // saveBtn
            // 
            saveBtn.FlatAppearance.BorderSize = 0;
            saveBtn.Location = new Point(155, 6);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(43, 23);
            saveBtn.TabIndex = 4;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            // 
            // minimizeBtn
            // 
            minimizeBtn.Dock = DockStyle.Right;
            minimizeBtn.FlatAppearance.BorderSize = 0;
            minimizeBtn.FlatStyle = FlatStyle.Flat;
            minimizeBtn.Location = new Point(1047, 0);
            minimizeBtn.Name = "minimizeBtn";
            minimizeBtn.Size = new Size(41, 35);
            minimizeBtn.TabIndex = 0;
            minimizeBtn.Click += minimizeBtn_Click;
            // 
            // maximizeBtn
            // 
            maximizeBtn.Dock = DockStyle.Right;
            maximizeBtn.FlatAppearance.BorderSize = 0;
            maximizeBtn.FlatStyle = FlatStyle.Flat;
            maximizeBtn.Location = new Point(1088, 0);
            maximizeBtn.Name = "maximizeBtn";
            maximizeBtn.Size = new Size(41, 35);
            maximizeBtn.TabIndex = 1;
            maximizeBtn.Click += maximizeBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Dock = DockStyle.Right;
            exitBtn.FlatAppearance.BorderSize = 0;
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.Location = new Point(1129, 0);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(41, 35);
            exitBtn.TabIndex = 2;
            exitBtn.Click += exitBtn_Click;
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            nameLbl.ForeColor = Color.BlueViolet;
            nameLbl.Location = new Point(12, 3);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(92, 28);
            nameLbl.TabIndex = 0;
            nameLbl.Text = "IMAGYNA";
            // 
            // fileMenu
            // 
            fileMenu.BackColor = Color.FromArgb(29, 33, 37);
            fileMenu.Dock = DockStyle.None;
            fileMenu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            fileMenu.Location = new Point(107, 7);
            fileMenu.Name = "fileMenu";
            fileMenu.Size = new Size(45, 24);
            fileMenu.TabIndex = 5;
            fileMenu.ItemClicked += fileMenu_ItemClicked;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.BackColor = Color.FromArgb(29, 33, 37);
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, closeToolStripMenuItem });
            fileToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.BackColor = Color.FromArgb(29, 33, 37);
            openToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(103, 22);
            openToolStripMenuItem.Text = "Open";
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.BackColor = Color.FromArgb(29, 33, 37);
            closeToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(103, 22);
            closeToolStripMenuItem.Text = "Close";
            // 
            // bottomPanel
            // 
            bottomPanel.BackColor = Color.FromArgb(29, 33, 37);
            bottomPanel.Controls.Add(rotleftBtn);
            bottomPanel.Controls.Add(histogramBtn);
            bottomPanel.Controls.Add(rotrightBtn);
            bottomPanel.Controls.Add(resetBtn);
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Location = new Point(0, 658);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(1170, 45);
            bottomPanel.TabIndex = 1;
            // 
            // rotleftBtn
            // 
            rotleftBtn.BackColor = Color.FromArgb(29, 33, 37);
            rotleftBtn.FlatAppearance.BorderSize = 0;
            rotleftBtn.FlatStyle = FlatStyle.Flat;
            rotleftBtn.Location = new Point(576, 7);
            rotleftBtn.Name = "rotleftBtn";
            rotleftBtn.Size = new Size(40, 31);
            rotleftBtn.TabIndex = 3;
            rotleftBtn.UseVisualStyleBackColor = true;
            rotleftBtn.Click += rotleftBtn_Click;
            // 
            // histogramBtn
            // 
            histogramBtn.Anchor = AnchorStyles.None;
            histogramBtn.BackColor = Color.FromArgb(29, 33, 37);
            histogramBtn.FlatAppearance.BorderSize = 0;
            histogramBtn.FlatStyle = FlatStyle.Flat;
            histogramBtn.Font = new Font("Corbel", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            histogramBtn.ForeColor = Color.White;
            histogramBtn.ImageAlign = ContentAlignment.MiddleLeft;
            histogramBtn.Location = new Point(12, 7);
            histogramBtn.Name = "histogramBtn";
            histogramBtn.Size = new Size(102, 31);
            histogramBtn.TabIndex = 2;
            histogramBtn.Text = "Histogram";
            histogramBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            histogramBtn.UseVisualStyleBackColor = false;
            histogramBtn.Click += histogramBtn_Click_1;
            // 
            // rotrightBtn
            // 
            rotrightBtn.BackColor = Color.FromArgb(29, 33, 37);
            rotrightBtn.FlatAppearance.BorderSize = 0;
            rotrightBtn.FlatStyle = FlatStyle.Flat;
            rotrightBtn.Location = new Point(622, 7);
            rotrightBtn.Name = "rotrightBtn";
            rotrightBtn.Size = new Size(40, 31);
            rotrightBtn.TabIndex = 4;
            rotrightBtn.UseVisualStyleBackColor = true;
            rotrightBtn.Click += rotrightBtn_Click;
            // 
            // resetBtn
            // 
            resetBtn.Anchor = AnchorStyles.None;
            resetBtn.BackColor = Color.FromArgb(29, 33, 37);
            resetBtn.FlatAppearance.BorderSize = 0;
            resetBtn.FlatStyle = FlatStyle.Flat;
            resetBtn.Font = new Font("Corbel", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resetBtn.ForeColor = Color.White;
            resetBtn.ImageAlign = ContentAlignment.MiddleLeft;
            resetBtn.Location = new Point(1065, 7);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(93, 31);
            resetBtn.TabIndex = 0;
            resetBtn.Text = "Reset";
            resetBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            resetBtn.UseVisualStyleBackColor = false;
            resetBtn.Click += resetBtn_Click;
            // 
            // expandsidePanel
            // 
            expandsidePanel.BackColor = Color.Black;
            expandsidePanel.Dock = DockStyle.Left;
            expandsidePanel.Location = new Point(0, 35);
            expandsidePanel.Name = "expandsidePanel";
            expandsidePanel.Size = new Size(214, 623);
            expandsidePanel.TabIndex = 3;
            expandsidePanel.Paint += panel1_Paint;
            // 
            // dragimgBtn
            // 
            dragimgBtn.Cursor = Cursors.Hand;
            dragimgBtn.FlatAppearance.BorderSize = 0;
            dragimgBtn.FlatStyle = FlatStyle.Flat;
            dragimgBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dragimgBtn.ForeColor = SystemColors.ButtonFace;
            dragimgBtn.ImageAlign = ContentAlignment.TopCenter;
            dragimgBtn.Location = new Point(461, 228);
            dragimgBtn.Name = "dragimgBtn";
            dragimgBtn.Size = new Size(489, 280);
            dragimgBtn.TabIndex = 4;
            dragimgBtn.Text = "Open an image or drag it here";
            dragimgBtn.TextAlign = ContentAlignment.BottomCenter;
            dragimgBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            dragimgBtn.UseVisualStyleBackColor = true;
            dragimgBtn.Click += button1_Click;
            dragimgBtn.DragDrop += dragimgBtn_DragDrop;
            dragimgBtn.Paint += dragimgBtn_Paint;
            // 
            // mainPbox
            // 
            mainPbox.Location = new Point(347, 98);
            mainPbox.Name = "mainPbox";
            mainPbox.Size = new Size(700, 510);
            mainPbox.SizeMode = PictureBoxSizeMode.Zoom;
            mainPbox.TabIndex = 6;
            mainPbox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 18, 20);
            ClientSize = new Size(1170, 703);
            Controls.Add(dragimgBtn);
            Controls.Add(expandsidePanel);
            Controls.Add(bottomPanel);
            Controls.Add(topPanel);
            Controls.Add(mainPbox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Image Processing";
            Load += Form1_Load;
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            fileMenu.ResumeLayout(false);
            fileMenu.PerformLayout();
            bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainPbox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel topPanel;
        private Label nameLbl;
        private Button exitBtn;
        private Button minimizeBtn;
        private Button maximizeBtn;
        private Button saveBtn;
        private MenuStrip fileMenu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private Panel bottomPanel;
        private Button histogramBtn;
        private Button resetBtn;
        private Button rotrightBtn;
        private Button rotleftBtn;
        private Panel expandsidePanel;
        private Button dragimgBtn;
        private PictureBox mainPbox;
    }
}
