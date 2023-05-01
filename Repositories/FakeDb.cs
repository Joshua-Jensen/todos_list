using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todos_list.Repositories;
public class FakeDb
{
    public List<Todo> Todos;
    public FakeDb()
    {
        Todos = new List<Todo>();
        Todos.Add(new Todo(1, "finish database", "please finish this data base with stuff", false));
        Todos.Add(new Todo(2, "eat rice krispy", "get a delicious rice krispy treat", false));
        Todos.Add(new Todo(3, "go home", "leave this accursed place of cshrap", false));
    }

}
