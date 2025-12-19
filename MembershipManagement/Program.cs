using Microsoft.EntityFrameworkCore;
using UserApi.Models;
using MembershipApi.Models;
using EventApi.Models;
using RegistrationApi.Models;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<UserContext>(opt => opt.UseInMemoryDatabase("Users"));
builder.Services.AddDbContext<MembershipContext>(opt => opt.UseInMemoryDatabase("Memberships"));
builder.Services.AddDbContext<EventContext>(opt => opt.UseInMemoryDatabase("Events"));
builder.Services.AddDbContext<RegistrationContext>(opt => opt.UseInMemoryDatabase("Registrations"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{   
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
