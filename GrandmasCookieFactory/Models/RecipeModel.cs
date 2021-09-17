using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrandmasCookieFactory.Models
{
    public class RecipeModel
    {

        public string Name { get; set; }
        public Dictionary<string,string> Ingredients { get; set; }
        public int Popularity { get; set; }
        public string Description { get; set; }

        public RecipeModel()
        {
            Ingredients = new Dictionary<string, string>();
        }
    }
}
