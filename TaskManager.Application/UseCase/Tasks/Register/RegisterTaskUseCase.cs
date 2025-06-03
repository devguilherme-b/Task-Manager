using TaskManager.Communication.Requests;
using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCase.Tasks.Register;
public class RegisterTaskUseCase
{
    public ResponseRegisterTaskJson Execute(RequestRegisterTaskJson request)
    {
        return new ResponseRegisterTaskJson()
        {
            Name = request.Name,
            Priority = request.Priority,
            Deadline = request.Deadline,
            Status = request.Status
        };
    }
}
