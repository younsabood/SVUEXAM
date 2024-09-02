using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SVUEXAM
{
    // ProfessorCourse.cs
    public partial class ProfessorCourse : UserControl
    {
        public ProfessorCourse()
        {
            InitializeComponent();
        }
        private void ProfessorCourse_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (string item in Departments.selectedDepartments)
            {
                comboBox1.Items.Add(item);
            }
        }
    }
}
