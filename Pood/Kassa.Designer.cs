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
			this.Hint_txt = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Toode_pbox = new System.Windows.Forms.PictureBox();
			this.Hind_lbl = new System.Windows.Forms.Label();
			this.Kogus_lbl = new System.Windows.Forms.Label();
			this.Toode_lbl = new System.Windows.Forms.Label();
			this.Kogus = new System.Windows.Forms.TextBox();
			this.Toode = new System.Windows.Forms.TextBox();
			this.Check_btn_click = new System.Windows.Forms.Button();
			this.Kustuta_btn_Click = new System.Windows.Forms.Button();
			this.Check_pdf_click = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Toode_pbox)).BeginInit();
			this.SuspendLayout();
			// 
			// Hint_txt
			// 
			this.Hint_txt.Location = new System.Drawing.Point(203, 164);
			this.Hint_txt.Name = "Hint_txt";
			this.Hint_txt.Size = new System.Drawing.Size(121, 20);
			this.Hint_txt.TabIndex = 33;
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.GridColor = System.Drawing.Color.DarkSlateBlue;
			this.dataGridView1.Location = new System.Drawing.Point(62, 277);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(639, 150);
			this.dataGridView1.TabIndex = 32;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
			// 
			// Toode_pbox
			// 
			this.Toode_pbox.Location = new System.Drawing.Point(354, 13);
			this.Toode_pbox.Name = "Toode_pbox";
			this.Toode_pbox.Size = new System.Drawing.Size(268, 216);
			this.Toode_pbox.TabIndex = 27;
			this.Toode_pbox.TabStop = false;
			// 
			// Hind_lbl
			// 
			this.Hind_lbl.AutoSize = true;
			this.Hind_lbl.Font = new System.Drawing.Font("SimSun-ExtB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Hind_lbl.ForeColor = System.Drawing.Color.MediumSlateBlue;
			this.Hind_lbl.Location = new System.Drawing.Point(112, 165);
			this.Hind_lbl.Name = "Hind_lbl";
			this.Hind_lbl.Size = new System.Drawing.Size(49, 19);
			this.Hind_lbl.TabIndex = 25;
			this.Hind_lbl.Text = "Hind";
			// 
			// Kogus_lbl
			// 
			this.Kogus_lbl.AutoSize = true;
			this.Kogus_lbl.Font = new System.Drawing.Font("SimSun-ExtB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Kogus_lbl.ForeColor = System.Drawing.Color.MediumSlateBlue;
			this.Kogus_lbl.Location = new System.Drawing.Point(102, 110);
			this.Kogus_lbl.Name = "Kogus_lbl";
			this.Kogus_lbl.Size = new System.Drawing.Size(59, 19);
			this.Kogus_lbl.TabIndex = 24;
			this.Kogus_lbl.Text = "Kogus";
			// 
			// Toode_lbl
			// 
			this.Toode_lbl.AccessibleName = "";
			this.Toode_lbl.AutoSize = true;
			this.Toode_lbl.BackColor = System.Drawing.Color.Transparent;
			this.Toode_lbl.Font = new System.Drawing.Font("SimSun-ExtB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Toode_lbl.ForeColor = System.Drawing.Color.MediumSlateBlue;
			this.Toode_lbl.Location = new System.Drawing.Point(58, 55);
			this.Toode_lbl.Name = "Toode_lbl";
			this.Toode_lbl.Size = new System.Drawing.Size(139, 19);
			this.Toode_lbl.TabIndex = 22;
			this.Toode_lbl.Text = "Toode nimetus";
			// 
			// Kogus
			// 
			this.Kogus.Location = new System.Drawing.Point(203, 109);
			this.Kogus.Name = "Kogus";
			this.Kogus.Size = new System.Drawing.Size(121, 20);
			this.Kogus.TabIndex = 21;
			this.Kogus.TextChanged += new System.EventHandler(this.Kogus_TextChanged);
			// 
			// Toode
			// 
			this.Toode.Location = new System.Drawing.Point(203, 54);
			this.Toode.Name = "Toode";
			this.Toode.Size = new System.Drawing.Size(121, 20);
			this.Toode.TabIndex = 20;
			this.Toode.TextChanged += new System.EventHandler(this.Toode_TextChanged);
			// 
			// Check_btn_click
			// 
			this.Check_btn_click.Font = new System.Drawing.Font("SimSun-ExtB", 14.25F);
			this.Check_btn_click.ForeColor = System.Drawing.Color.MediumSlateBlue;
			this.Check_btn_click.Location = new System.Drawing.Point(659, 28);
			this.Check_btn_click.Name = "Check_btn_click";
			this.Check_btn_click.Size = new System.Drawing.Size(103, 46);
			this.Check_btn_click.TabIndex = 36;
			this.Check_btn_click.Text = "Check";
			this.Check_btn_click.UseVisualStyleBackColor = true;
			this.Check_btn_click.Click += new System.EventHandler(this.Check_btn_click_Click);
			// 
			// Kustuta_btn_Click
			// 
			this.Kustuta_btn_Click.Font = new System.Drawing.Font("SimSun-ExtB", 14.25F);
			this.Kustuta_btn_Click.ForeColor = System.Drawing.Color.MediumSlateBlue;
			this.Kustuta_btn_Click.Location = new System.Drawing.Point(659, 110);
			this.Kustuta_btn_Click.Name = "Kustuta_btn_Click";
			this.Kustuta_btn_Click.Size = new System.Drawing.Size(104, 46);
			this.Kustuta_btn_Click.TabIndex = 37;
			this.Kustuta_btn_Click.Text = "Kustuta";
			this.Kustuta_btn_Click.UseVisualStyleBackColor = true;
			this.Kustuta_btn_Click.Click += new System.EventHandler(this.Kustuta_btn_Click_Click);
			// 
			// Check_pdf_click
			// 
			this.Check_pdf_click.Font = new System.Drawing.Font("SimSun-ExtB", 14.25F);
			this.Check_pdf_click.ForeColor = System.Drawing.Color.MediumSlateBlue;
			this.Check_pdf_click.Location = new System.Drawing.Point(659, 183);
			this.Check_pdf_click.Name = "Check_pdf_click";
			this.Check_pdf_click.Size = new System.Drawing.Size(103, 46);
			this.Check_pdf_click.TabIndex = 38;
			this.Check_pdf_click.Text = "Check PDF";
			this.Check_pdf_click.UseVisualStyleBackColor = true;
			this.Check_pdf_click.Click += new System.EventHandler(this.Check_pdf_click_Click);
			// 
			// Kassa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(1311, 671);
			this.Controls.Add(this.Check_pdf_click);
			this.Controls.Add(this.Kustuta_btn_Click);
			this.Controls.Add(this.Check_btn_click);
			this.Controls.Add(this.Hint_txt);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.Toode_pbox);
			this.Controls.Add(this.Hind_lbl);
			this.Controls.Add(this.Kogus_lbl);
			this.Controls.Add(this.Toode_lbl);
			this.Controls.Add(this.Kogus);
			this.Controls.Add(this.Toode);
			this.Name = "Kassa";
			this.Text = "Kassa";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Toode_pbox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Hint_txt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox Toode_pbox;
        private System.Windows.Forms.Label Hind_lbl;
        private System.Windows.Forms.Label Kogus_lbl;
        private System.Windows.Forms.Label Toode_lbl;
        private System.Windows.Forms.TextBox Kogus;
        private System.Windows.Forms.TextBox Toode;
        private System.Windows.Forms.Button Check_btn_click;
        private System.Windows.Forms.Button Kustuta_btn_Click;
        private System.Windows.Forms.Button Check_pdf_click;
    }
}