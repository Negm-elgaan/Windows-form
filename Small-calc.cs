namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public int userinput1,userinput2;

       
        Button b1 = new Button();
        Button b2 = new Button();
        Button b3 = new Button();
        Button b4 = new Button();
        TextBox t1 = new TextBox();
        TextBox t2 = new TextBox();
        TextBox t3 = new TextBox ();
        Label l1 = new Label();
        Label l2 = new Label();
        Label l3 = new Label ();
        private void Sum(object sender , EventArgs e)
        {
            userinput1 = int.Parse(t1.Text);
            userinput2 = int.Parse(t2.Text);
            int result = userinput1 + userinput2;
            //MessageBox.Show(result.ToString());
            t3.Text = result.ToString();
        }
        private void Sub(object sender , EventArgs e)
        {
            userinput1 = int.Parse(t1.Text);
            userinput2 = int.Parse(t2.Text);
            int result = userinput1 - userinput2;
            //MessageBox.Show(result.ToString());
            t3.Text = result.ToString();
        }
        private void div(object sender, EventArgs e)
        {
            userinput1 = int.Parse(t1.Text);
            userinput2 = int.Parse(t2.Text);
            int result = userinput1 / userinput2;
            //MessageBox.Show(result.ToString());
            t3.Text = result.ToString();
        }
        private void multiply(object sender , EventArgs e)
        {
            userinput1 = int.Parse(t1.Text);
            userinput2 = int.Parse(t2.Text);
            int result = userinput1 * userinput2;
            //MessageBox.Show(result.ToString());
            t3.Text = result.ToString();

        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
            Controls.Add(b1);
            Controls.Add(b2);
            Controls.Add(b3);
            Controls.Add(b4);
            Controls.Add(t1);
            Controls.Add(t2);
            Controls.Add(t3);
            Controls.Add(l1);
            Controls.Add(l2);
            Controls.Add(l3);
            t1.Location = new Point(100, 30);
            t1.Size = new Size(70, 20);
            //t1.Multiline = true;
            t2.Location = new Point(300, 30);
            t2.Size = new Size(70, 20);
            //t2.Multiline = true;
            l1.Name = "test";
            l1.Text = "Number:";
            l1.Location = new Point(10, 30);
            l1.Size = new Size(80, 20);
            l1.BackColor = Color.Black;
            l1.ForeColor = Color.Orange;
            l1.Font = new Font("ARR", 12, FontStyle.Bold);
            l2.Name = "test";
            l2.Text = "Number:";
            l2.Location = new Point(200, 30);
            l2.Size = new Size(80, 20);
            l2.BackColor = Color.Black;
            l2.ForeColor = Color.Orange;
            l2.Font = new Font("ARR", 12, FontStyle.Bold);
            l3.Name = "test";
            l3.Text = "Result:";
            l3.Location = new Point(400, 30);
            l3.Size = new Size(80, 20);
            l3.BackColor = Color.Black;
            l3.ForeColor = Color.Orange;
            l3.Font = new Font("ARR", 12, FontStyle.Bold);
            t3.Location = new Point(470, 30);
            t3.Size = new Size(70, 20);
            b1.Name = "test";
            b1.Text = "mult";
            b1.Location = new Point(300, 300);
            b1.Size = new Size(70, 70);
            b1.BackColor = Color.Black;
            b1.ForeColor = Color.Orange;
            b1.Font = new Font("ARR", 12, FontStyle.Bold);
            b1.MouseClick += multiply;
            b2.Name = "test";
            b2.Text = "sum";
            b2.Location = new Point(400, 300);
            b2.Size = new Size(70, 70);
            b2.BackColor = Color.Black;
            b2.ForeColor = Color.Orange;
            b2.Font = new Font("ARR", 12, FontStyle.Bold);
            b2.MouseClick += Sum;
            Name = "test";
            b3.Text = "sub";
            b3.Location = new Point(200, 300);
            b3.Size = new Size(70, 70);
            b3.BackColor = Color.Black;
            b3.ForeColor = Color.Orange;
            b3.Font = new Font("ARR", 12, FontStyle.Bold);
            b3.MouseClick += Sub;
            b4.Name = "test";
            b4.Text = "divide";
            b4.Location = new Point(100, 300);
            b4.Size = new Size(70, 70);
            b4.BackColor = Color.Black;
            b4.ForeColor = Color.Orange;
            b4.Font = new Font("ARR", 12, FontStyle.Bold);
            b4.MouseClick += div;
            t3.ReadOnly = true;
        }
        public Form1()
        {
            InitializeComponent();
        }
    }
}
