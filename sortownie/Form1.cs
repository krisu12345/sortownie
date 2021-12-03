using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace sortownie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] Tablica = new int[10000];
            using (var sr = new StreamReader(@"C:\Users\student\Desktop\ser.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                     Tablica.Append(int.Parse(line));
                }
            }
            static void sort(int[] tablica)
            {
                int n = tablica.Length;
                do
                {
                    for (int i = 0; i < n - 1; i++)
                    {
                        if (tablica[i] > tablica[i + 1])
                        {
                            int tmp = tablica[i];
                            tablica[i] = tablica[i + 1];
                            tablica[i + 1] = tmp;
                        }
                    }
                    n--;
                }
                while (n > 1);
            }
            //ile razy i wystwietlanie sredniej
            decimal ilerazy = numericUpDown1.Value;
            DateTime pomiar = DateTime.Now;
            for (int i = 0; i<ilerazy;i++)
            {
                sort(Tablica);
            }
            DateTime po = DateTime.Now;
            TimeSpan czas = po - pomiar;
            label1.Text = czas.Milliseconds.ToString();

        }
    }
}
