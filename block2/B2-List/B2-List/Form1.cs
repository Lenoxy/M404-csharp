using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B2_List
{
    public partial class Form1 : Form
    {
        List<int> zahlenfeld = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            zahlenfeld.Add(Convert.ToInt32(addTextBox.Text));
            Aktualisieren();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            while (zahlenfeld.Contains(Convert.ToInt32(removeTextBox)))
            {
                zahlenfeld.Remove(Convert.ToInt32(removeTextBox));
            }
            Aktualisieren();
        }


        private void Aktualisieren()
        {
            addTextBox.Clear();
            removeTextBox.Clear();
            zahlenfeld.Sort();
            outputListBox.Items.Clear();
            int max = zahlenfeld.Max();
            int min = zahlenfeld.Min();
            double average = zahlenfeld.Average();

            foreach ( int v in zahlenfeld)
            {
                outputListBox.Items.Add(v);
            }
        }
    }
}
