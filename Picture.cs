using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace image_viewer
{
    public class Picture
    {
        Image image;
        List<string> tags;

        public Picture(Image image, List<string> tags)
        {
            this.image = image;
            this.tags = tags;
        }

        public Picture(string path)
        {
            throw new NotImplementedException();
        }

        public void AddTag(string tag)
        {
            tags.Add(tag);

            // TODO: Perform metadata operations.
        }

        public void RemoveTag(string tag)
        {
            tags.Remove(tag);

            // TODO: Perform metadata operations.
        }

        public Image Image
        {
            get { return image; }
        }

        public List<string> Tags
        {
            get { return tags; }
        }
    }
}
