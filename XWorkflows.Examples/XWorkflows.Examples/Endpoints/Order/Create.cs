using XWorkflows.Examples.Helpers;
using XWorkflows.Examples.Model;
using XWorkflows.Examples.Workflows.OrderWorkflow;
using XWorkflows.Examples.Workflows.OrderWorkflow.Base;
using XWorkflows.Examples.Workflows.OrderWorkflow.Create;

namespace XWorkflows.Examples.Endpoints.Order;

public  static partial class OrderEndpoints
{
    private static Delegate CreateOrder => async (OrderWorkflow workflow,CreateOrderAction action,CreateOrderActionRequest request,CancellationToken token) =>
    {
        var result = await workflow.StartAction(null, action, request,token);
        return result.ToResult();
    };
}