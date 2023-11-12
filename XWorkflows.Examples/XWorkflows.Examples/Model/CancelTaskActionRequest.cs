namespace XWorkflows.Examples.Model;

public class CancelTaskActionRequest
{
    public string Id { get; }

    public CancelTaskActionRequest(string id)
    {
        Id = id;
    }
    
}