namespace CompanyWF
{
    partial class MainForm
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
            this.label_onpage = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.button_manageOrders = new System.Windows.Forms.Button();
            this.label_Menu = new System.Windows.Forms.Label();
            this.button_logOut = new System.Windows.Forms.Button();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_onpage
            // 
            this.label_onpage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_onpage.AutoSize = true;
            this.label_onpage.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_onpage.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label_onpage.Location = new System.Drawing.Point(324, 80);
            this.label_onpage.Name = "label_onpage";
            this.label_onpage.Size = new System.Drawing.Size(247, 30);
            this.label_onpage.TabIndex = 0;
            this.label_onpage.Text = "Wow, such empty...";
            // 
            // MenuPanel
            // 
            this.MenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MenuPanel.BackColor = System.Drawing.Color.Green;
            this.MenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuPanel.Controls.Add(this.button_manageOrders);
            this.MenuPanel.Controls.Add(this.label_Menu);
            this.MenuPanel.Controls.Add(this.button_logOut);
            this.MenuPanel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuPanel.ForeColor = System.Drawing.Color.Cornsilk;
            this.MenuPanel.Location = new System.Drawing.Point(1, 0);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.MenuPanel.MinimumSize = new System.Drawing.Size(177, 465);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(177, 465);
            this.MenuPanel.TabIndex = 1;
            // 
            // button_manageOrders
            // 
            this.button_manageOrders.BackColor = System.Drawing.Color.ForestGreen;
            this.button_manageOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_manageOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_manageOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_manageOrders.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_manageOrders.Location = new System.Drawing.Point(-1, 61);
            this.button_manageOrders.Name = "button_manageOrders";
            this.button_manageOrders.Size = new System.Drawing.Size(178, 48);
            this.button_manageOrders.TabIndex = 2;
            this.button_manageOrders.Text = "Manage Orders";
            this.button_manageOrders.UseVisualStyleBackColor = false;
            this.button_manageOrders.Click += new System.EventHandler(this.button_ManageOrders_Click);
            // 
            // label_Menu
            // 
            this.label_Menu.BackColor = System.Drawing.Color.DarkGreen;
            this.label_Menu.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Menu.Location = new System.Drawing.Point(0, 0);
            this.label_Menu.Name = "label_Menu";
            this.label_Menu.Size = new System.Drawing.Size(177, 50);
            this.label_Menu.TabIndex = 1;
            this.label_Menu.Text = "Menu";
            this.label_Menu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_logOut
            // 
            this.button_logOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_logOut.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button_logOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_logOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_logOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_logOut.Location = new System.Drawing.Point(-1, 406);
            this.button_logOut.Margin = new System.Windows.Forms.Padding(0);
            this.button_logOut.MaximumSize = new System.Drawing.Size(177, 46);
            this.button_logOut.Name = "button_logOut";
            this.button_logOut.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.button_logOut.Size = new System.Drawing.Size(177, 46);
            this.button_logOut.TabIndex = 0;
            this.button_logOut.Text = "Log out";
            this.button_logOut.UseVisualStyleBackColor = false;
            this.button_logOut.Click += new System.EventHandler(this.botton_logOut_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(750, 465);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.label_onpage);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MinimumSize = new System.Drawing.Size(768, 512);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_onpage;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Label label_Menu;
        private System.Windows.Forms.Button button_logOut;
        private System.Windows.Forms.Button button_manageOrders;
    }
}