using CQRSConcept.Api.Dtos.Blog;
using CQRSConcept.Api.Features.Command.Request;
using CQRSConcept.Api.Registeration;
using CQRSConcept.Domain.Registeration;
using CQRSConcept.Infrastructure.Registeration;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddControllers(); // برای APIهای کلاس‌محور
builder.Services.AddEndpointsApiExplorer(); // برای Minimal API
builder.Services.AddSwaggerGen();

//ioc

builder.Services.RegisterSqlServer(builder.Configuration);
builder.Services.RegisterMongo(builder.Configuration);

builder.Services.RegisterRepositories();
builder.Services.RegisterDomainServices();

builder.Services.RegisterMediatR();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.MapOpenApi();
}

app.MapPost("/Create", async (CreateBlogDto dto, IMediator mediator) =>
{
    return await mediator.Send(new CreateBlogRequest { blog = dto });

}).WithName("Blog");


app.Run();
