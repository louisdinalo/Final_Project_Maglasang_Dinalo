using System;
using System.Linq;
using System.Windows.Forms;
using Final_Project_Dinalo_Maglasang.Models;

namespace Final_Project_Dinalo_Maglasang
{
    public partial class Student_Registraion : Form
    {
        private DinaloMaglasangStudentsystemContext context;

        public Student_Registraion()
        {
            InitializeComponent();
            context = new DinaloMaglasangStudentsystemContext();
        }

        private void Student_Registraion_Load(object sender, EventArgs e)
        {
            // Auto-generate Student ID
            int nextId = 1;
            if (context.Students.Any())
            {
                nextId = context.Students.Max(s => s.StudentId) + 1;
            }
            STUDENTIDBOX.Text = nextId.ToString();
            STUDENTIDBOX.Enabled = false;
        }

        private void REGISTERBUTTON_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (string.IsNullOrWhiteSpace(FIRSTNAMEBOX.Text) ||
                    string.IsNullOrWhiteSpace(LASTNAMEBOX.Text) ||
                    string.IsNullOrWhiteSpace(EMAILBOX.Text) ||
                    string.IsNullOrWhiteSpace(ADDRESSBOX.Text))
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create new student
                var student = new Student
                {
                    FirstName = FIRSTNAMEBOX.Text.Trim(),
                    MiddleName = MIDDLEBOX.Text.Trim(),
                    LastName = LASTNAMEBOX.Text.Trim(),
                    Email = EMAILBOX.Text.Trim(),
                    Address = ADDRESSBOX.Text.Trim(),
                    Birthdate = BIRTHDATEPICKER.Value,
                    Course = COURSECOMBOBOX.SelectedItem?.ToString()
                };

                context.Students.Add(student);
                context.SaveChanges();

                MessageBox.Show($"Student {student.FirstName} {student.LastName} has been successfully registered!\nStudent ID: {student.StudentId}",
                    "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear form
                FIRSTNAMEBOX.Clear();
                MIDDLEBOX.Clear();
                LASTNAMEBOX.Clear();
                EMAILBOX.Clear();
                ADDRESSBOX.Clear();
                BIRTHDATEPICKER.Value = DateTime.Now;
                COURSECOMBOBOX.SelectedIndex = -1;

                // Refresh student ID
                int nextId = context.Students.Max(s => s.StudentId) + 1;
                STUDENTIDBOX.Text = nextId.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error registering student: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}