using EquipmentManager_Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EquipmentManager_Assignment1.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }



    }
}
