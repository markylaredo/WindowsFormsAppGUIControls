using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppGUI2
{
	public partial class Form1 : Form
	{
		private readonly CheckBox[] _checkBoxes;
		public Form1()
		{
			InitializeComponent();
			_checkBoxes = new CheckBox[4]
			{
				checkBox2,
				checkBox3,
				checkBox4,
				checkBox5,
			};
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			foreach (var box in _checkBoxes)
			{
				if (checkBox1.CheckState != CheckState.Indeterminate)
				{
					box.Checked = checkBox1.Checked;
				}
			}
		}

		private void Option_Click(object sender, EventArgs e)
		{
			int totalCheckBox = _checkBoxes.Length;
			int totalBoxesChecked = _checkBoxes.Count(state => state.Checked);

			if (totalBoxesChecked == totalCheckBox)
			{
				checkBox1.CheckState = CheckState.Checked;
			}

			if (totalBoxesChecked == 0)
			{
				checkBox1.CheckState = CheckState.Unchecked;
			}

			if (totalBoxesChecked < totalCheckBox && totalBoxesChecked > 0)
			{
				checkBox1.CheckState = CheckState.Indeterminate;
			}
		}
	}
}

