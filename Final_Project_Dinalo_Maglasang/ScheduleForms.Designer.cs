namespace Final_Project_Dinalo_Maglasang
{
    partial class ScheduleForms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label9 = new Label();
            label2 = new Label();
            label3 = new Label();
            COURSECOMBOBOX = new ComboBox();
            SEMESTERCOMBOBOX = new ComboBox();
            label4 = new Label();
            PROFFESORCOMBOBOX = new ComboBox();
            SUBJECTNAMEBOX = new TextBox();
            label5 = new Label();
            label6 = new Label();
            SUBJECTCODEBOX = new TextBox();
            DAYOFWEEKCOMBOBOX = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            STARTTIMEBOX = new TextBox();
            ENDTIMEBOX = new TextBox();
            SAVEBUTTON = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(293, 9);
            label1.Name = "label1";
            label1.Size = new Size(163, 45);
            label1.TabIndex = 0;
            label1.Text = "Schedule ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(19, 91);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 30;
            label9.Text = "Course";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 141);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 31;
            label2.Text = "Sementer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(447, 237);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 32;
            // 
            // COURSECOMBOBOX
            // 
            COURSECOMBOBOX.FormattingEnabled = true;
            COURSECOMBOBOX.Items.AddRange(new object[] { "BSIT", "BSME", "TVET" });
            COURSECOMBOBOX.Location = new Point(117, 87);
            COURSECOMBOBOX.Name = "COURSECOMBOBOX";
            COURSECOMBOBOX.Size = new Size(161, 23);
            COURSECOMBOBOX.TabIndex = 33;
            // 
            // SEMESTERCOMBOBOX
            // 
            SEMESTERCOMBOBOX.FormattingEnabled = true;
            SEMESTERCOMBOBOX.Items.AddRange(new object[] { "BSIT", "BSME", "TVET" });
            SEMESTERCOMBOBOX.Location = new Point(117, 137);
            SEMESTERCOMBOBOX.Name = "SEMESTERCOMBOBOX";
            SEMESTERCOMBOBOX.Size = new Size(161, 23);
            SEMESTERCOMBOBOX.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 195);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 35;
            label4.Text = "Proffesor";
            // 
            // PROFFESORCOMBOBOX
            // 
            PROFFESORCOMBOBOX.FormattingEnabled = true;
            PROFFESORCOMBOBOX.Items.AddRange(new object[] { "BSIT", "BSME", "TVET" });
            PROFFESORCOMBOBOX.Location = new Point(117, 191);
            PROFFESORCOMBOBOX.Name = "PROFFESORCOMBOBOX";
            PROFFESORCOMBOBOX.Size = new Size(161, 23);
            PROFFESORCOMBOBOX.TabIndex = 36;
            // 
            // SUBJECTNAMEBOX
            // 
            SUBJECTNAMEBOX.Location = new Point(428, 87);
            SUBJECTNAMEBOX.Name = "SUBJECTNAMEBOX";
            SUBJECTNAMEBOX.Size = new Size(165, 23);
            SUBJECTNAMEBOX.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(337, 90);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 38;
            label5.Text = "Subject Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(337, 136);
            label6.Name = "label6";
            label6.Size = new Size(80, 15);
            label6.TabIndex = 40;
            label6.Text = "Subject Code";
            // 
            // SUBJECTCODEBOX
            // 
            SUBJECTCODEBOX.Location = new Point(428, 133);
            SUBJECTCODEBOX.Name = "SUBJECTCODEBOX";
            SUBJECTCODEBOX.Size = new Size(165, 23);
            SUBJECTCODEBOX.TabIndex = 39;
            // 
            // DAYOFWEEKCOMBOBOX
            // 
            DAYOFWEEKCOMBOBOX.FormattingEnabled = true;
            DAYOFWEEKCOMBOBOX.Items.AddRange(new object[] { "BSIT", "BSME", "TVET" });
            DAYOFWEEKCOMBOBOX.Location = new Point(117, 237);
            DAYOFWEEKCOMBOBOX.Name = "DAYOFWEEKCOMBOBOX";
            DAYOFWEEKCOMBOBOX.Size = new Size(161, 23);
            DAYOFWEEKCOMBOBOX.TabIndex = 42;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(22, 241);
            label7.Name = "label7";
            label7.Size = new Size(79, 15);
            label7.TabIndex = 41;
            label7.Text = "Day of Week";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(26, 287);
            label8.Name = "label8";
            label8.Size = new Size(35, 15);
            label8.TabIndex = 44;
            label8.Text = "Time";
            // 
            // STARTTIMEBOX
            // 
            STARTTIMEBOX.Location = new Point(117, 284);
            STARTTIMEBOX.Name = "STARTTIMEBOX";
            STARTTIMEBOX.PlaceholderText = "Start";
            STARTTIMEBOX.Size = new Size(72, 23);
            STARTTIMEBOX.TabIndex = 43;
            // 
            // ENDTIMEBOX
            // 
            ENDTIMEBOX.Location = new Point(195, 284);
            ENDTIMEBOX.Name = "ENDTIMEBOX";
            ENDTIMEBOX.PlaceholderText = "End";
            ENDTIMEBOX.Size = new Size(83, 23);
            ENDTIMEBOX.TabIndex = 45;
            // 
            // SAVEBUTTON
            // 
            SAVEBUTTON.Location = new Point(518, 287);
            SAVEBUTTON.Name = "SAVEBUTTON";
            SAVEBUTTON.Size = new Size(75, 23);
            SAVEBUTTON.TabIndex = 46;
            SAVEBUTTON.Text = "Save";
            SAVEBUTTON.UseVisualStyleBackColor = true;
            SAVEBUTTON.Click += SAVEBUTTON_Click;
            // 
            // ScheduleForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 337);
            Controls.Add(SAVEBUTTON);
            Controls.Add(ENDTIMEBOX);
            Controls.Add(label8);
            Controls.Add(STARTTIMEBOX);
            Controls.Add(DAYOFWEEKCOMBOBOX);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(SUBJECTCODEBOX);
            Controls.Add(label5);
            Controls.Add(SUBJECTNAMEBOX);
            Controls.Add(PROFFESORCOMBOBOX);
            Controls.Add(label4);
            Controls.Add(SEMESTERCOMBOBOX);
            Controls.Add(COURSECOMBOBOX);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label9);
            Controls.Add(label1);
            Name = "ScheduleForms";
            Text = "Schedule";
            Load += ScheduleForms_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label9;
        private Label label2;
        private Label label3;
        private ComboBox COURSECOMBOBOX;
        private ComboBox SEMESTERCOMBOBOX;
        private Label label4;
        private ComboBox PROFFESORCOMBOBOX;
        private TextBox SUBJECTNAMEBOX;
        private Label label5;
        private Label label6;
        private TextBox SUBJECTCODEBOX;
        private ComboBox DAYOFWEEKCOMBOBOX;
        private Label label7;
        private Label label8;
        private TextBox STARTTIMEBOX;
        private TextBox ENDTIMEBOX;
        private Button SAVEBUTTON;
    }
}