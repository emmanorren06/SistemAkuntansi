using Microsoft.AspNetCore.Mvc;

namespace SistemAkuntansiPeterpan.Controllers {
    public class HomeController : Controller{
        
        public IActionResult Index(){
            return View();
        }
        public string About(){
            return "Hello from About";
        }

    }
}