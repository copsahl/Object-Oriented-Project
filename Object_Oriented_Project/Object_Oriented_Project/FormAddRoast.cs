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
    public partial class FormAddRoast : Form
    {
        User CurrentUser;
        public FormAddRoast(User currUser)
        {
            InitializeComponent();
            CurrentUser = currUser;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(beanTextBox.Text != "" && countryTextBox.Text != "" && coolTextBox.Text != "" && timeTextBox.Text != "" && amountTextBox.Text != "")
            {
                Roast tmp = new Roast();
                tmp.Bean = beanTextBox.Text;
                tmp.CountryOfOrigin = countryTextBox.Text;
                tmp.RoastCoolMinutes = Int32.Parse(coolTextBox.Text);
                tmp.RoastTimeMinutes = Int32.Parse(timeTextBox.Text);
                tmp.RoastAmountCups = Int32.Parse(amountTextBox.Text);

                CurrentUser.UserRoasts.Add(tmp);

                MessageBox.Show("New Roast Added!", "Alert!");
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
