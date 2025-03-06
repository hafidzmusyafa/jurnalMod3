namespace jurnal3
{
    public partial class Form1 : Form
    {
        string x;
        string y;
        bool p;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button12_Click(object sender, EventArgs e)
        {
            p = true;
            display.Text = "+";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (x != null && y != null)
            {
                int hasil = Convert.ToInt32(x) + Convert.ToInt32(y) ;
                display.Text = hasil.ToString();
                p = false;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(p == false)
            {
                x = "0";
                display.Text = x;
            } else
            {
                y = "0";
                display.Text = y;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (p == false)
            {
                x = "1";
                display.Text += x;
            }
            else
            {
                y = "1";
                display.Text = y;

            }
            display.Text = x;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (p == false)
            {
                x = "2";
                display.Text = x;
            }
            else
            {
                y = "2";
                display.Text = x;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (p == false)
            {
                x = "3";
                display.Text = x;
            }
            else
            {
                y = "3";
                display.Text = y;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (p == false)
            {
                x = "4";
                display.Text = x;
            }
            else
            {
                y = "4";
                display.Text = y;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (p == false)
            {
                x = "5";
                display.Text = x;
            }
            else
            {
                y = "5";
                display.Text = y;

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (p == false)
            {
                x = "6";
                display.Text = x;
            }
            else
            {
                y = "6";
                display.Text = y;

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (p == false)
            {
                x = "7";
                display.Text = x;
            }
            else
            {
                y = "7";
                display.Text = y;

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (p == false)
            {
                x = "8";
                display.Text = x;
            }
            else
            {
                y = "8";
                display.Text = y;

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (p == false)
            {
                x = "9";
                display.Text = x;
            }
            else
            {
                y = "9";
                display.Text = y;

            }
        }
    }
}
