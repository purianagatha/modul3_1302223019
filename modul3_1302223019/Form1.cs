using System.Reflection.Emit;
using System.Windows.Forms;

namespace modul3_1302223019
{
    public partial class Form1 : Form
    {
        string hasil = nameof(hasil);

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string hasil = button1.Text;
            hasil = hasil.ToLower();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int angka;
            angka = Convert.ToInt32(textBox2.Text);
            button2.Text = button2.Text + "+";
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int angka;
            angka = Convert.ToInt32(textBox2.Text);
            button2.Text = button3.Text + "+";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int angka;
            angka = Convert.ToInt32(textBox2.Text);
            button2.Text = button5.Text + "+";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int angka;
            angka = Convert.ToInt32(textBox2.Text);
            button2.Text = button4.Text + "+";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int angka;
            angka = Convert.ToInt32(textBox2.Text);
            button2.Text = button6.Text + "+";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int angka;
            angka = Convert.ToInt32(textBox2.Text);
            button2.Text = button7.Text + "+";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int angka;
            angka = Convert.ToInt32(textBox2.Text);
            button2.Text = button6.Text + "+";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int angka;
            angka = Convert.ToInt32(textBox2.Text);
            button2.Text = button9.Text + "+";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int angka;
            angka = Convert.ToInt32(textBox2.Text);
            button2.Text = button11.Text + "+";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                button12.Text = hasil;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
