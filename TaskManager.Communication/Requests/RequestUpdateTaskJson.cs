using TaskManager.Communication.Enums;

namespace TaskManager.Communication.Requests;
public class RequestUpdateTaskJson
{
    public string NewName { get; set; } = string.Empty;
    public string NewDescription { get; set; } = string.Empty;
    public PriorityEnum NewPriority { get; set; }
    public DateTime NewDeadline { get; set; }
    public StatusEnum NewStatus { get; set; }
}
