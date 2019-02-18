using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace b1a2
{
    public partial class Form1 : Form
    {
        double input1d;
        double input2d;
        double result;



        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            input1d = Convert.ToDouble(input1.Text);
            input2d = Convert.ToDouble(input2.Text);
            result = (input1d + input2d) / 2;
            output.Text = Convert.ToString(result);
        }
    }
}
