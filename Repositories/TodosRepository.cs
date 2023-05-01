using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todos_list.Repositories;
public class TodosRepository
{

    private readonly FakeDb _db;
    public TodosRepository(FakeDb db)
    {
        _db = db;
    }

    internal List<Todo> Get()
    {
        List<Todo> todos = _db.Todos;
        return todos;
    }
}
