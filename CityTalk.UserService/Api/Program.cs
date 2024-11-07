using Domain;

var builder = WebApplication.CreateBuilder(args);

Environment.SetEnvironmentVariable("ConnectionString", builder.Configuration.GetConnectionString("DbContext"));

builder.Services.RegisterDataAccessService(builder.Configuration);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MigrateDb();

app.Run();
