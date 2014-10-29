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
	public partial class Change : Form
	{
		Recipe recept = new Recipe();

		public Change()
		{
			InitializeComponent();
		}

		private void ChangeChangeRecipeButton_Click(object sender, EventArgs e)
		{
			recept.ChangeRecipe(ChangeRecipetitleTextbox.Text, ChangeTypeOfFoodTextbox.Text, ChangeIngredientsList.Text, ChangeInstructionsTextbox.Text);

			// Clears the textboxes and closes the dialog.
			ChangeRecipetitleTextbox.Text = null;
			ChangeTypeOfFoodTextbox.Text = null;
			ChangeIngredientsList.Text = null;
			ChangeInstructionsTextbox.Text = null;
			Close();
		}

		public void GatherChangeData(string Title, string Type, List<string> Ingredients, List<string> HowTo)
		{
			ChangeRecipetitleTextbox.Text = Title;
			ChangeTypeOfFoodTextbox.Text = Type;

			foreach (var item in Ingredients)
			{
				ChangeIngredientsList.Text += item + "\n";
			}

			foreach (var item in HowTo)
			{
				ChangeInstructionsTextbox.Text += item + "\n";
			}
		}
		
		
	}
}
