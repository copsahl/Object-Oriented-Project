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
        RecipeInterface MyRecipeInterface = new RecipeInterface();
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

            foreach(Recipe r in CurrentUser.UserRecipes)
            {
                recipeListBox.Items.Add(r.Name);
            }

        }

        private void dataGridDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewRecipeButton_Click(object sender, EventArgs e)
        {
            if(recipeListBox.Items.Count != 0)
            {
                var RecipeName = recipeListBox.GetItemText(recipeListBox.SelectedItem);
                if(RecipeName == null)
                {
                    MessageBox.Show("Failed to get selected recipe.", "Alert!");
                }
                else
                {
                    Recipe selectedRecipe = MyRecipeInterface.GetRecipeByname(CurrentUser.UserRecipes, RecipeName);
                    if(selectedRecipe == null)
                    {
                        MessageBox.Show("Failed to get selected recipe.", "Alert!");
                    }
                    else
                    {
                        FormDisplayRecipe displayRecipe = new FormDisplayRecipe(selectedRecipe, CurrentUser);
                        var ans = displayRecipe.ShowDialog();
                        if(ans == DialogResult.Yes)
                        {
                            CurrentUser.UserRecipes.Remove(selectedRecipe);
                            recipeListBox.Items.Remove(RecipeName);
                        }
                        
                    }
                }
            }
           
        }
    }
}
