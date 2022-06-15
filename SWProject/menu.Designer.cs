namespace SWProject
{
    partial class menu
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.MenuTag = new System.Windows.Forms.ToolStripMenuItem();
            this.take_attadnace = new System.Windows.Forms.ToolStripMenuItem();
            this.make_complaint = new System.Windows.Forms.ToolStripMenuItem();
            this.Attendance_details = new System.Windows.Forms.ToolStripMenuItem();
            this.register_user = new System.Windows.Forms.ToolStripMenuItem();
            this.CourseDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.assignCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.Back = new System.Windows.Forms.Button();
            this.registerCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuTag});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(784, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // MenuTag
            // 
            this.MenuTag.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MenuTag.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.take_attadnace,
            this.make_complaint,
            this.Attendance_details,
            this.register_user,
            this.CourseDetails,
            this.assignCourse,
            this.registerCourse});
            this.MenuTag.ForeColor = System.Drawing.Color.Black;
            this.MenuTag.Margin = new System.Windows.Forms.Padding(0, 0, 350, 0);
            this.MenuTag.Name = "MenuTag";
            this.MenuTag.Size = new System.Drawing.Size(50, 20);
            this.MenuTag.Text = "Menu";
            this.MenuTag.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // take_attadnace
            // 
            this.take_attadnace.Name = "take_attadnace";
            this.take_attadnace.Size = new System.Drawing.Size(180, 22);
            this.take_attadnace.Text = "Take Attendance";
            this.take_attadnace.Click += new System.EventHandler(this.take_attadnace_Click);
            // 
            // make_complaint
            // 
            this.make_complaint.Name = "make_complaint";
            this.make_complaint.Size = new System.Drawing.Size(180, 22);
            this.make_complaint.Text = "Make Complaint";
            this.make_complaint.Click += new System.EventHandler(this.make_complaint_Click);
            // 
            // Attendance_details
            // 
            this.Attendance_details.Name = "Attendance_details";
            this.Attendance_details.Size = new System.Drawing.Size(180, 22);
            this.Attendance_details.Text = "Attendance Details";
            this.Attendance_details.Click += new System.EventHandler(this.Attendance_details_Click);
            // 
            // register_user
            // 
            this.register_user.Name = "register_user";
            this.register_user.Size = new System.Drawing.Size(180, 22);
            this.register_user.Text = "RegisterNewuser";
            this.register_user.Click += new System.EventHandler(this.register_user_Click);
            // 
            // CourseDetails
            // 
            this.CourseDetails.Name = "CourseDetails";
            this.CourseDetails.Size = new System.Drawing.Size(180, 22);
            this.CourseDetails.Text = "CourseDetails";
            this.CourseDetails.Click += new System.EventHandler(this.CourseDetails_Click);
            // 
            // assignCourse
            // 
            this.assignCourse.Name = "assignCourse";
            this.assignCourse.Size = new System.Drawing.Size(180, 22);
            this.assignCourse.Text = "AssignCourse";
            this.assignCourse.Click += new System.EventHandler(this.assignCourseToolStripMenuItem_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.White;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Location = new System.Drawing.Point(0, 0);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(114, 24);
            this.Back.TabIndex = 5;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // registerCourse
            // 
            this.registerCourse.Name = "registerCourse";
            this.registerCourse.Size = new System.Drawing.Size(180, 22);
            this.registerCourse.Text = "RegisterCourse";
            this.registerCourse.Click += new System.EventHandler(this.registerCourse_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.menuStrip2);
            this.Name = "menu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menu";
            this.Load += new System.EventHandler(this.menu_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem MenuTag;
        private System.Windows.Forms.ToolStripMenuItem take_attadnace;
        private System.Windows.Forms.ToolStripMenuItem make_complaint;
        private System.Windows.Forms.ToolStripMenuItem Attendance_details;
        private System.Windows.Forms.ToolStripMenuItem register_user;
        private System.Windows.Forms.ToolStripMenuItem CourseDetails;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.ToolStripMenuItem assignCourse;
        private System.Windows.Forms.ToolStripMenuItem registerCourse;
    }
}