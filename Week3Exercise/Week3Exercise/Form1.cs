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
    }
}
