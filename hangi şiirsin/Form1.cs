using System.Diagnostics.Eventing.Reader;

namespace hangi_şiirsin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "siirsever" && textBox2.Text == "0508")
            {
                Form2 siir = new Form2();
                siir.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Tekrar deneyiniz.");
            }
        }
    }
}