using Microsoft.AspNetCore.Mvc;
using XWorkflows.Examples.Services;

namespace XWorkflows.Examples.Endpoints.Task;

public  static partial class TaskEndpoints
{
    private static Delegate GetTask =>
        async ([FromRoute] string TaskId, ITaskService service, CancellationToken token) =>
        {
            return await service.Get(TaskId);
        };
}
