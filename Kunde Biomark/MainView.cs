using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kunde_Biomark
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void BttProduktVerwalten_Click(object sender, EventArgs e)
        {
            ProductScreen productScreen = new ProductScreen();
            productScreen.Show();

           this.Hide();
        }

        private void BttRechnnung_Click(object sender, EventArgs e)
        {
            BillScreen billScreen = new BillScreen();
            billScreen.Show();
            this.Hide();
        }
    }
}
