namespace XWorkflows.Examples.Helpers;

public static class WorkflowHelpers
{
    public static IResult ToResult<T>(this WorkflowActionResult<T> result, bool noContent = false)
    {
        if (!result.IsSuccess)
        {
            if (result.Errors.Any(x => x.Result == WorkflowActionResultEnum.CanNotStartWorkflow))
                return Results.NotFound();

            return Results.BadRequest(new
            {
                Errors = string.Join(",",result.Errors.Select(x=>x.Error))
            });
        }

        return noContent ? Results.NoContent() : Results.Ok(result.Data);
    }
}