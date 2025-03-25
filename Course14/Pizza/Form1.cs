using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Form1 : Form
    {
        int Size = 0 , Crust = 0 , Toppings = 0 ;
        string Cheese = "" , Onion = "" , Mushroom = "" , Olives = "" , Tomatoes = "" , GreenPepper = "" , Top = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RbSmall_CheckedChanged(object sender, EventArgs e)
        {
            Size = 10;
            label10.Text = (Size + Crust + Toppings).ToString();
            label2.Text = "Small";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void RbMedium_CheckedChanged(object sender, EventArgs e)
        {
            Size = 20;
            label10.Text = (Size + Crust + Toppings).ToString();
            label2.Text = "Medium";
        }

        private void RbLarge_CheckedChanged(object sender, EventArgs e)
        {
            Size = 30;
            label10.Text = (Size + Crust + Toppings).ToString();
            label2.Text = "Large";
        }

        private void RbThin_CheckedChanged(object sender, EventArgs e)
        {
            Crust = 10;
            label10.Text = (Size + Crust + Toppings).ToString();
            label6.Text = "Thin";
        }

        private void RbThick_CheckedChanged(object sender, EventArgs e)
        {
            Crust = 20;
            label10.Text = (Size + Crust + Toppings).ToString();
            label6.Text = "Thick";
        }

        private void RbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            if (RbEatIn.Checked)
            {
                label8.Text = "Eat In";
            }
        }

        private void RbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            if (RbTakeOut.Checked)
            {
                label8.Text = "Take out";
            }
        }

        private void BtnOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order ?" , "Confirm" , MessageBoxButtons.OKCancel , MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully" , "Success" , MessageBoxButtons.OK , MessageBoxIcon.Exclamation);
                GbSize.Enabled = false;
                GbCrustType.Enabled = false;
                GbToppings.Enabled = false;
                GbWhereToEat.Enabled = false;
            }
            else
            {
                MessageBox.Show("Order Cancelled" , "Cancel" , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnResetForm_Click(object sender, EventArgs e)
        {
            GbSize.Enabled = true;
            GbCrustType.Enabled = true;
            GbToppings.Enabled = true;
            GbWhereToEat.Enabled = true;
            Cheese = "";
            Onion = "";
            Mushroom = "";
            Olives = "";
            Tomatoes = "";
            GreenPepper = "";
            Top = "";
            label4.Text = "No Toppings";
        }

        private void CkbOnion_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbOnion.Checked)
            {
                Toppings += 5;
                label10.Text = (Size + Crust + Toppings).ToString();
                Onion = "Onion,";
                Top = Cheese + Onion + Mushroom + Olives + Tomatoes + GreenPepper;
                if (Top[Top.Length - 1] == ',')
                {
                    Top = Top.Remove(Top.Length - 1);
                }
                label4.Text = Top;
            }
            else
            {
                Toppings -= 5;
                label10.Text = (Size + Crust + Toppings).ToString();
                Onion = "";
                Top = Cheese + Onion + Mushroom + Olives + Tomatoes + GreenPepper;
                label4.Text = Top;
                if (Top == "")
                {
                    label4.Text = "No Toppings";
                }
            }
        }

        private void CkBMushroom_CheckedChanged(object sender, EventArgs e)
        {
            if (CkBMushroom.Checked)
            {
                Toppings += 5;
                label10.Text = (Size + Crust + Toppings).ToString();
                Mushroom = "Mushroom,";
                Top = Cheese + Onion + Mushroom + Olives + Tomatoes + GreenPepper;
                if (Top[Top.Length - 1] == ',')
                {
                    Top = Top.Remove(Top.Length - 1);
                }
                label4.Text = Top;
            }
            else
            {
                Toppings -= 5;
                label10.Text = (Size + Crust + Toppings).ToString();
                Mushroom = "";
                Top = Cheese + Onion + Mushroom + Olives + Tomatoes + GreenPepper;
                label4.Text = Top;
                if (Top == "")
                {
                    label4.Text = "No Toppings";
                }
            }
        }

        private void CkbOlive_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbOlive.Checked)
            {
                Toppings += 5;
                label10.Text = (Size + Crust + Toppings).ToString();
                Olives = "Olives,";
                Top = Cheese + Onion + Mushroom + Olives + Tomatoes + GreenPepper;
                if (Top[Top.Length - 1] == ',')
                {
                    Top = Top.Remove(Top.Length - 1);
                }
                label4.Text = Top;
            }
            else
            {
                Toppings -= 5;
                label10.Text = (Size + Crust + Toppings).ToString();
                Olives = "";
                Top = Cheese + Onion + Mushroom + Olives + Tomatoes + GreenPepper;
                label4.Text = Top;
                if (Top == "")
                {
                    label4.Text = "No Toppings";
                }
            }
        }

        private void CkbTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbTomatoes.Checked)
            {
                Toppings += 5;
                label10.Text = (Size + Crust + Toppings).ToString();
                Tomatoes = "Tomatoes,";
                Top = Cheese + Onion + Mushroom + Olives + Tomatoes + GreenPepper;
                if (Top[Top.Length - 1] == ',')
                {
                    Top = Top.Remove(Top.Length - 1);
                }
                label4.Text = Top;
            }
            else
            {
                Toppings -= 5;
                label10.Text = (Size + Crust + Toppings).ToString();
                Tomatoes = "";
                Top = Cheese + Onion + Mushroom + Olives + Tomatoes + GreenPepper;
                label4.Text = Top;
                if (Top == "")
                {
                    label4.Text = "No Toppings";
                }
            }
        }

        private void CkbGreenPepper_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbGreenPepper.Checked)
            {
                Toppings += 5;
                label10.Text = (Size + Crust + Toppings).ToString();
                GreenPepper = "Green Pepper";
                Top = Cheese + Onion + Mushroom + Olives + Tomatoes + GreenPepper;
                if (Top[Top.Length - 1] == ',')
                {
                    Top = Top.Remove(Top.Length - 1);
                }
                label4.Text = Top;
            }
            else
            {
                Toppings -= 5;
                label10.Text = (Size + Crust + Toppings).ToString();
                GreenPepper = "";
                Top = Cheese + Onion + Mushroom + Olives + Tomatoes + GreenPepper;
                label4.Text = Top;
                if (Top == "")
                {
                    label4.Text = "No Toppings";
                }
            }
        }

        private void CkbExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbExtraCheese.Checked)
            {
                Toppings += 5;
                label10.Text = (Size + Crust + Toppings).ToString();
                Cheese = "Extra Cheese,";
                Top = Cheese + Onion + Mushroom + Olives + Tomatoes + GreenPepper;
                if (Top[Top.Length - 1] == ',')
                {
                    Top = Top.Remove(Top.Length - 1);
                }
                label4.Text = Top;
            }
            else
            {
                Toppings -= 5;
                label10.Text = (Size + Crust + Toppings).ToString();
                Cheese = "";
                Top = Cheese + Onion + Mushroom + Olives + Tomatoes + GreenPepper;
                label4.Text = Top;
                if (Top == "")
                {
                    label4.Text = "No Toppings";
                }
            }
            
        }

        private void label10_Click(object sender, EventArgs e)
        {
           
           
        }

        private void GbSize_Enter(object sender, EventArgs e)
        {

        }
    }
}
