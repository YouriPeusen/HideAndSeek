namespace HideAndSeek.Views
{
	partial class MapForm
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnChoose = new System.Windows.Forms.Button();
			this.btnReturn = new System.Windows.Forms.Button();
			this.lblTimer = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(182, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(606, 426);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// btnChoose
			// 
			this.btnChoose.Enabled = false;
			this.btnChoose.Location = new System.Drawing.Point(20, 398);
			this.btnChoose.Name = "btnChoose";
			this.btnChoose.Size = new System.Drawing.Size(142, 40);
			this.btnChoose.TabIndex = 1;
			this.btnChoose.Text = "Choose Room";
			this.btnChoose.UseVisualStyleBackColor = true;
			this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
			// 
			// btnReturn
			// 
			this.btnReturn.Location = new System.Drawing.Point(20, 13);
			this.btnReturn.Name = "btnReturn";
			this.btnReturn.Size = new System.Drawing.Size(105, 35);
			this.btnReturn.TabIndex = 2;
			this.btnReturn.Text = "Return";
			this.btnReturn.UseVisualStyleBackColor = true;
			this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
			// 
			// lblTimer
			// 
			this.lblTimer.AutoSize = true;
			this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTimer.Location = new System.Drawing.Point(13, 69);
			this.lblTimer.Name = "lblTimer";
			this.lblTimer.Size = new System.Drawing.Size(149, 39);
			this.lblTimer.TabIndex = 3;
			this.lblTimer.Text = "00:00:00";
			// 
			// MapForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblTimer);
			this.Controls.Add(this.btnReturn);
			this.Controls.Add(this.btnChoose);
			this.Controls.Add(this.pictureBox1);
			this.Name = "MapForm";
			this.Text = "MapForm";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnChoose;
		private System.Windows.Forms.Button btnReturn;
		private System.Windows.Forms.Label lblTimer;
	}
}