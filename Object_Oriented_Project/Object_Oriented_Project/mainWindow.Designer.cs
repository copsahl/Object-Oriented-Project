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
            this.modifyRecipeButton = new System.Windows.Forms.Button();
            this.viewNotesButton = new System.Windows.Forms.Button();
            this.dataGridDisplay = new System.Windows.Forms.DataGridView();
            this.currentUserLabel = new System.Windows.Forms.Label();
            this.currentUserTextBox = new System.Windows.Forms.TextBox();
            this.newRoastButton = new System.Windows.Forms.Button();
            this.dataGridLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // newRecipeButton
            // 
            this.newRecipeButton.Location = new System.Drawing.Point(24, 357);
            this.newRecipeButton.Name = "newRecipeButton";
            this.newRecipeButton.Size = new System.Drawing.Size(108, 46);
            this.newRecipeButton.TabIndex = 0;
            this.newRecipeButton.Text = "New Recipe";
            this.newRecipeButton.UseVisualStyleBackColor = true;
            // 
            // modifyRecipeButton
            // 
            this.modifyRecipeButton.Location = new System.Drawing.Point(419, 357);
            this.modifyRecipeButton.Name = "modifyRecipeButton";
            this.modifyRecipeButton.Size = new System.Drawing.Size(108, 46);
            this.modifyRecipeButton.TabIndex = 1;
            this.modifyRecipeButton.Text = "Modify Recipe";
            this.modifyRecipeButton.UseVisualStyleBackColor = true;
            // 
            // viewNotesButton
            // 
            this.viewNotesButton.Location = new System.Drawing.Point(630, 357);
            this.viewNotesButton.Name = "viewNotesButton";
            this.viewNotesButton.Size = new System.Drawing.Size(108, 46);
            this.viewNotesButton.TabIndex = 2;
            this.viewNotesButton.Text = "View Notes";
            this.viewNotesButton.UseVisualStyleBackColor = true;
            // 
            // dataGridDisplay
            // 
            this.dataGridDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDisplay.Location = new System.Drawing.Point(24, 71);
            this.dataGridDisplay.Name = "dataGridDisplay";
            this.dataGridDisplay.RowHeadersWidth = 51;
            this.dataGridDisplay.RowTemplate.Height = 24;
            this.dataGridDisplay.Size = new System.Drawing.Size(714, 259);
            this.dataGridDisplay.TabIndex = 3;
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
            this.newRoastButton.Location = new System.Drawing.Point(217, 357);
            this.newRoastButton.Name = "newRoastButton";
            this.newRoastButton.Size = new System.Drawing.Size(108, 46);
            this.newRoastButton.TabIndex = 6;
            this.newRoastButton.Text = "New Roast";
            this.newRoastButton.UseVisualStyleBackColor = true;
            // 
            // dataGridLabel
            // 
            this.dataGridLabel.AutoSize = true;
            this.dataGridLabel.Location = new System.Drawing.Point(21, 38);
            this.dataGridLabel.Name = "dataGridLabel";
            this.dataGridLabel.Size = new System.Drawing.Size(39, 17);
            this.dataGridLabel.TabIndex = 7;
            this.dataGridLabel.Text = "EDIT";
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 432);
            this.Controls.Add(this.dataGridLabel);
            this.Controls.Add(this.newRoastButton);
            this.Controls.Add(this.currentUserTextBox);
            this.Controls.Add(this.currentUserLabel);
            this.Controls.Add(this.dataGridDisplay);
            this.Controls.Add(this.viewNotesButton);
            this.Controls.Add(this.modifyRecipeButton);
            this.Controls.Add(this.newRecipeButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mainWindow";
            this.Text = "Coffee Logger";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newRecipeButton;
        private System.Windows.Forms.Button modifyRecipeButton;
        private System.Windows.Forms.Button viewNotesButton;
        private System.Windows.Forms.DataGridView dataGridDisplay;
        private System.Windows.Forms.Label currentUserLabel;
        private System.Windows.Forms.TextBox currentUserTextBox;
        private System.Windows.Forms.Button newRoastButton;
        private System.Windows.Forms.Label dataGridLabel;
    }
}

