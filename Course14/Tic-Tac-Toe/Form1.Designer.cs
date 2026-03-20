namespace Tic_Tac_Toe
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
            this.PB1 = new System.Windows.Forms.PictureBox();
            this.BtnRestart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).BeginInit();
            this.SuspendLayout();
            // 
            // PB1
            // 
            this.PB1.Location = new System.Drawing.Point(427, 103);
            this.PB1.Name = "PB1";
            this.PB1.Size = new System.Drawing.Size(100, 50);
            this.PB1.TabIndex = 0;
            this.PB1.TabStop = false;
            // 
            // BtnRestart
            // 
            this.BtnRestart.Location = new System.Drawing.Point(35, 159);
            this.BtnRestart.Name = "BtnRestart";
            this.BtnRestart.Size = new System.Drawing.Size(99, 44);
            this.BtnRestart.TabIndex = 1;
            this.BtnRestart.Text = "Restart Game";
            this.BtnRestart.UseVisualStyleBackColor = true;
            this.BtnRestart.Click += new System.EventHandler(this.BtnRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnRestart);
            this.Controls.Add(this.PB1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PB1;
        private System.Windows.Forms.Button BtnRestart;
    }
}

