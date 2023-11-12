using XWorkflows.Examples.Entities;
using XWorkflows.Examples.Model;
using XWorkflows.Examples.Services;
using XWorkflows.Examples.Workflows.TaskWorkflow.Base;

namespace XWorkflows.Examples.Workflows.TaskWorkflow.InProgress;
public class InProgressTaskAction : TaskWorkflowAction<TaskWorkflow.InProgress.InProgressTaskEvent, TaskWorkflow.InProgress.InProgressTaskState, TaskEntity, InProgressTaskActionRequest, bool>
{
    private readonly ITaskService _TaskService;

    public InProgressTaskAction(TaskWorkflow.InProgress.InProgressTaskState state, TaskWorkflow.InProgress.InProgressTaskEvent e,ITaskService TaskService) : base(state, e)
    {
        _TaskService = TaskService;
    }

    public async override Task<(WorkflowActionResult<bool>, TaskEntity)> Execute(TaskEntity data, InProgressTaskActionRequest p, CancellationToken cancelationToken)
    {
        await base.Execute(data, p, cancelationToken);
        await _TaskService.Save(data,p.Id);
        return new (
            WorkflowActionResult<bool>.Success(true),
            data
        );
    }
}
