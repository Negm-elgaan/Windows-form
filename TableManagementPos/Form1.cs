using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;



namespace TableManagementPos
{
    
    public partial class Form1 : Form
    {
        List<clsTable> TablesList = new List<clsTable>();
        Form2 f2 = new Form2();
        public Form1()
        {
            InitializeComponent();
            /*clsTable clsTable1 = new clsTable();
            TablesList.Add(clsTable1);
            clsTable clsTable2 = new clsTable();
            TablesList.Add(clsTable2);
            clsTable clsTable3 = new clsTable();
            TablesList.Add(clsTable3);
            clsTable clsTable4 = new clsTable();
            TablesList.Add(clsTable4);
            clsTable clsTable5 = new clsTable();
            TablesList.Add(clsTable5);*/
            
        }

        private void TablePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddTableBtn_Click(object sender, EventArgs e)
        {
            f2.AddButton();
        }

        private void GoToTa_Click(object sender, EventArgs e)
        {
            f2.Show();
        }
    }
}
