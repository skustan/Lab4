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
    }
}
