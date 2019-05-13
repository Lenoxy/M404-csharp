using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Block3_Aufgabe7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void btnBerechnenObjektbezogen_Click(object sender, EventArgs e)
        {
            double d = Convert.ToDouble(durchmesserTextbox.Text);
            Kreis k = new Kreis(d);
            objectOutputTextbox.Text = Convert.ToString(k.flaeche);
        }


    }
}
