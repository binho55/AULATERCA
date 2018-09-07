using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoMvc.Models
{
    public class ToDoItems
    {


        public Guid id { get; set; }

        public bool isDone { get; set; }

        public string Title { get; set; }

        public DateTimeOffset? DueAt { get; set; }

    }
}