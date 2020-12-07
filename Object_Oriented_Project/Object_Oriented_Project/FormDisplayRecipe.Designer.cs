namespace Object_Oriented_Project
{
    partial class FormDisplayRecipe
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
            this.RecipeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.roastDisplay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.creamerDisplay = new System.Windows.Forms.TextBox();
            this.noteListBox = new System.Windows.Forms.ListBox();
            this.addNoteButton = new System.Windows.Forms.Button();
            this.removeNoteButton = new System.Windows.Forms.Button();
            this.deleteRecipeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RecipeLabel
            // 
            this.RecipeLabel.AutoSize = true;
            this.RecipeLabel.Location = new System.Drawing.Point(167, 41);
            this.RecipeLabel.Name = "RecipeLabel";
            this.RecipeLabel.Size = new System.Drawing.Size(66, 17);
            this.RecipeLabel.TabIndex = 2;
            this.RecipeLabel.Text = "CHANGE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Roast:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Notes:";
            // 
            // roastDisplay
            // 
            this.roastDisplay.Location = new System.Drawing.Point(116, 96);
            this.roastDisplay.Name = "roastDisplay";
            this.roastDisplay.Size = new System.Drawing.Size(193, 22);
            this.roastDisplay.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Creamer:";
            // 
            // creamerDisplay
            // 
            this.creamerDisplay.Location = new System.Drawing.Point(116, 130);
            this.creamerDisplay.Name = "creamerDisplay";
            this.creamerDisplay.Size = new System.Drawing.Size(193, 22);
            this.creamerDisplay.TabIndex = 12;
            // 
            // noteListBox
            // 
            this.noteListBox.FormattingEnabled = true;
            this.noteListBox.ItemHeight = 16;
            this.noteListBox.Location = new System.Drawing.Point(12, 289);
            this.noteListBox.Name = "noteListBox";
            this.noteListBox.Size = new System.Drawing.Size(416, 164);
            this.noteListBox.TabIndex = 13;
            // 
            // addNoteButton
            // 
            this.addNoteButton.Location = new System.Drawing.Point(12, 470);
            this.addNoteButton.Name = "addNoteButton";
            this.addNoteButton.Size = new System.Drawing.Size(112, 41);
            this.addNoteButton.TabIndex = 14;
            this.addNoteButton.Text = "Add Note";
            this.addNoteButton.UseVisualStyleBackColor = true;
            this.addNoteButton.Click += new System.EventHandler(this.addNoteButton_Click);
            // 
            // removeNoteButton
            // 
            this.removeNoteButton.Location = new System.Drawing.Point(170, 470);
            this.removeNoteButton.Name = "removeNoteButton";
            this.removeNoteButton.Size = new System.Drawing.Size(112, 41);
            this.removeNoteButton.TabIndex = 15;
            this.removeNoteButton.Text = "Remove Note";
            this.removeNoteButton.UseVisualStyleBackColor = true;
            this.removeNoteButton.Click += new System.EventHandler(this.removeNoteButton_Click);
            // 
            // deleteRecipeButton
            // 
            this.deleteRecipeButton.Location = new System.Drawing.Point(316, 470);
            this.deleteRecipeButton.Name = "deleteRecipeButton";
            this.deleteRecipeButton.Size = new System.Drawing.Size(112, 41);
            this.deleteRecipeButton.TabIndex = 16;
            this.deleteRecipeButton.Text = "Delete Recipe";
            this.deleteRecipeButton.UseVisualStyleBackColor = true;
            this.deleteRecipeButton.Click += new System.EventHandler(this.deleteRecipeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Name:";
            // 
            // FormDisplayRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 544);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteRecipeButton);
            this.Controls.Add(this.removeNoteButton);
            this.Controls.Add(this.addNoteButton);
            this.Controls.Add(this.noteListBox);
            this.Controls.Add(this.creamerDisplay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.roastDisplay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RecipeLabel);
            this.Name = "FormDisplayRecipe";
            this.Text = "FormDisplayRecipe";
            this.Load += new System.EventHandler(this.FormDisplayRecipe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RecipeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox roastDisplay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox creamerDisplay;
        private System.Windows.Forms.ListBox noteListBox;
        private System.Windows.Forms.Button addNoteButton;
        private System.Windows.Forms.Button removeNoteButton;
        private System.Windows.Forms.Button deleteRecipeButton;
        private System.Windows.Forms.Label label2;
    }
}