using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.net.Models
{
    public class TodoItem
    {
        public string Message { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid Id { get; set; }
    }
}
