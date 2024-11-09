using Api.Services.User;
using Domain;
using Application;

var builder = WebApplication.CreateBuilder(args);

Environment.SetEnvironmentVariable("ConnectionString", builder.Configuration.GetConnectionString("DbContext"));

builder.Services.RegisterDataAccessService(builder.Configuration);

builder.Services.RegisterUseCasesService();

builder.Services.AddGrpc();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGrpcService<UserService>();

app.MigrateDb();

app.Run();
