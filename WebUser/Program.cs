using Microsoft.EntityFrameworkCore;
using WebUser.Data;
using WebUser.Models;



var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
app.UseAuthentication();
app.UseAuthorization();
app.UseEndpoints(endpoints =>

{
    endpoints.MapControllerRoute
    (
    name: "login",
    pattern: "Login",
    defaults: new { controller = "Account", action = "Login" });
});
