using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using CookBook.Models;
using CookBook.Managers;

namespace CookBook.Views
{
    public partial class MainWindow : Window
    {
        // RecipeManager instance to manage recipes
        private RecipeManager recipeManager = new RecipeManager();

        // ObservableCollection to bind to the ListView
        public ObservableCollection<Recipe> Recipes { get; set; } = new ObservableCollection<Recipe>();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this; // Set DataContext to enable data binding
        }

        // Button click event for adding a recipe
        private void AddRecipeButton_Click(object sender, RoutedEventArgs e)
        {
            // Retrieve recipe details from UI controls and create a new Recipe
            Recipe newRecipe = new Recipe
            {
                Name = "New Recipe", // You can replace this with the actual values from UI controls
                Type = "Type",
                Cuisine = "Cuisine"
                // Set other properties accordingly
            };

            recipeManager.AddRecipe(newRecipe);
            RefreshRecipeList();
        }

        // Button click event for editing a recipe
        private void EditRecipeButton_Click(object sender, RoutedEventArgs e)
        {
            // Retrieve selected recipe from the ListView
            Recipe selectedRecipe = (Recipe)RecipeListView.SelectedItem;

            if (selectedRecipe != null)
            {
                // Open a dialog or navigate to a new window for editing
                // You can implement this part based on your UI design
                // Pass the selectedRecipe to the editing form
                // ...

                // After editing, update the recipe in the RecipeManager
                recipeManager.EditRecipe(selectedRecipe.Name, selectedRecipe);
                RefreshRecipeList();
            }
        }

        // Button click event for deleting a recipe
        private void DeleteRecipeButton_Click(object sender, RoutedEventArgs e)
        {
            // Retrieve selected recipe from the ListView
            Recipe selectedRecipe = (Recipe)RecipeListView.SelectedItem;

            if (selectedRecipe != null)
            {
                recipeManager.DeleteRecipe(selectedRecipe.Name);
                RefreshRecipeList();
            }
        }

        // Button click event for exporting a recipe to PDF
        private void ExportToPDFButton_Click(object sender, RoutedEventArgs e)
        {
            // Implement exporting logic
            // You can use third-party libraries like MigraDoc for PDF export
        }

        // Helper method to refresh the recipe list in the UI
        private void RefreshRecipeList()
        {
            Recipes.Clear();
            foreach (Recipe recipe in recipeManager.GetRecipes())
            {
                Recipes.Add(recipe);
            }
        }

    }

}
