namespace SWProject
{
    partial class showAttForm
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
            this.Courses_id = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.attendace_day = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.attendanceDate = new System.Windows.Forms.DataGridView();
            this.AttendanceDays = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.AttendanceReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDate)).BeginInit();
            this.SuspendLayout();
            // 
            // Courses_id
            // 
            this.Courses_id.FormattingEnabled = true;
            this.Courses_id.Location = new System.Drawing.Point(373, 33);
            this.Courses_id.Name = "Courses_id";
            this.Courses_id.Size = new System.Drawing.Size(217, 21);
            this.Courses_id.TabIndex = 0;
            this.Courses_id.SelectedIndexChanged += new System.EventHandler(this.Courses_id_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(278, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Course";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // attendace_day
            // a
            this.attendace_day.Enabled = false;
            this.attendace_day.Location = new System.Drawing.Point(373, 83);
            this.attendace_day.Name = "attendace_day";
            this.attendace_day.ReadOnly = true;
            this.attendace_day.Size = new System.Drawing.Size(82, 20);
            this.attendace_day.TabIndex = 2;
            this.attendace_day.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(856, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "show attendence report";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // attendanceDate
            // 
            this.attendanceDate.BackgroundColor = System.Drawing.Color.BlanchedAlmond;
            this.attendanceDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attendanceDate.Location = new System.Drawing.Point(12, 117);
            this.attendanceDate.Name = "attendanceDate";
            this.attendanceDate.Size = new System.Drawing.Size(973, 396);
            this.attendanceDate.TabIndex = 4;
            this.attendanceDate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.attendanceDate_CellContentClick);
            // 
            // AttendanceDays
            // 
            this.AttendanceDays.Location = new System.Drawing.Point(257, 80);
            this.AttendanceDays.Name = "AttendanceDays";
            this.AttendanceDays.Size = new System.Drawing.Size(100, 23);
            this.AttendanceDays.TabIndex = 5;
            this.AttendanceDays.Text = "ايام الحضور";
            this.AttendanceDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.White;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Location = new System.Drawing.Point(0, 0);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(129, 32);
            this.Back.TabIndex = 6;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // AttendanceReport
            // 
            this.AttendanceReport.BackColor = System.Drawing.Color.White;
            this.AttendanceReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AttendanceReport.Location = new System.Drawing.Point(657, 0);
            this.AttendanceReport.Name = "AttendanceReport";
            this.AttendanceReport.Size = new System.Drawing.Size(129, 32);
            this.AttendanceReport.TabIndex = 7;
            this.AttendanceReport.Text = " AttendanceReport";
            this.AttendanceReport.UseVisualStyleBackColor = false;
            this.AttendanceReport.Click += new System.EventHandler(this.AttendanceReport_Click);
            // 
            // showAttForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.AttendanceReport);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.AttendanceDays);
            this.Controls.Add(this.attendanceDate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.attendace_day);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Courses_id);
            this.Name = "showAttForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "showAttForm";
            this.Load += new System.EventHandler(this.showAttForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Courses_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox attendace_day;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView attendanceDate;
        private System.Windows.Forms.Label AttendanceDays;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button AttendanceReport;
    }
}