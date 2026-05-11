using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using Final_Project_Dinalo_Maglasang.Models;

namespace Final_Project_Dinalo_Maglasang
{
    public partial class GradeForm : Form
    {
        private DinaloMaglasangStudentsystemContext context;
        private Dictionary<int, Dictionary<string, decimal>> gradeCache;

        public GradeForm()
        {
            InitializeComponent();
            context = new DinaloMaglasangStudentsystemContext();
            gradeCache = new Dictionary<int, Dictionary<string, decimal>>();
            this.Load += GradeForm_Load;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            SUBJECTCOMBOBOX.SelectedIndexChanged += SUBJECTCOMBOBOX_SelectedIndexChanged;
            SAVEBUTTON.Click += SAVEBUTTON_Click;

            // Add text changed events to auto-save or validate
            PRELIMBOX.TextChanged += GradeBox_TextChanged;
            MIDTERMBOX.TextChanged += GradeBox_TextChanged;
            FINALSBOX.TextChanged += GradeBox_TextChanged;
        }

        private void GradeForm_Load(object sender, EventArgs e)
        {
            LoadStudents();
            LoadSubjects();
            LoadGradeDataGrid();

            // Setup grade input validation
            SetupGradeInputs();
        }

        private void SetupGradeInputs()
        {
            // Add validation for grade inputs (only numbers and decimals)
            PRELIMBOX.KeyPress += GradeBox_KeyPress;
            MIDTERMBOX.KeyPress += GradeBox_KeyPress;
            FINALSBOX.KeyPress += GradeBox_KeyPress;
        }

        private void GradeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow numbers, decimal point, and control characters
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void GradeBox_TextChanged(object sender, EventArgs e)
        {
            // Auto-calculate and display remark when grades change
            CalculateAndDisplayAverage();
        }

        private void CalculateAndDisplayAverage()
        {
            if (!string.IsNullOrWhiteSpace(PRELIMBOX.Text) ||
                !string.IsNullOrWhiteSpace(MIDTERMBOX.Text) ||
                !string.IsNullOrWhiteSpace(FINALSBOX.Text))
            {
                decimal prelim = GetGradeValue(PRELIMBOX.Text);
                decimal midterm = GetGradeValue(MIDTERMBOX.Text);
                decimal finals = GetGradeValue(FINALSBOX.Text);

                int gradeCount = 0;
                decimal total = 0;

                if (prelim > 0) { total += prelim; gradeCount++; }
                if (midterm > 0) { total += midterm; gradeCount++; }
                if (finals > 0) { total += finals; gradeCount++; }

                if (gradeCount > 0)
                {
                    decimal average = total / gradeCount;
                    string remark = average >= 75 ? "Passing" : "Failing";

                    // You can add a label to display average and remark
                    // For now, we'll just store it or show in a tooltip
                    if (average >= 75)
                    {
                        PRELIMBOX.BackColor = System.Drawing.Color.LightGreen;
                        MIDTERMBOX.BackColor = System.Drawing.Color.LightGreen;
                        FINALSBOX.BackColor = System.Drawing.Color.LightGreen;
                    }
                    else
                    {
                        PRELIMBOX.BackColor = System.Drawing.Color.LightPink;
                        MIDTERMBOX.BackColor = System.Drawing.Color.LightPink;
                        FINALSBOX.BackColor = System.Drawing.Color.LightPink;
                    }
                }
            }
        }

        private decimal GetGradeValue(string gradeText)
        {
            if (string.IsNullOrWhiteSpace(gradeText))
                return 0;

            if (decimal.TryParse(gradeText, out decimal value))
                return Math.Min(100, Math.Max(0, value)); // Clamp between 0 and 100

            return 0;
        }

        private void LoadStudents()
        {
            var students = context.Students.ToList();
            comboBox1.DisplayMember = "FullName";
            comboBox1.ValueMember = "StudentId";
            comboBox1.DataSource = students;

            // Add a "Select Student" placeholder
            comboBox1.SelectedIndex = -1;
        }

        private void LoadSubjects()
        {
            var subjects = context.Subjects.ToList();
            SUBJECTCOMBOBOX.DisplayMember = "SubjectName";
            SUBJECTCOMBOBOX.ValueMember = "SubjectId";
            SUBJECTCOMBOBOX.DataSource = subjects;

            // Add a "Select Subject" placeholder
            SUBJECTCOMBOBOX.SelectedIndex = -1;
        }

