using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Blazor.net.Models;

namespace Blazor.net.Services
{
    public class ToDoService : IToDoService
    {
        private readonly IDictionary<Guid, TodoItem> items;

        public ToDoService()
        {
            this.items = new Dictionary<Guid, TodoItem>();
        }

        public void Add(TodoItem item)
        {
            Console.WriteLine(item.Id);
            Console.WriteLine(item.Message);
            Console.WriteLine(item.CreatedAt);
            this.items.Add(item.Id, item);
        }

        public IList<TodoItem> All()
        {
            return this.items.Values.ToList();
        }

        public void RemoveById(Guid id)
        {
            this.items.Remove(id);
        }

        public TodoItem GetById(Guid id)
        {
            return this.items[id];
        }
    }
}