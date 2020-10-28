using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyComicBookApp.Data;
using MyComicBookApp.Models;

namespace MyComicBookApp.Controllers
{
    public class ComicBookController : Controller
    {

        private ComicBookRepository _repo = null;

        public ComicBookController() {
            _repo = new ComicBookRepository();
        }

        // GET: ComicBook
        public ActionResult Detail(int? Id)
        {
            if (Id == null)
                return HttpNotFound();

            var comicBook = new ComicBook();
            comicBook = _repo.GetComicBook((int)Id);

            return View(comicBook);
        }


    }
}