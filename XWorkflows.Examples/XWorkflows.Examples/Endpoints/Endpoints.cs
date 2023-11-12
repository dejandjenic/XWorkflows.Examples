
using XWorkflows.Examples.Endpoints.Order;
using XWorkflows.Examples.Endpoints.Task;

namespace XWorkflows.Examples.Endpoints;

public static class Endpoints
{
    public static void RegisterEndpoints(this RouteGroupBuilder root)
    {
        root.RegisterOrderEndpoints();
        root.RegisterTaskEndpoints();
    }
}