using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicStoreMvcDemo.Models;

namespace MusicStoreMvcDemo.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            List<Genre> genre = new List<Genre>()
            {
                new Genre() { Name="Rock" },
                new Genre() { Name="Disco" },
                new Genre() { Name="Jazz" }
            };
            return View(genre);
        }

        public ActionResult Details(int id = 1)
        {
            var album = new Album() { Title = "Album " + id };
            return View(album);
        }

        public ActionResult Browse(string genre = "Rock")
        {
            var genreModel = new Genre() { Name = genre };
            return View(genreModel);
        }
    }
}