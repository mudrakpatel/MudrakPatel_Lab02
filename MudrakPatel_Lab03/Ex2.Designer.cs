namespace MudrakPatel_Lab03
{
    partial class Ex2
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
            this.userControl1 = new MudrakPatel_Lab03.UserControlEx2();
            this.loginButton = new System.Windows.Forms.Button();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userNameDisplayLabel = new System.Windows.Forms.Label();
            this.passwordDisplayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userControl1
            // 
            this.userControl1.Location = new System.Drawing.Point(13, 13);
            this.userControl1.Name = "userControl1";
            this.userControl1.Size = new System.Drawing.Size(302, 93);
            this.userControl1.TabIndex = 0;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(116, 112);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(25, 147);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(61, 13);
            this.userNameLabel.TabIndex = 2;
            this.userNameLabel.Text = "Username: ";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(28, 201);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(59, 13);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password: ";
            // 
            // userNameDisplayLabel
            // 
            this.userNameDisplayLabel.AutoSize = true;
            this.userNameDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.userNameDisplayLabel.Location = new System.Drawing.Point(93, 147);
            this.userNameDisplayLabel.Name = "userNameDisplayLabel";
            this.userNameDisplayLabel.Size = new System.Drawing.Size(0, 25);
            this.userNameDisplayLabel.TabIndex = 4;
            // 
            // passwordDisplayLabel
            // 
            this.passwordDisplayLabel.AutoSize = true;
            this.passwordDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.passwordDisplayLabel.Location = new System.Drawing.Point(98, 201);
            this.passwordDisplayLabel.Name = "passwordDisplayLabel";
            this.passwordDisplayLabel.Size = new System.Drawing.Size(0, 25);
            this.passwordDisplayLabel.TabIndex = 5;
            // 
            // Ex2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 266);
            this.Controls.Add(this.passwordDisplayLabel);
            this.Controls.Add(this.userNameDisplayLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.userControl1);
            this.Name = "Ex2";
            this.Text = "Testing user control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControlEx2 userControl1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label userNameDisplayLabel;
        private System.Windows.Forms.Label passwordDisplayLabel;
    }
}

