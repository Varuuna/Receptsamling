using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kokbok
{
	public class Recipe
	{
		public string Titel { get; set; }
		public string Maträtt { get; set; }
		public List<string> Ingredients = new List<string>();
		public string[] HowToCook { get; set; }

		public static List<Recipe> RecipeList = new List<Recipe>();

		// Creates new recipe.
		public void CreateRecipe(string Title, string Type, string Ingredients, string HowTo)
		{
			// Removes unecessary spaces after commas. Splits after the comma to make a string-array.
			// Also splits any newlines in the instructions into an array.
			string[] IngredientsArray = Ingredients.Split('\n');
			string[] InstructionsArray = HowTo.Split('\n');


			// Creates a new Recipe-object with the data input by the user. Adds it to the RecipeList.
			Recipe recept = new Recipe()
			{
				Titel = Title,
				Maträtt = Type,
				Ingredients = IngredientsArray.ToList(),
				HowToCook = InstructionsArray
			};
			RecipeList.Add(recept);

			StreamWriter write = new StreamWriter(@".\Receptsamling\receptlista", true);
			write.WriteLine(Title + "," + Type + "," + Ingredients + "," + HowTo);
			write.Close();
		}

		// Changes already existing recipe. (Currently functions exactly like CreateRecipe).
		public List<Recipe> ChangeRecipe(string Title, string Type, string Ingredients, string HowTo)
		{
			// Removes unecessary spaces after commas. Splits after the comma to make a string-array.
			// Also splits any newlines in the instructions into an array.
			string[] IngredientsArray = Ingredients.Split('\n');
			string[] InstructionsArray = HowTo.Split('\n');


			// Creates a new Recipe-object with the data input by the user. Adds it to the RecipeList.
			Recipe recept = new Recipe()
			{
				Titel = Title,
				Maträtt = Type,
				Ingredients = IngredientsArray.ToList(),
				HowToCook = InstructionsArray
			};
			RecipeList.Add(recept);
			return RecipeList;

		}

		// Removes selected recipe from the list.
		public void RemoveRecipe(int ID)
		{
			if (ID != -1)
			{
				Recipe.RecipeList.RemoveAt(ID);
			}
		}

	}
}
