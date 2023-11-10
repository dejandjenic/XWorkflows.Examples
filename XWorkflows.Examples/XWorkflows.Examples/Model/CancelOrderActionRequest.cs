namespace XWorkflows.Examples.Model;

public class CancelOrderActionRequest
{
    public string Id { get; }

    public CancelOrderActionRequest(string id)
    {
        Id = id;
    }
    
}