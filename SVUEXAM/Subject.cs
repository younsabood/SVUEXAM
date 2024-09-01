using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVUEXAM
{
    public partial class Subject : Form
    {
        public Subject(string name)
        {
            InitializeComponent();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Mangment.Exit();
        }
    }
}
