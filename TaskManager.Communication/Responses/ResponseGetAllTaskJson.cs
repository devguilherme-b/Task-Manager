﻿namespace TaskManager.Communication.Responses;
public class ResponseGetAllTaskJson
{
    public List<ResponseShortTaskJson> Tasks { get; set; } = [];
}
