namespace XWorkflows.Examples.Workflows.OrderWorkflow.Base;

public class OrderWorkflowEvent<T> : IWorkflowEventWithData<T>, IWorkflowEvent 
{
    public virtual Task Execute(T data, CancellationToken cancelationToken)
    {
        throw new NotImplementedException();
    }
}