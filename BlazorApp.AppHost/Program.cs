var builder = DistributedApplication.CreateBuilder(args);

var weatherApi = builder.AddProject<Projects.WeatherAPI>("weather-api");

builder.AddProject<Projects.BlazorApp>("frontend-app")
	.WithReference(weatherApi);

builder.Build().Run();
