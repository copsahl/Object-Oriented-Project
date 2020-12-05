using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Object_Oriented_Project
{
    public partial class Login : Form
    {
        public UserRepo MyUserRepo;
        public User currUser;
        public Login(UserRepo r)
        {
            InitializeComponent();
            MyUserRepo = r;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (MyUserRepo.Login(usernameInput.Text, passwordInput.Text))
            {
                this.DialogResult = DialogResult.OK;
                currUser = MyUserRepo.GetUserByName(MyUserRepo.GetAll(), usernameInput.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password.", "Alert!");
            }
        }
    }
}
