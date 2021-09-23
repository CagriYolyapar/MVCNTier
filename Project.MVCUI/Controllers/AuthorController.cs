using Project.BLL.DesignPatterns.GenericRepository.ConcRep;
using Project.ENTITIES.Models;
using Project.MVCUI.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.Controllers
{
    public class AuthorController : Controller
    {
        AuthorRepository _authRep;

        public AuthorController()
        {
            _authRep = new AuthorRepository();
        }
        // GET: Author
        public ActionResult AuthorList()
        {
            AuthorVM avm = new AuthorVM
            {
                Authors = _authRep.GetActives()
            };

            return View(avm);
        }

        public ActionResult AddAuthor()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAuthor(Author authorInstance)
        {
            _authRep.Add(authorInstance);
            return RedirectToAction("AuthorList");
        }

        public ActionResult UpdateAuthor(int id)
        {
            AuthorVM avm = new AuthorVM()
            {
                AuthorInstance = _authRep.Find(id)
            };

            return View(avm);
        }

        [HttpPost]
        public ActionResult UpdateAuthor(Author authorInstance)
        {
            _authRep.Update(authorInstance);
            return RedirectToAction("AuthorList");
        }

        public ActionResult DeleteAuthor(int id)
        {
            _authRep.Delete(_authRep.Find(id));
            return RedirectToAction("AuthorList");
        }
    }
}