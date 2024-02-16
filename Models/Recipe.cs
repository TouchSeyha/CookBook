using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Models
{

    public class Recipe
    {
        public ObservableCollection<Recipe> Recipes { get; set; } = new ObservableCollection<Recipe>();

        public string Name { get; set; }
        public string Type { get; set; }
        public string Cuisine { get; set; }
        
    }

}
