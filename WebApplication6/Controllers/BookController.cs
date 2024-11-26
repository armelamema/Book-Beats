using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class BookController : Controller
    {

    }
        namespace WebApplication6.Controllers
    {
        public class BookController : Controller
        {
            private readonly ApplicationDbContext _context;

            
            public BookController()
            {
                _context = new ApplicationDbContext(); 
            }

            // GET: Book/Index
            public ActionResult Index()
            {
             
                var books = _context.Books.ToList();
                return View(books);
            }

            // GET: Book/Create
            public ActionResult Create()
            {
                return View();
            }

            // POST: Book/Create
            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Create([Bind(Include = "Title, AuthorID, GenreID, PubYear")] Book book)
            {
                if (ModelState.IsValid)
                {
                    _context.Books.Add(book); 
                    _context.SaveChanges();    
                    return RedirectToAction("Index");  
                }

                return View(book); 
            }

            // GET: Book/Edit/5
            public ActionResult Edit(int? id)
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }

                var book = _context.Books.Find(id);  
                if (book == null)
                {
                    return HttpNotFound();  
                }

                return View(book);
            }

            // POST: Book/Edit/5
            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Edit([Bind(Include = "BookID, Title, AuthorID, GenreID, PubYear")] Book book)
            {
                if (ModelState.IsValid)
                {
                    _context.Entry(book).State = System.Data.Entity.EntityState.Modified;  
                    _context.SaveChanges();  
                    return RedirectToAction("Index"); 
                }

                return View(book); 
            }

            // GET: Book/Delete/5
            public ActionResult Delete(int? id)
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }

                var book = _context.Books.Find(id); 
                if (book == null)
                {
                    return HttpNotFound(); 
                }

                return View(book); 
            }

            // POST: Book/Delete/5
            [HttpPost, ActionName("Delete")]
            [ValidateAntiForgeryToken]
            public ActionResult DeleteConfirmed(int id)
            {
                var book = _context.Books.Find(id);
                _context.Books.Remove(book);  
                _context.SaveChanges(); 
                return RedirectToAction("Index");  
            }

         
            protected override void Dispose(bool disposing)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                base.Dispose(disposing);
            }
        }
    }
}