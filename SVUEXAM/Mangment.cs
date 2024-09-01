using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SVUEXAM
{
    internal class Mangment
    {
        public static void Exit()
        {
            Application.Exit();
        }
        public static void Show_and_Hide(Form f1, Form f2)
        {
            f1.Show();
            f2.Hide();
        }
    }
}
