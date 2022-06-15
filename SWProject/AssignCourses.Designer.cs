namespace SWProject
{
    partial class AssignCourses
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
            this.cmb_assistant = new System.Windows.Forms.ComboBox();
            this.cmb_user = new System.Windows.Forms.ComboBox();
            this.cmb_professor = new System.Windows.Forms.ComboBox();
            this.User = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Course = new System.Windows.Forms.Label();
            this.cmb_course = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.RegisterCourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_assistant
            // 
            this.cmb_assistant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_assistant.FormattingEnabled = true;
            this.cmb_assistant.Location = new System.Drawing.Point(337, 196);
            this.cmb_assistant.Name = "cmb_assistant";
            this.cmb_assistant.Size = new System.Drawing.Size(153, 21);
            this.cmb_assistant.TabIndex = 0;
            // 
            // cmb_user
            // 
            this.cmb_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_user.FormattingEnabled = true;
            this.cmb_user.Location = new System.Drawing.Point(337, 148);
            this.cmb_user.Name = "cmb_user";
            this.cmb_user.Size = new System.Drawing.Size(153, 21);
            this.cmb_user.TabIndex = 1;
            // 
            // cmb_professor
            // 
            this.cmb_professor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_professor.FormattingEnabled = true;
            this.cmb_professor.Location = new System.Drawing.Point(337, 253);
            this.cmb_professor.Name = "cmb_professor";
            this.cmb_professor.Size = new System.Drawing.Size(153, 21);
            this.cmb_professor.TabIndex = 3;
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(156, 148);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(100, 23);
            this.User.TabIndex = 5;
            this.User.Text = "User";
            this.User.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(156, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Assistant";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(156, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Professor";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Course
            // 
            this.Course.Location = new System.Drawing.Point(156, 103);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(100, 23);
            this.Course.TabIndex = 11;
            this.Course.Text = "Course";
            this.Course.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_course
            // 
            this.cmb_course.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_course.FormattingEnabled = true;
            this.cmb_course.Location = new System.Drawing.Point(337, 105);
            this.cmb_course.Name = "cmb_course";
            this.cmb_course.Size = new System.Drawing.Size(153, 21);
            this.cmb_course.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(479, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(221, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RegisterCourse
            // 
            this.RegisterCourse.BackColor = System.Drawing.Color.White;
            this.RegisterCourse.FlatAppearance.BorderSize = 0;
            this.RegisterCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterCourse.Location = new System.Drawing.Point(351, 312);
            this.RegisterCourse.Name = "RegisterCourse";
            this.RegisterCourse.Size = new System.Drawing.Size(87, 23);
            this.RegisterCourse.TabIndex = 15;
            this.RegisterCourse.Text = "RegisterCourse";
            this.RegisterCourse.UseVisualStyleBackColor = false;
            this.RegisterCourse.Click += new System.EventHandler(this.RegisterCourse_Click);
            // 
            // AssignCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.RegisterCourse);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_course);
            this.Controls.Add(this.Course);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.User);
            this.Controls.Add(this.cmb_professor);
            this.Controls.Add(this.cmb_user);
            this.Controls.Add(this.cmb_assistant);
            this.Name = "AssignCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AssignCourses";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AssignCourses_FormClosed);
            this.Load += new System.EventHandler(this.AssignCourses_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_assistant;
        private System.Windows.Forms.ComboBox cmb_user;
        private System.Windows.Forms.ComboBox cmb_professor;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Course;
        private System.Windows.Forms.ComboBox cmb_course;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button RegisterCourse;
    }
}