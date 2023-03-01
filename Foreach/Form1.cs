using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foreach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] kisiler = { "Ali", "Veli", "Can", "İsa", "Metin", "Haydar" };
            foreach (string k in kisiler)
            {
                listBox1.Items.Add(k);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] notlar = { 70, 85, 90, 100, 25 };
            foreach (int x in notlar)
            {
                listBox2.Items.Add(x);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            int[] sinavlar = { 50, 70, 80, 10, 100 };
            foreach (int s in sinavlar)
            {
                listBox3.Items.Add(s);
                toplam = toplam + s;
            }
            label1.Text = toplam.ToString();

            int ort = toplam / sinavlar.Length;
            label2.Text = ort.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
        }
    }
}
