using Microsoft.AspNetCore.Mvc;

namespace ProductApiClient.Controllers
{
    public class ProductController : Controller
    {
        private readonly IConfiguration _config;
        public ProductController(IConfiguration config)
        {
            _config = config;
        }
        public IActionResult Index()
        {
            ViewBag.ApiBaseUrl = _config["ApiSettings:BaseUrl"];
            return View();
        }
    }
}
