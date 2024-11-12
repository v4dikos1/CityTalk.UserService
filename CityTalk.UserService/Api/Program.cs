using Api.Services;
using Domain;

var builder = WebApplication.CreateBuilder(args);

builder.Services.RegisterDataAccessService(builder.Configuration);

builder.Services.AddGrpc();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGrpcService<UserService>();

app.SetConnectionStringEnvironment(app.Configuration.GetConnectionString("DbConnection"));

app.MigrateDb();

app.Run();
