﻿using DesafioTaskManager.Communication.Enums;

namespace DesafioTaskManager.Communication.Responses;

public class ResponseTaskJson
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public PriorityType Priority { get; set; }
    public DateTime LimiteDate { get; set; }
    public StatusType Status { get; set; }
}
