namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button)?.Text;
        }
        
        double a, b, c= 0;
        char symbols = '+';

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="")
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            symbols = (sender as Button).Text[0];
            textBox1.Clear();
        }        
        private void button17_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(textBox1.Text);
            switch (symbols)
            {
                case '+': c = a + b;
                    break;
                case '-': c = a - b;
                    break;
                case '*': c = a * b;
                    break;
                case '/': c = a / b;
                    break;
            }
            textBox1.Text = c.ToString();
        }



    }
}