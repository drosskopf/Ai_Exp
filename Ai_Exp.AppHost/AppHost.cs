var builder = DistributedApplication.CreateBuilder(args);

// Add the Web API project
var api = builder.AddProject<Projects.Ai_Exp_Web_Api>("webapi");

// Add the Next.js Web project
var web = builder.AddNpmApp("web", "../Ai_Exp.Web", "dev")
    .WithHttpEndpoint(env: "PORT")
    .WithExternalHttpEndpoints()
    .WaitFor(api);

builder.Build().Run();
