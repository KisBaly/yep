using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<int> ar = new List<int>();
        public List<string> nevek = new List<string> ();
        public List<string> pluszfeltet = new List<string> ();
        public List<int> feltar = new List<int>();
        public int vegosszeg = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            PizzakSzamol();
            FeletCheck();
            label5.Text+=(vegosszeg+"Ft");
        }
        public void PizzakSzamol()
        {
            if (checkBox1.Checked)
            {
                ar.Add(2500);
                nevek.Add("Margaréta");
                vegosszeg += 2500;
            }

            if (checkBox2.Checked)
            {
                ar.Add(2890);
                nevek.Add("Margaréta");
                vegosszeg += 2890;
            }
            if (checkBox5.Checked)
            {
                ar.Add(2890);
                nevek.Add("Gombás");
                vegosszeg += 2890;
            }
            if (checkBox5.Checked)
            {
                ar.Add(2890);
                nevek.Add("Bacon");
                vegosszeg += 2890;
            }
            if (checkBox14.Checked)
            {
                ar.Add(3200);
                nevek.Add("Capricosa");
                vegosszeg += 3200;
            }
            if (checkBox13.Checked)
            {
                ar.Add(2890);
                nevek.Add("Tarjás");
                vegosszeg += 2890;
            }
            if (checkBox11.Checked)
            {
                ar.Add(2890);
                nevek.Add("Kolbászos");
                vegosszeg += 2890;
            }
            if (checkBox4.Checked)
            {
                ar.Add(2890);
                nevek.Add("Sonkás");
                vegosszeg += 2890;
            }
            if (checkBox10.Checked)
            {
                ar.Add(3200);
                nevek.Add("Tonhalas");
                vegosszeg += 3200;
            }
            if (checkBox6.Checked)
            {
                ar.Add(2890);
                nevek.Add("Kolbászos");
                vegosszeg += 2890;
            }
        }
        public void FeletCheck()
        {
            if (checkBox17.Checked)
            {
                ar.Add(500);
                nevek.Add("Bacon");
                vegosszeg += 500;
            }

            if (checkBox16.Checked)
            {
                ar.Add(500);
                nevek.Add("Paradicsom");
                vegosszeg += 500;
            }
            if (checkBox8.Checked)
            {
                ar.Add(500);
                nevek.Add("Sajt");
                vegosszeg += 500;
            }
            if (checkBox9.Checked)
            {
                ar.Add(500);
                nevek.Add("Jalapeno");
                vegosszeg += 500;
            }
            if (checkBox7.Checked)
            {
                ar.Add(500);
                nevek.Add("Tojás");
                vegosszeg += 500;
            }
            if (checkBox15.Checked)
            {
                ar.Add(500);
                nevek.Add("Tejföl");
                vegosszeg += 500;
            }
            if (checkBox12.Checked)
            {
                ar.Add(500);
                nevek.Add("Hagyma");
                vegosszeg += 500;
            }
        }
        public void Adategyesztetes()
        {
            string s = textBox2.Text;
            label22.Text += s;
            string s1 = textBox3.Text;
            label25.Text += " " + s1;
            string s2 = textBox4.Text;
            label24.Text += " " + s2;
            string s3 = textBox1.Text;
            label23.Text += " " + s3;
            string s4 = textBox5.Text;
            label26.Text += " " + s4;
            label27.Text += " "+vegosszeg + "Ft";
            
        }
        public void ListaKiir()
        {
            for (int i = 0; i < nevek.Count; i++)
            {
                label29.Text += nevek[i]+"\n";
            }
            for (int i = 0; i < pluszfeltet.Count; i++)
            {
                label29.Text += nevek[i] + "\n";
            }
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Adategyesztetes();
            ListaKiir();
        }
    }
        }

