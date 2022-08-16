using HomeWorkShape.Repozitory.Interface;
using HomeWorkShape.Repozitory;
using HomeWorkShape.Model;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<IShape, Circle>();
builder.Services.AddTransient<IShape, Square>();
builder.Services.AddTransient<IShape, Triangle>();
builder.Services.AddTransient<IRepozitory, Repozitory>();
builder.Services.AddTransient<IFileOperation, FileOperation>();


// Add services to the container.
builder.Services.AddRazorPages();

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

app.Run();
