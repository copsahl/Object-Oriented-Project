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
        RoastInterface MyRoastInterface = new RoastInterface();
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

            foreach(Roast r in CurrentUser.UserRoasts)
            {
                roastListBox.Items.Add(r.Bean);
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

        private void viewRoastButton_Click(object sender, EventArgs e)
        {
            if (roastListBox.Items.Count != 0)
            {
                var RoastName = roastListBox.GetItemText(roastListBox.SelectedItem);
                if (RoastName == null)
                {
                    MessageBox.Show("Failed to get selected roast.", "Alert!");
                }
                else
                {
                    Roast selectedRoast = MyRoastInterface.GetRoastByBean(CurrentUser.UserRoasts, RoastName);
                    if (selectedRoast == null)
                    {
                        MessageBox.Show("Failed to get selected recipe.", "Alert!");
                    }
                    else
                    {
                        FormDisplayRoast displayRoast = new FormDisplayRoast(selectedRoast, CurrentUser);
                        var ans = displayRoast.ShowDialog();
                        if (ans == DialogResult.Yes)
                        {
                            CurrentUser.UserRoasts.Remove(selectedRoast);
                            roastListBox.Items.Remove(RoastName);
                        }

                    }
                }
            }

        }

        private void newRoastButton_Click(object sender, EventArgs e)
        {
            FormAddRoast addRoast = new FormAddRoast(CurrentUser);
            var x = addRoast.ShowDialog();
            if(x == DialogResult.Yes)
            {
                roastListBox.Items.Add(CurrentUser.UserRoasts[CurrentUser.UserRoasts.Count() - 1].Bean);

            }
        }

        private void newRecipeButton_Click(object sender, EventArgs e)
        {
            FormAddRecipe addRecipe = new FormAddRecipe(CurrentUser);
            var x = addRecipe.ShowDialog();
            if(x == DialogResult.Yes)
            {
                recipeListBox.Items.Add(CurrentUser.UserRecipes[CurrentUser.UserRecipes.Count() - 1].Name);
            }
        }
    }
}
