using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Models
{
    // Models/Recipe.cs
    public class Recipe
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Cuisine { get; set; } = "";
        public string Ingredients { get; set; }
        public string Instructions { get; set; }
        public List<string> Images { get; set; } = new List<string>();
    }

}
