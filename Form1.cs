using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private string action = "";
		private double firstNumber = 0;
		private double secondNumber = 0;
		private double result = 0;

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e) //cycle for buttons
		{
			label1.Text += button1.Text;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			label1.Text += button2.Text;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			label1.Text += button3.Text;
		}

		private void button4_Click(object sender, EventArgs e)
		{
			label1.Text += button4.Text;
		}

		private void button5_Click(object sender, EventArgs e)
		{
			label1.Text += button5.Text;
		}

		private void button6_Click(object sender, EventArgs e)
		{
			label1.Text += button6.Text;
		}

		private void button7_Click(object sender, EventArgs e)
		{
			label1.Text += button7.Text;
		}

		private void button8_Click(object sender, EventArgs e)
		{
			label1.Text += button8.Text;
		}

		private void button9_Click(object sender, EventArgs e)
		{
			label1.Text += button9.Text;
		}

		private void button10_Click(object sender, EventArgs e)
		{
			label1.Text += button10.Text;
		}

		private void button11_Click(object sender, EventArgs e)
		{
			firstNumber = Convert.ToDouble(label1.Text);
			label1.Text = "";
			action = "+";
		}

		private void button12_Click(object sender, EventArgs e)
		{
			firstNumber = Convert.ToDouble(label1.Text);
			label1.Text = "";
			action = "-";
		}

		private void button13_Click(object sender, EventArgs e)
		{
			secondNumber = Convert.ToDouble(label1.Text);
			if (action == "+")
			{
				result = firstNumber + secondNumber;
				label1.Text = result.ToString();
			}
			if (action == "-")
			{
				result = firstNumber - secondNumber;
				label1.Text = result.ToString();
			}
		}

		private void button14_Click(object sender, EventArgs e)
		{
			label1.Text = "";
			firstNumber = 0;
			secondNumber = 0;
		}

		private void button15_Click(object sender, EventArgs e)
		{
			label1.Text += button15.Text;
		}
	}
}
