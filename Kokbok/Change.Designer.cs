namespace Kokbok
{
	partial class Change
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
			this.ChangeChangeRecipeButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.ChangeRecipetitleTextbox = new System.Windows.Forms.TextBox();
			this.ChangeTypeOfFoodTextbox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.ChangeInstructionsTextbox = new System.Windows.Forms.RichTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.ChangeIngredientsList = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// ChangeChangeRecipeButton
			// 
			this.ChangeChangeRecipeButton.Location = new System.Drawing.Point(335, 284);
			this.ChangeChangeRecipeButton.Name = "ChangeChangeRecipeButton";
			this.ChangeChangeRecipeButton.Size = new System.Drawing.Size(75, 23);
			this.ChangeChangeRecipeButton.TabIndex = 0;
			this.ChangeChangeRecipeButton.Text = "Ändra";
			this.ChangeChangeRecipeButton.UseVisualStyleBackColor = true;
			this.ChangeChangeRecipeButton.Click += new System.EventHandler(this.ChangeChangeRecipeButton_Click);
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
			// ChangeRecipetitleTextbox
			// 
			this.ChangeRecipetitleTextbox.Location = new System.Drawing.Point(98, 10);
			this.ChangeRecipetitleTextbox.Name = "ChangeRecipetitleTextbox";
			this.ChangeRecipetitleTextbox.Size = new System.Drawing.Size(231, 20);
			this.ChangeRecipetitleTextbox.TabIndex = 3;
			// 
			// ChangeTypeOfFoodTextbox
			// 
			this.ChangeTypeOfFoodTextbox.Location = new System.Drawing.Point(98, 36);
			this.ChangeTypeOfFoodTextbox.Name = "ChangeTypeOfFoodTextbox";
			this.ChangeTypeOfFoodTextbox.Size = new System.Drawing.Size(231, 20);
			this.ChangeTypeOfFoodTextbox.TabIndex = 4;
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
			// ChangeInstructionsTextbox
			// 
			this.ChangeInstructionsTextbox.Location = new System.Drawing.Point(16, 173);
			this.ChangeInstructionsTextbox.Name = "ChangeInstructionsTextbox";
			this.ChangeInstructionsTextbox.Size = new System.Drawing.Size(313, 134);
			this.ChangeInstructionsTextbox.TabIndex = 7;
			this.ChangeInstructionsTextbox.Text = "";
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
			// ChangeIngredientsList
			// 
			this.ChangeIngredientsList.Location = new System.Drawing.Point(98, 62);
			this.ChangeIngredientsList.Name = "ChangeIngredientsList";
			this.ChangeIngredientsList.Size = new System.Drawing.Size(231, 92);
			this.ChangeIngredientsList.TabIndex = 9;
			this.ChangeIngredientsList.Text = "";
			// 
			// Change
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(422, 319);
			this.ControlBox = false;
			this.Controls.Add(this.ChangeIngredientsList);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.ChangeInstructionsTextbox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.ChangeTypeOfFoodTextbox);
			this.Controls.Add(this.ChangeRecipetitleTextbox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ChangeChangeRecipeButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Change";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Ändra Recept";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ChangeChangeRecipeButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox ChangeRecipetitleTextbox;
		private System.Windows.Forms.TextBox ChangeTypeOfFoodTextbox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RichTextBox ChangeInstructionsTextbox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RichTextBox ChangeIngredientsList;
	}
}