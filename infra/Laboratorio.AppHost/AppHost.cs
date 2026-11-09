var builder = DistributedApplication.CreateBuilder(args);

var redis = builder.AddRedis("redis");
var postgres = builder.AddPostgres("postgres");
var database = postgres.AddDatabase("laboratorio");

builder.AddProject<Projects.Laboratorio_Api>("laboratorio-api")
    .WithReference(redis)
    .WithReference(database)
    .WaitFor(redis)
    .WaitFor(database);

builder.Build().Run();
