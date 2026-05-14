using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponentesCores
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                this.BackColor = Color.LightSkyBlue;
                listBox1.BackColor = Color.Black;
                listBox1.ForeColor = Color.LightSkyBlue;
            }
            else if (listBox1.SelectedIndex == 1)
            {
                this.BackColor = Color.MediumPurple;
                listBox1.BackColor = Color.Black;
                listBox1.ForeColor = Color.MediumPurple;
            }
            else if (listBox1.SelectedIndex == 2)
            {
                this.BackColor = Color.LightGreen;
                listBox1.BackColor = Color.Black;
                listBox1.ForeColor = Color.LightGreen;
            }
            else
            {
                this.BackColor = Color.Pink;
                listBox1.BackColor = Color.Black;
                listBox1.ForeColor = Color.Pink;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
