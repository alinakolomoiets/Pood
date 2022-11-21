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
	public partial class Kategooria : Form
	{
		//SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\opilane\source\repos\Alina_Kolomoiets_TARpv21\Pood\Pood\AppData\Tooded_DB.mdf;Integrated Security = True");
		SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\opilane\source\repos\Pood\Pood\AppData\Tooded_DB.mdf;Integrated Security = True");
		SqlCommand cmd;
		SqlDataAdapter adapter_toode, adapter_kat, failinimi_adap;
		TabControl kategooriad;
		PictureBox pictureBox;
		TableLayoutPanel tlp;
		public Kategooria()
		{
			InitializeComponent();
			this.Size = new System.Drawing.Size(600, 300);
			Kategooriad();
		}
		public void Tooded(int kat_Id)
		{
			connect.Open();
			DataTable dt_toode = new DataTable();
			adapter_toode = new SqlDataAdapter("SELECT * FROM Toded", connect);
			adapter_toode.Fill(dt_toode);

			tlp = new TableLayoutPanel();
			foreach (DataRow toode in dt_toode.Rows)
			{
				//PictureBox pbox=new PictureBox.Image.Add.FromFile("../../Images/about.png");
			}

			connect.Close();

		}
		int kat_Id;
		string failid;

		List<string> fail_list;
		public List<string> Failid_KatId(int kat_Id)
		{
			fail_list = new List<string>();
			failinimi_adap = new SqlDataAdapter("SELECT Pilt FROM Toded WHERE Id=" + kat_Id, connect);
			//kat_Id_adap.MissingSchemaAction = MissingSchemaAction.Add;
			DataTable failid = new DataTable();
			failinimi_adap.Fill(failid);
			foreach (DataRow fail in failid.Rows)
			{
				fail_list.Add(fail["Pilt"].ToString());
			}
			return fail_list;
		}
		public void Kategooriad()
		{
			kategooriad = new TabControl();
			kategooriad.Name = "Kategooriad";
			kategooriad.Dock = DockStyle.Left;
			kategooriad.Width = this.Width;
			kategooriad.Height = this.Height;

			connect.Open();
			adapter_kat = new SqlDataAdapter("SELECT Id, Kategoorisnimetus FROM Kategooria", connect);

			DataTable dt_kat = new DataTable();
			adapter_kat.Fill(dt_kat);
			ImageList iconsList = new ImageList();//
			iconsList.ColorDepth = ColorDepth.Depth32Bit;//
			iconsList.ImageSize = new Size(25, 25);//

			int i = 0;//
			foreach (DataRow nimetus in dt_kat.Rows)
			{
				kategooriad.TabPages.Add((string)nimetus["Kategoorisnimetus"]);
				iconsList.Images.Add(Image.FromFile(@"C:\opilane\source\repos\Pood\Pood\Kategooria_pilt\" + (string)nimetus["Kategoorisnimetus"] + ".jpg"));//
				kategooriad.TabPages[i].ImageIndex = i;//
				i++;//
				kat_Id = (int)nimetus["Id"];
				fail_list = Failid_KatId(kat_Id);
				int r = 0;
				int c = 0;
				foreach (var fail in fail_list)
				{
					pictureBox = new PictureBox();
					pictureBox.Image = Image.FromFile(@"..\..\Images\" + fail);
					pictureBox.Width = pictureBox.Height = 100;
					pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
					pictureBox.Location = new Point(r, c);
					r = r + 100 + 2;
					kategooriad.TabPages[i - 1].Controls.Add(pictureBox);

				}
			}
			kategooriad.ImageList = iconsList;//
			connect.Close();
			this.Controls.Add(kategooriad);
		}
	}
}
