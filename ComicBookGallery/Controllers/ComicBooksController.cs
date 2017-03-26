using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public IActionResult Detail()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Saturday)
            {
                return Redirect("/");
            }
            return Content("Hello, from the comic books controller.");
        }
    }
}
