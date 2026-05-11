namespace Final_Project_Dinalo_Maglasang
{
    partial class ProffesorForm
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
            REGISTERBUTTON = new Button();
            label13 = new Label();
            label12 = new Label();
            ADDRESSBOX = new TextBox();
            LASTNAMEBOX = new TextBox();
            EMAILBOX = new TextBox();
            MIDDLEBOX = new TextBox();
            FIRSTNAMEBOX = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // REGISTERBUTTON
            // 
            REGISTERBUTTON.Location = new Point(501, 190);
            REGISTERBUTTON.Name = "REGISTERBUTTON";
            REGISTERBUTTON.Size = new Size(75, 23);
            REGISTERBUTTON.TabIndex = 36;
            REGISTERBUTTON.Text = "Register ";
            REGISTERBUTTON.UseVisualStyleBackColor = true;
            REGISTERBUTTON.Click += REGISTERBUTTON_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(12, 135);
            label13.Name = "label13";
            label13.Size = new Size(51, 15);
            label13.TabIndex = 34;
            label13.Text = "Address";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(199, 132);
            label12.Name = "label12";
            label12.Size = new Size(36, 15);
            label12.TabIndex = 33;
            label12.Text = "Email";
            // 
            // ADDRESSBOX
            // 
            ADDRESSBOX.Location = new Point(12, 153);
            ADDRESSBOX.Name = "ADDRESSBOX";
            ADDRESSBOX.Size = new Size(100, 23);
            ADDRESSBOX.TabIndex = 29;
            // 
            // LASTNAMEBOX
            // 
            LASTNAMEBOX.Location = new Point(438, 67);
            LASTNAMEBOX.Name = "LASTNAMEBOX";
            LASTNAMEBOX.Size = new Size(138, 23);
            LASTNAMEBOX.TabIndex = 27;
            // 
            // EMAILBOX
            // 
            EMAILBOX.Location = new Point(199, 150);
            EMAILBOX.Name = "EMAILBOX";
            EMAILBOX.Size = new Size(100, 23);
            EMAILBOX.TabIndex = 28;
            // 
            // MIDDLEBOX
            // 
            MIDDLEBOX.Location = new Point(199, 67);
            MIDDLEBOX.Name = "MIDDLEBOX";
            MIDDLEBOX.Size = new Size(138, 23);
            MIDDLEBOX.TabIndex = 26;
            // 
            // FIRSTNAMEBOX
            // 
            FIRSTNAMEBOX.Location = new Point(12, 67);
            FIRSTNAMEBOX.Name = "FIRSTNAMEBOX";
            FIRSTNAMEBOX.Size = new Size(138, 23);
            FIRSTNAMEBOX.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(438, 49);
            label10.Name = "label10";
            label10.Size = new Size(65, 15);
            label10.TabIndex = 41;
            label10.Text = "Last Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 49);
            label9.Name = "label9";
            label9.Size = new Size(67, 15);
            label9.TabIndex = 40;
            label9.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(199, 49);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 39;
            label3.Text = "Middle Name ";
            // 
            // ProffesorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 241);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(REGISTERBUTTON);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(ADDRESSBOX);
            Controls.Add(LASTNAMEBOX);
            Controls.Add(EMAILBOX);
            Controls.Add(MIDDLEBOX);
            Controls.Add(FIRSTNAMEBOX);
            Name = "ProffesorForm";
            Text = "ProffesorForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button REGISTERBUTTON;
        private Label label13;
        private Label label12;
        private TextBox ADDRESSBOX;
        private TextBox LASTNAMEBOX;
        private TextBox EMAILBOX;
        private TextBox MIDDLEBOX;
        private TextBox FIRSTNAMEBOX;
        private Label label10;
        private Label label9;
        private Label label3;
    }
}