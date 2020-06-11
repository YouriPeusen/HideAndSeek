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
	public partial class SeekerMainForm : Form
	{
		public SeekerMainForm()
		{
			InitializeComponent();
		}

		private void btnStartGame_Click(object sender, EventArgs e)
		{

		}

		private void btnShowFloorplan_Click(object sender, EventArgs e)
		{
			this.Hide();

			MapForm form = new MapForm();
			form.Closed += (s, args) => this.Close();
			form.Show();
		}

		private void btnCameras_Click(object sender, EventArgs e)
		{
			this.Hide();

			CamerasForm form = new CamerasForm();
			form.Closed += (s, args) => this.Close();
			form.Show();
		}

		private void btnGameStats_Click(object sender, EventArgs e)
		{
			this.Hide();

			StatisticsForm form = new StatisticsForm();
			form.Closed += (s, args) => this.Close();
			form.Show();
		}

		private void btnGameHistory_Click(object sender, EventArgs e)
		{
			this.Hide();

			HistoryForm form = new HistoryForm();
			form.Closed += (s, args) => this.Close();
			form.Show();
		}

		private void btnSettings_Click(object sender, EventArgs e)
		{
			this.Hide();

			SettingsForm form = new SettingsForm();
			form.Closed += (s, args) => this.Close();
			form.Show();
		}
	}
}
