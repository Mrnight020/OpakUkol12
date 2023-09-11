using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.opacko
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> listik;
        void Vypis(List<int> listek, ListBox listbox)
        {
            for (int i = 0; i < listek.Count; i++)
            {
                listbox.Items.Add(listek[i]);
            }
        }
        void Vypis(List<char> listek, ListBox listbox)
        {
            for (int i = 0; i < listek.Count; i++)
            {
                listbox.Items.Add(listek[i]);
            }
        }

        void Vymaz(List<int> listek, ListBox listbox)
        {
            for (int i = 0; i < listek.Count; i++)
            {
                int cislo = listek[i];
                int soucet = 0;
                for (int a = 1; a < cislo; a++)
                {
                    if (cislo % a == 0)
                    {
                        soucet += a;
                    }
                }
                if (soucet == cislo)
                {
                    listek.Remove(soucet);
                }
            }
        }

        int Druhemaximum(List<int> listek, ListBox listbox)
        {
             return(listik[listik.Count-2]);
        }
        int cifernysoucet(int max)
        {
            int soucet = 0;
            for(int i = 0;i < max;max /= 10)
            {
                soucet += max % 10;
            }
            return soucet;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Random rnd = new Random();
            listik = new List<int>();
            int n = int.Parse(textBox1.Text);

            for (int i = 0; i < n; i++)
            {
                listik.Add(rnd.Next(-5, 101));
            }

            Vypis(listik, listBox1);
            button1.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vymaz(listik, listBox2);
            Vypis(listik, listBox2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listik.Sort();
            Vypis(listik, listBox3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int soucet = listik.Sum();
            int pocet = listik.Count();
            double prumer =(double)soucet / (double)pocet;
            MessageBox.Show("aritmeticky pruer vsech cisel je :" + prumer);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int druhemax = Druhemaximum(listik, listBox3);
            MessageBox.Show("Druhe Maximu je :" + druhemax);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int max = listik[listik.Count - 1];

            int cifsoucet = cifernysoucet(max);
            MessageBox.Show("Ciferny soucet maximalniho cisla : " + cifsoucet);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<char> listek2 = new List<char>();

            for (int i = 0; i < listik.Count; i++)
            {
                if((char)listik[i] >= 'A' && (char)listik[i] <= 'Z')
                {
                    listek2.Add((char)listik[i]);
                }
                else
                {
                    listek2.Add('*');
                }
            }

            Vypis(listek2, listBox4);
        }
    }
}
