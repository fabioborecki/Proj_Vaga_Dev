using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System;

namespace Proj_Vaga_Dev.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Listar() {
            return View(); 
        }
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}

