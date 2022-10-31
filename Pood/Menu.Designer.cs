namespace Pood
{
    partial class Menu
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
            this.Kassa_btn_Click = new System.Windows.Forms.Button();
            this.Pood_btn_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Kassa_btn_Click
            // 
            this.Kassa_btn_Click.Font = new System.Drawing.Font("SimSun-ExtB", 14.25F);
            this.Kassa_btn_Click.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.Kassa_btn_Click.Location = new System.Drawing.Point(79, 153);
            this.Kassa_btn_Click.Name = "Kassa_btn_Click";
            this.Kassa_btn_Click.Size = new System.Drawing.Size(166, 74);
            this.Kassa_btn_Click.TabIndex = 0;
            this.Kassa_btn_Click.Text = "Kassa";
            this.Kassa_btn_Click.UseVisualStyleBackColor = true;
            this.Kassa_btn_Click.Click += new System.EventHandler(this.Kassa_btn_Click_Click);
            // 
            // Pood_btn_Click
            // 
            this.Pood_btn_Click.Font = new System.Drawing.Font("SimSun-ExtB", 14.25F);
            this.Pood_btn_Click.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.Pood_btn_Click.Location = new System.Drawing.Point(271, 155);
            this.Pood_btn_Click.Name = "Pood_btn_Click";
            this.Pood_btn_Click.Size = new System.Drawing.Size(164, 71);
            this.Pood_btn_Click.TabIndex = 1;
            this.Pood_btn_Click.Text = "Pood";
            this.Pood_btn_Click.UseVisualStyleBackColor = true;
            this.Pood_btn_Click.Click += new System.EventHandler(this.Pood_btn_Click_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(573, 372);
            this.Controls.Add(this.Pood_btn_Click);
            this.Controls.Add(this.Kassa_btn_Click);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Kassa_btn_Click;
        private System.Windows.Forms.Button Pood_btn_Click;
    }
}