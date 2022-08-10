using Core.Models;
using Microsoft.AspNetCore.Mvc;
using SD2.Models;
using SD2.Models.View;
using SD2.Services;
using System.Diagnostics;

namespace SD2.Controllers
{
    public class HomeController : Controller
    {
        private LoggerService logger;
        private IClient clientService;

        public HomeController(LoggerService _logger, IClient _clientService)
        {
            logger = _logger;
            clientService = _clientService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            RegisterViewModel model = new RegisterViewModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            Client client = model.Create();
            clientService.Create(client);

            return View();
        }

        public IActionResult Login(Object model)
        {
            // 
            return View();
        }

    }
}

/*
    route = "Home/Register?name=qwerty&age=34";
    parts = route.Split("/")  => ["Home", "Register"]
    controller = new [Home]Controler()
    controller.[Register]
 */