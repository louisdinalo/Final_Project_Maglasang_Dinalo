namespace Final_Project_Dinalo_Maglasang
{
    partial class HomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            studentToolStripMenuItem = new ToolStripMenuItem();
            enrollStudentToolStripMenuItem = new ToolStripMenuItem();
            gradeStudentToolStripMenuItem = new ToolStripMenuItem();
            viewStudentToolStripMenuItem = new ToolStripMenuItem();
            professorToolStripMenuItem = new ToolStripMenuItem();
            subjectToolStripMenuItem = new ToolStripMenuItem();
            scheduleToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.Location = new Point(534, 338);
            button1.Name = "button1";
            button1.Size = new Size(93, 42);
            button1.TabIndex = 0;
            button1.Text = "Register Now";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(232, 108);
            label1.Name = "label1";
            label1.Size = new Size(244, 39);
            label1.TabIndex = 1;
            label1.Text = "Enroll Today. ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(232, 146);
            label2.Name = "label2";
            label2.Size = new Size(394, 39);
            label2.TabIndex = 2;
            label2.Text = "Shape Your Tomorrow.";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(580, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 84);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { studentToolStripMenuItem, professorToolStripMenuItem, subjectToolStripMenuItem, scheduleToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(673, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { enrollStudentToolStripMenuItem, gradeStudentToolStripMenuItem, viewStudentToolStripMenuItem });
            studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            studentToolStripMenuItem.Size = new Size(60, 20);
            studentToolStripMenuItem.Text = "Student";
            studentToolStripMenuItem.Click += studentToolStripMenuItem_Click;
            // 
            // enrollStudentToolStripMenuItem
            // 
            enrollStudentToolStripMenuItem.Name = "enrollStudentToolStripMenuItem";
            enrollStudentToolStripMenuItem.Size = new Size(149, 22);
            enrollStudentToolStripMenuItem.Text = "Enroll Student";
            enrollStudentToolStripMenuItem.Click += enrollStudentToolStripMenuItem_Click;
            // 
            // gradeStudentToolStripMenuItem
            // 
            gradeStudentToolStripMenuItem.Name = "gradeStudentToolStripMenuItem";
            gradeStudentToolStripMenuItem.Size = new Size(149, 22);
            gradeStudentToolStripMenuItem.Text = "Grade Student";
            // 
            // viewStudentToolStripMenuItem
            // 
            viewStudentToolStripMenuItem.Name = "viewStudentToolStripMenuItem";
            viewStudentToolStripMenuItem.Size = new Size(149, 22);
            viewStudentToolStripMenuItem.Text = "View Student";
            viewStudentToolStripMenuItem.Click += viewStudentToolStripMenuItem_Click;
            // 
            // professorToolStripMenuItem
            // 
            professorToolStripMenuItem.Name = "professorToolStripMenuItem";
            professorToolStripMenuItem.Size = new Size(68, 20);
            professorToolStripMenuItem.Text = "Professor";
            professorToolStripMenuItem.Click += professorToolStripMenuItem_Click;
            // 
            // subjectToolStripMenuItem
            // 
            subjectToolStripMenuItem.Name = "subjectToolStripMenuItem";
            subjectToolStripMenuItem.Size = new Size(58, 20);
            subjectToolStripMenuItem.Text = "Subject";
            subjectToolStripMenuItem.Click += subjectToolStripMenuItem_Click;
            // 
            // scheduleToolStripMenuItem
            // 
            scheduleToolStripMenuItem.Name = "scheduleToolStripMenuItem";
            scheduleToolStripMenuItem.Size = new Size(67, 20);
            scheduleToolStripMenuItem.Text = "Schedule";
            scheduleToolStripMenuItem.Click += scheduleToolStripMenuItem_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(673, 403);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "HomePage";
            Text = "HomePage";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem enrollStudentToolStripMenuItem;
        private ToolStripMenuItem gradeStudentToolStripMenuItem;
        private ToolStripMenuItem viewStudentToolStripMenuItem;
        private ToolStripMenuItem professorToolStripMenuItem;
        private ToolStripMenuItem subjectToolStripMenuItem;
        private ToolStripMenuItem scheduleToolStripMenuItem;
    }
}
