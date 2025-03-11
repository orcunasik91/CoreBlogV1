using Microsoft.AspNetCore.Mvc;

namespace CoreBlogV1.WebUI.Controllers;
public class AdminController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}