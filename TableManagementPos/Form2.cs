using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableManagementPos
{
    public partial class Form2 : Form
    {
        string Table = "Table";
        int counter = 1;
        public Form2()
        {
            InitializeComponent();
            TableflowLayoutPanel.AutoScroll = true;
        }

        public void AddButton()
        {
            Button button = new Button();
            button.Text = Table + counter.ToString();
            counter++;
            button.Size = new Size(150, 100);
            Label label = new Label();
            label.Text = "4";
            label.Location = new Point(2, 2);
            label.BackColor = Color.Transparent;
            button.Controls.Add(label);
            this.TableflowLayoutPanel.Controls.Add(button);
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
