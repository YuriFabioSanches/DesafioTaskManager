using DesafioTaskManager.Communication.Responses;
using DesafioTaskManager.Communication.Enums;

namespace DesafioTaskManager.Application.UseCase.Task.GetById;

public class GetTaskByIdUseCase
{
    public ResponseTaskJson Execute(Guid id)
    {
        return new ResponseTaskJson
        {
            Id = id,
            Name = "Test",
            Description = "Test",
            LimiteDate = DateTime.Now,
            Priority = PriorityType.High,
            Status = StatusType.Waiting
        };
    }
}
