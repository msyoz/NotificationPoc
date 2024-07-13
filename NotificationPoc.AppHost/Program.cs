using Aspire.Hosting;
using Aspire.Hosting.Dapr;
using System.Collections.Immutable;

var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.NotificationService>("notificationservice")
    .WithDaprSidecar(new DaprSidecarOptions { ResourcesPaths = ImmutableHashSet.Create("./DaprComponents") });

var apiService = builder.AddProject<Projects.OtherService>("apiservice")
    .WithDaprSidecar(new DaprSidecarOptions { ResourcesPaths = ImmutableHashSet.Create("./DaprComponents") });

builder.AddProject<Projects.WebFrontend>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
