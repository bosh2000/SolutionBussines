using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SolutionBussines.DBRepository;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllers();

builder.Services.AddDbContext<SBDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DBConnection")));


var mappimgConfig = new MapperConfiguration(mc => mc.AddProfile(new AutoMappingProfile()));
IMapper mapper = mappimgConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

ServiceProvider serviceProvider = builder.Services.BuildServiceProvider();
SBDbContext DbcontextService= serviceProvider.GetService<SBDbContext>();

builder.Services.AddDbRepository(DbcontextService, mapper);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
