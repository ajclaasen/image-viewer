using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace image_viewer
{
    public partial class Tag : UserControl
    {
        public Tag(string name)
        {
            InitializeComponent();

            tagLabel.Text = name;
            this.Name = name;
        }

        public Tag(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
