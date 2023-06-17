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

   
    public partial class LoadingScreen : Form
    {
        private int loadingBarValue;
        // Konstructor
        public LoadingScreen()
        {
            InitializeComponent();
        }


        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            loadingbarTimer.Start();
        }

        private void loadingbarTimer_Tick(object sender, EventArgs e)
        {
            
            loadingBarValue+= 5;
            
            lblLoadingProgress.Text = loadingBarValue.ToString()+" %";
            loadingProgressBar.Value = loadingBarValue;

            // wenn der maximaleValue  erreicht stop
            if(loadingBarValue == loadingProgressBar.Maximum)
            {
                loadingbarTimer.Stop();

                //Finish loading to show Main View
                MainView mainView = new MainView();
                
                    mainView.Show();
                     this.Hide();
                //LoadingScreen loadingScreen = new LoadingScreen();
                    //loadingScreen.Hide();

            }
            
        }
       
    }
}
