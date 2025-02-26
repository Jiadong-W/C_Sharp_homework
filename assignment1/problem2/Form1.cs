namespace C_homework1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1;
            double num2;
            double result = 0;
            bool success1 = double.TryParse(textBox_num1.Text, out num1);
            if (!success1)
            {
                textBox4.Text = "第一个数输入有误！";
                return;
            }
            bool success2 = double.TryParse(textBox_num2.Text, out num2);
            if (!success2)
            {
                textBox4.Text = "第二个数输入有误！";
                return;
            }
            if (operator1 == 0)
            {
                textBox4.Text = "请选择运算符！";
                return;
            }
            switch (operator1)
            {
                case 1: result = num1 + num2; break;
                case 2: result = num1 - num2; break;
                case 3: result = num1 * num2; break;
                case 4: result = num1 / num2; break;
            }
            textBox4.Text = result.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            operator1 = 1;
            operator_textBox.Text = "+";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            operator1 = 2;
            operator_textBox.Text = "-";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operator1 = 3;
            operator_textBox.Text = "*";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            operator1 = 4;
            operator_textBox.Text = "/";
        }
    }
}