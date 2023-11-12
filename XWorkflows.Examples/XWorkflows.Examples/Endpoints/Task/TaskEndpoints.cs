
namespace XWorkflows.Examples.Endpoints.Task;

public  static partial class TaskEndpoints
{
    public static void RegisterTaskEndpoints(this RouteGroupBuilder root)
    {

        var taskGroup = root.MapGroup("/tasks");
        var taskRoute = "/{taskId}";

        taskGroup.MapPost("", CreateTask);
        taskGroup.MapGet("", Task.TaskEndpoints.ListTask);
        taskGroup.MapGet(taskRoute , Task.TaskEndpoints.GetTask);
        taskGroup.MapPost(taskRoute + "/in-progress", Task.TaskEndpoints.InProgressTask);
        taskGroup.MapPost(taskRoute + "/cancel", Task.TaskEndpoints.CancelTask);
        taskGroup.MapPost(taskRoute + "/complete", Task.TaskEndpoints.CompleteTask);

    }

   
}