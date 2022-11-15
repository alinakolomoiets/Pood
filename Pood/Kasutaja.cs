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
	public partial class Kasutaja : Form
	{
        SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\opilane\source\repos\Alina_Kolomoiets_TARpv21\Pood\Pood\AppData\Tooded_DB.mdf;Integrated Security = True");
        SqlCommand cmd;
        SqlDataAdapter adapter_toode, adapter_kat;
        OpenFileDialog openFileDialog;
        SaveFileDialog save;
        public Kasutaja()
        {
            InitializeComponent();
            Naita_Andmed();
        }

        private void Sulge_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Sisend_Click(object sender, EventArgs e)
        {
         
        }

		private void Sisend_Click_1(object sender, EventArgs e)
		{
            SqlCommand cmd = new SqlCommand("SELECT * FROM Registreerimine where login=@nimi , pasword=@parool", connect);
            cmd.Parameters.AddWithValue("@nimi", Nimi.Text);
            cmd.Parameters.AddWithValue("@parool", Parool.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            connect.Open();
            int i = cmd.ExecuteNonQuery();
            connect.Close();
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("TEIE ANDMED ON ANDMEBAASI SISSESTATUD :D");

                Kassa kassa = new Kassa();
                kassa.Show();
            }
            else
            {
                MessageBox.Show("Vale,proovige uuesti");
            }
        }

		private void Registrerimine_Click(object sender, EventArgs e)
        {
            
                    cmd = new SqlCommand("INSERT INTO Registreerimine (login,pasword) VALUES(@nimi,@parool)", connect);
                    connect.Open();
                    cmd.Parameters.AddWithValue("@nimi", Nimi.Text);
                    cmd.Parameters.AddWithValue("@parool", Parool.Text);
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    Naita_Andmed();

                    MessageBox.Show("OLED SEES");

                    Kassa kassa = new Kassa();
                    kassa.Show();
            
        }
        public void Naita_Andmed()
        {
            connect.Open();
            DataTable dt = new DataTable();
            //cmd = new SqlCommand("SELECT * FROM Toodedtable" , connect);
            adapter_toode = new SqlDataAdapter("SELECT * FROM Registreerimine", connect);
            adapter_toode.Fill(dt);

            connect.Close();
       

        }
    }
}
