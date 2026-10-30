using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
    public class ToDoListController : Controller
    {
        private readonly MyPortfolioContext _context;

        public ToDoListController(MyPortfolioContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.ToDoLists.ToList();
            return View(values);
        }
        public IActionResult CreateToDoList()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateToDoList(ToDoList toDoList)
        {
            toDoList.Status = false;
            _context.ToDoLists.Add(toDoList);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult DeleteToDoList(int id)
        {
            var value = _context.ToDoLists.Find(id);

            _context.ToDoLists.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult UpdateToDoList(int id)
        {
            var value = _context.ToDoLists.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateToDoList(ToDoList toDoList)
        {
            var value = _context.ToDoLists.Find(toDoList.ToDoListId);

            value.Title = toDoList.Title;
            value.Date = toDoList.Date;
            value.ImageUrl = toDoList.ImageUrl;
            value.Status = toDoList.Status;

            _context.ToDoLists.Update(value);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult ChangeStatusToFalse(int id)
        {
            var value = _context.ToDoLists.Find(id);
            value.Status = false;
            _context.SaveChanges();

            return RedirectToAction("Index");

        }
        public IActionResult ChangeStatusToTrue(int id)
        {
            var value = _context.ToDoLists.Find(id);
            value.Status = true;
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
