using ViewComponentTesting.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages()
    .AddRazorOptions(x =>
    {
        // /Components/{View Component Name}/{View Name}.cshtml
        x.ViewLocationFormats.Add("/{0}.cshtml");
        x.PageViewLocationFormats.Add("/{0}.cshtml");

    });

builder.Services.AddTransient<IUserService,UserService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
