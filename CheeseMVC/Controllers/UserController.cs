using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheeseMVC.Models.User;
using CheeseMVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CheeseMVC.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index(string message)
        {
            ViewBag.message = message;
            return View();
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            //UserData.GetById(id);
            return View();
        }

        // GET: User/Create
        public ActionResult Add()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(AddUserViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            model.Add();
            string messageString = $"Welcome {model.UserName}!";
            //return Redirect($"Index?message={messageString}");
            return RedirectToAction("Index", new { message = messageString });
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}