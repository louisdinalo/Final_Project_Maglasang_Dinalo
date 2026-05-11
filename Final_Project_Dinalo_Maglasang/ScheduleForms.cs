using System;
using System.Linq;
using System.Windows.Forms;
using Final_Project_Dinalo_Maglasang.Models;

namespace Final_Project_Dinalo_Maglasang
{
    public partial class ScheduleForms : Form
    {
        private DinaloMaglasangStudentsystemContext context;

        public ScheduleForms()
        {
            InitializeComponent();
            context = new DinaloMaglasangStudentsystemContext();
        }

        private void ScheduleForms_Load(object sender, EventArgs e)
        {
            LoadCourses();
            LoadInstructors();

            // Setup day of week combo box
            DAYOFWEEKCOMBOBOX.Items.Clear();
            DAYOFWEEKCOMBOBOX.Items.AddRange(new string[] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" });
        }

        private void LoadCourses()
        {
            var courses = context.Subjects
                .Select(s => s.CourseCode)
                .Distinct()
                .Where(c => c != null)
                .ToList();

            COURSECOMBOBOX.Items.Clear();
            foreach (var course in courses)
                COURSECOMBOBOX.Items.Add(course);
        }

        private void LoadInstructors()
        {
            var instructors = context.Instructors
                .Select(i => $"{i.FirstName} {i.LastName}")
                .ToList();

            PROFFESORCOMBOBOX.Items.Clear();
            foreach (var instructor in instructors)
                PROFFESORCOMBOBOX.Items.Add(instructor);
        }

        private void SAVEBUTTON_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (string.IsNullOrWhiteSpace(SUBJECTNAMEBOX.Text) ||
                    string.IsNullOrWhiteSpace(SUBJECTCODEBOX.Text) ||
                    COURSECOMBOBOX.SelectedItem == null ||
                    SEMESTERCOMBOBOX.SelectedItem == null ||
                    PROFFESORCOMBOBOX.SelectedItem == null ||
                    DAYOFWEEKCOMBOBOX.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(STARTTIMEBOX.Text) ||
                    string.IsNullOrWhiteSpace(ENDTIMEBOX.Text))
                {
                    MessageBox.Show("Please fill in all fields.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create or get subject
                var subject = context.Subjects
                    .FirstOrDefault(s => s.SubjectName == SUBJECTNAMEBOX.Text);

                if (subject == null)
                {
                    subject = new Subject
                    {
                        SubjectName = SUBJECTNAMEBOX.Text,
                        CourseCode = COURSECOMBOBOX.SelectedItem.ToString()
                    };
                    context.Subjects.Add(subject);
                    context.SaveChanges();
                }

                // Get instructor
                var instructorName = PROFFESORCOMBOBOX.SelectedItem.ToString().Split(' ');
                var instructor = context.Instructors
                    .FirstOrDefault(i => i.FirstName == instructorName[0] && i.LastName == instructorName[1]);

                if (instructor == null)
                {
                    MessageBox.Show("Selected instructor not found.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Parse times
                if (!TimeSpan.TryParse(STARTTIMEBOX.Text, out TimeSpan startTime) ||
                    !TimeSpan.TryParse(ENDTIMEBOX.Text, out TimeSpan endTime))
                {
                    MessageBox.Show("Please enter valid times (HH:MM format).", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create schedule
                var schedule = new Schedule
                {
                    SubjectId = subject.SubjectId,
                    DayGroup = DAYOFWEEKCOMBOBOX.SelectedItem.ToString(),
                    TimeStart = startTime,
                    EndTime = endTime,
                    InstructorId = instructor.InstructorId
                };

                context.Schedules.Add(schedule);
                context.SaveChanges();

                MessageBox.Show("Schedule has been successfully created!",
                    "Schedule Creation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear form
                SUBJECTNAMEBOX.Clear();
                SUBJECTCODEBOX.Clear();
                COURSECOMBOBOX.SelectedIndex = -1;
                SEMESTERCOMBOBOX.SelectedIndex = -1;
                PROFFESORCOMBOBOX.SelectedIndex = -1;
                DAYOFWEEKCOMBOBOX.SelectedIndex = -1;
                STARTTIMEBOX.Clear();
                ENDTIMEBOX.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating schedule: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}