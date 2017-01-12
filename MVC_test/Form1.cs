using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC_test
{
    public partial class Form1 : Form, INewUserView
    {

        ErrorProvider errorProvider;
        public Form1()
        {
            InitializeComponent();

            UserPresenter userPresenter = new UserPresenter();
            userPresenter.AttachView(this);
            errorProvider = new ErrorProvider();
            userPresenter.Init(this);
        }

        public string Email
        {
            get
            {
                return emailTextBox.Text.Trim();
            }

            set
            {
                emailTextBox.Text = value;
            }
        }

        public string Password
        {
            get
            {
                return passwordTextBox.Text.Trim();
            }

            set
            {
                passwordTextBox.Text = value;
            }
        }

        public string Username
        {
            get
            {
                return userNameTextBox.Text.Trim();
            }

            set
            {
                userNameTextBox.Text = value;
            }
        }

        public event NewUserEventHandler CreateNewUser;

        public void UserAlreadyExists()
        {
            MessageBox.Show("User Already Exists!");
        }

        private void OnNewUserCreate()
        {
            if (CreateNewUser != null)
            {
                CreateNewUser(this);
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (IsDataValid())
            {
                OnNewUserCreate();
            }
        }

        private bool IsDataValid()
        {
            bool isValid = true;

            if (String.IsNullOrEmpty(emailTextBox.Text))
            {
                errorProvider.SetError(emailTextBox, "Email should not be empty!");
                isValid = false;
            }
            else
            {
                errorProvider.Clear();
            }
            

            return isValid;
        }

        public void UserSuccess()
        {
            MessageBox.Show("User successfully created");
        }
    }
}
