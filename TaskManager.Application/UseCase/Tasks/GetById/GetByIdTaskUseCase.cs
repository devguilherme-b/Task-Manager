using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCase.Task.GetById;
public class GetByIdTaskUseCase
{
    public ResponseGetByIdTaskJson Execute(int id)
    {
        return new ResponseGetByIdTaskJson 
        {
            Id = id,
            Name = "Finalizar API para gerenciar Tarefas",
            Description = "Desenvolver endpoints para Criar, Editar, Visualisar e Deletar Tarefas",
            Deadline = new DateTime(year: 2025, month: 06, day: 29),
            Priority = Communication.Enums.PriorityEnum.Alta,
            Status = Communication.Enums.StatusEnum.Em_Andamento
        };
    }
}
