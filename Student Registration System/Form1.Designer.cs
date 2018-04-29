namespace MyProject
{
    partial class Main_Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_sign_up = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Registration System";
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(192, 116);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(216, 46);
            this.btn_login.TabIndex = 1;
            this.btn_login.Text = "Login Here";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_sign_up
            // 
            this.btn_sign_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sign_up.Location = new System.Drawing.Point(192, 213);
            this.btn_sign_up.Name = "btn_sign_up";
            this.btn_sign_up.Size = new System.Drawing.Size(216, 47);
            this.btn_sign_up.TabIndex = 2;
            this.btn_sign_up.Text = "Sign Up Here";
            this.btn_sign_up.UseVisualStyleBackColor = true;
            this.btn_sign_up.Click += new System.EventHandler(this.btn_sign_up_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(622, 339);
            this.Controls.Add(this.btn_sign_up);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.label1);
            this.Name = "Main_Form";
            this.Text = "Student Registration System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_sign_up;
    }
}

