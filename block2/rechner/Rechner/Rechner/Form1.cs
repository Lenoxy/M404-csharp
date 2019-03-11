using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rechner
{


    public partial class Calculator : Form
    {

        private double zahl1 = 0;
        private double zahl2 = 0;

        public Calculator()
        {
            InitializeComponent();
        }

        private void onDigitClick(object sender, EventArgs e)
        {
            txtDisplay.Text += ((Button)sender).Text;
        }

        private void onOperationClick(object sender, EventArgs e)
        {
            zahl1 = Convert.ToDouble(txtDisplay.Text);

        }

        private void onEqualClick(object sender, EventArgs e)
        {
            zahl2 = Convert.ToDouble(txtDisplay.Text);




        }
    }
}
