using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JedDatTypy08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static bool JePrvocislo(int x)
        {
            bool prvocilo = true;

            if (x == 0)
            {
                prvocilo = false;
            }
            else if (x >= 3)
            {
                for (int i = 2; i <= x / 2 && prvocilo; i++)
                {
                    if (x % i == 0)
                    {
                        prvocilo = false;
                    }
                }
            }
            return prvocilo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int prvocisla = 0;
            for (int i = 0; i < textBox1.Lines.Count(); i++)
            {
                int cislo = int.Parse(textBox1.Lines[i].ToString());
                if (JePrvocislo(cislo))
                {
                    prvocisla++;
                }
            }

            if (prvocisla >= 1)
            {
                MessageBox.Show("Ano, obsahuje prvocislo");
            }
            else
            {
                MessageBox.Show("Ne, neobsahuje prvocislo");
            }

        }
    }
}
