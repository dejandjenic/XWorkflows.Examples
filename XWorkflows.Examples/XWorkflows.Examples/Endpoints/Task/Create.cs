using XWorkflows.Examples.Helpers;
using XWorkflows.Examples.Model;
using XWorkflows.Examples.Workflows.TaskWorkflow.Base;
using XWorkflows.Examples.Workflows.TaskWorkflow.Create;

namespace XWorkflows.Examples.Endpoints.Task;

public  static partial class TaskEndpoints
{
    private static Delegate CreateTask => async (TaskWorkflow workflow,CreateTaskAction action,CreateTaskActionRequest request,CancellationToken token) =>
    {
        var result = await workflow.StartAction(null, action, request,token);
        return result.ToResult();
    };
}