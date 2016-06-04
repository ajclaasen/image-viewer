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
using System.Windows.Media.Imaging;

namespace image_viewer
{
    // TODO: Find solution for tagless file formats (such as .png).

    /// <summary>
    /// Shows an image and relevant controls.
    /// </summary>
    public partial class ImageForm : Form
    {
        private static readonly string[] _validExtensions = { ".jpg", ".jpeg", ".bmp", ".gif", ".png", ".tiff" };

        List<Tag> tagComponents;
        int currentImage;
        List<Picture> pictures;
        bool canPrevious; // Whether there is a previous image.
        bool canNext; // Whether there is a next image.

        public ImageForm()
        {
            tagComponents = new List<Tag>();
            pictures = new List<Picture>();

            InitializeComponent();
            
            ChangeImage();
        }

        private void SetImage(Image image)
        {
            pictureBox.Image = image;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string fileName = openFileDialog1.FileName;

            // Get the paths to all of the images in the directory of the file chosen
            string directoryPath = Path.GetDirectoryName(fileName);
            List<string> imagePaths = new List<string>();
            imagePaths = new List<string>(Directory.GetFiles(directoryPath));

            imagePaths.RemoveAll(s => !IsImage(s)); // Remove all non-images

            // Fill the pictures list.
            pictures.Clear();
            foreach (string s in imagePaths)
            {
                Image image = Image.FromFile(s);
                List<string> tags = getTags(s);
                pictures.Add(new Picture(image, tags));
            }

            currentImage = imagePaths.FindIndex(s => s == fileName);

            ChangeImage();
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

        private void ChangeImage()
        {
            if(pictures.Count > 0)
                SetImage(pictures[currentImage].Image);

            canPrevious = false;
            if(currentImage - 1 >= 0)
            {
                    canPrevious = true;
            }

            canNext = false;
            if(currentImage + 1 < pictures.Count)
            {
                    canNext = true;
            }

            SetButtonEnableds();
            SetTags();
        }

        private void SetButtonEnableds()
        {
            previousButton.Enabled = canPrevious;

            nextButton.Enabled = canNext;
        }

        private void SetTags()
        {
            tagComponents.Clear();

            if (pictures.Count > 0)
            {
                int height = 0;
                foreach (string s in pictures[currentImage].Tags)
                {
                    image_viewer.Tag tag = new image_viewer.Tag(s);
                    tag.Location = new Point(0, 0 + height);
                    tag.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                    tagsPanel.Controls.Add(tag);

                    height += tag.Height;
                }
            }
        }

        public static bool IsImage(string file)
        {
            return _validExtensions.Contains(Path.GetExtension(file));
        }

        private void PreviousImage()
        {
            if (canPrevious)
            {
                currentImage--;

                ChangeImage();
            }
        }

        private void NextImage()
        {
            if (canNext)
            {
                currentImage++;

                ChangeImage();
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

        public List<string> getTags(string file)
        {
            using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
            {
                BitmapSource img = BitmapFrame.Create(fs);
                BitmapMetadata md = (BitmapMetadata)img.Metadata;
                List<string> tags = new List<string>(md.Keywords);
                return tags;
            }
        }
    }
}