        private void LoadGradeDataGrid()
        {
            try
            {
                var grades = context.Grades
                    .Select(g => new
                    {
                        Subject = g.Subject.SubjectName,
                        GradeValue = g.GradeValue.HasValue ? g.GradeValue.Value.ToString("F2") : "N/A",
                        Remark = g.Remark ?? "No Grade"
                    })
                    .ToList();

                SUBJECTGRADEDATAGRIDVIEW.DataSource = grades;

                // Format the grid
                if (SUBJECTGRADEDATAGRIDVIEW.Columns.Count > 0)
                {
                    SUBJECTGRADEDATAGRIDVIEW.Columns["GradeValue"].HeaderText = "Grade";
                    SUBJECTGRADEDATAGRIDVIEW.Columns["GradeValue"].Width = 100;
                    SUBJECTGRADEDATAGRIDVIEW.Columns["Remark"].Width = 100;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading grade data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                LoadStudentGrades((Student)comboBox1.SelectedItem);

                // Auto-load grades for the first subject if available
                if (SUBJECTCOMBOBOX.Items.Count > 0 && SUBJECTCOMBOBOX.SelectedIndex == -1)
                {
                    SUBJECTCOMBOBOX.SelectedIndex = 0;
                }
            }
            else
            {
                ClearGradeInputs();
            }
        }

        private void SUBJECTCOMBOBOX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && SUBJECTCOMBOBOX.SelectedItem != null)
            {
                LoadGradesForSubject((Student)comboBox1.SelectedItem, (Subject)SUBJECTCOMBOBOX.SelectedItem);
            }
        }

