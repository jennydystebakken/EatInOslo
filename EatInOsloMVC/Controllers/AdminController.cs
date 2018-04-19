using Microsoft.AspNetCore.Mvc;
using RestaurantsMVC.Models;

namespace AdminMVC.Controllers{
    public class AdminController:Controller{
        public IActionResult AdminWelcome() {
            return View();
        }
    }
}