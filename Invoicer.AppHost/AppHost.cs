var builder = DistributedApplication.CreateBuilder(args);

builder.AddViteApp(name: "Invoicer-App", appDirectory: "../frontend");

builder.Build().Run();
