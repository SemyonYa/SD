using Core;
using Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SD2.Models.View;
using SD2.Services;

namespace SD2.Controllers
{
    public class ClientController : Controller
    {
        ClientService clientService;
        public ClientController(ClientService _clientService)
        {
            clientService = _clientService;
        }
        // GET: ClientController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ClientController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClientController/Create
        public ActionResult Create()
        {
            CreateClientViewModel model = new CreateClientViewModel();
            return View(model);
        }

        // POST: ClientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateClientViewModel model)
        {
            try
            {
                Client client = model.Create();
                clientService.Create(client);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientController/Edit/5
        public ActionResult Edit(int id)
        {
            Client? client = clientService.Find(id);

            if (client == null)
                throw new Exception("Not found");

            EditClientViewModel model = new EditClientViewModel(client);

            return View(model);
        }

        // POST: ClientController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, EditClientViewModel model)
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

        // GET: ClientController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClientController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
