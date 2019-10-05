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
        private IRecipeRepository repository;
        public HomeController(IRecipeRepository repo)
        {
            repository = repo;
        }
        public ViewResult Index() => View(repository.Recipes);
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