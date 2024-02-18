using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Şifreleme_Algoritmaları_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string anametin = textBox1.Text;
            byte[] veridizim = ASCIIEncoding.ASCII.GetBytes(anametin);
            string sifrelimetin = Convert.ToBase64String(veridizim);
            textBox2.Text = sifrelimetin;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string metincoz = textBox2.Text;
            byte[] veridizimcozulen = Convert.FromBase64String(metincoz);
            string anametin2 = ASCIIEncoding.ASCII.GetString(veridizimcozulen);
            textBox1.Text = anametin2;
        }
    }
}
