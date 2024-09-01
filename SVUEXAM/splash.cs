using SVUEXAM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace SVUEXAM
{
    public partial class splash : Form
    {
        private Timer splashTimer;

        public splash()
        {
            InitializeComponent();
            splashTimer = new Timer();
            splashTimer.Interval = 10;
            splashTimer.Tick += new EventHandler(splashTimer_Tick);
            splashTimer.Start();
        }

        private void splashTimer_Tick(object sender, EventArgs e)
        {
            if (ProgressBar.Value < ProgressBar.Maximum)
            {
                ProgressBar.Value += 3;
            }
            else
            {
                splashTimer.Stop();
                Login Login = new Login();
                Mangment.Show_and_Hide(Login,this);
            }
        }
    }

}
