using System;
using System.Drawing;
using System.Windows.Forms;

namespace SVUEXAM
{
    public partial class ProfessorDepartment : UserControl
    {
        public ProfessorDepartment()
        {
            InitializeComponent();

            // Initialize and configure FlowLayoutPanel
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.Dock = DockStyle.Fill; // Make it fill the UserControl
            flowLayoutPanel.AutoScroll = true; // Allow scrolling if there are many items
            flowLayoutPanel.WrapContents = true; // Enable wrapping of controls
            flowLayoutPanel.FlowDirection = FlowDirection.LeftToRight; // Items flow left to right

            // Add the FlowLayoutPanel to the UserControl
            this.Controls.Add(flowLayoutPanel);

            // Dynamically add multiple AddDepartments controls
            for (int i = 0; i < Const.names.Count; i++) // Use the count of names
            {
                string name = Const.names[i];
                Color color = Const.colors[i];
                AddDepartments addDepartments = new AddDepartments(name, color);
                addDepartments.Margin = new Padding(10); // Add some margin around each item
                flowLayoutPanel.Controls.Add(addDepartments);
            }
        }
    }
}

