
using XWorkflows.Examples.Endpoints.Order;

namespace XWorkflows.Examples.Endpoints;

public static class Endpoints
{
    public static void RegisterEndpoints(this RouteGroupBuilder root)
    {
        root.RegisterOrderEndpoints();
    }
}