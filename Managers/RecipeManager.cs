using CookBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Managers
{
    public class RecipeManager
    {
        private List<Recipe> recipes = new List<Recipe>();

        public void AddRecipe(Recipe recipe)
        {
            recipes.Add(recipe);
        }

        public void EditRecipe(string oldName, Recipe newRecipe)
        {
            var existingRecipe = recipes.Find(r => r.Name == oldName);
            if (existingRecipe != null)
            {
                existingRecipe.Name = newRecipe.Name;
                existingRecipe.Type = newRecipe.Type;
                existingRecipe.Cuisine = newRecipe.Cuisine;
                existingRecipe.Ingredients = newRecipe.Ingredients;
                existingRecipe.Instructions = newRecipe.Instructions;
            }
        }

        public void DeleteRecipe(string name)
        {
            recipes.RemoveAll(r => r.Name == name);
        }

        public List<Recipe> GetRecipes()
        {
            return recipes;
        }
    }
}
