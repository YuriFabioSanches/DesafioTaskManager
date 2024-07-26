namespace DesafioTaskManager.Communication.Responses;

public class ResponseCreatedTaskJson
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
}
