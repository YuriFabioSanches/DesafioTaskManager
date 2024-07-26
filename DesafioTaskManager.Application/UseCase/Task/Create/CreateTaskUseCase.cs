using DesafioTaskManager.Communication.Requests;
using DesafioTaskManager.Communication.Responses;

namespace DesafioTaskManager.Application.UseCase.Task.Create;

public class CreateTaskUseCase
{
    public ResponseCreatedTaskJson Execute(RequestTaskJson request)
    {
        return new ResponseCreatedTaskJson { Id = Guid.NewGuid(), Name = request.Name};
    }
}
