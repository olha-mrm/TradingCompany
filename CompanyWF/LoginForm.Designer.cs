namespace CompanyWF
{
    partial class LoginForm
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
            this.LogInLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LogInLabel
            // 
            this.LogInLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogInLabel.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.LogInLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogInLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogInLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.LogInLabel.Location = new System.Drawing.Point(0, 36);
            this.LogInLabel.Margin = new System.Windows.Forms.Padding(0);
            this.LogInLabel.Name = "LogInLabel";
            this.LogInLabel.Size = new System.Drawing.Size(417, 74);
            this.LogInLabel.TabIndex = 0;
            this.LogInLabel.Text = "ACCOUNT LOGIN";
            this.LogInLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.button1.Location = new System.Drawing.Point(85, 284);
            this.button1.MinimumSize = new System.Drawing.Size(80, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "Log in";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsernameTextBox.ForeColor = System.Drawing.Color.OliveDrab;
            this.UsernameTextBox.Location = new System.Drawing.Point(85, 160);
            this.UsernameTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.UsernameTextBox.MinimumSize = new System.Drawing.Size(80, 4);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(248, 32);
            this.UsernameTextBox.TabIndex = 2;
            this.UsernameTextBox.Text = "username";
            this.UsernameTextBox.Enter += new System.EventHandler(this.UsernameText_Enter);
            this.UsernameTextBox.Leave += new System.EventHandler(this.UsernameText_Leave);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTextBox.ForeColor = System.Drawing.Color.OliveDrab;
            this.PasswordTextBox.Location = new System.Drawing.Point(85, 212);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.PasswordTextBox.MinimumSize = new System.Drawing.Size(80, 4);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(248, 32);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.Text = "password";
            this.PasswordTextBox.WordWrap = false;
            this.PasswordTextBox.Enter += new System.EventHandler(this.PasswordText_Enter);
            this.PasswordTextBox.Leave += new System.EventHandler(this.PasswordText_Leave);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(417, 465);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LogInLabel);
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(365, 475);
            this.Name = "LoginForm";
            this.Text = "Log in page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LogInLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PasswordTextBox;
        internal System.Windows.Forms.TextBox UsernameTextBox;
    }
}

