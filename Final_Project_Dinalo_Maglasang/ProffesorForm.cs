using System;
using System.Linq;
using System.Windows.Forms;
using Final_Project_Dinalo_Maglasang.Models;

namespace Final_Project_Dinalo_Maglasang
{
    public partial class ProffesorForm : Form
    {
        private DinaloMaglasangStudentsystemContext context;

        public ProffesorForm()
        {
            InitializeComponent();
            context = new DinaloMaglasangStudentsystemContext();
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

                // Check if email already exists
                if (context.Instructors.Any(i => i.Email == EMAILBOX.Text.Trim()))
                {
                    MessageBox.Show("An instructor with this email already exists.", "Duplicate Email",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create new instructor
                var instructor = new Instructor
                {
                    FirstName = FIRSTNAMEBOX.Text.Trim(),
                    MiddleName = MIDDLEBOX.Text.Trim(),
                    LastName = LASTNAMEBOX.Text.Trim(),
                    Email = EMAILBOX.Text.Trim(),
                    Address = ADDRESSBOX.Text.Trim()
                };

                context.Instructors.Add(instructor);
                context.SaveChanges();

                MessageBox.Show($"Professor {instructor.FirstName} {instructor.LastName} has been successfully registered!\nID: {instructor.InstructorId}",
                    "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear form
                FIRSTNAMEBOX.Clear();
                MIDDLEBOX.Clear();
                LASTNAMEBOX.Clear();
                EMAILBOX.Clear();
                ADDRESSBOX.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error registering professor: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}