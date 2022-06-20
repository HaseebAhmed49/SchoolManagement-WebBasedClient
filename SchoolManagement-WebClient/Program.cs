using System.Net.Http.Headers;
using SchoolManagement_WebClient.Data;
using SchoolManagement_WebClient.Data.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<CourseServices>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Course}/{action=Index}/{id?}");

// Establish Connection with WebAPI
HttpClientCustom.client.BaseAddress = new Uri("https://localhost:5001");

// Specify headers
var val = "application/json";
var media = new MediaTypeWithQualityHeaderValue(val);
HttpClientCustom.client.DefaultRequestHeaders.Accept.Clear();
HttpClientCustom.client.DefaultRequestHeaders.Accept.Add(media);

app.Run();