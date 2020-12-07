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
    public partial class FormAddRecipe : Form
    {
        public User CurrentUser;
        public FormAddRecipe(User currUser)
        {
            InitializeComponent();
            CurrentUser = currUser;
        }

        private void FormAddRecipe_Load(object sender, EventArgs e)
        {
            foreach(Roast r in CurrentUser.UserRoasts)
            {
                roastComboBox.Items.Add(r.Bean);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Recipe tmp = new Recipe();
            if(nameTextBox.Text != "" && roastComboBox.Text != "" && creamerDisplay.Text != "")
            {
                tmp.Name = nameTextBox.Text;
                tmp.RoastUsed = roastComboBox.Text;
                tmp.CreamerUsed = creamerDisplay.Text;
                tmp.RecipeNotes = new Note();
                tmp.RecipeNotes.RecipeNotes = new List<string>();

                CurrentUser.UserRecipes.Add(tmp);

                MessageBox.Show("New Recipe Added!", "Alert!");
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
            else
            {
                MessageBox.Show("You must fill out ALL fields to add new roast.", "Alert!");
            }


        }
    }
}
