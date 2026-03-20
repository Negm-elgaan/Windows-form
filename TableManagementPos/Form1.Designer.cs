namespace TableManagementPos
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
            this.TablePanel = new System.Windows.Forms.Panel();
            this.AddTableBtn = new System.Windows.Forms.Button();
            this.GoToTa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TablePanel
            // 
            this.TablePanel.Location = new System.Drawing.Point(85, 35);
            this.TablePanel.Name = "TablePanel";
            this.TablePanel.Size = new System.Drawing.Size(400, 263);
            this.TablePanel.TabIndex = 0;
            this.TablePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TablePanel_Paint);
            // 
            // AddTableBtn
            // 
            this.AddTableBtn.Location = new System.Drawing.Point(588, 141);
            this.AddTableBtn.Name = "AddTableBtn";
            this.AddTableBtn.Size = new System.Drawing.Size(75, 23);
            this.AddTableBtn.TabIndex = 1;
            this.AddTableBtn.Text = "button1";
            this.AddTableBtn.UseVisualStyleBackColor = true;
            this.AddTableBtn.Click += new System.EventHandler(this.AddTableBtn_Click);
            // 
            // GoToTa
            // 
            this.GoToTa.Location = new System.Drawing.Point(588, 211);
            this.GoToTa.Name = "GoToTa";
            this.GoToTa.Size = new System.Drawing.Size(75, 23);
            this.GoToTa.TabIndex = 2;
            this.GoToTa.Text = "button2";
            this.GoToTa.UseVisualStyleBackColor = true;
            this.GoToTa.Click += new System.EventHandler(this.GoToTa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GoToTa);
            this.Controls.Add(this.AddTableBtn);
            this.Controls.Add(this.TablePanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TablePanel;
        private System.Windows.Forms.Button AddTableBtn;
        private System.Windows.Forms.Button GoToTa;
    }
}

