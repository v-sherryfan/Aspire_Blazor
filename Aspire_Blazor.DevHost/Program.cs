var builder = CloudApplication.CreateBuilder(args);

builder.AddProject<Aspire_Blazor.DevHost.Projects.BlazorApp1>();

builder.Build().Run();
