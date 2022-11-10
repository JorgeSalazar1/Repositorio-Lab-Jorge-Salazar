namespace L7_JJSC_1202022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int a = 0, b = 1, c = 0;
            label2.Text = "Serie de Fibonacci: ";
            for (int i = 0; i < n; i++)
            {
                c = a + b;
                a = b;
                b = c;
                label2.Text += a + ",";
            }
        }
    }
}