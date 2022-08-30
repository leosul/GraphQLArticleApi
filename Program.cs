using GraphQLApi.Data;
using GraphQLApi.GraphQL.Mutations;
using GraphQLApi.GraphQL.Queries;
using GraphQLApi.Interfaces;
using GraphQLApi.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContextFactory<CustomerDbContext>(options => options
    .UseSqlServer(builder.Configuration["ConnectionStrings:DefaultConnection"])
    .LogTo(Console.WriteLine));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICustomerService, CustomerService>();

builder.Services.AddScoped<CustomerQuery>();
builder.Services.AddGraphQLServer()
    .AddQueryType<CustomerQuery>()
    .AddMutationType<CustomerMutation>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGraphQL();

app.Run();
