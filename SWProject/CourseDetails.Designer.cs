namespace SWProject
{
    partial class CourseDetails
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
            this.cmb_courses = new System.Windows.Forms.ComboBox();
            this.lbl_course = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.student_count = new System.Windows.Forms.TextBox();
            this.Report = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_courses
            // 
            this.cmb_courses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_courses.FormattingEnabled = true;
            this.cmb_courses.Location = new System.Drawing.Point(322, 24);
            this.cmb_courses.Name = "cmb_courses";
            this.cmb_courses.Size = new System.Drawing.Size(196, 21);
            this.cmb_courses.TabIndex = 0;
            this.cmb_courses.SelectedIndexChanged += new System.EventHandler(this.cmb_courses_SelectedIndexChanged);
            // 
            // lbl_course
            // 
            this.lbl_course.Location = new System.Drawing.Point(198, 23);
            this.lbl_course.Name = "lbl_course";
            this.lbl_course.Size = new System.Drawing.Size(118, 21);
            this.lbl_course.TabIndex = 1;
            this.lbl_course.Text = "Courses : ";
            this.lbl_course.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.BlanchedAlmond;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(796, 358);
            this.dataGridView1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(-1, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Students :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // student_count
            // 
            this.student_count.Enabled = false;
            this.student_count.Location = new System.Drawing.Point(90, 59);
            this.student_count.Name = "student_count";
            this.student_count.Size = new System.Drawing.Size(100, 20);
            this.student_count.TabIndex = 5;
            this.student_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Report
            // 
            this.Report.BackColor = System.Drawing.Color.White;
            this.Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Report.Location = new System.Drawing.Point(676, 1);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(122, 23);
            this.Report.TabIndex = 6;
            this.Report.Text = "Report";
            this.Report.UseVisualStyleBackColor = false;
            this.Report.Click += new System.EventHandler(this.Report_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(676, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.White;
            this.back.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Location = new System.Drawing.Point(2, 1);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(115, 23);
            this.back.TabIndex = 8;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // CourseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.student_count);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_course);
            this.Controls.Add(this.cmb_courses);
            this.Name = "CourseDetails";
            this.Text = "CourseDetails";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CourseDetails_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CourseDetails_FormClosed);
            this.Load += new System.EventHandler(this.CourseDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_courses;
        private System.Windows.Forms.Label lbl_course;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox student_count;
        private System.Windows.Forms.Button Report;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button back;
    }
}