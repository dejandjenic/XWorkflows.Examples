using Microsoft.AspNetCore.Mvc;
using XWorkflows.Examples.Helpers;
using XWorkflows.Examples.Model;
using XWorkflows.Examples.Services;
using XWorkflows.Examples.Workflows.OrderWorkflow.Base;
using XWorkflows.Examples.Workflows.OrderWorkflow.Deliver;

namespace XWorkflows.Examples.Endpoints.Order;

public  static partial class OrderEndpoints
{
    private static Delegate DeliverOrder => async (OrderWorkflow workflow,DeliverOrderAction action,[FromRoute]string orderId,IOrderService repository,CancellationToken token) => 
    {
        var entity = await repository.Get(orderId);
        var result = await workflow.StartAction(entity, action, new DeliverOrderActionRequest(orderId),token);
        return result.ToResult(true);
    };
}