using Api.Services;
using Domain;

var builder = WebApplication.CreateBuilder(args);

Environment.SetEnvironmentVariable("ConnectionString", builder.Configuration.GetConnectionString("DbContext"));

builder.Services.RegisterDataAccessService(builder.Configuration);

builder.Services.AddGrpc();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGrpcService<UserService>();

app.MigrateDb();

app.Run();
