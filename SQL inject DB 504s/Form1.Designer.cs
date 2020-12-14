namespace SQL_inject_DB_504s
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
            this.loginTB = new System.Windows.Forms.TextBox();
            this.passwdTB = new System.Windows.Forms.TextBox();
            this.authenticationButton = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwdLabel = new System.Windows.Forms.Label();
            this.regButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginTB
            // 
            this.loginTB.Location = new System.Drawing.Point(89, 12);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(257, 20);
            this.loginTB.TabIndex = 0;
            this.loginTB.TextChanged += new System.EventHandler(this.LoginTB);
            // 
            // passwdTB
            // 
            this.passwdTB.Location = new System.Drawing.Point(89, 39);
            this.passwdTB.Name = "passwdTB";
            this.passwdTB.Size = new System.Drawing.Size(257, 20);
            this.passwdTB.TabIndex = 1;
            this.passwdTB.TextChanged += new System.EventHandler(this.PasswdTB);
            // 
            // authenticationButton
            // 
            this.authenticationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authenticationButton.Location = new System.Drawing.Point(13, 67);
            this.authenticationButton.Name = "authenticationButton";
            this.authenticationButton.Size = new System.Drawing.Size(333, 33);
            this.authenticationButton.TabIndex = 2;
            this.authenticationButton.Text = "Authentication W/ Injection";
            this.authenticationButton.UseVisualStyleBackColor = true;
            this.authenticationButton.Click += new System.EventHandler(this.AuthenticationButton_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(10, 13);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(47, 17);
            this.loginLabel.TabIndex = 3;
            this.loginLabel.Text = "Login:";
            // 
            // passwdLabel
            // 
            this.passwdLabel.AutoSize = true;
            this.passwdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwdLabel.Location = new System.Drawing.Point(10, 40);
            this.passwdLabel.Name = "passwdLabel";
            this.passwdLabel.Size = new System.Drawing.Size(73, 17);
            this.passwdLabel.TabIndex = 4;
            this.passwdLabel.Text = "Password:";
            // 
            // regButton
            // 
            this.regButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regButton.Location = new System.Drawing.Point(13, 145);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(333, 33);
            this.regButton.TabIndex = 5;
            this.regButton.Text = "Registration";
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(13, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(333, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Authentication W/O Injection";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 189);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.passwdLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.authenticationButton);
            this.Controls.Add(this.passwdTB);
            this.Controls.Add(this.loginTB);
            this.Name = "Form1";
            this.Text = "Login Form (Жмылев М.А, М4О-504С-16)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.TextBox passwdTB; 
        private System.Windows.Forms.Button authenticationButton;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwdLabel;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.Button button1;
    }
}

