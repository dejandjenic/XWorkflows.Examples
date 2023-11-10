using XWorkflows;
using XWorkflows.Examples;
using XWorkflows.Examples.Endpoints;
using XWorkflows.Examples.Repositories;
using XWorkflows.Examples.Services;
using XWorkflows.Examples.Workflows.OrderWorkflow;
using XWorkflows.Examples.Workflows.OrderWorkflow.Base;

var builder = WebApplication.CreateBuilder(args);
builder.Services.RegisterWorkflows(typeof(OrderWorkflow));
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IOrderEventStreamService, OrderEventStreamService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
    
var app = builder.Build();

app.MapGroup("").RegisterEndpoints();


app.UseSwagger();
app.UseSwaggerUI();

app.Run();