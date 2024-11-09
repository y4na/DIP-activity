using System.Runtime.InteropServices;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        private Image originalImage;
        private readonly Color defaultColor = Color.FromArgb(29, 33, 37);
        private readonly Color hoverColor = Color.FromArgb(40, 44, 48);
        private TrackBar exposureTrackBar;
        private TrackBar brightnessTrackBar;
        private TrackBar contrastTrackBar;
        private TrackBar saturationTrackBar;
        public Form1()
        {
            InitializeComponent();
            LoadButtonIcons();
            InitializeDragDropEvents();
            InitializeHoverEvents();

            this.Resize += Form1_Resize;
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            mainPbox.Location = new Point(
                (mainPanel.ClientSize.Width - mainPbox.Width) / 2,
                (mainPanel.ClientSize.Height - mainPbox.Height) / 2
            );

            dragimgBtn.Location = new Point(
                (mainPanel.ClientSize.Width - dragimgBtn.Width) / 2,
                (mainPanel.ClientSize.Height - dragimgBtn.Height) / 2
            );


        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void Form1_Load(object sender, EventArgs e)
        {
            fileMenu.Renderer = new CustomMenuRenderer();

            foreach (ToolStripMenuItem item in fileMenu.Items)
            {
                item.ForeColor = Color.White;
                foreach (ToolStripItem dropDownItem in item.DropDownItems)
                {
                    dropDownItem.ForeColor = Color.White;
                }
            }
        }

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void LoadButtonIcons()
        {
            string assetsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "assets");

            exitBtn.Image = Image.FromFile(Path.Combine(assetsPath, "close.png"));
            maximizeBtn.Image = Image.FromFile(Path.Combine(assetsPath, "maximize.png"));
            minimizeBtn.Image = Image.FromFile(Path.Combine(assetsPath, "minimize.png"));
            histogramBtn.Image = Image.FromFile(Path.Combine(assetsPath, "histo.png"));
            resetBtn.Image = Image.FromFile(Path.Combine(assetsPath, "reset.png"));
            rotleftBtn.Image = Image.FromFile(Path.Combine(assetsPath, "rotate-left.png"));
            rotrightBtn.Image = Image.FromFile(Path.Combine(assetsPath, "rotate-right.png"));
            dragimgBtn.Image = Image.FromFile(Path.Combine(assetsPath, "image.png"));
            adjustBtn.Image = Image.FromFile(Path.Combine(assetsPath, "adjust.png"));
            cropBtn.Image = Image.FromFile(Path.Combine(assetsPath, "crop.png"));
            effectsBtn.Image = Image.FromFile(Path.Combine(assetsPath, "effects.png"));
            substractBtn.Image = Image.FromFile(Path.Combine(assetsPath, "diagonal.png"));
            histogramClosebtn.Image = Image.FromFile(Path.Combine(assetsPath, "close.png"));

            dragimgBtn.ImageAlign = ContentAlignment.MiddleCenter;

        }

        private Image GetEmbeddedImage(string resourceName)
        {
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            using (var stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream != null)
                    return Image.FromStream(stream);
                throw new Exception("Resource not found: " + resourceName);
            }
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void maximizeBtn_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InitializeDragDropEvents()
        {
            dragimgBtn.AllowDrop = true;
            dragimgBtn.DragEnter += dragimgBtn_DragEnter;
            dragimgBtn.DragDrop += dragimgBtn_DragDrop;
            dragimgBtn.Click += dragimgBtn_Click;
            dragimgBtn.Paint += dragimgBtn_Paint;
        }

        private void InitializeHoverEvents()
        {
            AddHoverEffect(histogramBtn);
            AddHoverEffect(resetBtn);
            AddHoverEffect(rotleftBtn);
            AddHoverEffect(rotrightBtn);
        }

        private void AddHoverEffect(Button button)
        {
            button.MouseEnter += (s, e) => button.BackColor = hoverColor;
            button.MouseLeave += (s, e) => button.BackColor = defaultColor;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void histogramBtn_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                // Ensure the original image is cast to Bitmap
                Bitmap bitmapImage = originalImage as Bitmap;
                if (bitmapImage != null)
                {
                    // Generate histogram based on the lightness of the image
                    Bitmap lightnessHistogram = GenerateLightnessHistogram(bitmapImage);

                    // Display the generated histogram on the picture box
                    histogramPbox.Image = lightnessHistogram;

                    // Make the histogram panel visible
                    histogramPanel.Visible = true;
                }
                else
                {
                    MessageBox.Show("The original image is not a Bitmap.");
                }
            }
            else
            {
                MessageBox.Show("Please load an image first.");
            }
        }
        private void histogramClosebtn_Click(object sender, EventArgs e)
        {
            histogramPanel.Visible = false;
        }

        private Bitmap GenerateLightnessHistogram(Bitmap image)
        {
            int[] histogram = new int[256];

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixelColor = image.GetPixel(x, y);

                    int max = Math.Max(pixelColor.R, Math.Max(pixelColor.G, pixelColor.B));
                    int min = Math.Min(pixelColor.R, Math.Min(pixelColor.G, pixelColor.B));
                    int lightness = (max + min) / 2;

                    histogram[lightness]++;
                }
            }

            Bitmap histogramBitmap = new Bitmap(256, 200);
            Graphics g = Graphics.FromImage(histogramBitmap);
            g.Clear(Color.White);

            int maxValue = histogram.Max();

            for (int i = 0; i < 256; i++)
            {
                int barHeight = 0;
                if (maxValue > 0)
                {
                    barHeight = (int)((double)histogram[i] / maxValue * histogramBitmap.Height);
                }

                if (barHeight > 0)
                {
                    g.DrawLine(Pens.Black, i, histogramBitmap.Height, i, histogramBitmap.Height - barHeight);
                }
            }

            return histogramBitmap;
        }


        private void resetBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to clear all changes?", "Confirm Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ResetImage();
            }
        }

        private void ResetImage()
        {
            if (originalImage == null)
            {
                MessageBox.Show("Original image not loaded.");
                return;
            }
            mainPbox.Image = (Image)originalImage.Clone();
            nonePbox.Image = (Image)originalImage.Clone();
            greyscalePbox.Image = ConvertToGrayscale(originalImage);
            sepiaPbox.Image = ConvertToSepia(originalImage);
            invertPbox.Image = ConvertToInvert(originalImage);

            if (exposureTrackBar != null && brightnessTrackBar != null && contrastTrackBar != null && saturationTrackBar != null)
            {
                exposureTrackBar.Value = 0;
                brightnessTrackBar.Value = 0;
                contrastTrackBar.Value = 0;
                saturationTrackBar.Value = 0;
            }
        }



        private void rotrightBtn_Click(object sender, EventArgs e)
        {
            if (mainPbox.Image != null)
            {
                RotateImage(90);
            }
        }


        private void rotleftBtn_Click(object sender, EventArgs e)
        {
            if (mainPbox.Image != null)
            {
                RotateImage(-90);
            }
        }


        private void RotateImage(int angle)
        {
            if (mainPbox.Image == null) return;

            Bitmap rotatedImage = new Bitmap(mainPbox.Image);

            rotatedImage.RotateFlip(angle == 90 ? RotateFlipType.Rotate90FlipNone : RotateFlipType.Rotate270FlipNone);

            mainPbox.Image = rotatedImage;
            nonePbox.Image = rotatedImage;

            greyscalePbox.Image = ConvertToGrayscale(rotatedImage);
            sepiaPbox.Image = ConvertToSepia(rotatedImage);
            invertPbox.Image = ConvertToInvert(rotatedImage);

            nonePbox.SizeMode = PictureBoxSizeMode.Zoom;
            greyscalePbox.SizeMode = PictureBoxSizeMode.Zoom;
            sepiaPbox.SizeMode = PictureBoxSizeMode.Zoom;
            invertPbox.SizeMode = PictureBoxSizeMode.Zoom;
            mainPbox.SizeMode = PictureBoxSizeMode.Zoom;

            originalImage = (Image)rotatedImage.Clone();
        }



        private void openBtn_Click(object sender, EventArgs e)
        {

        }


        private void dragimgBtn_Paint(object sender, PaintEventArgs e)
        {
            using (Pen dashedPen = new Pen(Color.BlueViolet, 3))
            {
                dashedPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                e.Graphics.DrawRectangle(dashedPen, 0, 0, dragimgBtn.Width - 1, dragimgBtn.Height - 1);
            }
        }

        private void dragimgBtn_Click(object sender, EventArgs e)
        {
            OpenImageDialog();
        }

        private void dragimgBtn_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void dragimgBtn_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                LoadImage(files[0]);
            }
        }

        private void OpenImageDialog()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadImage(openFileDialog.FileName);
                }
            }
        }

        private void LoadImage(string filePath)
        {
            if (File.Exists(filePath))
            {

                Image image = Image.FromFile(filePath);
                mainPbox.Image = image;

                if (originalImage == null)
                {
                    originalImage = (Image)image.Clone();
                }

                nonePbox.Image = image;
                greyscalePbox.Image = ConvertToGrayscale(image);
                sepiaPbox.Image = ConvertToSepia(image);
                invertPbox.Image = ConvertToInvert(image);

                nonePbox.SizeMode = PictureBoxSizeMode.Zoom;
                greyscalePbox.SizeMode = PictureBoxSizeMode.Zoom;
                sepiaPbox.SizeMode = PictureBoxSizeMode.Zoom;
                invertPbox.SizeMode = PictureBoxSizeMode.Zoom;
                mainPbox.SizeMode = PictureBoxSizeMode.Zoom;

                dragimgBtn.Visible = false;

            }
        }




        private void adjustBtn_Click(object sender, EventArgs e)
        {
            adjustPanel.Visible = true;
            effectsPanel.Visible = false;
        }

        private void effectsBtn_Click(object sender, EventArgs e)
        {
            adjustPanel.Visible = false;
            effectsPanel.Visible = true;
        }


        private bool isSepiaApplied = false;
        private bool isGrayscaleApplied = false;
        private bool isInvertApplied = false;

        private void nonePbox_Click(object sender, EventArgs e)
        {
            mainPbox.Image = originalImage;

            isSepiaApplied = false;
            isGrayscaleApplied = false;
            isInvertApplied = false;
        }

        private void greyscalePbox_Click(object sender, EventArgs e)
        {
            ResetEffects();

            if (isGrayscaleApplied)
            {

                mainPbox.Image = originalImage;
                isGrayscaleApplied = false;
            }
            else
            {
                ApplyEffectToMainPbox(ConvertToGrayscale(mainPbox.Image));
                isGrayscaleApplied = true;
            }
        }

        private void sepiaPbox_Click(object sender, EventArgs e)
        {
            ResetEffects();

            if (isSepiaApplied)
            {
                mainPbox.Image = originalImage;
                isSepiaApplied = false;
            }
            else
            {
                ApplyEffectToMainPbox(ConvertToSepia(mainPbox.Image));
                isSepiaApplied = true;
            }
        }

        private void invertPbox_Click(object sender, EventArgs e)
        {
            ResetEffects();

            if (isInvertApplied)
            {
                mainPbox.Image = originalImage;
                isInvertApplied = false;
            }
            else
            {
                ApplyEffectToMainPbox(ConvertToInvert(mainPbox.Image));
                isInvertApplied = true;
            }
        }

        private void ApplyEffectToMainPbox(Image newImage)
        {
            if (originalImage == null)
            {
                originalImage = mainPbox.Image;
            }

            mainPbox.Image = newImage;
        }

        private void ResetEffects()
        {

            if (isSepiaApplied)
            {
                mainPbox.Image = originalImage;
                isSepiaApplied = false;
            }
            if (isGrayscaleApplied)
            {
                mainPbox.Image = originalImage;
                isGrayscaleApplied = false;
            }
            if (isInvertApplied)
            {
                mainPbox.Image = originalImage;
                isInvertApplied = false;
            }
        }

        private Image ConvertToGrayscale(Image originalImage)
        {

            Bitmap bmp = new Bitmap(originalImage);
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color originalColor = bmp.GetPixel(x, y);
                    int grayValue = (int)(originalColor.R * 0.3 + originalColor.G * 0.59 + originalColor.B * 0.11);
                    Color grayColor = Color.FromArgb(grayValue, grayValue, grayValue);
                    bmp.SetPixel(x, y, grayColor);
                }
            }
            return bmp;
        }

        private Image ConvertToSepia(Image originalImage)
        {
            Bitmap bmp = new Bitmap(originalImage);
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color originalColor = bmp.GetPixel(x, y);
                    int tr = (int)(originalColor.R * 0.393 + originalColor.G * 0.769 + originalColor.B * 0.189);
                    int tg = (int)(originalColor.R * 0.349 + originalColor.G * 0.686 + originalColor.B * 0.168);
                    int tb = (int)(originalColor.R * 0.272 + originalColor.G * 0.534 + originalColor.B * 0.131);
                    tr = tr > 255 ? 255 : tr;
                    tg = tg > 255 ? 255 : tg;
                    tb = tb > 255 ? 255 : tb;
                    Color sepiaColor = Color.FromArgb(tr, tg, tb);
                    bmp.SetPixel(x, y, sepiaColor);
                }
            }
            return bmp;
        }

        private Image ConvertToInvert(Image originalImage)
        {
            Bitmap bmp = new Bitmap(originalImage);
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color originalColor = bmp.GetPixel(x, y);
                    Color invertColor = Color.FromArgb(255 - originalColor.R, 255 - originalColor.G, 255 - originalColor.B);
                    bmp.SetPixel(x, y, invertColor);
                }
            }
            return bmp;
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z)
            {
                UndoEffect();
            }
        }

        private void UndoEffect()
        {

            if (originalImage != null)
            {
                mainPbox.Image = originalImage;
                originalImage = null;
            }
        }


        private void ExposureTrackbar_Scroll(object sender, EventArgs e)
        {
            AdjustExposure(exposureTrackbar.Value);
        }

        private void BrightnessTrackbar_Scroll(object sender, EventArgs e)
        {
            AdjustBrightness(brightnessTrackbar.Value);
        }

        private void ContrastTrackbar_Scroll(object sender, EventArgs e)
        {
            AdjustContrast(contrastTrackbar.Value);
        }

        private void SaturationTrackbar_Scroll(object sender, EventArgs e)
        {
            AdjustSaturation(saturationTrackbar.Value);
        }

        private void AdjustExposure(int value)
        {
            if (originalImage == null || value == 0)
            {
                mainPbox.Image = originalImage;
                return;
            }

            Bitmap bmp = new Bitmap(originalImage.Width, originalImage.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                float exposureFactor = 1.0f + (value / 100.0f);

                ColorMatrix colorMatrix = new ColorMatrix(new float[][]
                {
            new float[] {exposureFactor, 0, 0, 0, 0},
            new float[] {0, exposureFactor, 0, 0, 0},
            new float[] {0, 0, exposureFactor, 0, 0},
            new float[] {0, 0, 0, 1, 0},
            new float[] {0, 0, 0, 0, 1}
                });

                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(colorMatrix);
                g.DrawImage(originalImage, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, originalImage.Width, originalImage.Height, GraphicsUnit.Pixel, attributes);
            }

            mainPbox.Image = bmp;
        }

        private void AdjustBrightness(int value)
        {
            if (originalImage == null || value == 0)
            {
                mainPbox.Image = originalImage;
                return;
            }

            Bitmap bmp = new Bitmap(originalImage.Width, originalImage.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                float brightnessFactor = value / 255.0f;

                ColorMatrix colorMatrix = new ColorMatrix(new float[][]
                {
            new float[] {1, 0, 0, 0, 0},
            new float[] {0, 1, 0, 0, 0},
            new float[] {0, 0, 1, 0, 0},
            new float[] {0, 0, 0, 1, 0},
            new float[] {brightnessFactor, brightnessFactor, brightnessFactor, 0, 1}
                });

                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(colorMatrix);
                g.DrawImage(originalImage, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, originalImage.Width, originalImage.Height, GraphicsUnit.Pixel, attributes);
            }

            mainPbox.Image = bmp;
        }


        private void AdjustContrast(int value)
        {
            if (mainPbox.Image == null) return;

            Bitmap bmp = new Bitmap(originalImage);
            float contrast = 1 + (value / 100f);
            float translation = 0.5f * (1 - contrast);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                ColorMatrix colorMatrix = new ColorMatrix(new float[][]
                {
            new float[] {contrast, 0, 0, 0, 0},
            new float[] {0, contrast, 0, 0, 0},
            new float[] {0, 0, contrast, 0, 0},
            new float[] {0, 0, 0, 1, 0},
            new float[] {translation, translation, translation, 0, 1}
                });

                using (ImageAttributes attributes = new ImageAttributes())
                {
                    attributes.SetColorMatrix(colorMatrix);
                    g.DrawImage(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel, attributes);
                }
            }

            mainPbox.Image = bmp;
        }

        private void AdjustSaturation(int value)
        {
            if (mainPbox.Image == null) return;

            Bitmap bmp = new Bitmap(originalImage);
            float saturation = 1 + (value / 100f);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                ColorMatrix colorMatrix = new ColorMatrix(new float[][]
                {
            new float[] {0.213f + 0.787f * saturation, 0.213f - 0.213f * saturation, 0.213f - 0.213f * saturation, 0, 0},
            new float[] {0.715f - 0.715f * saturation, 0.715f + 0.285f * saturation, 0.715f - 0.715f * saturation, 0, 0},
            new float[] {0.072f - 0.072f * saturation, 0.072f - 0.072f * saturation, 0.072f + 0.928f * saturation, 0, 0},
            new float[] {0, 0, 0, 1, 0},
            new float[] {0, 0, 0, 0, 1}
                });

                using (ImageAttributes attributes = new ImageAttributes())
                {
                    attributes.SetColorMatrix(colorMatrix);
                    g.DrawImage(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel, attributes);
                }
            }

            mainPbox.Image = bmp;
        }

        private void cropBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon hehe");
        }

        private void subtractionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog to let the user choose a file
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the filter for image files (optional, you can adjust the types of files the user can select)
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            // Show the dialog and check if the user selected a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image selectedImage = Image.FromFile(openFileDialog.FileName);

                    mainPbox.Image = selectedImage;

                    originalImage = (Image)selectedImage.Clone();

                    nonePbox.Image = selectedImage;
                    greyscalePbox.Image = ConvertToGrayscale(selectedImage);
                    sepiaPbox.Image = ConvertToSepia(selectedImage);
                    invertPbox.Image = ConvertToInvert(selectedImage);

                    nonePbox.SizeMode = PictureBoxSizeMode.Zoom;
                    greyscalePbox.SizeMode = PictureBoxSizeMode.Zoom;
                    sepiaPbox.SizeMode = PictureBoxSizeMode.Zoom;
                    invertPbox.SizeMode = PictureBoxSizeMode.Zoom;
                    mainPbox.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "JPEG Image|*.jpg;*.jpeg|PNG Image|*.png|Bitmap Image|*.bmp|GIF Image|*.gif";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (mainPbox.Image != null)
                    {
                        mainPbox.Image.Save(saveFileDialog.FileName);

                        MessageBox.Show("Image saved successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No image to save.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving image: " + ex.Message);
                }
            }
        }

    }

    public class CustomMenuRenderer : ToolStripProfessionalRenderer
    {
        private Color menuBackColor = Color.FromArgb(29, 33, 37);
        private Color menuTextColor = Color.White;

        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
           
            if (e.Item.Selected || e.Item.Pressed)
            {
              e.Graphics.FillRectangle(new SolidBrush(menuBackColor), e.Item.ContentRectangle);
            }
            else
            {
                base.OnRenderMenuItemBackground(e);
            }
        }

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            e.TextColor = menuTextColor; 
            base.OnRenderItemText(e);
        }
    }


}
