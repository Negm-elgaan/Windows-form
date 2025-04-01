using PictureBoxEx.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBoxEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RBboy_CheckedChanged(object sender, EventArgs e)
        {
            PB1.Image = Image.FromFile(@"C:\Images\Boy.png");
            LBTitle.Text = "Boy";
        }

        private void RBgirl_CheckedChanged(object sender, EventArgs e)
        {
            PB1.Image = Image.FromFile(@"C:\Images\Girl.png");
            LBTitle.Text = "Girl";
        }

        private void RBbook_CheckedChanged(object sender, EventArgs e)
        {
            PB1.Image = Image.FromFile(@"C:\Images\Book.png");
            LBTitle.Text = "Book";
        }

        private void RBpen_CheckedChanged(object sender, EventArgs e)
        {
            PB1.Image = Image.FromFile(@"C:\Images\Pen.png");
            LBTitle.Text = "Pen";
        }
    }
}
