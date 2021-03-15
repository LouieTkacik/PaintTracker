using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addPaintButton_Click(object sender, EventArgs e)
        {
            string c, p;
            decimal q;
            if(categoryComboAdd.SelectedIndex > -1 && pigmentInputBox.Text!="" && quantityUpDown.Value>0)
            {
                c = categoryComboAdd.SelectedItem.ToString();
                p = pigmentInputBox.Text;
                q = quantityUpDown.Value;
                Paint freshPaint = new Paint(c, p, q);
            }
            else
            {
                MessageBox.Show("Please make sure to enter values for ALL of the inputs.");
            }
        }
    }
}
