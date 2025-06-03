using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCase.Tasks.GetAll;
public class GetAllTaskUseCase
{
    public ResponseGetAllTaskJson Execute()
    {
        return new ResponseGetAllTaskJson
        {
            Tasks = new List<ResponseShortTaskJson>() {
                 new ResponseShortTaskJson(){
                    Name = "Finalizar API para gerenciar Tarefas",
                    Deadline = new DateTime(year: 2025, month: 06, day: 29),
                    Priority = Communication.Enums.PriorityEnum.Alta,
                    Status = Communication.Enums.StatusEnum.Em_Andamento
                 },
                 new ResponseShortTaskJson(){
                    Name = "Fazer compras no mercado",
                    Deadline = new DateTime(year: 2025, month: 06, day: 05),
                    Priority = Communication.Enums.PriorityEnum.Media,
                    Status = Communication.Enums.StatusEnum.Aguardando
                 }
            }
        };
    }
}
