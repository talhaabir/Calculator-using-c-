using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULATOR_Assignment
{
    public partial class Form1 : Form
    {
        double value;
        bool operatio_pressed;
        string operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if((result.Text=="0")||(operatio_pressed))
            {
                result.Clear();
            }
            operatio_pressed = false;
            Button b=(Button)sender;
            result.Text = result.Text + b.Text;
        }

        private void operation_click(object sender, EventArgs e)
        {
            Button B=(Button)sender;
            operation= B.Text;
            value = Double.Parse(result.Text);
            operatio_pressed= true;
            equation.Text = value + "" + operation;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            equation.Text="";
            switch(operation)
            {
                case "+":;
                result.Text = (value + Double.Parse(result.Text)).ToString();
                break;

                case "-":;
                result.Text = (value - Double.Parse(result.Text)).ToString();
                break;

                case "*":;
                result.Text = (value * Double.Parse(result.Text)).ToString();
                break;

                case "/":
                    ;
                result.Text = (value / Double.Parse(result.Text)).ToString();
                break;
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }
    }
}
