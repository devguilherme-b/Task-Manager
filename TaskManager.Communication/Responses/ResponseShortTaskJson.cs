using TaskManager.Communication.Enums;

namespace TaskManager.Communication.Responses;
public class ResponseShortTaskJson
{
    public string Name { get; set; } = string.Empty;
    public PriorityEnum Priority { get; set; }
    public DateTime Deadline { get; set; }
    public StatusEnum Status { get; set; }
}
