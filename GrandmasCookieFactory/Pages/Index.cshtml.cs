using GrandmasCookieFactory.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrandmasCookieFactory.Pages
{
    public class IndexModel : PageModel
    {
        public List<RecipeModel> ListOfRecipes { get; set; } = AddRecipeModel.ListOfRecipes;
        public void OnGet()
        {
            string stringRecipes = HttpContext.Session.GetString("Recipes");
            if (!String.IsNullOrEmpty(stringRecipes))
            {
                ListOfRecipes = JsonConvert.DeserializeObject<List<RecipeModel>>(stringRecipes);
            }
        }
    }
}
