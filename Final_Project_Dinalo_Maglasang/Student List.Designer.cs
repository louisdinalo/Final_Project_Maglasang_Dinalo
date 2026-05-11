namespace Final_Project_Dinalo_Maglasang
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            STUDENTDATAGRIDVIEW = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)STUDENTDATAGRIDVIEW).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(257, 9);
            label1.Name = "label1";
            label1.Size = new Size(196, 45);
            label1.TabIndex = 1;
            label1.Text = "Student List";
            // 
            // STUDENTDATAGRIDVIEW
            // 
            STUDENTDATAGRIDVIEW.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            STUDENTDATAGRIDVIEW.Location = new Point(12, 73);
            STUDENTDATAGRIDVIEW.Name = "STUDENTDATAGRIDVIEW";
            STUDENTDATAGRIDVIEW.Size = new Size(674, 233);
            STUDENTDATAGRIDVIEW.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(708, 385);
            Controls.Add(STUDENTDATAGRIDVIEW);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Student List";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)STUDENTDATAGRIDVIEW).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView STUDENTDATAGRIDVIEW;
    }
}