var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.NotificationService>("notificationservice")
    .WithDaprSidecar();

builder.AddProject<Projects.OtherService>("otherservice")
    .WithDaprSidecar();

builder.AddProject<Projects.WebFrontend>("webfrontend");

builder.Build().Run();
