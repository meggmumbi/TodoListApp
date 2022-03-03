using System;
using System.Collections.Generic;
using System.Text;

namespace TodoListApp
{   
     public class TodoItem
    {
        public string TodoText { get; set; }
        public bool complete { get; set; }

        public TodoItem(string TodoText, bool Complete)
        {
            this.TodoText = TodoText;
            this.complete = complete;

        }
    }
}
