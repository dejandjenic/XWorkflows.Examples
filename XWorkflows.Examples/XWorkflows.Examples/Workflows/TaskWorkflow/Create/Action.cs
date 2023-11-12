using XWorkflows.Examples.Entities;
using XWorkflows.Examples.Model;
using XWorkflows.Examples.Services;
using XWorkflows.Examples.Workflows.TaskWorkflow.Base;
using XWorkflows.Examples.Workflows.TaskWorkflow.Create;
using XWorkflows.Examples.Workflows.TaskWorkflow.Base;

namespace XWorkflows.Examples.Workflows.TaskWorkflow.Create;

public class CreateTaskAction : TaskWorkflowAction<CreateTaskEvent, CreateTaskState, TaskEntity, CreateTaskActionRequest, IdObject>, IWorkflowStartAction
{
    private readonly ITaskService _orderService;

    public CreateTaskAction(CreateTaskState state, CreateTaskEvent e,ITaskService orderService) : base(state, e)
    {
        _orderService = orderService;
    }

    public async override Task<(WorkflowActionResult<IdObject>, TaskEntity)> Execute(TaskEntity data, CreateTaskActionRequest request, CancellationToken cancelationToken)
    {
        var order = new TaskEntity()
        {
            Description = request.Description,
            User = request.User
        };
        await base.Execute(order, request, cancelationToken);
        var id = await _orderService.Create(order);
        return new (
            WorkflowActionResult<IdObject>.Success(new IdObject(id)),
            order
        );
    }
}