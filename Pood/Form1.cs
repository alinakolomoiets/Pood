using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pood
{
	public partial class Form1 : Form
	{
		SqlConnection connect= new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\opilane\source\repos\Alina_Kolomoiets_TARpv21\Pood\Pood\AppData\Tooded_DB.mdf;Integrated Security = True");
		SqlCommand cmd;
		SqlDataAdapter adapter_toode, adapter_kat;
		public Form1()
		{
			InitializeComponent();
			Naita_Andmed();
		}
		public void Lisa_Andmed()
		{
			if(Toode.Text.Trim()!=string.Empty && Kogus.Text.Trim()!= string.Empty &&Hint_txt.Text.Trim() != string.Empty && Kat_cbox.SelectedItem != null)
			{
				try
				{
					cmd = new SqlCommand("INSERT INTO Toded (Toode nimetus , Kogus , Hind, Pilt , KategooriaID) VALUES(@toode,@kogus,@hind,@pilt,@kat)",connect);
					connect.Open();
					cmd.Parameters.AddWithValue("@toode", Toode.Text);
					cmd.Parameters.AddWithValue("@kogus", Kogus.Text);
					cmd.Parameters.AddWithValue("@hind", Hint_txt.Text);//forat andmebaasis ja vormis võrdsed
					cmd.Parameters.AddWithValue("@pilt", Toode.Text+".png");//format?
					cmd.Parameters.AddWithValue("@kat", Kat_cbox.SelectedIndex);//id andmebaasist  võtta
					cmd.ExecuteNonQuery();
					connect.Close();
					Kustuta_andmed();
					Naita_Andmed();
				}
				catch(Exception)
				{
					MessageBox.Show("Andmebaasiga viga!");
				}
			}
			else
			{
				MessageBox.Show("Sisesta andmed");
			}
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
			Toode_pbox.SizeMode = PictureBoxSizeMode.StretchImage;

			connect.Close();
			Naita_Kat();
		}
		public void Naita_Kat()
		{
			connect.Open();
			adapter_kat = new SqlDataAdapter("SELECT Kategooris_nimetus FROM Kategooria", connect);
			DataTable dt_kat = new DataTable();
			adapter_kat.Fill(dt_kat);
			foreach (DataRow nimetus in dt_kat.Rows)
			{
				Kat_cbox.Items.Add(nimetus["Kategooris_nimetus"]);
			}
			connect.Close();
		}
		public void Kustuta_andmed()
		{
			Toode.Text = "";
			Hint_txt.Text = "";
			Kogus.Text = "";
			Kat_cbox.Items.Clear();
		}
		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged_1(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (Toode.Text.Trim() != string.Empty && Kogus.Text.Trim() != string.Empty && Hint_txt.Text.Trim() != string.Empty && Kat_cbox.SelectedItem != null)
			{
				try
				{
					cmd = new SqlCommand("INSERT INTO Toded (Toode_nimetus , Kogus , Hind, Pilt , KategooriaID) VALUES(@toode,@kogus,@hind,@pilt,@kat)", connect);
					connect.Open();
					cmd.Parameters.AddWithValue("@toode", Toode.Text);
					cmd.Parameters.AddWithValue("@kogus", Kogus.Text);
					cmd.Parameters.AddWithValue("@hind", Hint_txt.Text);//forat andmebaasis ja vormis võrdsed
					cmd.Parameters.AddWithValue("@pilt", Toode.Text + ".jpg");//format?
					cmd.Parameters.AddWithValue("@kat", Kat_cbox.SelectedIndex);//id andmebaasist  võtta
					cmd.ExecuteNonQuery();
					connect.Close();
					Kustuta_andmed();
					Naita_Andmed();
				}
				catch (Exception)
				{
					MessageBox.Show("Andmebaasiga viga!");
				}
			}
			else
			{
				MessageBox.Show("Sisesta andmed");
			}
		}

		private void lisa_kat_Click(object sender, EventArgs e)
		{
			cmd = new SqlCommand("INSERT INTO Kategooria( Kategooris_nimetus) VALUES(@kat)", connect);
			connect.Open();
			cmd.Parameters.AddWithValue("@kat", Kat_cbox.Text);
			cmd.ExecuteNonQuery();
			connect.Close();
			Naita_Kat();
			Kustuta_andmed();
		}

		private void label1_Click_1(object sender, EventArgs e)
		{

		}
	}
}
