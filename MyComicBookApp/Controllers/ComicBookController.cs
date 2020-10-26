using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyComicBookApp.Controllers
{
    public class ComicBookController : Controller
    {
        // GET: ComicBook
        public ActionResult Detail()
        {
            ViewBag.seriesTitle = "The Amazing Spider-Man";
            ViewBag.issueNumber = 700;
            ViewBag.description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, " +
                "last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
            //viewbag.blabla = artist();
            ViewBag.artists = new string[]
            {
                "Script: Dan Slott",
                "Pencils: Humberto Ramos",
                "Inks: Victor Olazaba",
                "Colors: Edgar Delgado",
                "Letters: Chris Eliopoulos"
            };
            return View();
        }


    }
}