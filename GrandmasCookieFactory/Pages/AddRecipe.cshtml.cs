using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrandmasCookieFactory.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GrandmasCookieFactory.Pages
{
    public class AddRecipeModel : PageModel
    {
        public RecipeModel RecipeModel { get; set; }
        public IngredientsModel IngredientsModel { get; set; }
        public Dictionary<string, string> IngrediensList { get; set; }

        public void OnGet()
        {
        }

        public void OnPost() 
        { 

        }
    }
}
