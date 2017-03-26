using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComicBookGallery.Data;
using ComicBookGallery.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }
        public IActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var comicBook = _comicBookRepository.GetComicBook(id.Value);
            return View(comicBook);
        }
    }
}
