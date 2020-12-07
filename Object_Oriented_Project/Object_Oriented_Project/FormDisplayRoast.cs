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
    public partial class FormDisplayRoast : Form
    {
        public User CurrentUser;
        public Roast CurrentRoast;
        public FormDisplayRoast(Roast selectedRoast, User currUser)
        {
            InitializeComponent();
            CurrentUser = currUser;
            CurrentRoast = selectedRoast;
        }

        private void FormDisplayRoast_Load(object sender, EventArgs e)
        {
            coolTextBox.Enabled = false;
            beanTextBox.Enabled = false;
            amountTextBox.Enabled = false;
            timeTextBox.Enabled = false;
            countryTextBox.Enabled = false;

            coolTextBox.Text = CurrentRoast.RoastCoolMinutes.ToString();
            beanTextBox.Text = CurrentRoast.Bean;
            amountTextBox.Text = CurrentRoast.RoastAmountCups.ToString();
            timeTextBox.Text = CurrentRoast.RoastTimeMinutes.ToString();
            countryTextBox.Text = CurrentRoast.CountryOfOrigin;

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogBox = MessageBox.Show("Delete the currently selected roast?", "Delete Recipe", MessageBoxButtons.YesNo);
            if (dialogBox == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
