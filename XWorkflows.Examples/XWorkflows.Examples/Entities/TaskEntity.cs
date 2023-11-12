namespace XWorkflows.Examples.Entities;

public class TaskEntity  : IWorkflowStateEntity<TaskEntityState>
{
    
    public string Identifier { get; set; }
    public TaskEntityState State { get; set; }
    public async Task SetState(TaskEntityState state, string identifier)
    {
        State = state;
        Identifier = identifier;
    }

    public async Task<string> GetIdetifier()
    {
        return Identifier;
    }

    public async Task<TaskEntityState> GetState()
    {
        return State;
    }
    
    public string User { get; set; }
    public string Description { get; set; }
}