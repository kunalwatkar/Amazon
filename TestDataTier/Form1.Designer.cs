namespace TestDataTier
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
            this.btnGetCourseEnrollment = new System.Windows.Forms.Button();
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.btnIsThereRoom = new System.Windows.Forms.Button();
            this.btnTestDataTierGetCoursesOffered = new System.Windows.Forms.Button();
            this.lstCourses = new System.Windows.Forms.ListBox();
            this.btnDoesStudentExist = new System.Windows.Forms.Button();
            this.btnHasPrerequisitesTaken = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetCourseEnrollment
            // 
            this.btnGetCourseEnrollment.Location = new System.Drawing.Point(12, 12);
            this.btnGetCourseEnrollment.Name = "btnGetCourseEnrollment";
            this.btnGetCourseEnrollment.Size = new System.Drawing.Size(89, 43);
            this.btnGetCourseEnrollment.TabIndex = 0;
            this.btnGetCourseEnrollment.Text = "Get Course Enrollment";
            this.btnGetCourseEnrollment.UseVisualStyleBackColor = true;
            this.btnGetCourseEnrollment.Click += new System.EventHandler(this.btnGetCourseEnrollment_Click);
            // 
            // dg1
            // 
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.Location = new System.Drawing.Point(12, 71);
            this.dg1.Name = "dg1";
            this.dg1.Size = new System.Drawing.Size(398, 159);
            this.dg1.TabIndex = 1;
            // 
            // btnIsThereRoom
            // 
            this.btnIsThereRoom.Location = new System.Drawing.Point(438, 12);
            this.btnIsThereRoom.Name = "btnIsThereRoom";
            this.btnIsThereRoom.Size = new System.Drawing.Size(90, 32);
            this.btnIsThereRoom.TabIndex = 2;
            this.btnIsThereRoom.Text = "Is There Room";
            this.btnIsThereRoom.UseVisualStyleBackColor = true;
            this.btnIsThereRoom.Click += new System.EventHandler(this.btnIsThereRoom_Click);
            // 
            // btnTestDataTierGetCoursesOffered
            // 
            this.btnTestDataTierGetCoursesOffered.Location = new System.Drawing.Point(438, 59);
            this.btnTestDataTierGetCoursesOffered.Name = "btnTestDataTierGetCoursesOffered";
            this.btnTestDataTierGetCoursesOffered.Size = new System.Drawing.Size(90, 41);
            this.btnTestDataTierGetCoursesOffered.TabIndex = 3;
            this.btnTestDataTierGetCoursesOffered.Text = "Test Data Tier Get Courses Offered";
            this.btnTestDataTierGetCoursesOffered.UseVisualStyleBackColor = true;
            this.btnTestDataTierGetCoursesOffered.Click += new System.EventHandler(this.btnTestDataTierGetCoursesOffered_Click);
            // 
            // lstCourses
            // 
            this.lstCourses.FormattingEnabled = true;
            this.lstCourses.Location = new System.Drawing.Point(438, 115);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.Size = new System.Drawing.Size(120, 95);
            this.lstCourses.TabIndex = 4;
            // 
            // btnDoesStudentExist
            // 
            this.btnDoesStudentExist.Location = new System.Drawing.Point(12, 258);
            this.btnDoesStudentExist.Name = "btnDoesStudentExist";
            this.btnDoesStudentExist.Size = new System.Drawing.Size(111, 23);
            this.btnDoesStudentExist.TabIndex = 5;
            this.btnDoesStudentExist.Text = "Does Student Exist";
            this.btnDoesStudentExist.UseVisualStyleBackColor = true;
            this.btnDoesStudentExist.Click += new System.EventHandler(this.btnDoesStudentExist_Click);
            // 
            // btnHasPrerequisitesTaken
            // 
            this.btnHasPrerequisitesTaken.Location = new System.Drawing.Point(242, 258);
            this.btnHasPrerequisitesTaken.Name = "btnHasPrerequisitesTaken";
            this.btnHasPrerequisitesTaken.Size = new System.Drawing.Size(138, 23);
            this.btnHasPrerequisitesTaken.TabIndex = 6;
            this.btnHasPrerequisitesTaken.Text = "Has Prerequisites Taken";
            this.btnHasPrerequisitesTaken.UseVisualStyleBackColor = true;
            this.btnHasPrerequisitesTaken.Click += new System.EventHandler(this.btnHasPrerequisitesTaken_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 314);
            this.Controls.Add(this.btnHasPrerequisitesTaken);
            this.Controls.Add(this.btnDoesStudentExist);
            this.Controls.Add(this.lstCourses);
            this.Controls.Add(this.btnTestDataTierGetCoursesOffered);
            this.Controls.Add(this.btnIsThereRoom);
            this.Controls.Add(this.dg1);
            this.Controls.Add(this.btnGetCourseEnrollment);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetCourseEnrollment;
        private System.Windows.Forms.DataGridView dg1;
        private System.Windows.Forms.Button btnIsThereRoom;
        private System.Windows.Forms.Button btnTestDataTierGetCoursesOffered;
        private System.Windows.Forms.ListBox lstCourses;
        private System.Windows.Forms.Button btnDoesStudentExist;
        private System.Windows.Forms.Button btnHasPrerequisitesTaken;
    }
}

