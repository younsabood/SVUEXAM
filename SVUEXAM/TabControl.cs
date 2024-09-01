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
    public partial class TabControl : UserControl
    {
        public TabControl(string MajorName , string SubjectName)
        {
            InitializeComponent();
            major.Text = MajorName;
            Subject.Text = SubjectName;
        }
    }
}
