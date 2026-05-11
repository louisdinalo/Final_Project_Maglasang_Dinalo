using System;
using System.Windows.Forms;

namespace Final_Project_Dinalo_Maglasang
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void enrollStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_Registraion registrationForm = new Student_Registraion();
            registrationForm.ShowDialog();
        }

        private void viewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 studentListForm = new Form1();
            studentListForm.ShowDialog();
        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProffesorForm professorForm = new ProffesorForm();
            professorForm.ShowDialog();
        }

        private void subjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScheduleForms scheduleForm = new ScheduleForms();
            scheduleForm.ShowDialog();
        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScheduleForms scheduleForm = new ScheduleForms();
            scheduleForm.ShowDialog();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Student_Registraion registrationForm = new Student_Registraion();
            registrationForm.ShowDialog();
        }
    }
}