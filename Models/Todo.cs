using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTodoApi
{
    public class Todo
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
    }
}