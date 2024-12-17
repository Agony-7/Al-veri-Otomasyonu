using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alışveriş_Otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            int toplam;
            if (checkBox2.Checked)
            {
                listBox1.Items.Add(checkBox2.Text + ": " + label2.Text);
                toplam = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(label2.Text);
                textBox1.Text = toplam.ToString();
            }
            else
            {
                listBox1.Items.Remove(checkBox2.Text + ": " + label2.Text);
                toplam = Convert.ToInt32(textBox1.Text) - Convert.ToInt32(label2.Text);
                textBox1.Text = toplam.ToString();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int toplam;
            if (checkBox1.Checked)
            {
                listBox1.Items.Add(checkBox1.Text + ": " + label1.Text);
                toplam = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(label1.Text);
                textBox1.Text = toplam.ToString();
            }
            else
            {
                listBox1.Items.Remove(checkBox1.Text + ": " + label1.Text);
                toplam = Convert.ToInt32(textBox1.Text) - Convert.ToInt32(label1.Text);
                textBox1.Text = toplam.ToString();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double kdv, toplam, maliyet;
            toplam = Convert.ToInt32(textBox1.Text);
            kdv = toplam / 100 * 30;// Toplam fiyatın %30 kdv diyelim.
            maliyet = toplam - kdv;
            richTextBox1.Text += "Maliyet:" + maliyet + "\n";
            richTextBox1.Text += "KDV:" + kdv + "\n";
            richTextBox1.Text += "Ödenecek tutar:" + toplam + "\n";
        }
    }
}
