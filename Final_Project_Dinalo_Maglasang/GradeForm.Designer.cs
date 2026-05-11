namespace Final_Project_Dinalo_Maglasang
{
    partial class GradeForm
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            PRELIMBOX = new TextBox();
            label2 = new Label();
            label3 = new Label();
            MIDTERMBOX = new TextBox();
            label4 = new Label();
            FINALSBOX = new TextBox();
            label5 = new Label();
            SUBJECTCOMBOBOX = new ComboBox();
            SUBJECTGRADEDATAGRIDVIEW = new DataGridView();
            SAVEBUTTON = new Button();
            ((System.ComponentModel.ISupportInitialize)SUBJECTGRADEDATAGRIDVIEW).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 51);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(312, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 1;
            label1.Text = "Student";
            // 
            // PRELIMBOX
            // 
            PRELIMBOX.Location = new Point(12, 140);
            PRELIMBOX.Name = "PRELIMBOX";
            PRELIMBOX.Size = new Size(100, 23);
            PRELIMBOX.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 122);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 3;
            label2.Text = "Prelim";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 122);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 5;
            label3.Text = "Midterm";
            // 
            // MIDTERMBOX
            // 
            MIDTERMBOX.Location = new Point(118, 140);
            MIDTERMBOX.Name = "MIDTERMBOX";
            MIDTERMBOX.Size = new Size(100, 23);
            MIDTERMBOX.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(224, 122);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 7;
            label4.Text = "Finals";
            // 
            // FINALSBOX
            // 
            FINALSBOX.Location = new Point(224, 140);
            FINALSBOX.Name = "FINALSBOX";
            FINALSBOX.Size = new Size(100, 23);
            FINALSBOX.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 76);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 9;
            label5.Text = "Subject";
            // 
            // SUBJECTCOMBOBOX
            // 
            SUBJECTCOMBOBOX.FormattingEnabled = true;
            SUBJECTCOMBOBOX.Location = new Point(12, 94);
            SUBJECTCOMBOBOX.Name = "SUBJECTCOMBOBOX";
            SUBJECTCOMBOBOX.Size = new Size(312, 23);
            SUBJECTCOMBOBOX.TabIndex = 8;
            SUBJECTCOMBOBOX.SelectedIndexChanged += SUBJECTCOMBOBOX_SelectedIndexChanged;
            // 
            // SUBJECTGRADEDATAGRIDVIEW
            // 
            SUBJECTGRADEDATAGRIDVIEW.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SUBJECTGRADEDATAGRIDVIEW.Location = new Point(340, 13);
            SUBJECTGRADEDATAGRIDVIEW.Name = "SUBJECTGRADEDATAGRIDVIEW";
            SUBJECTGRADEDATAGRIDVIEW.Size = new Size(428, 150);
            SUBJECTGRADEDATAGRIDVIEW.TabIndex = 10;
            // 
            // SAVEBUTTON
            // 
            SAVEBUTTON.Location = new Point(12, 174);
            SAVEBUTTON.Name = "SAVEBUTTON";
            SAVEBUTTON.Size = new Size(75, 23);
            SAVEBUTTON.TabIndex = 11;
            SAVEBUTTON.Text = "Save";
            SAVEBUTTON.UseVisualStyleBackColor = true;
            SAVEBUTTON.Click += SAVEBUTTON_Click;
            // 
            // GradeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 209);
            Controls.Add(SAVEBUTTON);
            Controls.Add(SUBJECTGRADEDATAGRIDVIEW);
            Controls.Add(label5);
            Controls.Add(SUBJECTCOMBOBOX);
            Controls.Add(label4);
            Controls.Add(FINALSBOX);
            Controls.Add(label3);
            Controls.Add(MIDTERMBOX);
            Controls.Add(label2);
            Controls.Add(PRELIMBOX);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "GradeForm";
            Text = "GradeForm";
            Load += GradeForm_Load;
            ((System.ComponentModel.ISupportInitialize)SUBJECTGRADEDATAGRIDVIEW).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private TextBox PRELIMBOX;
        private Label label2;
        private Label label3;
        private TextBox MIDTERMBOX;
        private Label label4;
        private TextBox FINALSBOX;
        private Label label5;
        private ComboBox SUBJECTCOMBOBOX;
        private DataGridView SUBJECTGRADEDATAGRIDVIEW;
        private Button SAVEBUTTON;
    }
}