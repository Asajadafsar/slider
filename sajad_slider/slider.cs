using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace sajad_slider
{
    public partial class slider : Form
    {
        int index = 0;
        private List<string> ImagesList = new List<string>();
        public slider()
        {
            InitializeComponent();

        }
        
        private void zoomin_Click(object sender, EventArgs e)
        {
            images.Width += 4;
            images.Height += 3;
            images.Left=(this.Width-images.Width)/2;
            images.Top=(this.Height-images.Height)/2;
        }

        private void zoomout_Click(object sender, EventArgs e)
        {
            images.Width -= 4;
            images.Height -= 3;
            images.Left = (this.Width - images.Width) / 2;
            images.Top = (this.Height - images.Height) / 2;
        }
        private void browser(object sender, EventArgs e)
        {
        OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "slidersajad";
            ofd.Filter = "Images (*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
            ofd.InitialDirectory = @"C:\";
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                change.Visible = true;
                back.Visible = true;
                    ImagesList.Clear();
                foreach (string fileName in ofd.FileNames)
                {
                    ImagesList.Add(fileName);

                }
                ChangeImage(index);
            }
                
        }
        private void ChangeImage(int index)
        {
            if (ImagesList.Count > 0)
            {
                images.ImageLocation = ImagesList[index];
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            index = (index - 1 + ImagesList.Count) % ImagesList.Count;
            ChangeImage(index);
        }
        private void next_Click(object sender, EventArgs e)
        {
            index = (index + 1) % ImagesList.Count;
            ChangeImage(index);
        }

    }
}
