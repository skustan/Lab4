using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(Image.FromFile(@openFileDialog.FileName));
                }
            }
        }

        private void buttonRotate_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton90.Checked)
                {
                    pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    pictureBox1.Refresh();

                }
                if (radioButton180.Checked)
                {

                    pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    pictureBox1.Refresh();

                }
                if (radioButton270.Checked)
                {

                    pictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    pictureBox1.Refresh();
                }
            }
            catch { }
        }
    }
}
