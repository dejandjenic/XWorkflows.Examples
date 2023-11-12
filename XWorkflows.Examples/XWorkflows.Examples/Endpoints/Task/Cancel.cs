using Microsoft.AspNetCore.Mvc;
using XWorkflows.Examples.Helpers;
using XWorkflows.Examples.Model;
using XWorkflows.Examples.Services;
using XWorkflows.Examples.Workflows.TaskWorkflow.Base;
using XWorkflows.Examples.Workflows.TaskWorkflow.Cancel;

namespace XWorkflows.Examples.Endpoints.Task;

public  static partial class TaskEndpoints
{
    private static Delegate CancelTask => async (TaskWorkflow workflow,CancelTaskAction action,[FromRoute]string TaskId,ITaskService repository,CancellationToken token) => 
    {
        var entity = await repository.Get(TaskId);
        var result = await workflow.StartAction(entity, action, new CancelTaskActionRequest(TaskId),token);
        return result.ToResult(true);
    };
}