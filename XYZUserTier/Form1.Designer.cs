namespace XYZUserTier
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
            this.lbCourses = new System.Windows.Forms.ListBox();
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStID = new System.Windows.Forms.TextBox();
            this.cbCoursesOffered = new System.Windows.Forms.ComboBox();
            this.btnRegisterStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCourses
            // 
            this.lbCourses.FormattingEnabled = true;
            this.lbCourses.Location = new System.Drawing.Point(12, 12);
            this.lbCourses.Name = "lbCourses";
            this.lbCourses.Size = new System.Drawing.Size(120, 95);
            this.lbCourses.TabIndex = 0;
            this.lbCourses.SelectedIndexChanged += new System.EventHandler(this.lbCourses_SelectedIndexChanged);
            // 
            // dg1
            // 
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.Location = new System.Drawing.Point(175, 12);
            this.dg1.Name = "dg1";
            this.dg1.Size = new System.Drawing.Size(402, 149);
            this.dg1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "St. ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Courses Offered";
            // 
            // txtStID
            // 
            this.txtStID.Location = new System.Drawing.Point(110, 209);
            this.txtStID.Name = "txtStID";
            this.txtStID.Size = new System.Drawing.Size(100, 20);
            this.txtStID.TabIndex = 4;
            // 
            // cbCoursesOffered
            // 
            this.cbCoursesOffered.FormattingEnabled = true;
            this.cbCoursesOffered.Location = new System.Drawing.Point(110, 250);
            this.cbCoursesOffered.Name = "cbCoursesOffered";
            this.cbCoursesOffered.Size = new System.Drawing.Size(121, 21);
            this.cbCoursesOffered.TabIndex = 5;
            // 
            // btnRegisterStudent
            // 
            this.btnRegisterStudent.Location = new System.Drawing.Point(273, 250);
            this.btnRegisterStudent.Name = "btnRegisterStudent";
            this.btnRegisterStudent.Size = new System.Drawing.Size(98, 23);
            this.btnRegisterStudent.TabIndex = 6;
            this.btnRegisterStudent.Text = "Register Student";
            this.btnRegisterStudent.UseVisualStyleBackColor = true;
            this.btnRegisterStudent.Click += new System.EventHandler(this.btnRegisterStudent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 298);
            this.Controls.Add(this.btnRegisterStudent);
            this.Controls.Add(this.cbCoursesOffered);
            this.Controls.Add(this.txtStID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg1);
            this.Controls.Add(this.lbCourses);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbCourses;
        private System.Windows.Forms.DataGridView dg1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStID;
        private System.Windows.Forms.ComboBox cbCoursesOffered;
        private System.Windows.Forms.Button btnRegisterStudent;
    }
}

