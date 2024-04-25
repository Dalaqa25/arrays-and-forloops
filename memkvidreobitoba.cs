using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Martkutxedi
        {
            protected int sigrdze, sigane;

            public Martkutxedi(int a, int b)
            {
                sigane = a;
                sigrdze = b;
            }

            public int partobi()
            { 
                return sigane * sigrdze;
            }
        }

        class Paralelepipedi : Martkutxedi
        {
            public int simagle;

            public Paralelepipedi(int a, int b) : base(a, b)
            {
                simagle = a;
            }

            public int Moculoba()
            {
                return sigrdze * simagle * sigane;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int sigrdze = int.Parse(textBox1.Text);
            int sigane = int.Parse(textBox2.Text);
            int simagle = int.Parse(textBox3.Text);

            Martkutxedi martkutxedi = new Martkutxedi(sigane, sigrdze);
            Paralelepipedi paralelepipedi = new Paralelepipedi(sigrdze,simagle);

            int result1 = paralelepipedi.Moculoba();
            label1.Text = "მოცულობა: " + result1.ToString();
            int result2 = martkutxedi.partobi();
            label2.Text = "ფართობი: " + result2.ToString();
        }
    }
}
