using BusinessLogic.Concrete;
using BusinessLogic.Interfaces;
using System;
using DTO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyWF
{
    public partial class LoginForm : Form
    {
        protected readonly IAuthManager _authManager;
        protected string _username = null;
        public LoginForm(IAuthManager authManager)
        {
            InitializeComponent();
            _authManager = authManager;
        }

        private void Login()
        {
            if (_authManager.Login(UsernameTextBox.Text, PasswordTextBox.Text))
            {
                _username = UsernameTextBox.Text;
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Username or password is not correct.");
            }
        }
        //public long GetUserID()
        //{
        //    return _authManager.GetUserId(UsernameTextBox.Text);
        //}
        //public int GetUserAccess()
        //{
        //    return _authManager.GetAccessLevel(UsernameTextBox.Text);
        //}

        public UserDTO GetUser()
        {
            return _authManager.GetUserByUsername(_username);
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void UsernameText_Enter(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == "username")
            {
                UsernameTextBox.Text = "";

                UsernameTextBox.ForeColor = Color.Black;
            }
        }

        private void UsernameText_Leave(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == "")
            {
                UsernameTextBox.Text = "username";

                UsernameTextBox.ForeColor = Color.OliveDrab;                
            }
        }

        private void PasswordText_Enter(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "password")
            {
                PasswordTextBox.Text = "";

                PasswordTextBox.ForeColor = Color.Black;
                PasswordTextBox.PasswordChar = '*';
            }
        }

        private void PasswordText_Leave(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "")
            {
                PasswordTextBox.PasswordChar = '\0';
                PasswordTextBox.Text = "password";

                PasswordTextBox.ForeColor = Color.OliveDrab;
            }
        }        
    }
}
