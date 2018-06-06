using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheeseMVC.Models.Cheese;
using CheeseMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CheeseMVC.Controllers
{
    public class CheeseController : Controller
    {
        

        [HttpGet]
        public IActionResult Index()
        {
            List<Cheese> model = CheeseData.GetAll();
            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Cheese cheese)
        {
            CheeseData.Add(cheese);
            return Redirect("Index");
        }

        [HttpGet]
        public IActionResult CheckBoxDelete()
        {
            DeleteCheesesViewModel model = new DeleteCheesesViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult CheckBoxDelete(DeleteCheesesViewModel model)
        {
            model.Delete();
            return Redirect("Index");
        }

        [HttpGet]
        public IActionResult DropDownDelete()
        {
            List<Cheese> model = CheeseData.GetAll();
            return View(model);
        }

        [HttpPost]
        public IActionResult DropDownDelete(Cheese cheese)
        {
            CheeseData.Remove(cheese);
            return Redirect("Index");
        }
    }
}