namespace Pood
{
	partial class Kasutaja
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
			this.Sulge_btn = new System.Windows.Forms.Button();
			this.Parool = new System.Windows.Forms.TextBox();
			this.Registrerimine = new System.Windows.Forms.Button();
			this.Sisend = new System.Windows.Forms.Button();
			this.Nimi = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// Sulge_btn
			// 
			this.Sulge_btn.Font = new System.Drawing.Font("SimSun-ExtB", 14.25F);
			this.Sulge_btn.ForeColor = System.Drawing.Color.MediumSlateBlue;
			this.Sulge_btn.Location = new System.Drawing.Point(306, 164);
			this.Sulge_btn.Name = "Sulge_btn";
			this.Sulge_btn.Size = new System.Drawing.Size(77, 34);
			this.Sulge_btn.TabIndex = 12;
			this.Sulge_btn.Text = "Sulge";
			this.Sulge_btn.UseVisualStyleBackColor = true;
			// 
			// Parool
			// 
			this.Parool.Font = new System.Drawing.Font("SimSun-ExtB", 14.25F);
			this.Parool.ForeColor = System.Drawing.Color.MediumSlateBlue;
			this.Parool.Location = new System.Drawing.Point(211, 38);
			this.Parool.Name = "Parool";
			this.Parool.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.Parool.Size = new System.Drawing.Size(172, 26);
			this.Parool.TabIndex = 11;
			this.Parool.Text = "Parool";
			// 
			// Registrerimine
			// 
			this.Registrerimine.Font = new System.Drawing.Font("SimSun-ExtB", 14.25F);
			this.Registrerimine.ForeColor = System.Drawing.Color.MediumSlateBlue;
			this.Registrerimine.Location = new System.Drawing.Point(211, 97);
			this.Registrerimine.Name = "Registrerimine";
			this.Registrerimine.Size = new System.Drawing.Size(172, 41);
			this.Registrerimine.TabIndex = 10;
			this.Registrerimine.Text = "Registreerimine";
			this.Registrerimine.UseVisualStyleBackColor = true;
			this.Registrerimine.Click += new System.EventHandler(this.Registrerimine_Click);
			// 
			// Sisend
			// 
			this.Sisend.Font = new System.Drawing.Font("SimSun-ExtB", 14.25F);
			this.Sisend.ForeColor = System.Drawing.Color.MediumSlateBlue;
			this.Sisend.Location = new System.Drawing.Point(36, 97);
			this.Sisend.Name = "Sisend";
			this.Sisend.Size = new System.Drawing.Size(145, 41);
			this.Sisend.TabIndex = 9;
			this.Sisend.Text = "Sisend";
			this.Sisend.UseVisualStyleBackColor = true;
			this.Sisend.Click += new System.EventHandler(this.Sisend_Click_1);
			// 
			// Nimi
			// 
			this.Nimi.Font = new System.Drawing.Font("SimSun-ExtB", 14.25F);
			this.Nimi.ForeColor = System.Drawing.Color.MediumSlateBlue;
			this.Nimi.Location = new System.Drawing.Point(36, 38);
			this.Nimi.Name = "Nimi";
			this.Nimi.Size = new System.Drawing.Size(145, 26);
			this.Nimi.TabIndex = 8;
			this.Nimi.Text = "Nimi";
			// 
			// Kasutaja
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(436, 216);
			this.Controls.Add(this.Sulge_btn);
			this.Controls.Add(this.Parool);
			this.Controls.Add(this.Registrerimine);
			this.Controls.Add(this.Sisend);
			this.Controls.Add(this.Nimi);
			this.Name = "Kasutaja";
			this.Text = "Kasutaja";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button Sulge_btn;
		private System.Windows.Forms.TextBox Parool;
		private System.Windows.Forms.Button Registrerimine;
		private System.Windows.Forms.Button Sisend;
		private System.Windows.Forms.TextBox Nimi;
	}
}