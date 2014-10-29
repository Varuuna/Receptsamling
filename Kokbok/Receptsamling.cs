using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Kokbok
{
	public partial class Receptsamling : Form
	{
		public Recipe recept = new Recipe();
		public New Nytt = new New();
		public Change Ändra = new Change();

		public Receptsamling()
		{
			InitializeComponent();
			RecipeTitleLabel.Text = null;
			TypeOfFoodLabel.Text = null;
			RecipeInstructionsTextbox.Text = null;

			LoadFileInit();
			UpdateGrid();
		}

		private void NewRecipeButton_Click(object sender, EventArgs e)
		{
			// Launches the dialog for creating a new recipe.
			Nytt.ShowDialog();

			// Resets DataGrid and updates it with the new list everytime a recipe is added.
			UpdateGrid();

		}

		private void RemoveRecipeButton_Click(object sender, EventArgs e)
		{
			// Removes the selected column when "Ta Bort" is clicked.
			int x = RecipeCollectionGridView.Rows.IndexOf(RecipeCollectionGridView.CurrentRow);
			recept.RemoveRecipe(x);
			UpdateGrid();
		}

		// When you click on a cellcontent, the right-hand view is updated with all relevant data.
		private void RecipeCollectionGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			IngredientsList.Text = null;
			RecipeInstructionsTextbox.Text = null;

			int i = RecipeCollectionGridView.Rows.IndexOf(RecipeCollectionGridView.CurrentRow);

			RecipeTitleLabel.Text = Recipe.RecipeList[i].Titel;
			TypeOfFoodLabel.Text = Recipe.RecipeList[i].Maträtt;

			foreach (var item in Recipe.RecipeList[i].Ingredients)
			{
				IngredientsList.Text += IngredientsList.Text = item + "\n";
			}

			foreach (var item in Recipe.RecipeList[i].HowToCook)
			{
				RecipeInstructionsTextbox.Text += RecipeInstructionsTextbox.Text = item + "\n";
			}
		}

		// Gathers the necessary information from the selected column and sends it to ChangeRecipe()
		// Cheating a little. Actually removes the recipe, and adds the changed version back, rather than "just" changing.
		private void ChangeRecipeButton_Click(object sender, EventArgs e)
		{
			int i = RecipeCollectionGridView.Rows.IndexOf(RecipeCollectionGridView.CurrentRow);
			if (i != -1)
			{
				string Title = Recipe.RecipeList[i].Titel;
				string Type = Recipe.RecipeList[i].Maträtt;
				List<string> Ingredients = Recipe.RecipeList[i].Ingredients;
				List<string> HowTo = Recipe.RecipeList[i].HowToCook.ToList();

				recept.RemoveRecipe(i);

				Ändra.GatherChangeData(Title, Type, Ingredients, HowTo);
				Ändra.ShowDialog();
				UpdateGrid();
			}
			
		}

		// Refreshing the DataGrid.
		private void UpdateGrid()
		{
			RecipeCollectionGridView.DataSource = null;
			RecipeCollectionGridView.DataSource = new BindingList<Recipe>(Recipe.RecipeList);
			RecipeCollectionGridView.Refresh();
		}

		// Attempts to load the database on startup. If it fails, creates the file.
		public void LoadFileInit()
		{
			try
			{
				StreamReader LoadFile = new StreamReader(@".\Receptsamling\receptlista");
				while (!LoadFile.EndOfStream)
				{
					string RecipeFromFile = LoadFile.ReadToEnd();

					string[] StringSeparators = new String[] { "\r\n" };
					string[] LinedString = RecipeFromFile.Split(StringSeparators, StringSplitOptions.None);

					foreach (var item in LinedString)
					{
						if (item != "")
						{
							string[] SplitString = item.Split(',');

							Recipe recept = new Recipe()
							{
								Titel = SplitString[0],
								Maträtt = SplitString[1],
								Ingredients = SplitString[2].Split('\n').ToList(),
								HowToCook = SplitString[3].Split('\n')
							};
							Recipe.RecipeList.Add(recept);
						}
					}	
				}
				LoadFile.Close();

			}
			catch (Exception)
			{
				Error error = new Error();
				error.ErrorMsg("Receptfilen och/eller mappen kunde inte hittas. Filen/mappen \nkommer nu att skapas istället.");
				error.ShowDialog();
				Directory.CreateDirectory(@".\Receptsamling\");
				StreamWriter SaveFile = new StreamWriter(@".\Receptsamling\receptlista");
				SaveFile.Close();
			}

		}
	}
}
