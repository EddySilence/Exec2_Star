using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void rightButton_Click(object sender, EventArgs e)
		{

			//取得值
			string input = string.Empty;
			input = inputTextBox.Text;

			//判斷數字正確
			bool isInt = int.TryParse(input, out int number);
			MessageShow(isInt, number);

			//畫三角形
			input = inputTextBox.Text;
			resultTextBox.Text = String.Empty;

			for (int i = 1; i <= number; i++)
			{
				resultTextBox.Text += new string(' ', (number - i) * 2) + new string('*', i) + "\r\n";
			}

		}

		private void leftButton_Click(object sender, EventArgs e)
		{
			//取得值
			string input = string.Empty;
			input = inputTextBox.Text;

			//判斷數字正確
			bool isInt = int.TryParse(input, out int number);
			MessageShow(isInt, number);

			//畫三角形string input = string.Empty;
			input = inputTextBox.Text;
			resultTextBox.Text = String.Empty;

			for (int i = 1; i <= number; i++)
			{
				resultTextBox.Text += new string('*', i) + "\r\n";
			}

		}
		private void MessageShow(bool isInt, int number)
		{
			if (!isInt)
			{
				MessageBox.Show("要輸入數字");
			}
			else if (number > 10 || number < 1)
			{
				MessageBox.Show("數字要介於1~10之間");
			}
		}

		private void equalButton_Click(object sender, EventArgs e)
		{
			//取得值
			string input = string.Empty;
			input = inputTextBox.Text;

			//判斷數字正確
			bool isInt = int.TryParse(input, out int number);
			MessageShow(isInt, number);

			//畫三角形string input = string.Empty;
			input = inputTextBox.Text;
			resultTextBox.Text = String.Empty;

			for (int i = 1; i <= number; i++)
			{
				resultTextBox.Text += new string(' ', (number - i)) + new string('*', i) + "\r\n";
			}
		}
	}
}
