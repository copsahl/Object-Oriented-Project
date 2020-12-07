using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Object_Oriented_Project
{
    public partial class FormDisplayRecipe : Form
    {
        public Recipe GlobalRecipe;
        public User CurrentUser;
        public FormDisplayRecipe(Recipe SelectedRecipe, User currUser)
        {
            InitializeComponent();
            GlobalRecipe = SelectedRecipe;
            CurrentUser = currUser;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormDisplayRecipe_Load(object sender, EventArgs e)
        {
            RecipeLabel.Text = GlobalRecipe.Name;
            roastDisplay.Text = GlobalRecipe.RoastUsed;
            creamerDisplay.Text = GlobalRecipe.CreamerUsed;

            roastDisplay.Enabled = false;
            creamerDisplay.Enabled = false;

            foreach (string note in GlobalRecipe.RecipeNotes.RecipeNotes)
            {
                noteListBox.Items.Add(note);
            }

        }

        private void idDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void addNoteButton_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Add a new note to your recipe!", "Add Note", "");
            GlobalRecipe.RecipeNotes.RecipeNotes.Add(input);
            noteListBox.Items.Add(input);
            
        }

        private void removeNoteButton_Click(object sender, EventArgs e)
        {
            foreach(string s in noteListBox.SelectedItems.OfType<string>().ToList())
            {
                noteListBox.Items.Remove(s);
            }
        }

        private void deleteRecipeButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogBox = MessageBox.Show("Delete the currently selected recipe?", "Delete Recipe", MessageBoxButtons.YesNo);
            if(dialogBox == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }
    }
}
