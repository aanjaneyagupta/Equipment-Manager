﻿using EquipmentManager_Assignment1.Models;
using EquipmentManager_Assignment1.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EquipmentManager_Assignment1.Controllers
{
    public class RequestController:Controller
    {
        private static List<Request> requests = new List<Request>();
        private static int id = 1;
        private static RequestRepository requestRepository= new RequestRepository();

        [HttpGet]
        public IActionResult RequestForm()
        {
            return View();
        }


        [HttpPost]
        public IActionResult RequestForm(Request request)
        {
            if (ModelState.IsValid)
            {
                request.Id = id++;
                requestRepository.AddRequest(request);
                return RedirectToAction("Confirmation");
            }
            return View(request);
        }

        public IActionResult Confirmation()
        {
            return View();
        }

        public IActionResult Requests()
        {
            return View(requests);
        }
    }
}
