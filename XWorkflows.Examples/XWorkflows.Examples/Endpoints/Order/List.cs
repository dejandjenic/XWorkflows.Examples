using Microsoft.AspNetCore.Mvc;
using XWorkflows.Examples.Services;

namespace XWorkflows.Examples.Endpoints.Order;

public  static partial class OrderEndpoints
{
    private static Delegate ListOrder =>
        async (IOrderService service, CancellationToken token) =>
        {
            return await service.List();
        };
}
