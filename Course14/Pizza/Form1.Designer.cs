namespace Pizza
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GbSize = new System.Windows.Forms.GroupBox();
            this.RbLarge = new System.Windows.Forms.RadioButton();
            this.RbMedium = new System.Windows.Forms.RadioButton();
            this.RbSmall = new System.Windows.Forms.RadioButton();
            this.GbCrustType = new System.Windows.Forms.GroupBox();
            this.RbThick = new System.Windows.Forms.RadioButton();
            this.RbThin = new System.Windows.Forms.RadioButton();
            this.GbToppings = new System.Windows.Forms.GroupBox();
            this.CkbGreenPepper = new System.Windows.Forms.CheckBox();
            this.CkbOlive = new System.Windows.Forms.CheckBox();
            this.CkbOnion = new System.Windows.Forms.CheckBox();
            this.CkbTomatoes = new System.Windows.Forms.CheckBox();
            this.CkBMushroom = new System.Windows.Forms.CheckBox();
            this.CkbExtraCheese = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GbWhereToEat = new System.Windows.Forms.GroupBox();
            this.RbTakeOut = new System.Windows.Forms.RadioButton();
            this.RbEatIn = new System.Windows.Forms.RadioButton();
            this.BtnOrderPizza = new System.Windows.Forms.Button();
            this.BtnResetForm = new System.Windows.Forms.Button();
            this.GbOrderSummary = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LSize = new System.Windows.Forms.Label();
            this.GbSize.SuspendLayout();
            this.GbCrustType.SuspendLayout();
            this.GbToppings.SuspendLayout();
            this.GbWhereToEat.SuspendLayout();
            this.GbOrderSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbSize
            // 
            this.GbSize.Controls.Add(this.RbLarge);
            this.GbSize.Controls.Add(this.RbMedium);
            this.GbSize.Controls.Add(this.RbSmall);
            this.GbSize.Location = new System.Drawing.Point(12, 71);
            this.GbSize.Name = "GbSize";
            this.GbSize.Size = new System.Drawing.Size(217, 100);
            this.GbSize.TabIndex = 0;
            this.GbSize.TabStop = false;
            this.GbSize.Text = "Size";
            this.GbSize.Enter += new System.EventHandler(this.GbSize_Enter);
            // 
            // RbLarge
            // 
            this.RbLarge.AutoSize = true;
            this.RbLarge.Location = new System.Drawing.Point(31, 76);
            this.RbLarge.Name = "RbLarge";
            this.RbLarge.Size = new System.Drawing.Size(52, 17);
            this.RbLarge.TabIndex = 2;
            this.RbLarge.TabStop = true;
            this.RbLarge.Text = "Large";
            this.RbLarge.UseVisualStyleBackColor = true;
            this.RbLarge.CheckedChanged += new System.EventHandler(this.RbLarge_CheckedChanged);
            // 
            // RbMedium
            // 
            this.RbMedium.AutoSize = true;
            this.RbMedium.Location = new System.Drawing.Point(31, 53);
            this.RbMedium.Name = "RbMedium";
            this.RbMedium.Size = new System.Drawing.Size(62, 17);
            this.RbMedium.TabIndex = 1;
            this.RbMedium.TabStop = true;
            this.RbMedium.Text = "Medium";
            this.RbMedium.UseVisualStyleBackColor = true;
            this.RbMedium.CheckedChanged += new System.EventHandler(this.RbMedium_CheckedChanged);
            // 
            // RbSmall
            // 
            this.RbSmall.AutoSize = true;
            this.RbSmall.Location = new System.Drawing.Point(31, 30);
            this.RbSmall.Name = "RbSmall";
            this.RbSmall.Size = new System.Drawing.Size(50, 17);
            this.RbSmall.TabIndex = 0;
            this.RbSmall.TabStop = true;
            this.RbSmall.Text = "Small";
            this.RbSmall.UseVisualStyleBackColor = true;
            this.RbSmall.CheckedChanged += new System.EventHandler(this.RbSmall_CheckedChanged);
            // 
            // GbCrustType
            // 
            this.GbCrustType.Controls.Add(this.RbThick);
            this.GbCrustType.Controls.Add(this.RbThin);
            this.GbCrustType.Location = new System.Drawing.Point(12, 193);
            this.GbCrustType.Name = "GbCrustType";
            this.GbCrustType.Size = new System.Drawing.Size(217, 100);
            this.GbCrustType.TabIndex = 1;
            this.GbCrustType.TabStop = false;
            this.GbCrustType.Text = "Crust Type";
            // 
            // RbThick
            // 
            this.RbThick.AutoSize = true;
            this.RbThick.Location = new System.Drawing.Point(31, 58);
            this.RbThick.Name = "RbThick";
            this.RbThick.Size = new System.Drawing.Size(79, 17);
            this.RbThick.TabIndex = 1;
            this.RbThick.TabStop = true;
            this.RbThick.Text = "Thick Crust";
            this.RbThick.UseVisualStyleBackColor = true;
            this.RbThick.CheckedChanged += new System.EventHandler(this.RbThick_CheckedChanged);
            // 
            // RbThin
            // 
            this.RbThin.AutoSize = true;
            this.RbThin.Location = new System.Drawing.Point(31, 34);
            this.RbThin.Name = "RbThin";
            this.RbThin.Size = new System.Drawing.Size(73, 17);
            this.RbThin.TabIndex = 0;
            this.RbThin.TabStop = true;
            this.RbThin.Text = "Thin Crust";
            this.RbThin.UseVisualStyleBackColor = true;
            this.RbThin.CheckedChanged += new System.EventHandler(this.RbThin_CheckedChanged);
            // 
            // GbToppings
            // 
            this.GbToppings.Controls.Add(this.CkbGreenPepper);
            this.GbToppings.Controls.Add(this.CkbOlive);
            this.GbToppings.Controls.Add(this.CkbOnion);
            this.GbToppings.Controls.Add(this.CkbTomatoes);
            this.GbToppings.Controls.Add(this.CkBMushroom);
            this.GbToppings.Controls.Add(this.CkbExtraCheese);
            this.GbToppings.Location = new System.Drawing.Point(278, 71);
            this.GbToppings.Name = "GbToppings";
            this.GbToppings.Size = new System.Drawing.Size(200, 100);
            this.GbToppings.TabIndex = 2;
            this.GbToppings.TabStop = false;
            this.GbToppings.Text = "Toppings";
            // 
            // CkbGreenPepper
            // 
            this.CkbGreenPepper.AutoSize = true;
            this.CkbGreenPepper.Location = new System.Drawing.Point(114, 66);
            this.CkbGreenPepper.Name = "CkbGreenPepper";
            this.CkbGreenPepper.Size = new System.Drawing.Size(91, 17);
            this.CkbGreenPepper.TabIndex = 5;
            this.CkbGreenPepper.Text = "Green pepper";
            this.CkbGreenPepper.UseVisualStyleBackColor = true;
            this.CkbGreenPepper.CheckedChanged += new System.EventHandler(this.CkbGreenPepper_CheckedChanged);
            // 
            // CkbOlive
            // 
            this.CkbOlive.AutoSize = true;
            this.CkbOlive.Location = new System.Drawing.Point(114, 43);
            this.CkbOlive.Name = "CkbOlive";
            this.CkbOlive.Size = new System.Drawing.Size(55, 17);
            this.CkbOlive.TabIndex = 4;
            this.CkbOlive.Text = "Olives";
            this.CkbOlive.UseVisualStyleBackColor = true;
            this.CkbOlive.CheckedChanged += new System.EventHandler(this.CkbOlive_CheckedChanged);
            // 
            // CkbOnion
            // 
            this.CkbOnion.AutoSize = true;
            this.CkbOnion.Location = new System.Drawing.Point(114, 20);
            this.CkbOnion.Name = "CkbOnion";
            this.CkbOnion.Size = new System.Drawing.Size(54, 17);
            this.CkbOnion.TabIndex = 3;
            this.CkbOnion.Text = "Onion";
            this.CkbOnion.UseVisualStyleBackColor = true;
            this.CkbOnion.CheckedChanged += new System.EventHandler(this.CkbOnion_CheckedChanged);
            // 
            // CkbTomatoes
            // 
            this.CkbTomatoes.AutoSize = true;
            this.CkbTomatoes.Location = new System.Drawing.Point(6, 66);
            this.CkbTomatoes.Name = "CkbTomatoes";
            this.CkbTomatoes.Size = new System.Drawing.Size(73, 17);
            this.CkbTomatoes.TabIndex = 2;
            this.CkbTomatoes.Text = "Tomatoes";
            this.CkbTomatoes.UseVisualStyleBackColor = true;
            this.CkbTomatoes.CheckedChanged += new System.EventHandler(this.CkbTomatoes_CheckedChanged);
            // 
            // CkBMushroom
            // 
            this.CkBMushroom.AutoSize = true;
            this.CkBMushroom.Location = new System.Drawing.Point(7, 43);
            this.CkBMushroom.Name = "CkBMushroom";
            this.CkBMushroom.Size = new System.Drawing.Size(75, 17);
            this.CkBMushroom.TabIndex = 1;
            this.CkBMushroom.Text = "Mushroom";
            this.CkBMushroom.UseVisualStyleBackColor = true;
            this.CkBMushroom.CheckedChanged += new System.EventHandler(this.CkBMushroom_CheckedChanged);
            // 
            // CkbExtraCheese
            // 
            this.CkbExtraCheese.AutoSize = true;
            this.CkbExtraCheese.Location = new System.Drawing.Point(7, 20);
            this.CkbExtraCheese.Name = "CkbExtraCheese";
            this.CkbExtraCheese.Size = new System.Drawing.Size(89, 17);
            this.CkbExtraCheese.TabIndex = 0;
            this.CkbExtraCheese.Text = "Extra Cheese";
            this.CkbExtraCheese.UseVisualStyleBackColor = true;
            this.CkbExtraCheese.CheckedChanged += new System.EventHandler(this.CkbExtraCheese_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(212, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "MAKE YOUR PIZZA";
            // 
            // GbWhereToEat
            // 
            this.GbWhereToEat.Controls.Add(this.RbTakeOut);
            this.GbWhereToEat.Controls.Add(this.RbEatIn);
            this.GbWhereToEat.Location = new System.Drawing.Point(283, 193);
            this.GbWhereToEat.Name = "GbWhereToEat";
            this.GbWhereToEat.Size = new System.Drawing.Size(200, 100);
            this.GbWhereToEat.TabIndex = 4;
            this.GbWhereToEat.TabStop = false;
            this.GbWhereToEat.Text = "Where To Eat";
            // 
            // RbTakeOut
            // 
            this.RbTakeOut.AutoSize = true;
            this.RbTakeOut.Location = new System.Drawing.Point(108, 34);
            this.RbTakeOut.Name = "RbTakeOut";
            this.RbTakeOut.Size = new System.Drawing.Size(70, 17);
            this.RbTakeOut.TabIndex = 1;
            this.RbTakeOut.TabStop = true;
            this.RbTakeOut.Text = "Take Out";
            this.RbTakeOut.UseVisualStyleBackColor = true;
            this.RbTakeOut.CheckedChanged += new System.EventHandler(this.RbTakeOut_CheckedChanged);
            // 
            // RbEatIn
            // 
            this.RbEatIn.AutoSize = true;
            this.RbEatIn.Location = new System.Drawing.Point(5, 34);
            this.RbEatIn.Name = "RbEatIn";
            this.RbEatIn.Size = new System.Drawing.Size(52, 17);
            this.RbEatIn.TabIndex = 0;
            this.RbEatIn.TabStop = true;
            this.RbEatIn.Text = "Eat in";
            this.RbEatIn.UseVisualStyleBackColor = true;
            this.RbEatIn.CheckedChanged += new System.EventHandler(this.RbEatIn_CheckedChanged);
            // 
            // BtnOrderPizza
            // 
            this.BtnOrderPizza.Location = new System.Drawing.Point(219, 374);
            this.BtnOrderPizza.Name = "BtnOrderPizza";
            this.BtnOrderPizza.Size = new System.Drawing.Size(104, 46);
            this.BtnOrderPizza.TabIndex = 5;
            this.BtnOrderPizza.Text = "Order Pizza";
            this.BtnOrderPizza.UseVisualStyleBackColor = true;
            this.BtnOrderPizza.Click += new System.EventHandler(this.BtnOrderPizza_Click);
            // 
            // BtnResetForm
            // 
            this.BtnResetForm.Location = new System.Drawing.Point(363, 373);
            this.BtnResetForm.Name = "BtnResetForm";
            this.BtnResetForm.Size = new System.Drawing.Size(98, 47);
            this.BtnResetForm.TabIndex = 6;
            this.BtnResetForm.Text = "Reset form";
            this.BtnResetForm.UseVisualStyleBackColor = true;
            this.BtnResetForm.Click += new System.EventHandler(this.BtnResetForm_Click);
            // 
            // GbOrderSummary
            // 
            this.GbOrderSummary.Controls.Add(this.label10);
            this.GbOrderSummary.Controls.Add(this.label9);
            this.GbOrderSummary.Controls.Add(this.label8);
            this.GbOrderSummary.Controls.Add(this.label7);
            this.GbOrderSummary.Controls.Add(this.label6);
            this.GbOrderSummary.Controls.Add(this.label5);
            this.GbOrderSummary.Controls.Add(this.label4);
            this.GbOrderSummary.Controls.Add(this.label3);
            this.GbOrderSummary.Controls.Add(this.label2);
            this.GbOrderSummary.Controls.Add(this.LSize);
            this.GbOrderSummary.Location = new System.Drawing.Point(489, 71);
            this.GbOrderSummary.Name = "GbOrderSummary";
            this.GbOrderSummary.Size = new System.Drawing.Size(303, 324);
            this.GbOrderSummary.TabIndex = 7;
            this.GbOrderSummary.TabStop = false;
            this.GbOrderSummary.Text = "Order Summary";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkGreen;
            this.label10.Location = new System.Drawing.Point(83, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 31);
            this.label10.TabIndex = 9;
            this.label10.Text = "$0";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Total Price:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(103, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Where To Eat:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Crust Type:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "No Toppings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Toppings:";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // LSize
            // 
            this.LSize.AutoSize = true;
            this.LSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSize.Location = new System.Drawing.Point(17, 20);
            this.LSize.Name = "LSize";
            this.LSize.Size = new System.Drawing.Size(35, 13);
            this.LSize.TabIndex = 0;
            this.LSize.Text = "Size:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GbOrderSummary);
            this.Controls.Add(this.BtnResetForm);
            this.Controls.Add(this.BtnOrderPizza);
            this.Controls.Add(this.GbWhereToEat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GbToppings);
            this.Controls.Add(this.GbCrustType);
            this.Controls.Add(this.GbSize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GbSize.ResumeLayout(false);
            this.GbSize.PerformLayout();
            this.GbCrustType.ResumeLayout(false);
            this.GbCrustType.PerformLayout();
            this.GbToppings.ResumeLayout(false);
            this.GbToppings.PerformLayout();
            this.GbWhereToEat.ResumeLayout(false);
            this.GbWhereToEat.PerformLayout();
            this.GbOrderSummary.ResumeLayout(false);
            this.GbOrderSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GbSize;
        private System.Windows.Forms.RadioButton RbLarge;
        private System.Windows.Forms.RadioButton RbMedium;
        private System.Windows.Forms.RadioButton RbSmall;
        private System.Windows.Forms.GroupBox GbCrustType;
        private System.Windows.Forms.RadioButton RbThick;
        private System.Windows.Forms.RadioButton RbThin;
        private System.Windows.Forms.GroupBox GbToppings;
        private System.Windows.Forms.CheckBox CkbGreenPepper;
        private System.Windows.Forms.CheckBox CkbOlive;
        private System.Windows.Forms.CheckBox CkbOnion;
        private System.Windows.Forms.CheckBox CkbTomatoes;
        private System.Windows.Forms.CheckBox CkBMushroom;
        private System.Windows.Forms.CheckBox CkbExtraCheese;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GbWhereToEat;
        private System.Windows.Forms.RadioButton RbTakeOut;
        private System.Windows.Forms.RadioButton RbEatIn;
        private System.Windows.Forms.Button BtnOrderPizza;
        private System.Windows.Forms.Button BtnResetForm;
        private System.Windows.Forms.GroupBox GbOrderSummary;
        private System.Windows.Forms.Label LSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

