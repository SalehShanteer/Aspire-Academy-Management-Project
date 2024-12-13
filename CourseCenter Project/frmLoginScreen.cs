using CourseCenter_Project.Properties;
using CourseCenterBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CourseCenter_Project
{
    public partial class frmLoginScreen : Form
    {

        private clsSavedUser _SavedUser;

        private byte _NumberOfRemainingAttempts = clsSettings.NumberOfRemainingAttempts;

        private short _NumberOfRemainingSeconds = clsSettings.NumberOfRemainingSeconds;
       

        private void _RegisterLoginTime(clsUser User)
        {
            User.LastLogin = DateTime.Now;
            User.Save();
        }

        private void _ShowMainScreen(string Username, string Password)
        {
            //Retrieve user details
            clsUser User = clsUser.Find(Username, Password);

            _RegisterLoginTime(User);

             frmMain frm = new frmMain(User);
            frm.ShowDialog();          
        }

        private void _ManageRemainingAttempts()
        {
            _NumberOfRemainingAttempts--;

            if (_NumberOfRemainingAttempts == 0)
            {
                timerRemaining.Enabled = true;
            }
            else if (_NumberOfRemainingAttempts < clsSettings.NumberOfRemainingAttempts)
            {
                //Show timer label
                lblRemainingAndTimer.Visible = true;

                //Show remaining attempts
                lblRemainingAndTimer.Text = $"Remaining Attempt(s) ({_NumberOfRemainingAttempts})";
            }
        }

        private void _Login()
        {
            string Username = txtUsername.Text;
            string Password = clsUtility.Encrypt(txtPassword.Text);

            if (clsUser.IsExist(Username, Password))
            {
                if (clsUser.IsUserActive(Username))
                {
                    if (ckbRememberMe.Checked)
                    {
                        clsSavedUser.Update(Username, Password);
                    }
                    _ShowMainScreen(Username, Password);
                }
                else
                    MessageBox.Show("User is not active, please contact with admin", "Login failed"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Username or password is incorrect!", "Login failed"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);

                _ManageRemainingAttempts();
            }
        }
        
        private void _FillSavedUsernameAndPassword()
        {
            _SavedUser = clsSavedUser.Find();
            if (_SavedUser != null)
            {
                //Display username and password for saved user
                txtUsername.Text = _SavedUser.Username;
                txtPassword.Text = clsUtility.Decrypt(_SavedUser.Password);
            }
        }

        private void _ResetTimer()
        {
            _NumberOfRemainingAttempts = clsSettings.NumberOfRemainingAttempts;//Reset Number of attempts

            _NumberOfRemainingSeconds = clsSettings.NumberOfRemainingSeconds;//Reset timer

            lblRemainingAndTimer.Visible = false;//Hide timer label

            timerRemaining.Enabled = false;//Diable timer after ther time end
        }

        public frmLoginScreen()
        {
            InitializeComponent();
        }

        private void btnShowHidePassword_Click(object sender, EventArgs e)
        {
            if (btnShowHidePassword.Tag.ToString() == "Show")
            {
                //Hide password
                btnShowHidePassword.Image = Resources.hide;
                btnShowHidePassword.Tag = "Hide";
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                //Show password
                btnShowHidePassword.Image = Resources.show;
                btnShowHidePassword.Tag = "Show";
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void frmLoginScreen_Load(object sender, EventArgs e)
        {
            _FillSavedUsernameAndPassword();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Only you can login if you have remaining attempts
            if (_NumberOfRemainingAttempts > 0)
                _Login();
        }

        private void timerRemaining_Tick(object sender, EventArgs e)
        {
            if (_NumberOfRemainingSeconds > 0)
            {
                _NumberOfRemainingSeconds--;

                string TimeString = clsUtility.TimerString(_NumberOfRemainingSeconds);

                lblRemainingAndTimer.Text = $"You can log in again in {TimeString}";
            }
            else
            {
                _ResetTimer();
            }
        }

       
    }
}
