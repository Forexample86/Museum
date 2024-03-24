using Microsoft.AspNetCore.Mvc;
using Museum.Models;


public class AuthController : Controller
{
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(User user)
    {
        if (user.Username == "admin" && user.Password == "password")
        {
            // Сохранение факта аутентификации в сессии
            HttpContext.Session.SetString("User", user.Username);

            return RedirectToAction("Index", "Home");
        }

        return View();
    }
}
