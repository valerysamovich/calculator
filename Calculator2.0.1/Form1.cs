using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator2._0._1
{
    public partial class Form1 : Form
    {
        int firstNumber;
        int secondNumber;
        int result;
        string mathOperator;

        public Form1()
        {
            InitializeComponent();
        }

        // buttons from 0 to 9
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }
        
        
        // operators +, -, *, /
        private void button11_Click(object sender, EventArgs e)
        {
            mathOperator = "+";
            firstNumber = int.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            mathOperator = "-";
            firstNumber = int.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            mathOperator = "*";
            firstNumber = int.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            mathOperator = "/";
            firstNumber = int.Parse(textBox1.Text);
            textBox1.Text = "";
        }


        // operator =
        private void button15_Click(object sender, EventArgs e)
        {
            secondNumber = int.Parse(textBox1.Text);
            
            // math expressions
            if (mathOperator == "+") { result = firstNumber + secondNumber; }
            if (mathOperator == "-") { result = firstNumber - secondNumber; }
            if (mathOperator == "*") { result = firstNumber * secondNumber; }
            if (mathOperator == "/") { result = firstNumber / secondNumber; }

            textBox1.Text = result.ToString();
        }
    }
}
