namespace PictureBoxEx
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PB1 = new System.Windows.Forms.PictureBox();
            this.LBTitle = new System.Windows.Forms.Label();
            this.RBboy = new System.Windows.Forms.RadioButton();
            this.RBgirl = new System.Windows.Forms.RadioButton();
            this.RBbook = new System.Windows.Forms.RadioButton();
            this.RBpen = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).BeginInit();
            this.SuspendLayout();
            // 
            // PB1
            // 
            this.PB1.Image = ((System.Drawing.Image)(resources.GetObject("PB1.Image")));
            this.PB1.Location = new System.Drawing.Point(256, 96);
            this.PB1.Name = "PB1";
            this.PB1.Size = new System.Drawing.Size(268, 146);
            this.PB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB1.TabIndex = 0;
            this.PB1.TabStop = false;
            // 
            // LBTitle
            // 
            this.LBTitle.AutoSize = true;
            this.LBTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTitle.ForeColor = System.Drawing.Color.Red;
            this.LBTitle.Location = new System.Drawing.Point(344, 28);
            this.LBTitle.Name = "LBTitle";
            this.LBTitle.Size = new System.Drawing.Size(58, 25);
            this.LBTitle.TabIndex = 1;
            this.LBTitle.Text = "Title";
            // 
            // RBboy
            // 
            this.RBboy.AutoSize = true;
            this.RBboy.Location = new System.Drawing.Point(140, 287);
            this.RBboy.Name = "RBboy";
            this.RBboy.Size = new System.Drawing.Size(43, 17);
            this.RBboy.TabIndex = 2;
            this.RBboy.TabStop = true;
            this.RBboy.Text = "Boy";
            this.RBboy.UseVisualStyleBackColor = true;
            this.RBboy.CheckedChanged += new System.EventHandler(this.RBboy_CheckedChanged);
            // 
            // RBgirl
            // 
            this.RBgirl.AutoSize = true;
            this.RBgirl.Location = new System.Drawing.Point(265, 287);
            this.RBgirl.Name = "RBgirl";
            this.RBgirl.Size = new System.Drawing.Size(40, 17);
            this.RBgirl.TabIndex = 3;
            this.RBgirl.TabStop = true;
            this.RBgirl.Text = "Girl";
            this.RBgirl.UseVisualStyleBackColor = true;
            this.RBgirl.CheckedChanged += new System.EventHandler(this.RBgirl_CheckedChanged);
            // 
            // RBbook
            // 
            this.RBbook.AutoSize = true;
            this.RBbook.Location = new System.Drawing.Point(385, 287);
            this.RBbook.Name = "RBbook";
            this.RBbook.Size = new System.Drawing.Size(50, 17);
            this.RBbook.TabIndex = 4;
            this.RBbook.TabStop = true;
            this.RBbook.Text = "Book";
            this.RBbook.UseVisualStyleBackColor = true;
            this.RBbook.CheckedChanged += new System.EventHandler(this.RBbook_CheckedChanged);
            // 
            // RBpen
            // 
            this.RBpen.AutoSize = true;
            this.RBpen.Location = new System.Drawing.Point(517, 287);
            this.RBpen.Name = "RBpen";
            this.RBpen.Size = new System.Drawing.Size(44, 17);
            this.RBpen.TabIndex = 5;
            this.RBpen.TabStop = true;
            this.RBpen.Text = "Pen";
            this.RBpen.UseVisualStyleBackColor = true;
            this.RBpen.CheckedChanged += new System.EventHandler(this.RBpen_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RBpen);
            this.Controls.Add(this.RBbook);
            this.Controls.Add(this.RBgirl);
            this.Controls.Add(this.RBboy);
            this.Controls.Add(this.LBTitle);
            this.Controls.Add(this.PB1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB1;
        private System.Windows.Forms.Label LBTitle;
        private System.Windows.Forms.RadioButton RBboy;
        private System.Windows.Forms.RadioButton RBgirl;
        private System.Windows.Forms.RadioButton RBbook;
        private System.Windows.Forms.RadioButton RBpen;
    }
}

