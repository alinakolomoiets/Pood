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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Kassa_btn_Click_Click(object sender, EventArgs e)
        {

            Kassa kassa = new Kassa();
            kassa.ShowDialog();
        }

        private void Pood_btn_Click_Click(object sender, EventArgs e)
        {

            Tooded tooded = new Tooded();
            tooded.ShowDialog();
        }
    }
}
