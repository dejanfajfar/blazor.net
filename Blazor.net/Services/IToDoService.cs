using System;
using System.Collections.Generic;
using Blazor.net.Models;

namespace Blazor.net.Services
{
    public interface IToDoService
    {
        void Add(TodoItem item);
        IList<TodoItem> All();

        void RemoveById(Guid Id);

        TodoItem GetById(Guid id);
    }
}