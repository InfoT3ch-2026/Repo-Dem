namespace GUICalc
{
    public partial class Form1 : Form
    {
        double val1;
        double val2;
        double result;
        string op;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(".")) 
            { 
                textBox1.Text = textBox1.Text + ".";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToDouble(textBox1.Text);
            op = "+";
            textBox1.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToDouble(textBox1.Text);
            op = "-";
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToDouble(textBox1.Text);
            op = "*";
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToDouble(textBox1.Text);
            op = "/";
            textBox1.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            val2 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";

            if (op == "+")
            {
                result = val1 + val2;
                textBox1.Text = Convert.ToString(result);
            }
            else if (op == "-")
            {
                result = val1 - val2;
                textBox1.Text = Convert.ToString(result);
            }
            else if (op == "*")
            {
                result = val1 * val2;
                textBox1.Text = Convert.ToString(result);
            }
            else if (op == "/")
            {
                result = val1 / val2;
                textBox1.Text = Convert.ToString(result);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            val1 = 0;
            val2 = 0;
            result = 0;
            textBox1.Text = "";
        }
    }
}
