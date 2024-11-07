using System.Runtime.InteropServices;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadButtonIcons();

            dragimgBtn.AllowDrop = true;
            dragimgBtn.DragEnter += dragimgBtn_DragEnter;
            dragimgBtn.DragDrop += dragimgBtn_DragDrop;
            dragimgBtn.Click += dragimgBtn_Click;
            dragimgBtn.Paint += dragimgBtn_Paint;
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

            Color defaultColor = Color.FromArgb(29, 33, 37);
            Color hoverColor = Color.FromArgb(40, 44, 48);

            histogramBtn.MouseEnter += (s, e) => histogramBtn.BackColor = hoverColor;
            histogramBtn.MouseLeave += (s, e) => histogramBtn.BackColor = defaultColor;

            resetBtn.MouseEnter += (s, e) => resetBtn.BackColor = hoverColor;
            resetBtn.MouseLeave += (s, e) => resetBtn.BackColor = defaultColor;

            rotleftBtn.MouseEnter += (s, e) => rotleftBtn.BackColor = hoverColor;
            rotleftBtn.MouseLeave += (s, e) => rotleftBtn.BackColor = defaultColor;

            rotrightBtn.MouseEnter += (s, e) => rotrightBtn.BackColor = hoverColor;
            rotrightBtn.MouseLeave += (s, e) => rotrightBtn.BackColor = defaultColor;
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

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void histogramBtn_Click(object sender, EventArgs e)
        {

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {

        }

        private void rotrightBtn_Click(object sender, EventArgs e)
        {

        }

        private void histogramBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void rotleftBtn_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void openBtn_Click(object sender, EventArgs e)
        {

        }
        private void dragimgBtn_Paint(object sender, PaintEventArgs e)
        {
            using (Pen dashedPen = new Pen(Color.BlueViolet, 3))
            {
                dashedPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash; // Set the border style to dashed

                // Draw the dashed border around the button
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
                e.Effect = DragDropEffects.Copy;  // Allow copy action
            }
            else
            {
                e.Effect = DragDropEffects.None;  // Prevent drag-drop if it's not a file
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
                mainPbox.Image = Image.FromFile(filePath);
                dragimgBtn.Visible = false;
            }
        }

    }

    public class CustomMenuRenderer : ToolStripProfessionalRenderer
    {
        private Color menuBackColor = Color.FromArgb(29, 33, 37);
        private Color menuTextColor = Color.White;

        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            // Background color when item is selected or pressed
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
            e.TextColor = menuTextColor; // Text color for all items
            base.OnRenderItemText(e);
        }
    }


}
