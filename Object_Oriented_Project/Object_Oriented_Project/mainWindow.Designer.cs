namespace Object_Oriented_Project
{
    partial class mainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.newRecipeButton = new System.Windows.Forms.Button();
            this.currentUserLabel = new System.Windows.Forms.Label();
            this.currentUserTextBox = new System.Windows.Forms.TextBox();
            this.newRoastButton = new System.Windows.Forms.Button();
            this.viewRecipeButton = new System.Windows.Forms.Button();
            this.viewRoastButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.recipeListBox = new System.Windows.Forms.ListBox();
            this.roastListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // newRecipeButton
            // 
            this.newRecipeButton.Location = new System.Drawing.Point(12, 357);
            this.newRecipeButton.Name = "newRecipeButton";
            this.newRecipeButton.Size = new System.Drawing.Size(108, 46);
            this.newRecipeButton.TabIndex = 0;
            this.newRecipeButton.Text = "New Recipe";
            this.newRecipeButton.UseVisualStyleBackColor = true;
            this.newRecipeButton.Click += new System.EventHandler(this.newRecipeButton_Click);
            // 
            // currentUserLabel
            // 
            this.currentUserLabel.AutoSize = true;
            this.currentUserLabel.Location = new System.Drawing.Point(21, 9);
            this.currentUserLabel.Name = "currentUserLabel";
            this.currentUserLabel.Size = new System.Drawing.Size(97, 17);
            this.currentUserLabel.TabIndex = 4;
            this.currentUserLabel.Text = "Current User: ";
            // 
            // currentUserTextBox
            // 
            this.currentUserTextBox.Location = new System.Drawing.Point(124, 6);
            this.currentUserTextBox.Name = "currentUserTextBox";
            this.currentUserTextBox.Size = new System.Drawing.Size(155, 22);
            this.currentUserTextBox.TabIndex = 5;
            // 
            // newRoastButton
            // 
            this.newRoastButton.Location = new System.Drawing.Point(429, 357);
            this.newRoastButton.Name = "newRoastButton";
            this.newRoastButton.Size = new System.Drawing.Size(108, 46);
            this.newRoastButton.TabIndex = 6;
            this.newRoastButton.Text = "New Roast";
            this.newRoastButton.UseVisualStyleBackColor = true;
            this.newRoastButton.Click += new System.EventHandler(this.newRoastButton_Click);
            // 
            // viewRecipeButton
            // 
            this.viewRecipeButton.Location = new System.Drawing.Point(227, 357);
            this.viewRecipeButton.Name = "viewRecipeButton";
            this.viewRecipeButton.Size = new System.Drawing.Size(108, 46);
            this.viewRecipeButton.TabIndex = 8;
            this.viewRecipeButton.Text = "View Recipe";
            this.viewRecipeButton.UseVisualStyleBackColor = true;
            this.viewRecipeButton.Click += new System.EventHandler(this.viewRecipeButton_Click);
            // 
            // viewRoastButton
            // 
            this.viewRoastButton.Location = new System.Drawing.Point(644, 357);
            this.viewRoastButton.Name = "viewRoastButton";
            this.viewRoastButton.Size = new System.Drawing.Size(108, 46);
            this.viewRoastButton.TabIndex = 9;
            this.viewRoastButton.Text = "View Roast";
            this.viewRoastButton.UseVisualStyleBackColor = true;
            this.viewRoastButton.Click += new System.EventHandler(this.viewRoastButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Recipe(s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Roast(s)";
            // 
            // recipeListBox
            // 
            this.recipeListBox.FormattingEnabled = true;
            this.recipeListBox.ItemHeight = 16;
            this.recipeListBox.Location = new System.Drawing.Point(12, 71);
            this.recipeListBox.Name = "recipeListBox";
            this.recipeListBox.Size = new System.Drawing.Size(323, 276);
            this.recipeListBox.TabIndex = 13;
            // 
            // roastListBox
            // 
            this.roastListBox.FormattingEnabled = true;
            this.roastListBox.ItemHeight = 16;
            this.roastListBox.Location = new System.Drawing.Point(429, 71);
            this.roastListBox.Name = "roastListBox";
            this.roastListBox.Size = new System.Drawing.Size(323, 276);
            this.roastListBox.TabIndex = 14;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 432);
            this.Controls.Add(this.roastListBox);
            this.Controls.Add(this.recipeListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewRoastButton);
            this.Controls.Add(this.viewRecipeButton);
            this.Controls.Add(this.newRoastButton);
            this.Controls.Add(this.currentUserTextBox);
            this.Controls.Add(this.currentUserLabel);
            this.Controls.Add(this.newRecipeButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mainWindow";
            this.Text = "Coffee Logger";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newRecipeButton;
        private System.Windows.Forms.Label currentUserLabel;
        private System.Windows.Forms.TextBox currentUserTextBox;
        private System.Windows.Forms.Button newRoastButton;
        private System.Windows.Forms.Button viewRecipeButton;
        private System.Windows.Forms.Button viewRoastButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox recipeListBox;
        private System.Windows.Forms.ListBox roastListBox;
    }
}

