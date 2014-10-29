namespace Kokbok
{
	partial class New
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
			this.NewAddRecipeButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.NewRecipetitleTextbox = new System.Windows.Forms.TextBox();
			this.TypeOfFoodTextbox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.NewInstructionsTextbox = new System.Windows.Forms.RichTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.NewIngredientsList = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// NewAddRecipeButton
			// 
			this.NewAddRecipeButton.Location = new System.Drawing.Point(335, 284);
			this.NewAddRecipeButton.Name = "NewAddRecipeButton";
			this.NewAddRecipeButton.Size = new System.Drawing.Size(75, 23);
			this.NewAddRecipeButton.TabIndex = 5;
			this.NewAddRecipeButton.Text = "Lägg till";
			this.NewAddRecipeButton.UseVisualStyleBackColor = true;
			this.NewAddRecipeButton.Click += new System.EventHandler(this.NewAddRecipeButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Recepttitel:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Typ av maträtt:";
			// 
			// NewRecipetitleTextbox
			// 
			this.NewRecipetitleTextbox.Location = new System.Drawing.Point(98, 10);
			this.NewRecipetitleTextbox.Name = "NewRecipetitleTextbox";
			this.NewRecipetitleTextbox.Size = new System.Drawing.Size(231, 20);
			this.NewRecipetitleTextbox.TabIndex = 1;
			// 
			// TypeOfFoodTextbox
			// 
			this.TypeOfFoodTextbox.Location = new System.Drawing.Point(98, 36);
			this.TypeOfFoodTextbox.Name = "TypeOfFoodTextbox";
			this.TypeOfFoodTextbox.Size = new System.Drawing.Size(231, 20);
			this.TypeOfFoodTextbox.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Ingredienser:";
			// 
			// NewInstructionsTextbox
			// 
			this.NewInstructionsTextbox.Location = new System.Drawing.Point(16, 173);
			this.NewInstructionsTextbox.Name = "NewInstructionsTextbox";
			this.NewInstructionsTextbox.Size = new System.Drawing.Size(313, 134);
			this.NewInstructionsTextbox.TabIndex = 4;
			this.NewInstructionsTextbox.Text = "";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 157);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(118, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Instruktioner/Tillagning:";
			// 
			// NewIngredientsList
			// 
			this.NewIngredientsList.Location = new System.Drawing.Point(98, 62);
			this.NewIngredientsList.Name = "NewIngredientsList";
			this.NewIngredientsList.Size = new System.Drawing.Size(231, 92);
			this.NewIngredientsList.TabIndex = 3;
			this.NewIngredientsList.Text = "";
			// 
			// New
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(422, 319);
			this.Controls.Add(this.NewIngredientsList);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.NewInstructionsTextbox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.TypeOfFoodTextbox);
			this.Controls.Add(this.NewRecipetitleTextbox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.NewAddRecipeButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "New";
			this.Text = "Nytt Recept";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button NewAddRecipeButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox NewRecipetitleTextbox;
		private System.Windows.Forms.TextBox TypeOfFoodTextbox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RichTextBox NewInstructionsTextbox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RichTextBox NewIngredientsList;
	}
}