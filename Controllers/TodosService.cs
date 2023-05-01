namespace todos_list.Services;
public class TodosService
{
    private readonly TodosRepository _repo;
    public TodosService(TodosRepository repo)
    {
        _repo = repo;
    }

    internal List<Todo> Get()
    {
        List<Todo> todos = _repo.Get();
        return todos;
    }
}
