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
			this.Sulge_btn = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// Nimi
			// 
			this.Nimi.Font = new System.Drawing.Font("SimSun-ExtB", 14.25F);
			this.Nimi.ForeColor = System.Drawing.Color.MediumSlateBlue;
			this.Nimi.Location = new System.Drawing.Point(31, 98);
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
			this.Sisend.ForeColor = System.Drawing.Color.MediumSlateBlue;
			this.Sisend.Location = new System.Drawing.Point(31, 149);
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
			this.Registrerimine.ForeColor = System.Drawing.Color.MediumSlateBlue;
			this.Registrerimine.Location = new System.Drawing.Point(206, 149);
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
			this.Parool.ForeColor = System.Drawing.Color.MediumSlateBlue;
			this.Parool.Location = new System.Drawing.Point(206, 98);
			this.Parool.Name = "Parool";
			this.Parool.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.Parool.Size = new System.Drawing.Size(172, 26);
			this.Parool.TabIndex = 5;
			this.Parool.Text = "Parool";
			this.Parool.TextChanged += new System.EventHandler(this.Parool_TextChanged);
			// 
			// Sulge_btn
			// 
			this.Sulge_btn.Font = new System.Drawing.Font("SimSun-ExtB", 14.25F);
			this.Sulge_btn.ForeColor = System.Drawing.Color.MediumSlateBlue;
			this.Sulge_btn.Location = new System.Drawing.Point(301, 196);
			this.Sulge_btn.Name = "Sulge_btn";
			this.Sulge_btn.Size = new System.Drawing.Size(77, 34);
			this.Sulge_btn.TabIndex = 6;
			this.Sulge_btn.Text = "Sulge";
			this.Sulge_btn.UseVisualStyleBackColor = true;
			this.Sulge_btn.Click += new System.EventHandler(this.Sulge_btn_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.Font = new System.Drawing.Font("SimSun-ExtB", 14.25F);
			this.comboBox1.ForeColor = System.Drawing.Color.MediumSlateBlue;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(398, 98);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(143, 27);
			this.comboBox1.TabIndex = 7;
			this.comboBox1.Text = "Valik roll";
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// Registreerimine
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(597, 273);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.Sulge_btn);
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
		private System.Windows.Forms.Button Sulge_btn;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}