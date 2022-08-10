using Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SD2.Models.View;
using SD2.Services;

namespace SD2.Controllers
{
    public class ProfileController : Controller
    {
        private string token = "drsgfkiadvja'dovd9sui304u893[4ir[90-qscd;oubasc";

        private LoggerService logger;
        private ClientService clientService;

        public ProfileController(LoggerService _logger, ClientService _clientService)
        {
            logger = _logger;
            clientService = _clientService;
        }
        private Client GetMyself()
        {
            return clientService.FindByToken(token)!;
        }
        // GET: ProfileController/Edit/5
        public ActionResult Edit()
        {
            Client client = GetMyself();
            EditProfileViewModel model = new EditProfileViewModel(client);
            return View(model);
        }

        // POST: ProfileController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, EditProfileViewModel model)
        {
            try
            {
                Client? client = clientService.Find(id);

                if (client == null)
                    throw new Exception("Not found");

                model.Fill(client);
                clientService.Update(client);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
