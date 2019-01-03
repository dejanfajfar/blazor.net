using System;
using Blazor.net.Models;
using Blazor.net.Services;
using Microsoft.AspNetCore.Blazor.Components;

namespace Blazor.net.Views
{
    public class TodoBase : BlazorComponent
    {
        [Inject]
        protected IToDoService Items { get; set; }

        protected TodoItem NewTodo = new TodoItem();

        protected void AddTodo()
        {
            NewTodo.CreatedAt = DateTime.UtcNow;
            NewTodo.Id = Guid.NewGuid();
            Items.Add(NewTodo);
            NewTodo = new TodoItem();
            this.StateHasChanged();
        }

        protected void RemoveById(Guid id)
        {
            Console.WriteLine($"Removed {id}");
            Items.RemoveById(id);
            this.StateHasChanged();
        }
    }
}