using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace image_viewer
{
    /// <summary>
    /// Shows an image and relevant controls.
    /// </summary>
    public partial class ImageForm : Form
    {
        private static readonly string[] _validExtensions = { ".jpg", ".jpeg", ".bmp", ".gif", ".png", ".tiff" }; //  etc

        string[] images = new string[0];
        int currentImage;
        Image previousImage;
        Image nextImage;
        bool canPrevious; // Whether there is a previous image.
        bool canNext; // Whether there is a next image.

        public ImageForm()
        {
            InitializeComponent();
            ImageChanged();
        }

        private void SetImage(Image image)
        {
            pictureBox.Image = image;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            SetImage(Image.FromStream(openFileDialog1.OpenFile()));

            string directoryPath = Path.GetDirectoryName(openFileDialog1.FileName);
            images = Directory.GetFiles(directoryPath);

            currentImage = 0;
            foreach(string imageName in images)
            {
                if (imageName == openFileDialog1.FileName)
                    break;
                currentImage++;
            }

            ImageChanged();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            PreviousImage();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            NextImage();
        }

        private void ImageChanged()
        {
            string previousImagePath = "", nextImagePath = "";

            canPrevious = false;
            if(currentImage - 1 >= 0)
            {
                previousImagePath = images[currentImage - 1];
                if (IsImage(previousImagePath))
                    canPrevious = true;
            }

            canNext = false;
            if(currentImage < images.Length)
            {
                nextImagePath = images[currentImage + 1];
                if (IsImage(nextImagePath))
                    canNext = true;
            }

            // Load previous & next image.
            if (canPrevious)
                previousImage = Image.FromFile(previousImagePath);
            if (canNext)
                nextImage = Image.FromFile(nextImagePath);

            SetButtonEnableds();
        }

        private void SetButtonEnableds()
        {
            previousButton.Enabled = canPrevious;

            nextButton.Enabled = canNext;
        }

        public static bool IsImage(string file)
        {
            return IsImageExtension(Path.GetExtension(file));
        }

        public static bool IsImageExtension(string ext)
        {
            return _validExtensions.Contains(ext);
        }

        private void PreviousImage()
        {
            if (canPrevious)
            {
                currentImage--;
                SetImage(previousImage);

                ImageChanged();
            }
        }

        private void NextImage()
        {
            if (canNext)
            {
                currentImage++;
                SetImage(nextImage);

                ImageChanged();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Left:
                    PreviousImage();
                    break;
                case Keys.Right:
                    NextImage();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
