using Microsoft.AspNetCore.Mvc;
using XWorkflows.Examples.Helpers;
using XWorkflows.Examples.Model;
using XWorkflows.Examples.Services;
using XWorkflows.Examples.Workflows.OrderWorkflow.Base;
using XWorkflows.Examples.Workflows.OrderWorkflow.Submit;

namespace XWorkflows.Examples.Endpoints.Order;

public  static partial class OrderEndpoints
{
    private static Delegate SubmitOrder => async (OrderWorkflow workflow,SubmitOrderAction action,[FromRoute]string orderId,IOrderService repository,CancellationToken token) =>
    {
        var entity = await repository.Get(orderId);
        var result = await workflow.StartAction(entity, action, new SubmitOrderActionRequest(orderId),token);
        return result.ToResult(true);
    };
}