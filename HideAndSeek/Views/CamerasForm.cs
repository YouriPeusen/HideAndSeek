using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HideAndSeek.Views
{
	public partial class CamerasForm : Form
	{
		public CamerasForm()
		{
			InitializeComponent();
		}

		private void btnReturn_Click(object sender, EventArgs e)
		{
			this.Hide();

			SeekerMainForm form = new SeekerMainForm();
			form.Closed += (s, args) => this.Close();
			form.Show();
		}

		private void btnRoom1_Click(object sender, EventArgs e)
		{

		}

		private void btnRoom2_Click(object sender, EventArgs e)
		{

		}

		private void btnRoom3_Click(object sender, EventArgs e)
		{

		}

		private void btnRoom4_Click(object sender, EventArgs e)
		{

		}

		private void btnRoom5_Click(object sender, EventArgs e)
		{

		}

		private void btnRoom6_Click(object sender, EventArgs e)
		{

		}

		private void btnroom7_Click(object sender, EventArgs e)
		{

		}

		private void btnRoom8_Click(object sender, EventArgs e)
		{

		}

		private void btnRoom9_Click(object sender, EventArgs e)
		{

		}
	}
}
