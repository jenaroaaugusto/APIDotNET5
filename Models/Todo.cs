using System;

namespace MeuTodo5.Models
{
    public class Todo
	{
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Done { get; set; } = false;
        public string Description { get; set; }
    }
}

