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
using Newtonsoft.Json;

namespace image_viewer
{
    /// <summary>
    /// Shows the library & allows users to interact with it.
    /// </summary>
    public partial class LibraryForm : Form
    {
        public LibraryForm()
        {
            InitializeComponent();

            // Load library
            if (File.Exists("library.json"))
            {
                // Load the library
            }
            else
            {
                FileStream libraryFileStream = File.Create("library.json");


            }



            // Do the rest

        }
    }
}
