using Microsoft.AspNetCore.Mvc;
using TestForWebAppCLDV.Models;

namespace TestForWebAppCLDV.Controllers
{
    public class UserController : Controller
    {
        //object of model specifically (table)
        public userTable usrtbl = new userTable();

        [HttpPost]
        public IActionResult about(userTable users)
        {
            var result = usrtbl.insert_User(users);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult about()
        {
            return View(usrtbl);
        }
    }
}
