using System.Collections.Generic;
using System.Linq;
using TodoMvcApp.Models;

namespace TodoMvcApp.Services
{
    public class TodoService
    {
        private static List<TodoItem> items = new List<TodoItem>();
        private static int counter = 1;

        public List<TodoItem> GetAll(string category = null, int? priority = null, bool showHidden = false)
        {
            IEnumerable<TodoItem> result = showHidden ? items : items.Where(i => !i.IsHidden);

            if (!string.IsNullOrEmpty(category))
                result = result.Where(i => i.Category == category);

            if (priority.HasValue)
                result = result.Where(i => i.Priority == priority.Value);

            return result.ToList();
        }

        public void Add(TodoItem item)
        {
            item.Id = counter++;
            items.Add(item);
        }

        public void ToggleComplete(int id)
        {
            var item = items.FirstOrDefault(i => i.Id == id);
            if (item != null) item.IsCompleted = !item.IsCompleted;
        }

        public void Hide(int id)
        {
            var item = items.FirstOrDefault(i => i.Id == id);
            if (item != null) item.IsHidden = true;
        }

        public void Delete(int id)
        {
            var item = items.FirstOrDefault(i => i.Id == id);
            if (item != null)
            {
                items.Remove(item);
            }
        }

        public void Unhide(int id)
        {
            var item = items.FirstOrDefault(i => i.Id == id);
            if (item != null)
            {
                item.IsHidden = false;
            }
        }
    }
}
