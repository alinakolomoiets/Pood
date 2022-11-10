namespace Pood
{
	partial class Registreerimine
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
			this.components = new System.ComponentModel.Container();
			this.Nimi = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.Sisend = new System.Windows.Forms.Button();
			this.Registrerimine = new System.Windows.Forms.Button();
			this.Parool = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// Nimi
			// 
			this.Nimi.Font = new System.Drawing.Font("SimSun-ExtB", 14.25F);
			this.Nimi.Location = new System.Drawing.Point(126, 98);
			this.Nimi.Name = "Nimi";
			this.Nimi.Size = new System.Drawing.Size(145, 26);
			this.Nimi.TabIndex = 0;
			this.Nimi.Text = "Nimi";
			this.Nimi.TextChanged += new System.EventHandler(this.Nimi_TextChanged);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// Sisend
			// 
			this.Sisend.Font = new System.Drawing.Font("SimSun-ExtB", 14.25F);
			this.Sisend.Location = new System.Drawing.Point(126, 149);
			this.Sisend.Name = "Sisend";
			this.Sisend.Size = new System.Drawing.Size(145, 41);
			this.Sisend.TabIndex = 3;
			this.Sisend.Text = "Sisend";
			this.Sisend.UseVisualStyleBackColor = true;
			this.Sisend.Click += new System.EventHandler(this.Sisend_Click);
			// 
			// Registrerimine
			// 
			this.Registrerimine.Font = new System.Drawing.Font("SimSun-ExtB", 14.25F);
			this.Registrerimine.Location = new System.Drawing.Point(328, 149);
			this.Registrerimine.Name = "Registrerimine";
			this.Registrerimine.Size = new System.Drawing.Size(172, 41);
			this.Registrerimine.TabIndex = 4;
			this.Registrerimine.Text = "Registreerimine";
			this.Registrerimine.UseVisualStyleBackColor = true;
			this.Registrerimine.Click += new System.EventHandler(this.Registrerimine_Click);
			// 
			// Parool
			// 
			this.Parool.Font = new System.Drawing.Font("SimSun-ExtB", 14.25F);
			this.Parool.Location = new System.Drawing.Point(328, 98);
			this.Parool.Name = "Parool";
			this.Parool.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.Parool.Size = new System.Drawing.Size(172, 26);
			this.Parool.TabIndex = 5;
			this.Parool.Text = "Parool";
			this.Parool.TextChanged += new System.EventHandler(this.Parool_TextChanged);
			// 
			// Registreerimine
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(597, 273);
			this.Controls.Add(this.Parool);
			this.Controls.Add(this.Registrerimine);
			this.Controls.Add(this.Sisend);
			this.Controls.Add(this.Nimi);
			this.Name = "Registreerimine";
			this.Text = "Registreerimine";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox Nimi;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Button Sisend;
		private System.Windows.Forms.Button Registrerimine;
		private System.Windows.Forms.TextBox Parool;
	}
}