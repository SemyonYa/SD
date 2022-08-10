using Microsoft.AspNetCore.Mvc;
using SD2.Services;

namespace SD2.Controllers
{
    public class MessageController : Controller
    {
        // 1. 
        private LoggerService loggerService;

        // 2
        // Dependency Injection => []
        public MessageController(LoggerService _loggerService)
        {
            this.loggerService = _loggerService;
        }



        public IActionResult Index()
        {
            // Сделано в 12:40
            loggerService.Write("Сделано в 12:40");
            return View();
        }
    }
}
