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



        class Jami
        {
            
            public int sum = 0;
            public int Method(int[] array)
            {
                for (int index = 0; index < array.Length; index++)
                {
                    if(array[index] > 0)
                    {
                        sum += array[index];
                    }
                }

                return sum;     
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] array = new int[] { 5, -7, 4, -6, 9 };
            Jami jami = new Jami();
            int result = jami.Method(array);
            label1.Text = "sum: " + result.ToString();
        }
    }
}
