namespace Pood
{
	partial class Omanik
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
			this.Parool = new System.Windows.Forms.TextBox();
			this.Nimi = new System.Windows.Forms.TextBox();
			this.Sisend = new System.Windows.Forms.Button();
			this.Sulge_btn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Parool
			// 
			this.Parool.Font = new System.Drawing.Font("SimSun-ExtB", 14.25F);
			this.Parool.ForeColor = System.Drawing.Color.MediumSlateBlue;
			this.Parool.Location = new System.Drawing.Point(209, 59);
			this.Parool.Name = "Parool";
			this.Parool.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.Parool.Size = new System.Drawing.Size(172, 26);
			this.Parool.TabIndex = 7;
			this.Parool.Text = "Parool";
			// 
			// Nimi
			// 
			this.Nimi.Font = new System.Drawing.Font("SimSun-ExtB", 14.25F);
			this.Nimi.ForeColor = System.Drawing.Color.MediumSlateBlue;
			this.Nimi.Location = new System.Drawing.Point(43, 59);
			this.Nimi.Name = "Nimi";
			this.Nimi.Size = new System.Drawing.Size(145, 26);
			this.Nimi.TabIndex = 6;
			this.Nimi.Text = "Nimi";
			// 
			// Sisend
			// 
			this.Sisend.Font = new System.Drawing.Font("SimSun-ExtB", 14.25F);
			this.Sisend.ForeColor = System.Drawing.Color.MediumSlateBlue;
			this.Sisend.Location = new System.Drawing.Point(43, 115);
			this.Sisend.Name = "Sisend";
			this.Sisend.Size = new System.Drawing.Size(145, 41);
			this.Sisend.TabIndex = 8;
			this.Sisend.Text = "Sisend";
			this.Sisend.UseVisualStyleBackColor = true;
			this.Sisend.Click += new System.EventHandler(this.Sisend_Click);
			// 
			// Sulge_btn
			// 
			this.Sulge_btn.Font = new System.Drawing.Font("SimSun-ExtB", 14.25F);
			this.Sulge_btn.ForeColor = System.Drawing.Color.MediumSlateBlue;
			this.Sulge_btn.Location = new System.Drawing.Point(209, 115);
			this.Sulge_btn.Name = "Sulge_btn";
			this.Sulge_btn.Size = new System.Drawing.Size(77, 41);
			this.Sulge_btn.TabIndex = 9;
			this.Sulge_btn.Text = "Sulge";
			this.Sulge_btn.UseVisualStyleBackColor = true;
			this.Sulge_btn.Click += new System.EventHandler(this.Sulge_btn_Click);
			// 
			// Omanik
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(397, 232);
			this.Controls.Add(this.Sulge_btn);
			this.Controls.Add(this.Sisend);
			this.Controls.Add(this.Parool);
			this.Controls.Add(this.Nimi);
			this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.Name = "Omanik";
			this.Text = "Omanik";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox Parool;
		private System.Windows.Forms.TextBox Nimi;
		private System.Windows.Forms.Button Sisend;
		private System.Windows.Forms.Button Sulge_btn;
	}
}