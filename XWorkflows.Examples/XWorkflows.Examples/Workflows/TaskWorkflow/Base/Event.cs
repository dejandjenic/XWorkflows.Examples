namespace XWorkflows.Examples.Workflows.TaskWorkflow.Base;

public class TaskWorkflowEvent<T> : IWorkflowEventWithData<T>, IWorkflowEvent 
{
    public virtual Task Execute(T data, CancellationToken cancelationToken)
    {
        throw new NotImplementedException();
    }
}