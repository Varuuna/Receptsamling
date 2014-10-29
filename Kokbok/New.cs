using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kokbok
{
	public partial class New : Form
	{
		public List<Recipe> RecipeList = new List<Recipe>();
		public Recipe recept = new Recipe();

		public New()
		{
			InitializeComponent();
		}

		private void NewAddRecipeButton_Click(object sender, EventArgs e)
		{
			recept.CreateRecipe(NewRecipetitleTextbox.Text, TypeOfFoodTextbox.Text, NewIngredientsList.Text, NewInstructionsTextbox.Text);

			// Clears the textboxes and closes the dialog.
			NewRecipetitleTextbox.Text = null;
			TypeOfFoodTextbox.Text = null;
			NewIngredientsList.Text = null;
			NewInstructionsTextbox.Text = null;
			Close();
		}

	}
}
