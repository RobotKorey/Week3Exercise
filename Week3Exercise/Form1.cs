namespace Week3Exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int[] test = new int[2];

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userInput1 = textBox1.Text;
            string userInput2 = textBox2.Text;


            test[0] = (Convert.ToInt32(userInput1));
            ;
            test[1] = (Convert.ToInt32(userInput2));

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = test[0].ToString();

            label2.Text = test[1].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (test[0] > test[1]) ;
            {
                label5.Text = test[0].ToString();
            }
            label5.Text = test[1].ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (test[0] == test[1])
            {
                label6.Text = "The two numbers are equal";
            }
            else label6.Text = "The two numbers are not equal";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int numberA;
            int numberB;
            if (test[0] > test[1])
            {
                numberA = test[0];
                numberB = test[1];
            }


            else
            {
                numberA = test[1];
                numberB = test[0];
            }

            int numberC = numberB;

            int numberD = numberA % numberB;



            int numberE;

            do
            {
                numberE = numberC % numberD;

                numberC = numberE;

                numberE = numberD % numberC;

                numberD = numberE;
            }
            while (numberE != 0);

            if (numberC > numberD)
            {
                label7.Text = numberC.ToString();
            }

            else
            {
                label7.Text = numberD.ToString();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int counter = test.Count();
            label8.Text = counter.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            int sum = test[0] + test[1];
            label9.Text = sum.ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int counter = test.Count();
            int sum = test[0] + test[1];

            int result = sum / counter;

            label10.Text = result.ToString();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            int userInput1 = Convert.ToInt32(textBox3.Text);

            test[0] = test[0] * userInput1;

            test[1] = test[1] * userInput1;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int userInput1 = Convert.ToInt32(textBox4.Text);

            test[0] = test[0] + userInput1;

            test[1] = test[1] + userInput1;
        }
    }
}
