//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace WindowsFormsAppGUI2
//{
//	public partial class Form2 : Form
//	{
//		private readonly CheckBox[] _checkboxes;
//		public Form2()
//		{
// 			_checkboxes = new CheckBox[4]
//			{
//				checkBox2,
//				checkBox3,
//				checkBox4,
//				checkBox5,
//			};

//		}

//		private void Options_Click(object sender, EventArgs e)
//		{

//			int allBoxesChecked = _checkboxes.Length;
//			int totalBoxesChecked = _checkboxes.Count(x => x.Checked);
 
//			if (totalBoxesChecked == allBoxesChecked)
//			{
//				checkBox1.CheckState = CheckState.Checked;
//			}

//			if (totalBoxesChecked == 0)
//			{
//				checkBox1.CheckState = CheckState.Unchecked;
//			}

//			if (totalBoxesChecked < allBoxesChecked
//&& totalBoxesChecked > 0)
//			{
//				checkBox1.CheckState = CheckState.Indeterminate;
//			}
 
//		}

//		private void checkBox1_CheckedChanged(object sender, EventArgs e)
//		{
//			foreach (var checkbox in _checkboxes)
//			{
//				if (checkBox1.CheckState != CheckState.Indeterminate)
//				{
//					checkbox.Checked = checkBox1.Checked;
//				}

//			}
//		}
//	}

//}
