﻿using TaskManager.Communication.Enums;

namespace TaskManager.Communication.Responses;
public class ResponseGetByIdTaskJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public PriorityEnum Priority { get; set; }
    public DateTime Deadline { get; set; }
    public StatusEnum Status { get; set; }
}
