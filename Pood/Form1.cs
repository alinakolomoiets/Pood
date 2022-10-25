using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pood
{
	public partial class Form1 : Form
	{
		SqlConnection connect= new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\opilane\source\repos\Alina_Kolomoiets_TARpv21\Pood\Pood\AppData\Tooded_DB.mdf;Integrated Security = True");
		SqlCommand cmd;
		SqlDataAdapter adapter_toode, adapter_kat;
		OpenFileDialog openFileDialog;
		SaveFileDialog save;

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


			openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*";

			connect.Close();
			Naita_Kat();
		}
		public void Naita_Kat()
		{
			connect.Open();
			adapter_kat = new SqlDataAdapter("SELECT Kategoorisnimetus FROM Kategooria", connect);
			DataTable dt_kat = new DataTable();
			adapter_kat.Fill(dt_kat);
			foreach (DataRow nimetus in dt_kat.Rows)
			{
				Kat_cbox.Items.Add(nimetus["Kategoorisnimetus"]);
			}
			connect.Close();

		}
		public void Kustuta_andmed()
		{
			Toode.Text = "";
			Kogus.Text = "";
			Hint_txt.Text = "";
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
					string path = Toode_pbox.ImageLocation;
					FileInfo fi = new FileInfo(path);
					string extn = fi.Extension;
					cmd = new SqlCommand("INSERT INTO Toded (Toode_nimetus , Kogus , Hind, Pilt , KategooriaID) VALUES(@toode,@kogus,@hind,@pilt,@kat)", connect);
					connect.Open();
					cmd.Parameters.AddWithValue("@toode", Toode.Text);
					cmd.Parameters.AddWithValue("@kogus", Kogus.Text);
					cmd.Parameters.AddWithValue("@hind", Hint_txt.Text);//forat andmebaasis ja vormis võrdsed
					cmd.Parameters.AddWithValue("@pilt", Toode.Text + extn);//format?
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
			cmd = new SqlCommand("INSERT INTO Kategooria( Kategoorisnimetus) VALUES(@kat)", connect);
			connect.Open();
			cmd.Parameters.AddWithValue("@kat", Kat_cbox.Text);
			cmd.ExecuteNonQuery();
			connect.Close();
			Naita_Kat();
			Kustuta_andmed();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Toode.Text = "";
			Kogus.Text = "";
			Hint_txt.Text = "";
			Kat_cbox.Items.Clear();
		}


		private void button3_Click(object sender, EventArgs e)
		{
			if(Toode.Text != "" && Kogus.Text != "" && Hint_txt.Text != "" && Toode_pbox.Image != null)
			{
				cmd = new SqlCommand("UPDATE Tooded SET Toode_nimetus=@toode,Kogus=@kogus,Hind=@hind,Pilt=@pilt WHERE Id=@id", connect);
				connect.Open();
				cmd.Parameters.AddWithValue("@id", Id);
				cmd.Parameters.AddWithValue("@toode", Toode.Text);
				cmd.Parameters.AddWithValue("@kogus", Kogus.Text);
				cmd.Parameters.AddWithValue("@hind", Hint_txt.Text.Replace("," , "."));
				string file_pilt = Toode.Text + ".jpg";//kontroll
				cmd.Parameters.AddWithValue("@pilt", file_pilt);
				cmd.ExecuteNonQuery();
				connect.Close();
				Naita_Andmed();
				Kustuta_andmed();
				MessageBox.Show("Andmed uuendatud");

			}
		}
		Random rand = new Random();
		private void button2_Click(object sender, EventArgs e)
		{
			openFileDialog.InitialDirectory = @"C:\Users\opilane\Images";
			if(openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string ext=Path.GetExtension(openFileDialog.FileName);
				Toode_pbox.Load(openFileDialog.FileName);
				Bitmap finalIMG = new Bitmap(Toode_pbox.Image, Toode_pbox.Width, Toode_pbox.Height);
				Toode_pbox.Image = finalIMG;
				Toode_pbox.Show();
				string destiantionFile;
				try
				{
					destiantionFile = @"..\..\Images\" + Toode.Text + ext;
					File.Copy(openFileDialog.FileName,destiantionFile);
				}
				catch
				{
					destiantionFile = @"..\..\Images\" + Toode.Text + rand.Next(1, 99999).ToString()+ext;
					File.Copy(openFileDialog.FileName, destiantionFile);
				}
			}
		}
		int Id;

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			Id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
			Toode.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			Kogus.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			Hint_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

			Toode_pbox.Image = Image.FromFile(@"..\..\Images\" + dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());

			string v = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
			Kat_cbox.SelectedIndex = Int32.Parse(v) - 1;
		}

		private void Toode_pbox_Click(object sender, EventArgs e)
		{

		}

		private void kustuta_kat_btn_Click(object sender, EventArgs e)
		{
			if (Kat_cbox.Text == "")
				return;

			string sql = "DELETE FROM Kategooria WHERE Kategoorisnimetus = @nimi";

			using (SqlCommand cmd = new SqlCommand(sql, connect))
			{
				connect.Open();
				cmd.Parameters.AddWithValue("@nimi", Kat_cbox.Text);
				cmd.ExecuteNonQuery();
				connect.Close();

				Kustuta_andmed();
				Naita_Andmed();
			}

		}

		private void label1_Click_1(object sender, EventArgs e)
		{

		}
	}
}
