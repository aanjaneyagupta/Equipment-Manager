using EquipmentManager_Assignment1.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EquipmentManager_Assignment1.Controllers
{
    public class AdminController : Controller
    {
        private static RequestRepository requestRepository=new RequestRepository();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Requests()
        {
            var requests = requestRepository.GetAllRequests(); 
            return View(requests);
        }
    }
}
