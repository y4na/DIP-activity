using System.IO;
using System.Windows.Forms;

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
            useCameraToolStripMenuItem = new ToolStripMenuItem();
            rotleftBtn = new Button();
            histogramBtn = new Button();
            rotrightBtn = new Button();
            resetBtn = new Button();
            dragimgBtn = new Button();
            mainPbox = new PictureBox();
            sidePanel = new Panel();
            substractBtn = new Button();
            effectsBtn = new Button();
            cropBtn = new Button();
            adjustBtn = new Button();
            adjustPanel = new Panel();
            label1 = new Label();
            saturationTrackbar = new TrackBar();
            contrastTrackbar = new TrackBar();
            saturationLbl = new Label();
            contrastLbl = new Label();
            brightnessLbl = new Label();
            brightnessTrackbar = new TrackBar();
            exposureLbl = new Label();
            exposureTrackbar = new TrackBar();
            effectsPanel = new Panel();
            effectnoneLbl = new Label();
            nonePbox = new PictureBox();
            effect3Lbl = new Label();
            effect2Lbl = new Label();
            effect1Lbl = new Label();
            sepiaPbox = new PictureBox();
            invertPbox = new PictureBox();
            greyscalePbox = new PictureBox();
            mainPanel = new Panel();
            histogramPanel = new Panel();
            label2 = new Label();
            histogramPbox = new PictureBox();
            histogramClosebtn = new Button();
            bottomPanel = new Panel();
            topPanel.SuspendLayout();
            fileMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainPbox).BeginInit();
            sidePanel.SuspendLayout();
            adjustPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)saturationTrackbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contrastTrackbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)brightnessTrackbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exposureTrackbar).BeginInit();
            effectsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nonePbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sepiaPbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)invertPbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)greyscalePbox).BeginInit();
            mainPanel.SuspendLayout();
            histogramPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)histogramPbox).BeginInit();
            bottomPanel.SuspendLayout();
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
            topPanel.Padding = new Padding(0, 0, 0, 1);
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
            saveBtn.Click += saveBtn_Click;
            // 
            // minimizeBtn
            // 
            minimizeBtn.Dock = DockStyle.Right;
            minimizeBtn.FlatAppearance.BorderSize = 0;
            minimizeBtn.FlatStyle = FlatStyle.Flat;
            minimizeBtn.Location = new Point(1047, 0);
            minimizeBtn.Name = "minimizeBtn";
            minimizeBtn.Size = new Size(41, 34);
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
            maximizeBtn.Size = new Size(41, 34);
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
            exitBtn.Size = new Size(41, 34);
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
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, closeToolStripMenuItem, useCameraToolStripMenuItem });
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
            openToolStripMenuItem.Size = new Size(180, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.BackColor = Color.FromArgb(29, 33, 37);
            closeToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(180, 22);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // useCameraToolStripMenuItem
            // 
            useCameraToolStripMenuItem.BackColor = Color.FromArgb(29, 33, 37);
            useCameraToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            useCameraToolStripMenuItem.Name = "useCameraToolStripMenuItem";
            useCameraToolStripMenuItem.Size = new Size(180, 22);
            useCameraToolStripMenuItem.Text = "Use Camera";
            // 
            // rotleftBtn
            // 
            rotleftBtn.Anchor = AnchorStyles.None;
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
            histogramBtn.Anchor = AnchorStyles.Left;
            histogramBtn.BackColor = Color.FromArgb(29, 33, 37);
            histogramBtn.FlatAppearance.BorderSize = 0;
            histogramBtn.FlatStyle = FlatStyle.Flat;
            histogramBtn.Font = new Font("Corbel", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            histogramBtn.ForeColor = Color.White;
            histogramBtn.ImageAlign = ContentAlignment.MiddleLeft;
            histogramBtn.Location = new Point(7, 7);
            histogramBtn.Name = "histogramBtn";
            histogramBtn.Size = new Size(102, 31);
            histogramBtn.TabIndex = 2;
            histogramBtn.Text = "Histogram";
            histogramBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            histogramBtn.UseVisualStyleBackColor = false;
            histogramBtn.Click += histogramBtn_Click;
            // 
            // rotrightBtn
            // 
            rotrightBtn.Anchor = AnchorStyles.None;
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
            resetBtn.Anchor = AnchorStyles.Right;
            resetBtn.BackColor = Color.FromArgb(29, 33, 37);
            resetBtn.FlatAppearance.BorderSize = 0;
            resetBtn.FlatStyle = FlatStyle.Flat;
            resetBtn.Font = new Font("Corbel", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resetBtn.ForeColor = Color.White;
            resetBtn.ImageAlign = ContentAlignment.MiddleLeft;
            resetBtn.Location = new Point(996, 7);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(93, 31);
            resetBtn.TabIndex = 0;
            resetBtn.Text = "Reset";
            resetBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            resetBtn.UseVisualStyleBackColor = false;
            resetBtn.Click += resetBtn_Click;
            // 
            // dragimgBtn
            // 
            dragimgBtn.Cursor = Cursors.Hand;
            dragimgBtn.FlatAppearance.BorderSize = 0;
            dragimgBtn.FlatStyle = FlatStyle.Flat;
            dragimgBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dragimgBtn.ForeColor = SystemColors.ButtonFace;
            dragimgBtn.ImageAlign = ContentAlignment.TopCenter;
            dragimgBtn.Location = new Point(237, 150);
            dragimgBtn.Name = "dragimgBtn";
            dragimgBtn.Size = new Size(446, 280);
            dragimgBtn.TabIndex = 4;
            dragimgBtn.Text = "Open an image or drag it here";
            dragimgBtn.TextAlign = ContentAlignment.BottomCenter;
            dragimgBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            dragimgBtn.UseVisualStyleBackColor = true;
            dragimgBtn.DragDrop += dragimgBtn_DragDrop;
            dragimgBtn.Paint += dragimgBtn_Paint;
            // 
            // mainPbox
            // 
            mainPbox.Location = new Point(146, 65);
            mainPbox.Name = "mainPbox";
            mainPbox.Size = new Size(619, 467);
            mainPbox.SizeMode = PictureBoxSizeMode.Zoom;
            mainPbox.TabIndex = 6;
            mainPbox.TabStop = false;
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(29, 33, 37);
            sidePanel.Controls.Add(substractBtn);
            sidePanel.Controls.Add(effectsBtn);
            sidePanel.Controls.Add(cropBtn);
            sidePanel.Controls.Add(adjustBtn);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Location = new Point(0, 35);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(69, 668);
            sidePanel.TabIndex = 7;
            // 
            // substractBtn
            // 
            substractBtn.FlatAppearance.BorderColor = Color.Gray;
            substractBtn.FlatAppearance.BorderSize = 0;
            substractBtn.FlatStyle = FlatStyle.Flat;
            substractBtn.Location = new Point(12, 346);
            substractBtn.Name = "substractBtn";
            substractBtn.Size = new Size(49, 36);
            substractBtn.TabIndex = 12;
            substractBtn.UseVisualStyleBackColor = true;
            // 
            // effectsBtn
            // 
            effectsBtn.FlatAppearance.BorderColor = Color.Gray;
            effectsBtn.FlatAppearance.BorderSize = 0;
            effectsBtn.FlatStyle = FlatStyle.Flat;
            effectsBtn.Location = new Point(12, 289);
            effectsBtn.Name = "effectsBtn";
            effectsBtn.Size = new Size(49, 36);
            effectsBtn.TabIndex = 11;
            effectsBtn.UseVisualStyleBackColor = true;
            effectsBtn.Click += effectsBtn_Click;
            // 
            // cropBtn
            // 
            cropBtn.FlatAppearance.BorderColor = Color.Gray;
            cropBtn.FlatAppearance.BorderSize = 0;
            cropBtn.FlatStyle = FlatStyle.Flat;
            cropBtn.Location = new Point(12, 230);
            cropBtn.Name = "cropBtn";
            cropBtn.Size = new Size(49, 36);
            cropBtn.TabIndex = 10;
            cropBtn.UseVisualStyleBackColor = true;
            cropBtn.Click += cropBtn_Click;
            // 
            // adjustBtn
            // 
            adjustBtn.FlatAppearance.BorderColor = Color.Gray;
            adjustBtn.FlatAppearance.BorderSize = 0;
            adjustBtn.FlatStyle = FlatStyle.Flat;
            adjustBtn.Location = new Point(12, 171);
            adjustBtn.Name = "adjustBtn";
            adjustBtn.Size = new Size(49, 36);
            adjustBtn.TabIndex = 9;
            adjustBtn.UseVisualStyleBackColor = true;
            adjustBtn.Click += adjustBtn_Click;
            // 
            // adjustPanel
            // 
            adjustPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            adjustPanel.BackColor = Color.FromArgb(29, 33, 37);
            adjustPanel.Controls.Add(label1);
            adjustPanel.Controls.Add(saturationTrackbar);
            adjustPanel.Controls.Add(contrastTrackbar);
            adjustPanel.Controls.Add(saturationLbl);
            adjustPanel.Controls.Add(contrastLbl);
            adjustPanel.Controls.Add(brightnessLbl);
            adjustPanel.Controls.Add(brightnessTrackbar);
            adjustPanel.Controls.Add(exposureLbl);
            adjustPanel.Controls.Add(exposureTrackbar);
            adjustPanel.Location = new Point(76, 41);
            adjustPanel.Name = "adjustPanel";
            adjustPanel.Size = new Size(205, 611);
            adjustPanel.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.BlueViolet;
            label1.Location = new Point(0, 528);
            label1.Name = "label1";
            label1.Size = new Size(207, 52);
            label1.TabIndex = 7;
            label1.Text = "DISCLAIMER:\nEffects are not yet stacked.\nWhen switching tabs and applying certain\n effects, the image will be back to the original.";
            // 
            // saturationTrackbar
            // 
            saturationTrackbar.Location = new Point(17, 301);
            saturationTrackbar.Maximum = 100;
            saturationTrackbar.Minimum = -100;
            saturationTrackbar.Name = "saturationTrackbar";
            saturationTrackbar.Size = new Size(174, 45);
            saturationTrackbar.TabIndex = 19;
            saturationTrackbar.Scroll += SaturationTrackbar_Scroll;
            // 
            // contrastTrackbar
            // 
            contrastTrackbar.Location = new Point(17, 221);
            contrastTrackbar.Maximum = 100;
            contrastTrackbar.Minimum = -100;
            contrastTrackbar.Name = "contrastTrackbar";
            contrastTrackbar.Size = new Size(174, 45);
            contrastTrackbar.TabIndex = 17;
            contrastTrackbar.Scroll += ContrastTrackbar_Scroll;
            // 
            // saturationLbl
            // 
            saturationLbl.AutoSize = true;
            saturationLbl.Font = new Font("Ebrima", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saturationLbl.ForeColor = SystemColors.ButtonFace;
            saturationLbl.Location = new Point(17, 269);
            saturationLbl.Name = "saturationLbl";
            saturationLbl.Size = new Size(67, 17);
            saturationLbl.TabIndex = 16;
            saturationLbl.Text = "Saturation";
            // 
            // contrastLbl
            // 
            contrastLbl.AutoSize = true;
            contrastLbl.Font = new Font("Ebrima", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contrastLbl.ForeColor = SystemColors.ButtonFace;
            contrastLbl.Location = new Point(17, 190);
            contrastLbl.Name = "contrastLbl";
            contrastLbl.Size = new Size(57, 17);
            contrastLbl.TabIndex = 15;
            contrastLbl.Text = "Contrast";
            // 
            // brightnessLbl
            // 
            brightnessLbl.AutoSize = true;
            brightnessLbl.Font = new Font("Ebrima", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            brightnessLbl.ForeColor = SystemColors.ButtonFace;
            brightnessLbl.Location = new Point(17, 107);
            brightnessLbl.Name = "brightnessLbl";
            brightnessLbl.Size = new Size(68, 17);
            brightnessLbl.TabIndex = 13;
            brightnessLbl.Text = "Brightness";
            // 
            // brightnessTrackbar
            // 
            brightnessTrackbar.Location = new Point(17, 137);
            brightnessTrackbar.Maximum = 100;
            brightnessTrackbar.Minimum = -100;
            brightnessTrackbar.Name = "brightnessTrackbar";
            brightnessTrackbar.Size = new Size(174, 45);
            brightnessTrackbar.TabIndex = 12;
            brightnessTrackbar.Scroll += BrightnessTrackbar_Scroll;
            // 
            // exposureLbl
            // 
            exposureLbl.AutoSize = true;
            exposureLbl.Font = new Font("Ebrima", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exposureLbl.ForeColor = SystemColors.ButtonFace;
            exposureLbl.Location = new Point(17, 30);
            exposureLbl.Name = "exposureLbl";
            exposureLbl.Size = new Size(62, 17);
            exposureLbl.TabIndex = 10;
            exposureLbl.Text = "Exposure";
            // 
            // exposureTrackbar
            // 
            exposureTrackbar.Location = new Point(17, 59);
            exposureTrackbar.Maximum = 100;
            exposureTrackbar.Minimum = -100;
            exposureTrackbar.Name = "exposureTrackbar";
            exposureTrackbar.Size = new Size(174, 45);
            exposureTrackbar.TabIndex = 9;
            exposureTrackbar.Scroll += ExposureTrackbar_Scroll;
            // 
            // effectsPanel
            // 
            effectsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            effectsPanel.BackColor = Color.FromArgb(29, 33, 37);
            effectsPanel.Controls.Add(effectnoneLbl);
            effectsPanel.Controls.Add(nonePbox);
            effectsPanel.Controls.Add(effect3Lbl);
            effectsPanel.Controls.Add(effect2Lbl);
            effectsPanel.Controls.Add(effect1Lbl);
            effectsPanel.Controls.Add(sepiaPbox);
            effectsPanel.Controls.Add(invertPbox);
            effectsPanel.Controls.Add(greyscalePbox);
            effectsPanel.Location = new Point(76, 41);
            effectsPanel.Name = "effectsPanel";
            effectsPanel.Size = new Size(205, 611);
            effectsPanel.TabIndex = 9;
            // 
            // effectnoneLbl
            // 
            effectnoneLbl.AutoSize = true;
            effectnoneLbl.BackColor = Color.Transparent;
            effectnoneLbl.Font = new Font("Ebrima", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            effectnoneLbl.ForeColor = SystemColors.ButtonFace;
            effectnoneLbl.Location = new Point(87, 120);
            effectnoneLbl.Name = "effectnoneLbl";
            effectnoneLbl.Size = new Size(41, 17);
            effectnoneLbl.TabIndex = 7;
            effectnoneLbl.Text = "None";
            // 
            // nonePbox
            // 
            nonePbox.BorderStyle = BorderStyle.FixedSingle;
            nonePbox.Cursor = Cursors.Hand;
            nonePbox.Location = new Point(43, 24);
            nonePbox.Name = "nonePbox";
            nonePbox.Size = new Size(125, 108);
            nonePbox.SizeMode = PictureBoxSizeMode.Zoom;
            nonePbox.TabIndex = 6;
            nonePbox.TabStop = false;
            nonePbox.Click += nonePbox_Click;
            // 
            // effect3Lbl
            // 
            effect3Lbl.AutoSize = true;
            effect3Lbl.BackColor = Color.Transparent;
            effect3Lbl.Font = new Font("Ebrima", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            effect3Lbl.ForeColor = SystemColors.ButtonFace;
            effect3Lbl.Location = new Point(85, 563);
            effect3Lbl.Name = "effect3Lbl";
            effect3Lbl.Size = new Size(41, 17);
            effect3Lbl.TabIndex = 5;
            effect3Lbl.Text = "Sepia";
            // 
            // effect2Lbl
            // 
            effect2Lbl.AutoSize = true;
            effect2Lbl.BackColor = Color.Transparent;
            effect2Lbl.Font = new Font("Ebrima", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            effect2Lbl.ForeColor = SystemColors.ButtonFace;
            effect2Lbl.Location = new Point(85, 415);
            effect2Lbl.Name = "effect2Lbl";
            effect2Lbl.Size = new Size(44, 17);
            effect2Lbl.TabIndex = 4;
            effect2Lbl.Text = "Invert";
            // 
            // effect1Lbl
            // 
            effect1Lbl.AutoSize = true;
            effect1Lbl.BackColor = Color.Transparent;
            effect1Lbl.Font = new Font("Ebrima", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            effect1Lbl.ForeColor = SystemColors.ButtonFace;
            effect1Lbl.Location = new Point(74, 268);
            effect1Lbl.Name = "effect1Lbl";
            effect1Lbl.Size = new Size(66, 17);
            effect1Lbl.TabIndex = 3;
            effect1Lbl.Text = "Greyscale";
            // 
            // sepiaPbox
            // 
            sepiaPbox.BorderStyle = BorderStyle.FixedSingle;
            sepiaPbox.Cursor = Cursors.Hand;
            sepiaPbox.Location = new Point(43, 468);
            sepiaPbox.Name = "sepiaPbox";
            sepiaPbox.Size = new Size(125, 108);
            sepiaPbox.SizeMode = PictureBoxSizeMode.Zoom;
            sepiaPbox.TabIndex = 2;
            sepiaPbox.TabStop = false;
            sepiaPbox.Click += sepiaPbox_Click;
            // 
            // invertPbox
            // 
            invertPbox.BorderStyle = BorderStyle.FixedSingle;
            invertPbox.Cursor = Cursors.Hand;
            invertPbox.Location = new Point(43, 320);
            invertPbox.Name = "invertPbox";
            invertPbox.Size = new Size(125, 108);
            invertPbox.SizeMode = PictureBoxSizeMode.Zoom;
            invertPbox.TabIndex = 1;
            invertPbox.TabStop = false;
            invertPbox.Click += invertPbox_Click;
            // 
            // greyscalePbox
            // 
            greyscalePbox.BorderStyle = BorderStyle.FixedSingle;
            greyscalePbox.Cursor = Cursors.Hand;
            greyscalePbox.Location = new Point(43, 172);
            greyscalePbox.Name = "greyscalePbox";
            greyscalePbox.Size = new Size(125, 108);
            greyscalePbox.SizeMode = PictureBoxSizeMode.Zoom;
            greyscalePbox.TabIndex = 0;
            greyscalePbox.TabStop = false;
            greyscalePbox.Click += greyscalePbox_Click;
            // 
            // mainPanel
            // 
            mainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.Controls.Add(histogramPanel);
            mainPanel.Controls.Add(dragimgBtn);
            mainPanel.Controls.Add(mainPbox);
            mainPanel.Location = new Point(288, 35);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(879, 617);
            mainPanel.TabIndex = 10;
            // 
            // histogramPanel
            // 
            histogramPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            histogramPanel.BorderStyle = BorderStyle.FixedSingle;
            histogramPanel.Controls.Add(label2);
            histogramPanel.Controls.Add(histogramPbox);
            histogramPanel.Controls.Add(histogramClosebtn);
            histogramPanel.Location = new Point(14, 362);
            histogramPanel.MaximumSize = new Size(368, 241);
            histogramPanel.Name = "histogramPanel";
            histogramPanel.Size = new Size(368, 241);
            histogramPanel.TabIndex = 7;
            histogramPanel.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(16, 15);
            label2.Name = "label2";
            label2.Size = new Size(257, 21);
            label2.TabIndex = 5;
            label2.Text = "Histogram of the Original Image";
            // 
            // histogramPbox
            // 
            histogramPbox.Location = new Point(16, 58);
            histogramPbox.Name = "histogramPbox";
            histogramPbox.Size = new Size(333, 165);
            histogramPbox.SizeMode = PictureBoxSizeMode.Zoom;
            histogramPbox.TabIndex = 4;
            histogramPbox.TabStop = false;
            // 
            // histogramClosebtn
            // 
            histogramClosebtn.FlatAppearance.BorderSize = 0;
            histogramClosebtn.FlatStyle = FlatStyle.Flat;
            histogramClosebtn.Location = new Point(326, -1);
            histogramClosebtn.Name = "histogramClosebtn";
            histogramClosebtn.Size = new Size(41, 34);
            histogramClosebtn.TabIndex = 3;
            histogramClosebtn.Click += histogramClosebtn_Click;
            // 
            // bottomPanel
            // 
            bottomPanel.BackColor = Color.FromArgb(29, 33, 37);
            bottomPanel.Controls.Add(rotleftBtn);
            bottomPanel.Controls.Add(histogramBtn);
            bottomPanel.Controls.Add(rotrightBtn);
            bottomPanel.Controls.Add(resetBtn);
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Location = new Point(69, 658);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(1101, 45);
            bottomPanel.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 18, 20);
            ClientSize = new Size(1170, 703);
            Controls.Add(bottomPanel);
            Controls.Add(adjustPanel);
            Controls.Add(effectsPanel);
            Controls.Add(sidePanel);
            Controls.Add(topPanel);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Image Processing";
            Load += Form1_Load;
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            fileMenu.ResumeLayout(false);
            fileMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mainPbox).EndInit();
            sidePanel.ResumeLayout(false);
            adjustPanel.ResumeLayout(false);
            adjustPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)saturationTrackbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)contrastTrackbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)brightnessTrackbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)exposureTrackbar).EndInit();
            effectsPanel.ResumeLayout(false);
            effectsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nonePbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)sepiaPbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)invertPbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)greyscalePbox).EndInit();
            mainPanel.ResumeLayout(false);
            histogramPanel.ResumeLayout(false);
            histogramPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)histogramPbox).EndInit();
            bottomPanel.ResumeLayout(false);
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
        private Button histogramBtn;
        private Button resetBtn;
        private Button rotrightBtn;
        private Button rotleftBtn;
        private Button dragimgBtn;
        private PictureBox mainPbox;
        private Panel sidePanel;
        private Panel adjustPanel;
        private Button adjustBtn;
        private Button cropBtn;
        private Button substractBtn;
        private Button effectsBtn;
        private Label exposureLbl;
        private TrackBar exposureTrackbar;
        private Label brightnessLbl;
        private TrackBar brightnessTrackbar;
        private TrackBar saturationTrackbar;
        private TrackBar contrastTrackbar;
        private Label saturationLbl;
        private Label contrastLbl;
        private Panel effectsPanel;
        private PictureBox sepiaPbox;
        private PictureBox invertPbox;
        private PictureBox greyscalePbox;
        private Label effect3Lbl;
        private Label effect2Lbl;
        private Label effect1Lbl;
        private Panel mainPanel;
        private Label effectnoneLbl;
        private PictureBox nonePbox;
        private Panel bottomPanel;
        private Label label1;
        private Panel histogramPanel;
        private Button histogramClosebtn;
        private PictureBox histogramPbox;
        private Label label2;
        private ToolStripMenuItem useCameraToolStripMenuItem;
    }
}
