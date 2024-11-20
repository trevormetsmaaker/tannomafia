using Microsoft.AspNetCore.Mvc;

namespace tannomafia.Controllers
{
    public class AccountsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
