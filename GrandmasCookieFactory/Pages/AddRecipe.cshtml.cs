using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;
using GrandmasCookieFactory.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace GrandmasCookieFactory.Pages
{
    public class AddRecipeModel : PageModel
    {
        [BindProperty]
        public RecipeModel RecipeModel { get; set; } 
        [BindProperty]
        public IngredientsModel IngredientsModel { get; set; }
        public static List<RecipeModel> ListOfRecipes { get; set; } = new List<RecipeModel>();

        public void OnGet()
        {
        }

        public IActionResult OnPost() 
        {

            RecipeModel.Ingredients.Add(IngredientsModel.Key, IngredientsModel.Value);
            
            string stringRecipes = HttpContext.Session.GetString("Recipes");

            if (!String.IsNullOrEmpty(stringRecipes))
            {
                ListOfRecipes = JsonConvert.DeserializeObject<List<RecipeModel>>(stringRecipes);
            }

            ListOfRecipes.Add(RecipeModel);

            stringRecipes = JsonConvert.SerializeObject(ListOfRecipes); //Write to .NET object

            HttpContext.Session.SetString("Recipes",stringRecipes);

            return RedirectToPage("/Index");
        }
    }
}
