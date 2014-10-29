namespace Kokbok
{
	partial class Receptsamling
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.NewRecipeButton = new System.Windows.Forms.Button();
			this.RemoveRecipeButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.ChangeRecipeButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SearchFilterRecipeTextbox = new System.Windows.Forms.TextBox();
			this.SearchFilterRecipeButton = new System.Windows.Forms.Button();
			this.RecipeCollectionGridView = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.RecipeInstructionsTextbox = new System.Windows.Forms.RichTextBox();
			this.IngredientsList = new System.Windows.Forms.RichTextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.TypeOfFoodLabel = new System.Windows.Forms.Label();
			this.RecipeTitleLabel = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.RecipeCollectionGridView)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// NewRecipeButton
			// 
			this.NewRecipeButton.ForeColor = System.Drawing.Color.Black;
			this.NewRecipeButton.Location = new System.Drawing.Point(6, 19);
			this.NewRecipeButton.Name = "NewRecipeButton";
			this.NewRecipeButton.Size = new System.Drawing.Size(86, 26);
			this.NewRecipeButton.TabIndex = 0;
			this.NewRecipeButton.Text = "Nytt";
			this.NewRecipeButton.UseVisualStyleBackColor = true;
			this.NewRecipeButton.Click += new System.EventHandler(this.NewRecipeButton_Click);
			// 
			// RemoveRecipeButton
			// 
			this.RemoveRecipeButton.ForeColor = System.Drawing.Color.Black;
			this.RemoveRecipeButton.Location = new System.Drawing.Point(98, 19);
			this.RemoveRecipeButton.Name = "RemoveRecipeButton";
			this.RemoveRecipeButton.Size = new System.Drawing.Size(86, 26);
			this.RemoveRecipeButton.TabIndex = 1;
			this.RemoveRecipeButton.Text = "Ta Bort";
			this.RemoveRecipeButton.UseVisualStyleBackColor = true;
			this.RemoveRecipeButton.Click += new System.EventHandler(this.RemoveRecipeButton_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.ChangeRecipeButton);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.SearchFilterRecipeTextbox);
			this.groupBox1.Controls.Add(this.SearchFilterRecipeButton);
			this.groupBox1.Controls.Add(this.NewRecipeButton);
			this.groupBox1.Controls.Add(this.RemoveRecipeButton);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(813, 58);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Recept";
			// 
			// ChangeRecipeButton
			// 
			this.ChangeRecipeButton.ForeColor = System.Drawing.Color.Black;
			this.ChangeRecipeButton.Location = new System.Drawing.Point(190, 19);
			this.ChangeRecipeButton.Name = "ChangeRecipeButton";
			this.ChangeRecipeButton.Size = new System.Drawing.Size(86, 26);
			this.ChangeRecipeButton.TabIndex = 3;
			this.ChangeRecipeButton.Text = "Ändra";
			this.ChangeRecipeButton.UseVisualStyleBackColor = true;
			this.ChangeRecipeButton.Click += new System.EventHandler(this.ChangeRecipeButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(452, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Nyckelord:";
			// 
			// SearchFilterRecipeTextbox
			// 
			this.SearchFilterRecipeTextbox.Location = new System.Drawing.Point(513, 23);
			this.SearchFilterRecipeTextbox.Name = "SearchFilterRecipeTextbox";
			this.SearchFilterRecipeTextbox.Size = new System.Drawing.Size(202, 20);
			this.SearchFilterRecipeTextbox.TabIndex = 4;
			// 
			// SearchFilterRecipeButton
			// 
			this.SearchFilterRecipeButton.ForeColor = System.Drawing.Color.Black;
			this.SearchFilterRecipeButton.Location = new System.Drawing.Point(721, 19);
			this.SearchFilterRecipeButton.Name = "SearchFilterRecipeButton";
			this.SearchFilterRecipeButton.Size = new System.Drawing.Size(86, 26);
			this.SearchFilterRecipeButton.TabIndex = 5;
			this.SearchFilterRecipeButton.Text = "Sök";
			this.SearchFilterRecipeButton.UseVisualStyleBackColor = true;
			// 
			// RecipeCollectionGridView
			// 
			this.RecipeCollectionGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.RecipeCollectionGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.RecipeCollectionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.RecipeCollectionGridView.DefaultCellStyle = dataGridViewCellStyle2;
			this.RecipeCollectionGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.RecipeCollectionGridView.Location = new System.Drawing.Point(6, 19);
			this.RecipeCollectionGridView.Name = "RecipeCollectionGridView";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.RecipeCollectionGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.RecipeCollectionGridView.Size = new System.Drawing.Size(319, 409);
			this.RecipeCollectionGridView.TabIndex = 6;
			this.RecipeCollectionGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RecipeCollectionGridView_CellContentClick);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.RecipeCollectionGridView);
			this.groupBox2.Location = new System.Drawing.Point(12, 77);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(331, 434);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Receptlista";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.RecipeInstructionsTextbox);
			this.groupBox3.Controls.Add(this.IngredientsList);
			this.groupBox3.Controls.Add(this.pictureBox1);
			this.groupBox3.Controls.Add(this.TypeOfFoodLabel);
			this.groupBox3.Controls.Add(this.RecipeTitleLabel);
			this.groupBox3.Location = new System.Drawing.Point(349, 77);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(476, 434);
			this.groupBox3.TabIndex = 5;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Beskrivning";
			// 
			// RecipeInstructionsTextbox
			// 
			this.RecipeInstructionsTextbox.Location = new System.Drawing.Point(11, 291);
			this.RecipeInstructionsTextbox.Name = "RecipeInstructionsTextbox";
			this.RecipeInstructionsTextbox.ReadOnly = true;
			this.RecipeInstructionsTextbox.Size = new System.Drawing.Size(459, 137);
			this.RecipeInstructionsTextbox.TabIndex = 5;
			this.RecipeInstructionsTextbox.TabStop = false;
			this.RecipeInstructionsTextbox.Text = "";
			// 
			// IngredientsList
			// 
			this.IngredientsList.Location = new System.Drawing.Point(11, 73);
			this.IngredientsList.Name = "IngredientsList";
			this.IngredientsList.ReadOnly = true;
			this.IngredientsList.Size = new System.Drawing.Size(202, 212);
			this.IngredientsList.TabIndex = 4;
			this.IngredientsList.TabStop = false;
			this.IngredientsList.Text = "";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(219, 73);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(251, 212);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// TypeOfFoodLabel
			// 
			this.TypeOfFoodLabel.AutoSize = true;
			this.TypeOfFoodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.TypeOfFoodLabel.Location = new System.Drawing.Point(8, 44);
			this.TypeOfFoodLabel.Name = "TypeOfFoodLabel";
			this.TypeOfFoodLabel.Size = new System.Drawing.Size(312, 17);
			this.TypeOfFoodLabel.TabIndex = 1;
			this.TypeOfFoodLabel.Text = "<Typ av maträtt. exempelvis \"Kötträtt\" \"Fiskrätt\">";
			// 
			// RecipeTitleLabel
			// 
			this.RecipeTitleLabel.AutoSize = true;
			this.RecipeTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RecipeTitleLabel.Location = new System.Drawing.Point(7, 20);
			this.RecipeTitleLabel.Name = "RecipeTitleLabel";
			this.RecipeTitleLabel.Size = new System.Drawing.Size(183, 24);
			this.RecipeTitleLabel.TabIndex = 0;
			this.RecipeTitleLabel.Text = "<Titel på valt recept>";
			// 
			// Receptsamling
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(837, 523);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Receptsamling";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Toves Bästa Recept";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.RecipeCollectionGridView)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button NewRecipeButton;
		private System.Windows.Forms.Button RemoveRecipeButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button SearchFilterRecipeButton;
		private System.Windows.Forms.TextBox SearchFilterRecipeTextbox;
		private System.Windows.Forms.DataGridView RecipeCollectionGridView;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label TypeOfFoodLabel;
		private System.Windows.Forms.Label RecipeTitleLabel;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button ChangeRecipeButton;
		private System.Windows.Forms.RichTextBox RecipeInstructionsTextbox;
		private System.Windows.Forms.RichTextBox IngredientsList;
	}
}

