using Aspire.Hosting;

var builder = DistributedApplication.CreateBuilder(args);

var api = builder.AddProject<Projects.AiExp_Web_Api>("web-api");

var web = builder.AddJavaScriptApp("web", "../AiExp.Web", runScriptName: "dev")
	.WithHttpEndpoint(env: "PORT")
	.WithExternalHttpEndpoints()
	.WithReference(api)
	.WaitFor(api);

builder.AddJavaScriptApp("web-tests", "../tests/AiExp.Web.Test", runScriptName: "test")
	.WithReference(web)
	.WithReference(api)
	.WaitFor(web)
	.ExcludeFromManifest();

builder.Build().Run();