        private void LoadStudentGrades(Student student)
        {
            try
            {
                // Get all grades for the selected student through enrollments
                var studentGrades = (from enrollment in context.Enrollments
                                     join schedule in context.Schedules on enrollment.ScheduleId equals schedule.ScheduleId
                                     join subject in context.Subjects on schedule.SubjectId equals subject.SubjectId
                                     join grade in context.Grades on subject.SubjectId equals grade.SubjectId into grades
                                     from grade in grades.DefaultIfEmpty()
                                     where enrollment.StudentId == student.StudentId
                                     select new
                                     {
                                         Subject = subject.SubjectName,
                                         SubjectId = subject.SubjectId,
                                         GradeValue = grade != null && grade.GradeValue.HasValue ? grade.GradeValue.Value.ToString("F2") : "No Grade",
                                         Remark = grade != null ? grade.Remark : "Not Graded",
                                         Prelim = GetGradeComponent(subject.SubjectId, "Prelim"),
                                         Midterm = GetGradeComponent(subject.SubjectId, "Midterm"),
                                         Finals = GetGradeComponent(subject.SubjectId, "Finals")
                                     }).ToList();

                SUBJECTGRADEDATAGRIDVIEW.DataSource = studentGrades;

                // Format the grid
                if (SUBJECTGRADEDATAGRIDVIEW.Columns.Count > 0)
                {
                    SUBJECTGRADEDATAGRIDVIEW.Columns["Subject"].Width = 150;
                    SUBJECTGRADEDATAGRIDVIEW.Columns["GradeValue"].HeaderText = "Final Grade";
                    SUBJECTGRADEDATAGRIDVIEW.Columns["GradeValue"].Width = 100;
                    SUBJECTGRADEDATAGRIDVIEW.Columns["Remark"].Width = 100;

                    // Hide Prelim, Midterm, Finals columns from grid (they're for internal use)
                    if (SUBJECTGRADEDATAGRIDVIEW.Columns.Contains("Prelim"))
                        SUBJECTGRADEDATAGRIDVIEW.Columns["Prelim"].Visible = false;
                    if (SUBJECTGRADEDATAGRIDVIEW.Columns.Contains("Midterm"))
                        SUBJECTGRADEDATAGRIDVIEW.Columns["Midterm"].Visible = false;
                    if (SUBJECTGRADEDATAGRIDVIEW.Columns.Contains("Finals"))
                        SUBJECTGRADEDATAGRIDVIEW.Columns["Finals"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading student grades: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadGradesForSubject(Student student, Subject subject)
        {
            try
            {
                // Load saved grades for this specific student and subject
                // Since your schema doesn't directly link grades to students through enrollments,
                // we'll store and retrieve from a cache or a custom grades table

                // For demonstration, we'll check if there's an enrollment for this student and subject
                var enrollment = (from e in context.Enrollments
                                  join s in context.Schedules on e.ScheduleId equals s.ScheduleId
                                  where e.StudentId == student.StudentId && s.SubjectId == subject.SubjectId
                                  select e).FirstOrDefault();

                if (enrollment != null)
                {
                    // Check if there are grades for this subject
                    var grade = context.Grades.FirstOrDefault(g => g.SubjectId == subject.SubjectId);

                    if (grade != null && grade.GradeValue.HasValue)
                    {
                        // In a real scenario, you'd have separate fields for Prelim, Midterm, Finals
                        // Since your schema only has GradeValue, we'll assume it's the final grade
                        // For now, we'll just show that there's an existing grade
                        MessageBox.Show($"Existing grade found for {subject.SubjectName}: {grade.GradeValue.Value:F2} - {grade.Remark}",
                            "Grade Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                // You can extend this by creating a new table for component grades (Prelim, Midterm, Finals)
                // or store them as JSON in a text field
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading subject grades: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal GetGradeComponent(int subjectId, string component)
        {
            // This is a placeholder - you would need to create a separate table
            // to store Prelim, Midterm, and Finals grades separately
            // For now, return 0
            return 0;
        }

        private void SAVEBUTTON_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem == null)
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

                var student = (Student)comboBox1.SelectedItem;
                var subject = (Subject)SUBJECTCOMBOBOX.SelectedItem;

                // Get grade values
                decimal prelim = GetGradeValue(PRELIMBOX.Text);
                decimal midterm = GetGradeValue(MIDTERMBOX.Text);
                decimal finals = GetGradeValue(FINALSBOX.Text);

                // Calculate average
                int gradeCount = 0;
                decimal total = 0;

                if (prelim > 0) { total += prelim; gradeCount++; }
                if (midterm > 0) { total += midterm; gradeCount++; }
                if (finals > 0) { total += finals; gradeCount++; }

                if (gradeCount == 0)
                {
                    MessageBox.Show("Please enter at least one grade.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal average = total / gradeCount;
                string remark = average >= 75 ? "Passed" : "Failed";

                // Check if a grade entry already exists for this subject
                var existingGrade = context.Grades.FirstOrDefault(g => g.SubjectId == subject.SubjectId);

                if (existingGrade != null)
                {
                    // Update existing grade
                    existingGrade.GradeValue = average;
                    existingGrade.Remark = remark;
                    MessageBox.Show($"Grade updated for {subject.SubjectName}!\nAverage: {average:F2}\nRemark: {remark}",
                        "Grade Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Create new grade
                    var newGrade = new Grade
                    {
                        SubjectId = subject.SubjectId,
                        GradeValue = average,
                        Remark = remark
                    };
                    context.Grades.Add(newGrade);
                    MessageBox.Show($"Grade saved for {subject.SubjectName}!\nAverage: {average:F2}\nRemark: {remark}",
                        "Grade Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                context.SaveChanges();

                // Refresh the grade display
                LoadGradeDataGrid();
                if (comboBox1.SelectedItem != null)
                {
                    LoadStudentGrades((Student)comboBox1.SelectedItem);
                }

                // Store grades in cache for this student and subject
                StoreGradeComponents(student.StudentId, subject.SubjectId, prelim, midterm, finals, average, remark);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric grades (0-100).", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving grades: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StoreGradeComponents(int studentId, int subjectId, decimal prelim, decimal midterm, decimal finals, decimal average, string remark)
        {
            // Cache the component grades for display when reselecting
            string cacheKey = $"{studentId}_{subjectId}";
            if (!gradeCache.ContainsKey(studentId))
            {
                gradeCache[studentId] = new Dictionary<string, decimal>();
            }

            gradeCache[studentId][$"{subjectId}_prelim"] = prelim;
            gradeCache[studentId][$"{subjectId}_midterm"] = midterm;
            gradeCache[studentId][$"{subjectId}_finals"] = finals;
            gradeCache[studentId][$"{subjectId}_average"] = average;
        }

        private void LoadGradeComponents(int studentId, int subjectId)
        {
            if (gradeCache.ContainsKey(studentId))
            {
                if (gradeCache[studentId].ContainsKey($"{subjectId}_prelim"))
                {
                    PRELIMBOX.Text = gradeCache[studentId][$"{subjectId}_prelim"].ToString();
                    MIDTERMBOX.Text = gradeCache[studentId][$"{subjectId}_midterm"].ToString();
                    FINALSBOX.Text = gradeCache[studentId][$"{subjectId}_finals"].ToString();
                    return;
                }
            }

            // If not in cache, clear the boxes
            ClearGradeInputs();
        }

        private void ClearGradeInputs()
        {
            PRELIMBOX.Clear();
            MIDTERMBOX.Clear();
            FINALSBOX.Clear();
            PRELIMBOX.BackColor = System.Drawing.Color.White;
            MIDTERMBOX.BackColor = System.Drawing.Color.White;
            FINALSBOX.BackColor = System.Drawing.Color.White;
        }
    }
}