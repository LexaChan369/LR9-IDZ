namespace ЛР9_ИДЗ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox2.Text);
            double y = double.Parse(textBox3.Text);
            double f = double.Parse(textBox4.Text);
            double p = double.Parse(textBox5.Text);
            int n = int.Parse((string)listBox1.SelectedItem);
            int k = int.Parse((string)listBox2.SelectedItem);
            double result = 0;
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < k; j++)
                {
                    result += (Math.Pow(p, i)*x*x*x + 3 * Math.Pow(f, j)*y*y) / (i*j);
                }
            }
            textBox1.Text = result.ToString();
        }
    }
}