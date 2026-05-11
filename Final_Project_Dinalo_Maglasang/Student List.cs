using System;
using System.Linq;
using System.Windows.Forms;
using Final_Project_Dinalo_Maglasang.Models;

namespace Final_Project_Dinalo_Maglasang
{
    public partial class Form1 : Form
    {
        private DinaloMaglasangStudentsystemContext context;

        public Form1()
        {
            InitializeComponent();
            context = new DinaloMaglasangStudentsystemContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void LoadStudents()
        {
            try
            {
                var students = context.Students
                    .Select(s => new
                    {
                        s.FirstName,
                        s.MiddleName,
                        s.LastName,
                        s.Address,
                        s.Email,
                        Birthdate = s.Birthdate.HasValue ? s.Birthdate.Value.ToString("yyyy-MM-dd") : "",
                        s.Course
                    })
                    .ToList();

                STUDENTDATAGRIDVIEW.DataSource = students;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading students: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}