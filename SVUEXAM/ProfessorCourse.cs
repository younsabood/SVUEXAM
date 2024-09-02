using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SVUEXAM
{
    // ProfessorCourse.cs
    public partial class ProfessorCourse : UserControl
    {
        public ProfessorCourse()
        {
            InitializeComponent();
            DepartmentsComboBox.Items.Clear();
            DepartmentsComboBox.Items.Add("Select Department");
            DepartmentsComboBox.SelectedItem = "Select Department";
            DataGridView.Columns.Clear();
            DataGridView.Columns.Add("CourseName", "Course Name");
            DataGridView.Columns.Add("CourseArabicName", "Course Arabic Name");
            DataGridView.Columns.Add("CourseEnglishName", "Course English Name");
            DataGridView.Columns.Add("CreditHours", "Credit Hours");
            DataGridView.Columns.Add("CourseCode", "Course Code");
            DataGridView.Columns.Add("SpecializationName", "Specialization Name");
            DataGridView.Columns.Add("DepartmentName", "Department Name");
        }

        public void InitializeDepartments()
        {

            foreach (string Departments in Departments.selectedDepartments)
            {
                DepartmentsComboBox.Items.Add(Departments);
            }
        }
        public async void CourseItems()
        {
            // Ensure the department has been selected
            if (DepartmentsComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a department first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Get the selected department
            string selectedDepartment = DepartmentsComboBox.SelectedItem.ToString();

            // Define the query with a parameter placeholder
            string query = @"
                    SELECT c.CourseCode
                    FROM Course c
                    JOIN Specialization s ON c.SpecializationID = s.SpecializationID
                    JOIN Department d ON s.DepartmentID = d.DepartmentID
                    WHERE d.Name = @DepartmentName
                    ORDER BY c.Name ASC";

            // Create SqlParameter for the query
            SqlParameter departmentParam = new SqlParameter("@DepartmentName", selectedDepartment);

            try
            {
                // Execute the query with the SqlParameter
                DataTable resultTable = await SQL.ExecuteQueryAsync(query, true, departmentParam);
                Course.Items.Clear();
                Course.Items.Add("Select Course");
                Course.SelectedItem = "Select Course";
                if (resultTable != null && resultTable.Rows.Count > 0)
                {
                    foreach (DataRow row in resultTable.Rows)
                    {
                        string courseName = row["CourseCode"].ToString();
                        Course.Items.Add(courseName);
                    }
                }
                else
                {
                    MessageBox.Show("No courses found for the selected department or an error occurred.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async void CourseSelectedItem()
        {
            // Get the selected course code
            string selectedCourseCode = Course.SelectedItem?.ToString() ?? string.Empty;

            // Ensure a course is selected
            if (string.IsNullOrEmpty(selectedCourseCode))
            {
                MessageBox.Show("Please select a course.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Define the query with a parameter placeholder
            string query = @"
                    SELECT 
                        c.Name AS CourseName,
                        c.ArabicName AS CourseArabicName,
                        c.EnglishName AS CourseEnglishName,
                        c.CreditHours,
                        c.CourseCode,
                        s.SpecializationName,
                        d.Name AS DepartmentName
                    FROM 
                        Course c
                        INNER JOIN Specialization s ON c.SpecializationID = s.SpecializationID
                        INNER JOIN Department d ON s.DepartmentID = d.DepartmentID
                    WHERE 
                        c.CourseCode = @CourseCode;";

            // Create SqlParameter for the query
            SqlParameter courseParam = new SqlParameter("@CourseCode", selectedCourseCode);

            try
            {
                // Fetch the data using SQL.ExecuteQueryAsync
                DataTable resultTable = await SQL.ExecuteQueryAsync(query, false, courseParam);

                // Ensure the resultTable has columns and rows
                if (resultTable != null && resultTable.Columns.Count > 0 && resultTable.Rows.Count > 0)
                {
                    // Check if the DataGridView already contains a row with the same CourseCode
                    bool rowExists = false;
                    foreach (DataGridViewRow row in DataGridView.Rows)
                    {
                        // Assuming CourseCode is the 5th column (index 4)
                        if (row.Cells[4].Value?.ToString() == selectedCourseCode)
                        {
                            rowExists = true;
                            break;
                        }
                    }

                    // Only add the row if it does not already exist
                    if (!rowExists)
                    {
                        // Assuming the DataGridView has 7 columns, adjust this to match your DataGridView's column count
                        if (DataGridView.ColumnCount == 7)
                        {
                            // Create a new row and populate it with data
                            DataRow row = resultTable.Rows[0];
                            DataGridViewRow dgvRow = new DataGridViewRow();
                            dgvRow.CreateCells(DataGridView);

                            // Populate cells with data from DataRow
                            for (int i = 0; i < 7; i++)
                            {
                                dgvRow.Cells[i].Value = row[i];
                            }

                            // Add the row to the DataGridView
                            DataGridView.Rows.Add(dgvRow);
                        }
                        else
                        {
                            MessageBox.Show("The DataGridView column count does not match the expected number of columns.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The selected course is already in the table.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No data found for the selected course.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Reset the selected item
                Course.SelectedItem = "Select Course";
            }
            catch (Exception ex)
            {
                // Show error message
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void DepartmentsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Course.Items.Clear();
            Course.Items.Add("Select Course");
            Course.SelectedItem = "Select Course";
            if (DepartmentsComboBox.SelectedItem == null || DepartmentsComboBox.SelectedItem.ToString() == "Select Department")
            {
                return;
            }
            else
            {
                CourseItems();
            }
        }

        private void Course_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (Course.SelectedItem == null || Course.SelectedItem.ToString() == "Select Course")
            {
                return;
            }
            CourseSelectedItem();
        }

        private void DataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is not on the header row
            if (e.RowIndex >= 0)
            {
                // Confirm removal
                var result = MessageBox.Show("Are you sure you want to delete this row?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Remove the row from the DataGridView
                    DataGridView.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
    }
}
