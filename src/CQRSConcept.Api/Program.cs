using CQRSConcept.Api.Dtos.Blog;
using CQRSConcept.Api.Features.Command.Request;
using CQRSConcept.Api.Registeration;
using CQRSConcept.Domain.Registeration;
using CQRSConcept.Infrastructure.Registeration;
using MediatR;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

//ioc

builder.Services.RegisterSqlServer(builder.Configuration);
builder.Services.RegisterMongo(builder.Configuration);

builder.Services.RegisterRepositories();
builder.Services.RegisterDomainServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapGet("/Create", async ([FromBody] CreateBlogDto dto, IMediator mediator) =>
{
    return await mediator.Send(new CreateBlogRequest { blog = dto });

}).WithName("Blog");


app.Run();
