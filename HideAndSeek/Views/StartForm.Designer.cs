namespace HideAndSeek
{
	partial class StartForm
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
			this.btnSeeker = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnHider = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnSeeker
			// 
			this.btnSeeker.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSeeker.Location = new System.Drawing.Point(154, 107);
			this.btnSeeker.Name = "btnSeeker";
			this.btnSeeker.Size = new System.Drawing.Size(494, 107);
			this.btnSeeker.TabIndex = 0;
			this.btnSeeker.Text = "Seeker";
			this.btnSeeker.UseVisualStyleBackColor = true;
			this.btnSeeker.Click += new System.EventHandler(this.btnSeeker_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(341, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Choose a role:";
			// 
			// btnHider
			// 
			this.btnHider.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHider.Location = new System.Drawing.Point(154, 245);
			this.btnHider.Name = "btnHider";
			this.btnHider.Size = new System.Drawing.Size(494, 107);
			this.btnHider.TabIndex = 2;
			this.btnHider.Text = "Hider";
			this.btnHider.UseVisualStyleBackColor = true;
			this.btnHider.Click += new System.EventHandler(this.btnHider_Click);
			// 
			// StartForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnHider);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSeeker);
			this.Name = "StartForm";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.StartForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSeeker;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnHider;
	}
}

