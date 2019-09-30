using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using COMP229_301044056_Assign01.Models;

namespace COMP229_301044056_Assign01.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {

            Recipe[] myRecipe = 
                {new Recipe {ID = 502, Name = "Panna Cotta", Cuisine = "Italian", Category = "Desserts" },
                 new Recipe {ID = 402, Name = "Beef Taco", Cuisine = "Mexican", Category = "Entrees" },
                 new Recipe {ID = 102, Name = "Autumn Soup", Cuisine = "American", Category = "Appetizers"}};
            return View(myRecipe);
        }
        public ViewResult DataPage()
        {
            return View();
        }
        public ViewResult DisplayPage()
        {
            return View();
        }
        public ViewResult InsertPage()
        {
            return View();
        }
        public ViewResult UserPage()
        {
            return View();
        }
    }
}