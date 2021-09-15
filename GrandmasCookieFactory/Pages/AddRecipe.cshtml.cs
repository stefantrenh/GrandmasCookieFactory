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
        [BindProperty]
        public RecipeModel RecipeModel { get; set; }
        [BindProperty]
        public IngredientsModel IngredientsModel { get; set; }
        [BindProperty]
        public Dictionary<string, string> IngredientsList { get; set; } = new Dictionary<string, string>();

        public void OnGet()
        {
        }

        public void OnPost() 
        { 

        }
    }
}
