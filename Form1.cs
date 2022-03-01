using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textButton_Click(object sender, EventArgs e)
        {
            //testPictureBox.Load("E:\\AN III\\SEM III\\bmp_jpeg.jpg");
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                testPictureBox.Load(openFileDialog1.FileName);
            }
        }
    }
}
