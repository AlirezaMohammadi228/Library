using Library.Models.Book;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace Library.Controllers
{
    public class BookController : Controller
    {
        public static BookRepository bookRepository { get; set; } = new();

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Book book)
        {
            bookRepository.Create(book);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            bookRepository.Delete(bookRepository.GetById(id));
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var model = bookRepository.GetById(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult Update(Book book , int id)
        {
            bookRepository.Update(book, id);
            return RedirectToAction("Index");
        }
        [HttpGet]

        public IActionResult Index()
        {
            return View(bookRepository.Filter(BookGenre.None, string.Empty));
        }
        [HttpPost]
        public IActionResult Index(BookGenre bookGenre, string title)
        {
            return View(bookRepository.Filter(bookGenre, title));
        }

    }
}
