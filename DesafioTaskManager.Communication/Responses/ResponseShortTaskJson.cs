using DesafioTaskManager.Communication.Enums;

namespace DesafioTaskManager.Communication.Responses;

public class ResponseShortTaskJson
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public PriorityType Priority { get; set; }
    public StatusType Status { get; set; }
}
