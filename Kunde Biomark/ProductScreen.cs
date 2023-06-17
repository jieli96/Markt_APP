using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kunde_Biomark
{
    public partial class ProductScreen : Form
    {
        public ProductScreen()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MainView mainView = new MainView();
            mainView.Show();
            this.Hide();
        }
    }
}
