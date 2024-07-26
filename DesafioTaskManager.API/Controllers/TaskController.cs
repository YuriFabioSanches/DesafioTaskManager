using DesafioTaskManager.Application.UseCase.Task.Create;
using DesafioTaskManager.Application.UseCase.Task.Delete;
using DesafioTaskManager.Application.UseCase.Task.GetAll;
using DesafioTaskManager.Application.UseCase.Task.GetById;
using DesafioTaskManager.Application.UseCase.Task.Update;
using DesafioTaskManager.Communication.Requests;
using DesafioTaskManager.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace DesafioTaskManager.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllShortTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAll()
    {
        var response = new GetAllTasksUseCase().Execute();
        if (response.Tasks.Count != 0)
            return Ok(response);
        return NoContent();
    }

    [HttpGet ("{id}")]
    [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult GetById([FromRoute] Guid id)
    {
        var response = new GetTaskByIdUseCase().Execute(id);
        return Ok(response);
    }

    [HttpPost]
    [ProducesResponseType(typeof(ResponseCreatedTaskJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult Create([FromBody] RequestTaskJson request) 
    {
        var response = new CreateTaskUseCase().Execute(request);
        return Created(string.Empty, response);
    }

    [HttpPut ("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult Update([FromRoute] Guid id, [FromBody] RequestTaskJson request)
    {
        var useCase = new UpdateTaskUseCase();
        useCase.Execute(id, request);
        return NoContent();
    }

    [HttpDelete ("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult Delete([FromRoute]Guid id)
    {
        var useCase = new DeleteTaskUseCase();
        useCase.Execute(id);
        return NoContent();
    }

}
