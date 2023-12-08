using Microsoft.AspNetCore.Mvc;
using App.Filters;

namespace App.Areas.Admin.Controllers
{
public class AdminController : Controller
{
[Area("Admin")]
[AdminAuthorize]
public IActionResult Index()
{
return View();
}
}
}