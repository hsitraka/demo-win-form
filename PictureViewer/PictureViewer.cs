using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class PictureViewer : Form
    {
        public PictureViewer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
                imageSizeComboBox.Enabled = true;
            }
        }

        private void imageSizeComboBox_SelectedChanged(object sender, EventArgs e)
        {
            if (imageSizeComboBox.SelectedItem.ToString() == "Normal")
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
            else if (imageSizeComboBox.SelectedItem.ToString() == "Stretch")
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            switch (imageSizeComboBox.SelectedItem.ToString())
            {
                case "Normal":
                    pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
                    break;
                case "Stretch":
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case "Zoom":
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case "Auto size":
                    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                case "Center":
                    pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                default:
                    break;
            }
        }
    }
}
