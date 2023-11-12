using Microsoft.AspNetCore.Mvc;
using XWorkflows.Examples.Helpers;
using XWorkflows.Examples.Model;
using XWorkflows.Examples.Services;
using XWorkflows.Examples.Workflows.TaskWorkflow.Base;
using XWorkflows.Examples.Workflows.TaskWorkflow.Cancel;
using XWorkflows.Examples.Workflows.TaskWorkflow.InProgress;

namespace XWorkflows.Examples.Endpoints.Task;

public  static partial class TaskEndpoints
{
    private static Delegate InProgressTask => async (TaskWorkflow workflow,InProgressTaskAction action,[FromRoute]string TaskId,ITaskService repository,CancellationToken token) => 
    {
        var entity = await repository.Get(TaskId);
        var result = await workflow.StartAction(entity, action, new InProgressTaskActionRequest(TaskId),token);
        return result.ToResult(true);
    };
}