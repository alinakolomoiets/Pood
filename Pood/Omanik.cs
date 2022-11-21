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
	public partial class Omanik : Form
	{
        //SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\opilane\source\repos\Alina_Kolomoiets_TARpv21\Pood\Pood\AppData\Tooded_DB.mdf;Integrated Security = True");
        SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\opilane\source\repos\Pood\Pood\AppData\Tooded_DB.mdf;Integrated Security = True");
        SqlCommand cmd;
		SqlDataAdapter adapter_toode, adapter_kat;
		OpenFileDialog openFileDialog;
		SaveFileDialog save;
		public Omanik()
		{
			InitializeComponent();
		}

		private void Sulge_btn_Click(object sender, EventArgs e)
		{
            this.Close();
		}

		private void Sisend_Click(object sender, EventArgs e)
		{
            SqlCommand cmd = new SqlCommand("SELECT * FROM Omanik where login=@nimi and password=@parool", connect);
            cmd.Parameters.AddWithValue("@nimi",Nimi.Text);
            cmd.Parameters.AddWithValue("@parool",Parool.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt); 
            connect.Open();
            int i = cmd.ExecuteNonQuery();
            connect.Close();
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("OLED SEES");
 
                Tooded tooded = new Tooded();
                tooded.Show();
            }
            else
            {
                MessageBox.Show("Vale,proovige uuesti");
            }
        }
	}
}
