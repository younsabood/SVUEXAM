using System;
using System.Windows.Forms;

namespace SVUEXAM
{
    public partial class DRDataInput : Form
    {
        // Form instances
        private DRNameAndEmail dRNameAndEmail = new DRNameAndEmail();
        private ProfessorDepartment professorDepartment = new ProfessorDepartment();
        private ProfessorCourse professorCourse = new ProfessorCourse();

        // Track current page
        private int currentPage = 1;

        public DRDataInput()
        {
            InitializeComponent();
        }

        private void DRDataInput_Load(object sender, EventArgs e)
        {
            // Set DockStyle for all pages
            dRNameAndEmail.Dock = DockStyle.Fill;
            professorDepartment.Dock = DockStyle.Fill;
            professorCourse.Dock = DockStyle.Fill;

            // Start with the first page
            ShowPage(1);
        }

        private void Next_Click(object sender, EventArgs e)
        {
            // Navigate forward through pages
            NavigateToPage(currentPage + 1);
        }
        private void Previous_Click(object sender, EventArgs e)
        {
            // Navigate backward through pages
            NavigateToPage(currentPage - 1);
        }


        private void NavigateToPage(int pageID)
        {
            if (pageID < 1 || pageID > 3) 
                return;

            // Remove the current page
            RemoveCurrentPage();

            // Show the new page
            ShowPage(pageID);

            // Update current page
            currentPage = pageID;

            // Update Exit button enabled state
            Previous.Enabled = (currentPage > 1);
            Next.Enabled = (currentPage < 3);

        }

        private void RemoveCurrentPage()
        {
            // Remove the current page based on currentPage value
            if (currentPage == 1)
            {
                contenar.Controls.Remove(dRNameAndEmail);
            }
            else if (currentPage == 2)
            {
                contenar.Controls.Remove(professorDepartment);
            }
            else if (currentPage == 3)
            {
                contenar.Controls.Remove(professorCourse);
            }
        }

        private void ShowPage(int pageID)
        {
            // Add the new page based on pageID value
            if (pageID == 1)
            {
                contenar.Controls.Add(dRNameAndEmail);
            }
            else if (pageID == 2)
            {
                contenar.Controls.Add(professorDepartment);
            }
            else if (pageID == 3)
            {
                contenar.Controls.Add(professorCourse);
                professorCourse.InitializeDepartments();
            }
        }


    }
}
