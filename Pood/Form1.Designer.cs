﻿namespace Pood
{
	partial class Form1
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
			this.Toode = new System.Windows.Forms.TextBox();
			this.Kogus = new System.Windows.Forms.TextBox();
			this.Hind = new System.Windows.Forms.TextBox();
			this.Toode_lbl = new System.Windows.Forms.Label();
			this.Kategooria_lbl = new System.Windows.Forms.Label();
			this.Kogus_lbl = new System.Windows.Forms.Label();
			this.Hind_lbl = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.Hint_txt = new System.Windows.Forms.TextBox();
			this.kategoria = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// Toode
			// 
			this.Toode.Location = new System.Drawing.Point(170, 12);
			this.Toode.Name = "Toode";
			this.Toode.Size = new System.Drawing.Size(121, 20);
			this.Toode.TabIndex = 0;
			this.Toode.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// Kogus
			// 
			this.Kogus.Location = new System.Drawing.Point(170, 47);
			this.Kogus.Name = "Kogus";
			this.Kogus.Size = new System.Drawing.Size(121, 20);
			this.Kogus.TabIndex = 1;
			this.Kogus.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
			// 
			// Hind
			// 
			this.Hind.Location = new System.Drawing.Point(170, 129);
			this.Hind.Name = "Hind";
			this.Hind.Size = new System.Drawing.Size(121, 20);
			this.Hind.TabIndex = 2;
			// 
			// Toode_lbl
			// 
			this.Toode_lbl.AccessibleName = "";
			this.Toode_lbl.AutoSize = true;
			this.Toode_lbl.BackColor = System.Drawing.Color.Snow;
			this.Toode_lbl.Font = new System.Drawing.Font("Nachlieli CLM", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.Toode_lbl.Location = new System.Drawing.Point(47, 15);
			this.Toode_lbl.Name = "Toode_lbl";
			this.Toode_lbl.Size = new System.Drawing.Size(104, 17);
			this.Toode_lbl.TabIndex = 3;
			this.Toode_lbl.Text = "Toode nimetus";
			this.Toode_lbl.Click += new System.EventHandler(this.label1_Click);
			// 
			// Kategooria_lbl
			// 
			this.Kategooria_lbl.AutoSize = true;
			this.Kategooria_lbl.Location = new System.Drawing.Point(65, 294);
			this.Kategooria_lbl.Name = "Kategooria_lbl";
			this.Kategooria_lbl.Size = new System.Drawing.Size(58, 13);
			this.Kategooria_lbl.TabIndex = 4;
			this.Kategooria_lbl.Text = "Kategooria";
			// 
			// Kogus_lbl
			// 
			this.Kogus_lbl.AutoSize = true;
			this.Kogus_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
			this.Kogus_lbl.Location = new System.Drawing.Point(71, 50);
			this.Kogus_lbl.Name = "Kogus_lbl";
			this.Kogus_lbl.Size = new System.Drawing.Size(56, 18);
			this.Kogus_lbl.TabIndex = 5;
			this.Kogus_lbl.Text = "Kogus";
			this.Kogus_lbl.Click += new System.EventHandler(this.label2_Click);
			// 
			// Hind_lbl
			// 
			this.Hind_lbl.AutoSize = true;
			this.Hind_lbl.Location = new System.Drawing.Point(79, 89);
			this.Hind_lbl.Name = "Hind_lbl";
			this.Hind_lbl.Size = new System.Drawing.Size(29, 13);
			this.Hind_lbl.TabIndex = 6;
			this.Hind_lbl.Text = "Hind";
			this.Hind_lbl.Click += new System.EventHandler(this.label3_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(170, 286);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 7;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(321, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(268, 216);
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(597, 185);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(110, 43);
			this.button1.TabIndex = 9;
			this.button1.Text = "Otsi fail";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(597, 240);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(110, 38);
			this.button2.TabIndex = 10;
			this.button2.Text = "Otsi fail";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(485, 240);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(104, 38);
			this.button3.TabIndex = 11;
			this.button3.Text = "Uuenda";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(364, 240);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(105, 38);
			this.button4.TabIndex = 12;
			this.button4.Text = "Lisa";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(68, 286);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(639, 150);
			this.dataGridView1.TabIndex = 13;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// Hint_txt
			// 
			this.Hint_txt.Location = new System.Drawing.Point(170, 86);
			this.Hint_txt.Name = "Hint_txt";
			this.Hint_txt.Size = new System.Drawing.Size(121, 20);
			this.Hint_txt.TabIndex = 15;
			// 
			// kategoria
			// 
			this.kategoria.AutoSize = true;
			this.kategoria.Location = new System.Drawing.Point(71, 129);
			this.kategoria.Name = "kategoria";
			this.kategoria.Size = new System.Drawing.Size(58, 13);
			this.kategoria.TabIndex = 16;
			this.kategoria.Text = "Kategooria";
			this.kategoria.Click += new System.EventHandler(this.label1_Click_1);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.kategoria);
			this.Controls.Add(this.Hint_txt);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.Hind_lbl);
			this.Controls.Add(this.Kogus_lbl);
			this.Controls.Add(this.Kategooria_lbl);
			this.Controls.Add(this.Toode_lbl);
			this.Controls.Add(this.Hind);
			this.Controls.Add(this.Kogus);
			this.Controls.Add(this.Toode);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox Toode;
		private System.Windows.Forms.TextBox Kogus;
		private System.Windows.Forms.TextBox Hind;
		private System.Windows.Forms.Label Toode_lbl;
		private System.Windows.Forms.Label Kategooria_lbl;
		private System.Windows.Forms.Label Kogus_lbl;
		private System.Windows.Forms.Label Hind_lbl;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.TextBox Hint_txt;
		private System.Windows.Forms.Label kategoria;
	}
}
