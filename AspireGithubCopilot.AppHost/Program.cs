var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.GithubAgent>("githubagent");

builder.Build().Run();
