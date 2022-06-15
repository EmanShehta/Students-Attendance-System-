namespace SWProject
{
    partial class register
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
            this.user_name = new System.Windows.Forms.TextBox();
            this.user_passowrd = new System.Windows.Forms.TextBox();
            this.user_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.role = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.register_user = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user_name
            // 
            this.user_name.Location = new System.Drawing.Point(343, 70);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(186, 20);
            this.user_name.TabIndex = 0;
            // 
            // user_passowrd
            // 
            this.user_passowrd.Location = new System.Drawing.Point(343, 168);
            this.user_passowrd.Name = "user_passowrd";
            this.user_passowrd.PasswordChar = '*';
            this.user_passowrd.Size = new System.Drawing.Size(186, 20);
            this.user_passowrd.TabIndex = 1;
            this.user_passowrd.Visible = false;
            // 
            // user_email
            // 
            this.user_email.Location = new System.Drawing.Point(343, 117);
            this.user_email.Name = "user_email";
            this.user_email.Size = new System.Drawing.Size(186, 20);
            this.user_email.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(196, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "UserName :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(196, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(196, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // role
            // 
            this.role.DisplayMember = "test";
            this.role.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.role.FormattingEnabled = true;
            this.role.Items.AddRange(new object[] {
            "0-user",
            "1-admin",
            "2-Instructor",
            "3-Assistant"});
            this.role.Location = new System.Drawing.Point(343, 210);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(181, 21);
            this.role.TabIndex = 6;
            this.role.ValueMember = "est";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(196, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Role :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // register_user
            // 
            this.register_user.BackColor = System.Drawing.Color.White;
            this.register_user.FlatAppearance.BorderSize = 0;
            this.register_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_user.Location = new System.Drawing.Point(449, 269);
            this.register_user.Name = "register_user";
            this.register_user.Size = new System.Drawing.Size(75, 23);
            this.register_user.TabIndex = 8;
            this.register_user.Text = "Register";
            this.register_user.UseVisualStyleBackColor = false;
            this.register_user.Click += new System.EventHandler(this.register_user_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.White;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Location = new System.Drawing.Point(343, 269);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 10;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.register_user);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.role);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.user_email);
            this.Controls.Add(this.user_passowrd);
            this.Controls.Add(this.user_name);
            this.Name = "register";
            this.Text = "register";
            this.Load += new System.EventHandler(this.register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.TextBox user_passowrd;
        private System.Windows.Forms.TextBox user_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox role;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button register_user;
        private System.Windows.Forms.Button back;
    }
}