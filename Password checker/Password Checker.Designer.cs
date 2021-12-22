namespace Password_checker
{
    partial class password_checker
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
            this.usernamentry_txt = new System.Windows.Forms.TextBox();
            this.title_lbl = new System.Windows.Forms.Label();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.question_lbl = new System.Windows.Forms.Label();
            this.passwordentry_txt = new System.Windows.Forms.TextBox();
            this.password_lbl = new System.Windows.Forms.Label();
            this.username_lbl = new System.Windows.Forms.Label();
            this.passwordstrength_bar = new System.Windows.Forms.ProgressBar();
            this.description_lbl = new System.Windows.Forms.Label();
            this.advice_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernamentry_txt
            // 
            this.usernamentry_txt.Location = new System.Drawing.Point(90, 50);
            this.usernamentry_txt.Margin = new System.Windows.Forms.Padding(4);
            this.usernamentry_txt.Name = "usernamentry_txt";
            this.usernamentry_txt.Size = new System.Drawing.Size(293, 22);
            this.usernamentry_txt.TabIndex = 0;
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.Location = new System.Drawing.Point(1, 2);
            this.title_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(177, 25);
            this.title_lbl.TabIndex = 1;
            this.title_lbl.Text = "Password Checker";
            // 
            // confirm_btn
            // 
            this.confirm_btn.Location = new System.Drawing.Point(165, 106);
            this.confirm_btn.Margin = new System.Windows.Forms.Padding(4);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(100, 28);
            this.confirm_btn.TabIndex = 2;
            this.confirm_btn.Text = "Enter";
            this.confirm_btn.UseVisualStyleBackColor = true;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // question_lbl
            // 
            this.question_lbl.AutoSize = true;
            this.question_lbl.Location = new System.Drawing.Point(51, 27);
            this.question_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.question_lbl.Name = "question_lbl";
            this.question_lbl.Size = new System.Drawing.Size(283, 17);
            this.question_lbl.TabIndex = 3;
            this.question_lbl.Text = "Please enter your username and password.";
            // 
            // passwordentry_txt
            // 
            this.passwordentry_txt.Location = new System.Drawing.Point(90, 76);
            this.passwordentry_txt.Margin = new System.Windows.Forms.Padding(4);
            this.passwordentry_txt.Name = "passwordentry_txt";
            this.passwordentry_txt.Size = new System.Drawing.Size(293, 22);
            this.passwordentry_txt.TabIndex = 4;
            this.passwordentry_txt.UseSystemPasswordChar = true;
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Location = new System.Drawing.Point(9, 79);
            this.password_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(73, 17);
            this.password_lbl.TabIndex = 5;
            this.password_lbl.Text = "Password:";
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Location = new System.Drawing.Point(9, 50);
            this.username_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(77, 17);
            this.username_lbl.TabIndex = 6;
            this.username_lbl.Text = "Username:";
            // 
            // passwordstrength_bar
            // 
            this.passwordstrength_bar.Enabled = false;
            this.passwordstrength_bar.Location = new System.Drawing.Point(12, 143);
            this.passwordstrength_bar.Name = "passwordstrength_bar";
            this.passwordstrength_bar.Size = new System.Drawing.Size(417, 23);
            this.passwordstrength_bar.TabIndex = 7;
            this.passwordstrength_bar.Visible = false;
            // 
            // description_lbl
            // 
            this.description_lbl.AutoSize = true;
            this.description_lbl.Enabled = false;
            this.description_lbl.Location = new System.Drawing.Point(9, 123);
            this.description_lbl.Name = "description_lbl";
            this.description_lbl.Size = new System.Drawing.Size(129, 17);
            this.description_lbl.TabIndex = 8;
            this.description_lbl.Text = "Password strength:";
            this.description_lbl.Visible = false;
            // 
            // advice_lbl
            // 
            this.advice_lbl.AutoSize = true;
            this.advice_lbl.Enabled = false;
            this.advice_lbl.Location = new System.Drawing.Point(9, 169);
            this.advice_lbl.Name = "advice_lbl";
            this.advice_lbl.Size = new System.Drawing.Size(54, 17);
            this.advice_lbl.TabIndex = 9;
            this.advice_lbl.Text = "Advice:";
            this.advice_lbl.Visible = false;
            // 
            // password_checker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 291);
            this.Controls.Add(this.advice_lbl);
            this.Controls.Add(this.description_lbl);
            this.Controls.Add(this.passwordstrength_bar);
            this.Controls.Add(this.username_lbl);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.passwordentry_txt);
            this.Controls.Add(this.question_lbl);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.title_lbl);
            this.Controls.Add(this.usernamentry_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "password_checker";
            this.ShowIcon = false;
            this.Text = "Password Checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernamentry_txt;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Button confirm_btn;
        private System.Windows.Forms.Label question_lbl;
        private System.Windows.Forms.TextBox passwordentry_txt;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.ProgressBar passwordstrength_bar;
        private System.Windows.Forms.Label description_lbl;
        private System.Windows.Forms.Label advice_lbl;
    }
}

