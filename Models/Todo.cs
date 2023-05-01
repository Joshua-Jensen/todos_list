using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace todos_list.Models
{
    public class Todo
    {


        public Todo(int id, string title, string body, bool done)
        {
            Id = id;
            Title = title;
            Body = body;
            Done = done;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public bool Done { get; set; }

    }
}