var builder = DistributedApplication.CreateBuilder(args);

var database = builder.AddPostgres("postgres")
    .WithPgAdmin(options => options.WithHostPort(6001));
database.AddDatabase("Invoicer");

builder.AddViteApp(name: "Invoicer-App", appDirectory: "../frontend");

builder.AddProject<Projects.Invoicer_Gateway>("invoicer-gateway");

builder.AddProject<Projects.Invoicer_Documents>("invoicer-documents");

builder.Build().Run();
