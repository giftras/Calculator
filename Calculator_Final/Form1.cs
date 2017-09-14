using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Final
{
	public partial class Form1 : Form
	{
		public static double result = 0, value = 0, THBUSD = 30.3, memory_store = 0;
		public static Boolean checkkey = false;
		public static char currenttask = '+';
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void calculartorInfoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Enabled = false;
			CalculatorInfo f2 = new CalculatorInfo();
			f2.ShowDialog();
			this.Enabled = true;
		}

		private void convertBinaryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Enabled = false;
			ConvertBinary f2 = new ConvertBinary();
			f2.ShowDialog();
			this.Enabled = true;
		}

		private void num_click(object sender, EventArgs e)
		{
			// Create num as a button so we can take out the value on the text
			Button num = sender as Button;
			// if the value is 0 (no value enter to continue clear the textbox and start new number)
			if (value == 0)
			{ maintextbox.Text = ""; }
			//Input the number to the textbox
			maintextbox.Text += num.Text;
			// change the textbox number to the value
			value = Convert.ToDouble(maintextbox.Text);
			// if current task is = then put the value to the result
			if (currenttask == '=')
			{ result = Convert.ToDouble(maintextbox.Text); }
			//check key to make sure that number is entered
			checkkey = true;
		}

		private void percent_Click(object sender, EventArgs e)
		{
			// get the percent of the result and store it back to value
			value = result / 100 * value;
			// start working with the operator
			operationclick(sender, e);
			//Run result printout
			// do the result again to change the operator and display operator
			doResult("=", '=');
		}

		private void button1_Click(object sender, EventArgs e)
		{
			// if the current task is still in operation finish the operation first
			if (currenttask != '=')
			{ operationclick(sender, e); }
			// check text length so the number is included and listbox is checked
			if (maintextbox.Text.Length > 0 && listBoxCurrency.SelectedIndex > -1)
			{
				//get the task
				String currencyText = listBoxCurrency.SelectedItem.ToString();
				// do the task
				if (currencyText.Equals("USD -> THB"))
				{
					result = Convert.ToDouble(maintextbox.Text) * THBUSD;
					// work on the result
					doResult("B", '=');
				}
				else if (currencyText.Equals("THB -> USD"))
				{
					// work the result
					result = Convert.ToDouble(maintextbox.Text) / THBUSD;
					// run the result printout
					doResult("$", '=');
				}
			}
		}

		private void operationclick(object sender, EventArgs e)
		{
			// ope for the operator button
			Button ope = sender as Button;
			// set default character to blank as the start ()
			char ct = ' ';
			//operator with text longer than 1 will not be able to use switchcase so you need to change it
			if (ope.Text.Length > 1)
			{
				//change operator mod to M character
				if (ope.Text.Equals("Mod"))
				// put b into char
				{ ct = 'M'; }
			}
			// if the operator is just 1 char then put it to b directly
			else
			{ ct = Convert.ToChar(ope.Text); }
			//(b will be using at the buttom)

			// checkkey to make sure that the number is entered.
			if (checkkey == true)
			{
				// check the current task
				switch (currenttask)
				{
					// do the operation as current task is called
					case '+':
						result += value;
						break;
					case '-':
						result -= value;
						break;
					case 'x':
						result *= value;
						break;
					case '/':
						result /= value;
						break;
					case 'M':
						result %= value;
						break;
					case '^':
						result = Math.Pow(result, value);
						break;
				}
				// check key change to false so that user can press the
				checkkey = false;
				
			}
			// change the current task to the new task
			currenttask = ct;
			//print the result (= is not here because equal sign mean show the result only!)
			doResult(Convert.ToString(currenttask), ct);

		}

		void onetimeoperation(object sender, EventArgs e)
		{
			Button ope = sender as Button;
			// if task is given finish the task first
			if (currenttask != '=')
			{ operationclick(sender, e); }
			//one time operaor will work with result directly so it is seperate out to the new function
			if (maintextbox.Text.Length > 0)
			{
				// power of 2
				if (ope.Text.Equals("^2"))
				{ result = Math.Pow(Convert.ToDouble(maintextbox.Text), 2); }
				// power of 3
				else if (ope.Text.Equals("^3"))
				// 10 to the power of ....
				{ result = Math.Pow(Convert.ToDouble(maintextbox.Text), 3); }
				else if (ope.Text.Equals("10^"))
				{ result = Math.Pow(10, Convert.ToDouble(maintextbox.Text)); }
				// Exponential
				else if (ope.Text.Equals("Exp"))
				{ result = Math.Exp(Convert.ToDouble(maintextbox.Text)); }
				//factorial
				else if (ope.Text.Equals("n!"))
				{
					double number1 = Convert.ToDouble(maintextbox.Text);
					double factorial;
					factorial = 1;
					while (number1 >= 1)
					{
						factorial = number1 * factorial;
						number1--;
					}
					result = factorial; }
				//Run Result printout
				doResult("=", '=');
			}
		}

		void doResult(String ope, Char ct)
		{
			// change the current task
			currenttask = ct;
			// move the value back to 0
			value = 0;
			// show the result to textbox
			maintextbox.Text = Convert.ToString(result);
		}
		//for deleting the text in maintextbox
		private void DEL_Click(object sender, EventArgs e)
		{
			

			String del = RemoveLastChar(maintextbox.Text);
			// input = del;
			maintextbox.Text = del;
			if (del == String.Empty)
			{
				value = Convert.ToDouble("0");
			}
			else if(value != 0 && result == 0) 
			{
				value = Convert.ToDouble(del);
			}
			else
			{
				result = Convert.ToDouble(del);
			}

		}

		public string RemoveLastChar(string fulltext)
		{
			string del = string.Empty;
			//each char to be in array
			char[] text = fulltext.ToCharArray();
			for (int i = 0; i < text.Length - 1; i++)
			{
				del += text[i];
			}
			//return the new text that already deleted the last char
			return del;
		}

		private void Memory(object sender, EventArgs e)
		{
			Button ope = sender as Button;
			//get the 2nd text so we will know what to do (MC -> C = clear, M+ -> + = plus, M- -> - = minus)
			char mem = ope.Text.ElementAt(1);
			// if it is clear then clear the memory
			if (mem == 'C')
			{
				memory.Clear();
				memory_store = 0;
				memory.Text = "Nothing stored in Memeory";
			}
			//if not clear then do what?
			else
			{
				if (!maintextbox.Text.Equals(""))
				{
					switch (mem)
					{
						// plus to the memory
						case '+':
							memory_store += Convert.ToDouble(maintextbox.Text);
							memory.Text = Convert.ToString(memory_store);
							break;
						// minus from the memory
						case '-':
							memory_store -= Convert.ToDouble(maintextbox.Text);
							memory.Text = Convert.ToString(memory_store);
							break;
					}
				}
			}
		}
		//for the clear button
		private void buttonClear_Click(object sender, EventArgs e)
		{
			result = 0;
			value = 0;
			maintextbox.Text = "";
			currenttask = '=';
		}



	}
}
