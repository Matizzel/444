using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _444
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                
                double x0 = Convert.ToDouble(textBox1.Text);
                double xk = Convert.ToDouble(textBox2.Text);
                double dx = Convert.ToDouble(textBox3.Text);
                double b = Convert.ToDouble(textBox4.Text);
                double x = x0;
                while (x <= (xk + dx / 2))
                {
                    double y = 0.8 * Math.Pow(10, -5) * Math.Pow((Math.Pow(x,3) + Math.Pow(b, 3)),7/6);
                    string strOut = String.Format("x={0,05} | y={1:f10}", x, y);
                    textBox5.Text += strOut + Environment.NewLine;
                    x = x + dx;
                }
        }
    }
}
