using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pood
{
	public partial class Registreerimine : Form
	{
		public Registreerimine()
		{
			InitializeComponent();
		}

		private void Nimi_TextChanged(object sender, EventArgs e)
		{
			if (Nimi.Text.Length < 5)
				return;
		}

		private void Parool_TextChanged(object sender, EventArgs e)
		{
			if (Parool.Text.Length < 8)
				return;
		}

		private void Sisend_Click(object sender, EventArgs e)
		{

		}

		private void Registrerimine_Click(object sender, EventArgs e)
		{

		}
	}
}
