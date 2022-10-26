namespace Pood
{
	partial class Kassa
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
			this.Toode_lbl = new System.Windows.Forms.Label();
			this.Tooded = new System.Windows.Forms.ComboBox();
			this.Toode_pbox = new System.Windows.Forms.PictureBox();
			this.Kogus_lbl = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Kogus = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.Toode_pbox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Kogus)).BeginInit();
			this.SuspendLayout();
			// 
			// Toode_lbl
			// 
			this.Toode_lbl.AccessibleName = "";
			this.Toode_lbl.AutoSize = true;
			this.Toode_lbl.BackColor = System.Drawing.Color.Transparent;
			this.Toode_lbl.Font = new System.Drawing.Font("SimSun-ExtB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Toode_lbl.ForeColor = System.Drawing.Color.MediumSlateBlue;
			this.Toode_lbl.Location = new System.Drawing.Point(51, 39);
			this.Toode_lbl.Name = "Toode_lbl";
			this.Toode_lbl.Size = new System.Drawing.Size(139, 19);
			this.Toode_lbl.TabIndex = 4;
			this.Toode_lbl.Text = "Toode nimetus";
			// 
			// Tooded
			// 
			this.Tooded.FormattingEnabled = true;
			this.Tooded.Location = new System.Drawing.Point(208, 41);
			this.Tooded.Name = "Tooded";
			this.Tooded.Size = new System.Drawing.Size(121, 21);
			this.Tooded.TabIndex = 18;
			// 
			// Toode_pbox
			// 
			this.Toode_pbox.Location = new System.Drawing.Point(390, 39);
			this.Toode_pbox.Name = "Toode_pbox";
			this.Toode_pbox.Size = new System.Drawing.Size(268, 216);
			this.Toode_pbox.TabIndex = 19;
			this.Toode_pbox.TabStop = false;
			// 
			// Kogus_lbl
			// 
			this.Kogus_lbl.AutoSize = true;
			this.Kogus_lbl.Font = new System.Drawing.Font("SimSun-ExtB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Kogus_lbl.ForeColor = System.Drawing.Color.MediumSlateBlue;
			this.Kogus_lbl.Location = new System.Drawing.Point(51, 92);
			this.Kogus_lbl.Name = "Kogus_lbl";
			this.Kogus_lbl.Size = new System.Drawing.Size(59, 19);
			this.Kogus_lbl.TabIndex = 20;
			this.Kogus_lbl.Text = "Kogus";
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.GridColor = System.Drawing.Color.DarkSlateBlue;
			this.dataGridView1.Location = new System.Drawing.Point(55, 272);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(639, 150);
			this.dataGridView1.TabIndex = 21;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// Kogus
			// 
			this.Kogus.Location = new System.Drawing.Point(154, 91);
			this.Kogus.Name = "Kogus";
			this.Kogus.Size = new System.Drawing.Size(120, 20);
			this.Kogus.TabIndex = 22;
			// 
			// Kassa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Kogus);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.Kogus_lbl);
			this.Controls.Add(this.Toode_pbox);
			this.Controls.Add(this.Tooded);
			this.Controls.Add(this.Toode_lbl);
			this.Name = "Kassa";
			this.Text = "Menu";
			((System.ComponentModel.ISupportInitialize)(this.Toode_pbox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Kogus)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Toode_lbl;
		private System.Windows.Forms.ComboBox Tooded;
		private System.Windows.Forms.PictureBox Toode_pbox;
		private System.Windows.Forms.Label Kogus_lbl;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.NumericUpDown Kogus;
	}
}