using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hangi_şiirsin
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Cemal Süreya")
            {
                Form3 sureya = new Form3();
                sureya.Show();
                this.Hide();
            }
            if (comboBox1.Text == "Orhan Veli")
            {
                Form4 orhanveli = new Form4();
                orhanveli.Show();
                this.Hide();
            }
            if (comboBox1.Text == "Nazım Hikmet")
            {
                Form5 nazim = new Form5();
                nazim.Show();
                this.Hide();
            }
            if (comboBox1.Text == "Attila Ilhan")
            {
                Form6 attila = new Form6();
                attila.Show();
                this.Hide();
            }
            if (comboBox1.Text == "Özdemir Asaf")
            {
                Form7 asaf = new Form7();
                asaf.Show();
                this.Hide();
            }
            if (comboBox1.Text == "Turgut Uyar")
            {
                Form8 tuyar = new Form8();
                tuyar.Show();
                this.Hide();
            }

        }
    }
}
