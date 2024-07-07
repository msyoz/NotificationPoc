using Aspire.Hosting.Dapr;
using System.Collections.Immutable;

var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.NotificationService>("notificationservice")
    .WithDaprSidecar(new DaprSidecarOptions { ResourcesPaths = ImmutableHashSet.Create("./DaprComponents") });

builder.AddProject<Projects.OtherService>("otherservice")
    .WithDaprSidecar(new DaprSidecarOptions { ResourcesPaths = ImmutableHashSet.Create("./DaprComponents") });

builder.AddProject<Projects.WebFrontend>("webfrontend");

builder.Build().Run();
