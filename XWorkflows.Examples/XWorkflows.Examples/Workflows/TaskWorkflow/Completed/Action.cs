using XWorkflows.Examples.Entities;
using XWorkflows.Examples.Model;
using XWorkflows.Examples.Services;
using XWorkflows.Examples.Workflows.TaskWorkflow.Base;

namespace XWorkflows.Examples.Workflows.TaskWorkflow.Completed;
public class CompletedTaskAction : TaskWorkflowAction<TaskWorkflow.Completed.CompletedTaskEvent, TaskWorkflow.Completed.CompletedTaskState, TaskEntity, CompletedTaskActionRequest, bool>
{
    private readonly ITaskService _TaskService;

    public CompletedTaskAction(TaskWorkflow.Completed.CompletedTaskState state, TaskWorkflow.Completed.CompletedTaskEvent e,ITaskService TaskService) : base(state, e)
    {
        _TaskService = TaskService;
    }

    public async override Task<(WorkflowActionResult<bool>, TaskEntity)> Execute(TaskEntity data, CompletedTaskActionRequest p, CancellationToken cancelationToken)
    {
        await base.Execute(data, p, cancelationToken);
        await _TaskService.Save(data,p.Id);
        return new (
            WorkflowActionResult<bool>.Success(true),
            data
        );
    }
}
