using System;
using System.Drawing;
using System.Windows.Forms;

namespace SVUEXAM
{
    public partial class AddDepartments : UserControl
    {
        // Instance-level variable to track selection state
        private bool isSelected = false;

        // Events for when a department is selected or deselected
        public event Action<string> DepartmentSelected;
        public event Action<string> DepartmentDeselected;

        public AddDepartments(string name, Color color)
        {
            InitializeComponent();
            DepName.Text = name;
            box.BackColor = color; // Set the initial background color from the provided color list
        }

        private void DepName_Click(object sender, EventArgs e)
        {
            if (isSelected)
            {
                // Deselect
                isSelected = false;
                box.BackColor = Const.colors[Const.names.IndexOf(DepName.Text)]; // Reset to original color
                DepName.ForeColor = Color.WhiteSmoke;

                // Remove from the list if unselected
                if (Departments.selectedDepartments.Contains(DepName.Text))
                {
                    Departments.selectedDepartments.Remove(DepName.Text);
                    DepartmentDeselected?.Invoke(DepName.Text); // Fire deselected event
                }
            }
            else
            {
                // Select
                isSelected = true;
                box.BackColor = Color.Blue; // Set selected color
                DepName.ForeColor = Color.White;

                // Add to the list if selected
                if (!Departments.selectedDepartments.Contains(DepName.Text))
                {
                    Departments.selectedDepartments.Add(DepName.Text);
                    DepartmentSelected?.Invoke(DepName.Text); // Fire selected event
                }
            }
        }

        private void DepName_Enter(object sender, EventArgs e)
        {
            // Highlight on enter if not already selected
            if (!isSelected)
            {
                box.BackColor = Color.LightBlue; // Optional: Different color on hover/enter
                DepName.ForeColor = Color.White;
            }
        }

        private void DepName_Leave(object sender, EventArgs e)
        {
            // Revert to the selected state color
            if (isSelected)
            {
                box.BackColor = Color.Blue; // Keep selected color
                DepName.ForeColor = Color.White;
            }
            else
            {
                // Revert to original color if not selected
                box.BackColor = Const.colors[Const.names.IndexOf(DepName.Text)];
                DepName.ForeColor = Color.WhiteSmoke;
            }
        }
    }
}
