using XWorkflows.Examples.Entities;
using XWorkflows.Examples.Model;
using XWorkflows.Examples.Services;
using XWorkflows.Examples.Workflows.TaskWorkflow.Base;

namespace XWorkflows.Examples.Workflows.TaskWorkflow.Cancel;

public class CancelTaskAction : TaskWorkflowAction<CancelTaskEvent, CancelTaskState, TaskEntity, CancelTaskActionRequest, bool>
{
    private readonly ITaskService _taskService;

    public CancelTaskAction(CancelTaskState state, CancelTaskEvent e,ITaskService orderService) : base(state, e)
    {
        _taskService = orderService;
    }

    public async override Task<(WorkflowActionResult<bool>, TaskEntity)> Execute(TaskEntity data, CancelTaskActionRequest p, CancellationToken cancelationToken)
    {
        await base.Execute(data, p, cancelationToken);
        await _taskService.Save(data,p.Id);
        return new (
            WorkflowActionResult<bool>.Success(true),
            data
        );
    }
}
