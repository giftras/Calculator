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
	public partial class ConvertBinary : Form
	{
		public ConvertBinary()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int num = Convert.ToInt32(textBox1.Text);
			int decimal_val = 0, base_val = 1, rem;

			while (num > 0)
			{
				rem = num % 10;
				decimal_val = decimal_val + rem * base_val;
				num = num / 10;
				base_val = base_val * 2;
			}

			textBox2.Text = Convert.ToString(decimal_val);
		}
	}
}
