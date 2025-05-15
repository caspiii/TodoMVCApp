using Microsoft.AspNetCore.Mvc;
using TodoMvcApp.Models;
using TodoMvcApp.Services;

namespace TodoMvcApp.Controllers
{
    public class TodoController : Controller
    {
        private readonly TodoService _service;

        public TodoController(TodoService service)
        {
            _service = service;
        }

        public IActionResult Index(string category, int? priority, bool showHidden = false)
        {
            var items = _service.GetAll(category, priority, showHidden);
            return View(items);
        }


        [HttpPost]
        public IActionResult Add(string title, string category, int priority)
        {
            if (!string.IsNullOrWhiteSpace(title))
            {
                _service.Add(new TodoItem
                {
                    Title = title,
                    Category = category,
                    Priority = priority
                });
            }
            return RedirectToAction("Index");
        }

        public IActionResult Toggle(int id)
        {
            _service.ToggleComplete(id);
            return RedirectToAction("Index");
        }

        public IActionResult Hide(int id)
        {
            _service.Hide(id);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return RedirectToAction("Index");
        }
        
        public IActionResult Unhide(int id)
        {
              _service.Unhide(id);
         // Keep the current filters and showHidden=true query parameter if needed
               return RedirectToAction("Index", new { showHidden = true });
        }


    }
}
