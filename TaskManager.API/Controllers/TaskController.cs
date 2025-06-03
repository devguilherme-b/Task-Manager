using Microsoft.AspNetCore.Mvc;
using TaskManager.Application.UseCase.Task.GetById;
using TaskManager.Application.UseCase.Tasks.Delete;
using TaskManager.Application.UseCase.Tasks.GetAll;
using TaskManager.Application.UseCase.Tasks.Register;
using TaskManager.Application.UseCase.Tasks.Update;
using TaskManager.Communication.Requests;
using TaskManager.Communication.Responses;

namespace TaskManager.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterTaskJson), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody] RequestRegisterTaskJson request)
    {
        var useCase = new RegisterTaskUseCase();
        var response = useCase.Execute(request);

        return Created(string.Empty, response);
    }

    [HttpGet]
    [ProducesResponseType(typeof(GetAllTaskUseCase), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrosJson), StatusCodes.Status404NotFound)]
    public IActionResult GetAll()
    {
        var useCase = new GetAllTaskUseCase();
        var response = useCase.Execute();
        if (response.Tasks.Any())
        {
            return Ok(response);
        }            
        return NotFound();
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseGetByIdTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrosJson), StatusCodes.Status400BadRequest)]
    public IActionResult GetById(int id)
    {
        var useUcase = new GetByIdTaskUseCase();
        var response = useUcase.Execute(id);

        return Ok(response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrosJson), StatusCodes.Status400BadRequest)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestUpdateTaskJson request)
    {
        var useCase = new UpdateTaskUseCase();
        useCase.Execute(id, request);
        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrosJson),StatusCodes.Status404NotFound)]
    public IActionResult Delete(int id)
    {
        var useCase = new DeleteTaskUseCase();
        useCase.Execute(id);
        return NoContent();
    }
}
