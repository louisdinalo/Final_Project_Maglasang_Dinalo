using System;
using System.Linq;
using System.Windows.Forms;
using Final_Project_Dinalo_Maglasang.Models;

namespace Final_Project_Dinalo_Maglasang
{
    public partial class Enrollment : Form
    {
        private DinaloMaglasangStudentsystemContext context;

        public Enrollment()
        {
            InitializeComponent();
            context = new DinaloMaglasangStudentsystemContext();
        }

        private void Enrollment_Load(object sender, EventArgs e)
        {
            LoadStudents();
            LoadSubjects();
        }

        private void LoadStudents()
        {
            var students = context.Students.ToList();
            STUDENTCOMBOBOX.DataSource = students;
            STUDENTCOMBOBOX.DisplayMember = "FirstName";
            STUDENTCOMBOBOX.ValueMember = "StudentId";
        }

        private void LoadSubjects()
        {
            var subjects = context.Subjects.ToList();
            SUBJECTCOMBOBOX.DataSource = subjects;
            SUBJECTCOMBOBOX.DisplayMember = "SubjectName";
            SUBJECTCOMBOBOX.ValueMember = "SubjectId";
        }

        private void STUDENTCOMBOBOX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (STUDENTCOMBOBOX.SelectedItem is Student student)
            {
                FIRSTNAMEBOX.Text = student.FirstName;
                MIDDLEBOX.Text = student.MiddleName;
                LASTNAMEBOX.Text = student.LastName;
                EMAILBOX.Text = student.Email;
                ADDRESSBOX.Text = student.Address;
                if (student.Birthdate.HasValue)
                    BIRTHDATEPICKER.Value = student.Birthdate.Value;
                COURSEBOX.Text = student.Course;
            }
        }

        private void ENROLLBUTTON_Click(object sender, EventArgs e)
        {
            try
            {
                if (STUDENTCOMBOBOX.SelectedItem == null)
                {
                    MessageBox.Show("Please select a student.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (SUBJECTCOMBOBOX.SelectedItem == null)
                {
                    MessageBox.Show("Please select a subject.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var student = (Student)STUDENTCOMBOBOX.SelectedItem;
                var subject = (Subject)SUBJECTCOMBOBOX.SelectedItem;

                // Check if already enrolled
                var existingEnrollment = context.Enrollments
                    .FirstOrDefault(e => e.StudentId == student.StudentId);

                if (existingEnrollment != null)
                {
                    MessageBox.Show("This student is already enrolled.", "Duplicate Enrollment",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create enrollment
                var enrollment = new Models.Enrollment
                {
                    StudentId = student.StudentId,
                    DateEnrolled = DateTime.Now,
                    Status = "Enrolled"
                };

                context.Enrollments.Add(enrollment);
                context.SaveChanges();

                MessageBox.Show($"Student {student.FirstName} {student.LastName} has been successfully enrolled in {subject.SubjectName}!",
                    "Enrollment Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear selection
                STUDENTCOMBOBOX.SelectedIndex = -1;
                SUBJECTCOMBOBOX.SelectedIndex = -1;
                ClearStudentFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error enrolling student: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearStudentFields()
        {
            FIRSTNAMEBOX.Clear();
            MIDDLEBOX.Clear();
            LASTNAMEBOX.Clear();
            EMAILBOX.Clear();
            ADDRESSBOX.Clear();
            COURSEBOX.Clear();
        }
    }
}