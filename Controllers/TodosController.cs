using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace todos_list.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TodosController : ControllerBase
{
    private readonly TodosService _todosService;
    public TodosController(TodosService todosService)
    {
        _todosService = todosService;
    }

    [HttpGet]
    public ActionResult<List<Todo>> Get()
    {
        try
        {
            List<Todo> todos = _todosService.Get();
            return Ok(todos);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}
