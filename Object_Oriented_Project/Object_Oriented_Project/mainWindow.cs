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
    public partial class mainWindow : Form
    {
        UserRepo MyUserRepo = new UserRepo();
        User CurrentUser = new User();

        public mainWindow()
        {
            InitializeComponent();
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {
            Login LoginForm = new Login(MyUserRepo);
            var result = LoginForm.ShowDialog();
            CurrentUser = LoginForm.currUser;
            if (result != DialogResult.OK)
            {
                this.Close();
            }

            currentUserTextBox.Text = CurrentUser.Name.ToString();

            roastGridDisplay.DataSource = CurrentUser.UserRoasts;
            recipeGridDisplay.DataSource = CurrentUser.UserRecipes;
        }

        private void dataGridDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
