using Api.StartupConfigurations;
using Api.StartupConfigurations.Options;
using Domain;
using Keycloak.Configurations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

Environment.SetEnvironmentVariable("ConnectionString", builder.Configuration.GetConnectionString("DbContext"));

builder.Services.RegisterDataAccessService(builder.Configuration);

builder.Services.ConfigureOptions<KeycloakConfigurationSetup>();
builder.Services.ConfigureOptions<KeycloakScopesConfigurationSetup>();

builder.Services.AddKeycloakConfiguration();
builder.Services.ConfigureSwagger();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapControllers();

app.MigrateDb();

app.ConfigureSwaggerUI();

app.UseAuthentication();
app.UseAuthorization();

app.Run();
