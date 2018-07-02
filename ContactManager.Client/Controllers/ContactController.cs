using ContactManager.Client.Models;
using ContactManager.Client.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactManager.Client.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            ContactClient contactclient = new ContactClient();
            ViewBag.listContacts = contactclient.findAll();                
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public ActionResult Create(ContactViewModel contactVM)
        {
            ContactClient contactclient = new ContactClient();
            contactclient.Create(contactVM.contact);
            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            ContactClient contactclient = new ContactClient();
            ContactViewModel contactVM = new ContactViewModel();
            contactVM.contact = contactclient.find(id);
            return View("Edit", contactVM);
        }

        [HttpPost]
        public ActionResult Edit(ContactViewModel contactVM)
        {
            ContactClient contactclient = new ContactClient();
            contactclient.Edit(contactVM.contact);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            ContactClient contactclient = new ContactClient();
            contactclient.Delete(id);
            return RedirectToAction("Index");
        }
    }
}