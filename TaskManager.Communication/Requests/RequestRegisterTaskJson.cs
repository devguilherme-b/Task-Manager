using TaskManager.Communication.Enums;

namespace TaskManager.Communication.Requests;
public class RequestRegisterTaskJson
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public PriorityEnum Priority { get; set; }
    public DateTime Deadline { get; set; }
    public StatusEnum Status { get; set; }
}
