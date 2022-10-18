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
		SqlConnection connect= new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\AppData\Tooded_DB.mdf;Integrated Security = True");
		SqlCommand cmd;
		SqlDataAdapter adapter;
		public Form1()
		{
			InitializeComponent();
			Naita_Andmed();
		}
		public void Naita_Andmed()
		{
			connect.Open();
			DataTable dt = new DataTable();
			//cmd = new SqlCommand("SELECT * FROM Toodedtable" , connect);
			adapter = new SqlDataAdapter("SELECT * FROM Toded", connect);
			adapter.Fill(dt);
			dataGridView1.DataSource = dt;
			connect.Close();
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

		private void label1_Click_1(object sender, EventArgs e)
		{

		}
	}
}
