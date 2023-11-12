
namespace XWorkflows.Examples.Endpoints.Order;

public  static partial class OrderEndpoints
{
    public static void RegisterOrderEndpoints(this RouteGroupBuilder root)
    {

        var orderGroup = root.MapGroup("/orders");
        var orderRoute = "/{orderId}";

        orderGroup.MapPost("", CreateOrder);
        orderGroup.MapGet("", ListOrder);
        orderGroup.MapGet(orderRoute , GetOrder);
        orderGroup.MapPost(orderRoute + "/submit", SubmitOrder);
        orderGroup.MapPost(orderRoute + "/cancel", CancelOrder);
        orderGroup.MapPost(orderRoute + "/deliver", DeliverOrder);

    }

   
}