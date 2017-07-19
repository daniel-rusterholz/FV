using FV.Data;
using FV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FV.Controllers
{
    public class FvController : Controller
    {
        private ComicBookReposetory _comicBookReposetory = null;

        public FvController()
        {
            _comicBookReposetory = new ComicBookReposetory();
        }

        public ActionResult Index()
        {
            var comicBooks = _comicBookReposetory.GetComicBooks();

            return View(comicBooks);
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var comicBook = _comicBookReposetory.GetComicBook(id.Value);

            return View(comicBook);
        }

    }
}