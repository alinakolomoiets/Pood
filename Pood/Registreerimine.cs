using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Pood
{
	public partial class Registreerimine : Form
	{
		SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\opilane\source\repos\Alina_Kolomoiets_TARpv21\Pood\Pood\AppData\Tooded_DB.mdf;Integrated Security = True");
		SqlCommand cmd;
		SqlDataAdapter adapter_registr, adapter_kat;
		OpenFileDialog openFileDialog;
		SaveFileDialog save;
		public Registreerimine()

		{

			InitializeComponent();
			Naita_Andmed();
		}

		private void Nimi_TextChanged(object sender, EventArgs e)
		{
			if (Nimi.Text.Length > 3)
			{

			}
		}

		private void Parool_TextChanged(object sender, EventArgs e)
		{
			if (Nimi.Text.Length > 5)
			{

			}
		}
		int Id ;
		private void Sisend_Click(object sender, EventArgs e)
		{
			
}

		private void Registrerimine_Click(object sender, EventArgs e)
		{
			if (Nimi.Text != "" && Parool.Text != "")
				try
				{
					cmd = new SqlCommand("INSERT INTO Registreerimine (login,pasword ,RollID) VALUES(@login,@pasword,@roll)", connect);
					connect.Open();
					cmd.Parameters.AddWithValue("@login", Nimi.Text);
					cmd.Parameters.AddWithValue("@pasword", Parool.Text);
					cmd.Parameters.AddWithValue("@kat", comboBox1.SelectedIndex);
					cmd.ExecuteNonQuery();
					Id = Convert.ToInt32(cmd.ExecuteScalar());
					connect.Close();
					Naita_Andmed();
				}

				catch(Exception)
				{

				}
		}

		private void Sulge_btn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
		public void Naita_Andmed()
		{
			connect.Open();
			DataTable dt = new DataTable();
			adapter_registr = new SqlDataAdapter("SELECT * FROM Registreerimine", connect);
			adapter_registr.Fill(dt);

			
			connect.Close();
			Naita_Kat();
		}
		public void Naita_Kat()
		{
			connect.Open();
			adapter_kat = new SqlDataAdapter("SELECT roll FROM Roll", connect);
			DataTable dt_kat = new DataTable();
			adapter_kat.Fill(dt_kat);
			foreach (DataRow nimetus in dt_kat.Rows)
			{
				comboBox1.Items.Add(nimetus["roll"]);
			}
			connect.Close();

		}
	}
}
