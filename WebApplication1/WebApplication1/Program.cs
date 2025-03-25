var builder = WebApplication.CreateBuilder(args);

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

// Set a custom home page (redirect to Weather.cshtml)
app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/", context =>
    {
        context.Response.Redirect("/Weather");
        return Task.CompletedTask;
    });

    endpoints.MapRazorPages();
});

app.Run();
