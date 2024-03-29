﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Pdf;
using Image = System.Drawing.Image;


namespace Pood
{
    public partial class Kassa : Form
    {

        //SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\opilane\source\repos\Alina_Kolomoiets_TARpv21\Pood\Pood\AppData\Tooded_DB.mdf;Integrated Security = True");
        SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\opilane\source\repos\Pood\Pood\AppData\Tooded_DB.mdf;Integrated Security = True");
        SqlCommand cmd;
        SqlDataAdapter adapter_toode , adapter_kat , failinimi_adap;
        TabControl kategooriad;
        PictureBox pictureBox;

        public Kassa()
        {
            InitializeComponent();
            Naita_Andmed();
        }
       
        Document document;
        Random rnd = new Random();
        private void Check_pdf_click_Click(object sender, EventArgs e)
        {
            document = new Document();
            var page = document.Pages.Add();
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Toode      Hind      Kogus      Summa"));
            foreach (var toode in Tooded_list)
            {
                page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(toode));
            }
            int num = rnd.Next(0, 100000);
            //document.Save(@"C:\Users\opilane\source\repos\Alina_Kolomoiets_TARpv21\Pood\Pood\Arved\Arve" + num + ".pdf");
            document.Save(@"C:\opilane\source\repos\Pood\Pood\Arved\Arve" + num + ".pdf");
            document.Dispose();
            //System.Diagnostics.Process.Start(@"C:\Users\opilane\source\repos\Alina_Kolomoiets_TARpv21\Pood\Pood\Arved\Arve" + num + ".pdf");
            System.Diagnostics.Process.Start(@"C:\opilane\source\repos\Pood\Pood\Arved\Arve" + num + ".pdf");
        }
        int Id;

        List<string> Tooded_list = new List<string>();
        private void Check_btn_click_Click(object sender, EventArgs e)
        {
            Tooded_list.Add("-----------------------");
            Tooded_list.Add((Toode.Text + "            " + Hint_txt.Text + "              " + Kogus.Text + "            " + (Convert.ToInt32(Kogus.Text.ToString()) * Convert.ToInt32(Hint_txt.Text.ToString()))).ToString());
        }
        private void Kustuta_btn_Click_Click(object sender, EventArgs e)
        {
            Tooded_list.Clear();
        }
        public void Naita_Andmed()
        {
            connect.Open();
            DataTable dt = new DataTable();
            //cmd = new SqlCommand("SELECT * FROM Toodedtable" , connect);
            adapter_toode = new SqlDataAdapter("SELECT * FROM Toded", connect);
            adapter_toode.Fill(dt);
            dataGridView1.DataSource = dt;

            Toode_pbox.Image = Image.FromFile("../../Images/about.png");
            connect.Close();
        }

		private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{
            Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            Toode.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Kogus.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Hint_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

            Toode_pbox.Image = Image.FromFile(@"..\..\Images\" + dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());

            try
            {
                Toode_pbox.Image = Image.FromFile(@"..\..\Images\" + dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch (Exception)
            {
                Toode_pbox.Image = Image.FromFile(@"..\..\Images\about.png");
                MessageBox.Show("Fail puudub");
            }
        }

		private void Kat_boxi_Click(object sender, EventArgs e)
		{
            Kategooria kategooria = new Kategooria();
            kategooria.Show();

        }

        private void Toode_TextChanged(object sender, EventArgs e)
		{
          
        }
		private void Kogus_TextChanged(object sender, EventArgs e)
		{
         
        }
    }
}
