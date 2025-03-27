using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.Filter = "Image|*.png;*.png;*.bmp;*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK) { }
                pictureBox1.Image = new Bitmap(Image.FromFile(@openFileDialog.FileName));
            }
        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            buttonGreen.BackColor = Color.Green;

            Bitmap greenPic = new Bitmap(pictureBox1.Image);
            for (int x = 0; x <= greenPic.Width - 1; x++) {
                for (int y = 0; y <= greenPic.Height - 1; y++) { 
                    if(greenPic.GetPixel(x, y).G < greenPic.GetPixel(x,y).R + greenPic.GetPixel(x, y).B)
                    {
                        greenPic.SetPixel(x, y, Color.Black);
                    }
                }
            }
            pictureBox1.Image = greenPic;
            pictureBox1.Refresh();
        }
    }
}
