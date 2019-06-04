using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double Resistor1, Resistor2, ResistanceT;
                Resistor1 = Convert.ToDouble(textBox2.Text);
                Resistor2 = Convert.ToDouble(textBox1.Text);
                ResistanceT = Resistor1 + Resistor2 ;
                label3.Text = "Resistance= " + ResistanceT;
            }
            catch
            {
                MessageBox.Show("Please Type in 2 numbers");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {


        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double Resistor1, Resistor2,Resistor3, ResistanceT;
                Resistor1 = Convert.ToDouble(textBox4.Text);
                Resistor2 = Convert.ToDouble(textBox5.Text);
                Resistor3 = Convert.ToDouble(textBox3.Text);
                ResistanceT = Resistor1 + Resistor2 + Resistor3;
                label7.Text = "Resistance= " + ResistanceT;
            }
            catch
            {
                MessageBox.Show("Please Type in 3 numbers");
            }
        }
    }
}
