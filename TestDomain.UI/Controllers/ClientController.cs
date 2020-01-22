using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestDomain.Domain.Contracts.Repositories;
using TestDomain.Domain.Entities;

namespace TestDomain.UI.Controllers
{
    public class ClientController : Controller
    {
        public IClient _client;

        public ClientController(IClient client)
        {
            _client = client;
        }
        // GET: Client
        public ActionResult Index()
        {
            var x = _client.GetAll();

            return View(x);
        }

        // GET: Client/Details/5
        public ActionResult Details(int id)
        {
            var x = _client.GetById(id);
            return View(x);
        }

        // GET: Client/Create
        public ActionResult Create(Client obj)
        {
            return View();
        }

        // POST: Client/Create
        [HttpPost]
        public ActionResult Create(Client obj)
        {
            try
            {
                if (!ModelState.IsValid)
                    throw new Exception("erro");

                _client.Insert(obj);
                _client.Commit();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Client/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Client/Edit/5
        [HttpPost]
        public ActionResult Edit(Client obj)
        {
            try
            {
                if (!ModelState.IsValid)
                    throw new Exception("erro");

                _client.Insert(obj);
                _client.Commit();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Client/Delete/5
        public ActionResult Delete(int id)
        {
            var x = _client.GetById(id);
            return View(x);
        }

        // POST: Client/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                _client.Delete(id);
                _client.Commit();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
