using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_2_practise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // calculate the area of a rectangle
                double width, height, area;
                width = Convert.ToDouble(textBox1.Text);
                height = Convert.ToDouble(textBox2.Text);
                area = width * height;
                label1.Text = "Area = " + area;
                    
             }
            catch
            {
                MessageBox.Show("type 2 numbers you SPAZMOID!!!!!");
            }
            
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
