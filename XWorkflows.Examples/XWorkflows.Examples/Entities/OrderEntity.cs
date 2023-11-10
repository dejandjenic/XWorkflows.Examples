namespace XWorkflows.Examples.Entities;

public class OrderEntity : IWorkflowStateEntity<OrderEntityState>
{
    public string Identifier { get; set; }
    public OrderEntityState State { get; set; }

    public async Task<string> GetIdetifier()
    {
        return Identifier;
    }

    public async Task<OrderEntityState> GetState()
    {
        return State;
    }

    public async Task SetState(OrderEntityState state, string identifier)
    {
        State = state;
        Identifier = identifier;
    }
    
    public string User { get; set; }
    public string Description { get; set; }
}