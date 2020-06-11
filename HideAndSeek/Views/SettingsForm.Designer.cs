namespace HideAndSeek.Views
{
	partial class SettingsForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnReturn = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.txbTimeLimit = new System.Windows.Forms.TextBox();
			this.lblTimeLimit = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnReturn
			// 
			this.btnReturn.Location = new System.Drawing.Point(12, 12);
			this.btnReturn.Name = "btnReturn";
			this.btnReturn.Size = new System.Drawing.Size(105, 35);
			this.btnReturn.TabIndex = 3;
			this.btnReturn.Text = "Return";
			this.btnReturn.UseVisualStyleBackColor = true;
			this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
			// 
			// btnSave
			// 
			this.btnSave.Enabled = false;
			this.btnSave.Location = new System.Drawing.Point(12, 398);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(142, 40);
			this.btnSave.TabIndex = 4;
			this.btnSave.Text = "Save Changes";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txbTimeLimit
			// 
			this.txbTimeLimit.Location = new System.Drawing.Point(69, 92);
			this.txbTimeLimit.Name = "txbTimeLimit";
			this.txbTimeLimit.Size = new System.Drawing.Size(141, 20);
			this.txbTimeLimit.TabIndex = 5;
			// 
			// lblTimeLimit
			// 
			this.lblTimeLimit.AutoSize = true;
			this.lblTimeLimit.Location = new System.Drawing.Point(13, 95);
			this.lblTimeLimit.Name = "lblTimeLimit";
			this.lblTimeLimit.Size = new System.Drawing.Size(50, 13);
			this.lblTimeLimit.TabIndex = 6;
			this.lblTimeLimit.Text = "Time limit";
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblTimeLimit);
			this.Controls.Add(this.txbTimeLimit);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnReturn);
			this.Name = "SettingsForm";
			this.Text = "SettingsForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnReturn;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox txbTimeLimit;
		private System.Windows.Forms.Label lblTimeLimit;
	}
}