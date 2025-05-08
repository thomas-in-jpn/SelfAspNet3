using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders.Composite;

namespace SelfAspNet3.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return Content("こんにちは　世界!");
        }
    }
}
