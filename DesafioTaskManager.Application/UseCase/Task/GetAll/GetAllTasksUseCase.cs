using DesafioTaskManager.Communication.Enums;
using DesafioTaskManager.Communication.Responses;

namespace DesafioTaskManager.Application.UseCase.Task.GetAll;

public class GetAllTasksUseCase
{
    public ResponseAllShortTaskJson Execute()
    {
        return new ResponseAllShortTaskJson
        {
            Tasks = new List<ResponseShortTaskJson>
            {
                new ResponseShortTaskJson { Id = Guid.NewGuid(), Name = "Test1", Priority = PriorityType.High, Status = StatusType.InProgress},
                new ResponseShortTaskJson { Id = Guid.NewGuid(), Name = "Test2", Priority = PriorityType.Medium, Status = StatusType.Completed},
                new ResponseShortTaskJson { Id = Guid.NewGuid(), Name = "Test3", Priority = PriorityType.Low, Status = StatusType.Cancelled}
            }
        };
    }
}
