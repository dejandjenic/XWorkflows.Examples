using Microsoft.AspNetCore.Mvc;
using XWorkflows.Examples.Services;

namespace XWorkflows.Examples.Endpoints.Task;

public  static partial class TaskEndpoints
{
    private static Delegate ListTask =>
        async (ITaskService service, CancellationToken token) =>
        {
            return await service.List();
        };
}
