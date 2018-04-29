namespace MyProject
{
    partial class Sign_Up
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
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.title_Sign_up = new System.Windows.Forms.Label();
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_UserName
            // 
            this.txt_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserName.Location = new System.Drawing.Point(293, 127);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(263, 31);
            this.txt_UserName.TabIndex = 0;
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(293, 208);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(263, 31);
            this.txt_Password.TabIndex = 1;
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(293, 285);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(263, 31);
            this.txt_Email.TabIndex = 1;
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.Location = new System.Drawing.Point(109, 127);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(160, 31);
            this.lbl_UserName.TabIndex = 2;
            this.lbl_UserName.Text = "User Name";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(109, 208);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(142, 31);
            this.lbl_Password.TabIndex = 2;
            this.lbl_Password.Text = "Password";
            this.lbl_Password.Click += new System.EventHandler(this.lbl_Password_Click);
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(109, 285);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(86, 31);
            this.lbl_Email.TabIndex = 2;
            this.lbl_Email.Text = "Email";
            this.lbl_Email.Click += new System.EventHandler(this.lbl_Email_Click);
            // 
            // title_Sign_up
            // 
            this.title_Sign_up.AutoSize = true;
            this.title_Sign_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_Sign_up.Location = new System.Drawing.Point(244, 14);
            this.title_Sign_up.Name = "title_Sign_up";
            this.title_Sign_up.Size = new System.Drawing.Size(220, 37);
            this.title_Sign_up.TabIndex = 3;
            this.title_Sign_up.Text = "Sign Up Here";
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SignUp.Location = new System.Drawing.Point(366, 378);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(190, 46);
            this.btn_SignUp.TabIndex = 4;
            this.btn_SignUp.Text = "Sign Up";
            this.btn_SignUp.UseVisualStyleBackColor = true;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // Sign_Up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(727, 447);
            this.Controls.Add(this.btn_SignUp);
            this.Controls.Add(this.title_Sign_up);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_UserName);
            this.Name = "Sign_Up";
            this.Text = "Sign_Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label title_Sign_up;
        private System.Windows.Forms.Button btn_SignUp;
    }
}