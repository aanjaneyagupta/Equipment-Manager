using EquipmentManager_Assignment1.Models;
using Microsoft.AspNetCore.Mvc;

namespace EquipmentManager_Assignment1.Controllers
{
    public class EquipmentController : Controller
    {
        public IActionResult AllEquipment()
        {
            var equipmentList = GetAllEquipmentList();
            return View(equipmentList);
        }

        private List<Equipment> GetAllEquipmentList()
        {
            return new List<Equipment>
            {
                new Equipment {EquipmentId=1, Type = EquipmentType.Laptop, Description="Lenovo Legion", IsAvailable=true },
                new Equipment{EquipmentId=2, Type= EquipmentType.Other, Description="PS4", IsAvailable=true},
                new Equipment {EquipmentId=3, Type = EquipmentType.Phone, Description="iPhone 11", IsAvailable=false },
                new Equipment{EquipmentId=4, Type=EquipmentType.Tablet, Description="iPad Air", IsAvailable=true },

            };
        }
    }
}
