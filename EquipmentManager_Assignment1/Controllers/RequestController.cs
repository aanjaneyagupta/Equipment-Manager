using EquipmentManager_Assignment1.Models;
using Microsoft.AspNetCore.Mvc;

namespace EquipmentManager_Assignment1.Controllers
{
    public class RequestController:Controller
    {
        private static List<Request> requests = new List<Request>();
        private static int id = 1;

        [HttpGet]
        public IActionResult RequestForm()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult RequestForm(Request request)
        //{

        //}
        [HttpPost]
        public IActionResult RequestForm(Request request)
        {
            if (ModelState.IsValid)
            {
                request.Id = id++;
                requests.Add(request);
                return RedirectToAction("Confirmation");
            }
            return View(request);
        }

        // GET: /Confirmation
        public IActionResult Confirmation()
        {
            return View();
        }

        // GET: /Requests (for Admin view)
        public IActionResult Requests()
        {
            return View(requests);
        }
    }
}
