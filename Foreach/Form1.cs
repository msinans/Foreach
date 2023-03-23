using System;
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
        // Dizideki elemanlar, dört sayısına tam bölünenler ve bu sayıların ayrı ayrı toplamları
        private void button5_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            int sayi = 0;
            int adet = 0;

            int[] dizi = { 12, 13, 14, 16, 22, 26, 28, 30, 44, 80 };
            foreach (int d in dizi)
            {
                listBox4.Items.Add(d);
                toplam = toplam + d;
            }
            label7.Text = toplam.ToString();

            foreach (int d in dizi)
            {
                if (d % 4 == 0)
                {
                    listBox5.Items.Add(d);
                    sayi = sayi + d;
                    adet++;
                }
                label5.Text = sayi.ToString();
                label6.Text = adet.ToString();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string[] kategoriler = { "Bilgisayar", "Monitör", "Telefon"};
            string[] urunler = { "Ürün 1", "Ürün 2", "Ürün 3" };

            foreach (var u in urunler)
            {
                listBox6.Items.Add(u);
                foreach (var k in kategoriler)
                {
                    listBox7.Items.Add(k);
                }
            }

        }
    }
}
