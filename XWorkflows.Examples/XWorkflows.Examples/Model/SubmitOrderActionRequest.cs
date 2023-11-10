namespace XWorkflows.Examples.Model;

public class SubmitOrderActionRequest
{
    public string Id { get; }

    public SubmitOrderActionRequest(string id)
    {
        Id = id;
    }
}