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


        private void button2_Click(object sender, EventArgs e)
        {
        }



        private List<int> Tablica = new List<int>();

        private void button1_Click(object sender, EventArgs e)
        {
            if (Tablica.Count == 0)
            {
                OpenFileDialog theDialog = new OpenFileDialog();
                theDialog.Title = "Open Text File";
                theDialog.Filter = "TXT files|*.txt";
                theDialog.InitialDirectory = @"C:\";
                theDialog.ShowDialog();



                using (var sr = new StreamReader(theDialog.FileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Tablica.Add(int.Parse(line));
                    }
                }
            }
            static void sort(List<int> tablica)
            {
                int n = tablica.Count;
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




            //ile razy i czas
            decimal ilerazy = numericUpDown1.Value;
            DateTime pomiar = DateTime.Now;
            for (int i = 0; i<ilerazy;i++)
            {
                sort(Tablica);
            }
            DateTime po = DateTime.Now;
            TimeSpan czas = po - pomiar;
            label1.Text = czas.Seconds.ToString() + "s";

        }




        private void button2_Click_1(object sender, EventArgs e)
        {

            if (Tablica.Count == 0)
            {
                OpenFileDialog theDialog = new OpenFileDialog();
                theDialog.Title = "Open Text File";
                theDialog.Filter = "TXT files|*.txt";
                theDialog.InitialDirectory = @"C:\";
                theDialog.ShowDialog();



                using (var sr = new StreamReader(theDialog.FileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Tablica.Add(int.Parse(line));
                    }
                }
            }
            //ile razy i czas
            decimal ilerazy = numericUpDown2.Value;
            DateTime pomiar = DateTime.Now;
            for (int i = 0; i < ilerazy; i++)
            {
                Quick_Sort(Tablica,0,Tablica.Count-1);
            }
            DateTime po = DateTime.Now;
            TimeSpan czas = po - pomiar;
            label4.Text = czas.Seconds.ToString() + "s";

        }
        private static void Quick_Sort(List<int> arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    Quick_Sort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quick_Sort(arr, pivot + 1, right);
                }
            }

        }

        private static int Partition(List<int> arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {

                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;


                }
                else
                {
                    return right;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (Tablica.Count == 0)
            {
                OpenFileDialog theDialog = new OpenFileDialog();
                theDialog.Title = "Open Text File";
                theDialog.Filter = "TXT files|*.txt";
                theDialog.InitialDirectory = @"C:\";
                theDialog.ShowDialog();



                using (var sr = new StreamReader(theDialog.FileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Tablica.Add(int.Parse(line));
                    }
                }
            }
            //ile razy i czas
            decimal ilerazy = numericUpDown2.Value;
            DateTime pomiar = DateTime.Now;
            for (int i = 0; i < ilerazy; i++)
            {
                Quick_Sort(Tablica, 0, Tablica.Count - 1);
            }
            DateTime po = DateTime.Now;
            TimeSpan czas = po - pomiar;
            label5.Text = czas.Seconds.ToString() + "s";
        }
    }
    }
//qs przez wstawianie, kopcowanie, scalnie
