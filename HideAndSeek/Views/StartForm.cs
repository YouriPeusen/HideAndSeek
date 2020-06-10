using HideAndSeek.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HideAndSeek
{
	public partial class StartForm : Form
	{
		public StartForm()
		{
			InitializeComponent();
		}

		private void StartForm_Load(object sender, EventArgs e)
		{

		}

		private void btnSeeker_Click(object sender, EventArgs e)
		{
			this.Hide();

			SeekerMainForm form = new SeekerMainForm();
			form.Closed += (s, args) => this.Close();
			form.Show();
		}

		private void btnHider_Click(object sender, EventArgs e)
		{
			this.Hide();

			HiderMainForm form = new HiderMainForm();
			form.Closed += (s, args) => this.Close();
			form.Show();
		}
	}
}
