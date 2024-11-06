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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        struct Adat
        {
            public int azon;
            public string nev;
            public int hossz;
            public int melyseg;
            public string telepules;
            public string vedettseg;

        }
        public Form1()
        {
            InitializeComponent();
        }

        string[] kategoriak = File.ReadAllLines("barlangok.txt");

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] kategoriak = File.ReadAllLines("barlangok.txt");
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            int i, index;


            for (i = 0; i < kategoriak.Length; i++)
            {
                Console.WriteLine(kategoriak[i]);
            }

            Adat[] adatok = new Adat[kategoriak.Length];

            for (i = 0; i < kategoriak.Length; i++)
            {
                string[] sorok = kategoriak[i].Split(';');
                adatok[i].azon = int.Parse(sorok[0]);
                adatok[i].nev = sorok[1];
                adatok[i].hossz = int.Parse(sorok[2]);
                adatok[i].melyseg = int.Parse(sorok[3]);
                adatok[i].telepules = sorok[4];
                adatok[i].vedettseg = sorok[5];

            }
            int barlangazon;
            int siker = 0;
            barlangazon = int.Parse(textBox1.Text);
            label1.Text = barlangazon.ToString();

            for (i = 0; i < kategoriak.Length; i++)
            {
                if (barlangazon==adatok[i].azon)
                {
                    label5.Text = adatok[i].nev;
                    siker = 1;
                }
                if (siker==0)
                {
                    MessageBox.Show("Nincs ilyen barlang!");
                }
            }
        }
    }
}
