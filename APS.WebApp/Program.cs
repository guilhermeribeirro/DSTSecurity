var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDistributedMemoryCache();
builder.Services.AddMvc().AddSessionStateTempDataProvider();

builder.Services.AddSession(options => {
    options.Cookie.IsEssential = true;
    options.Cookie.HttpOnly = true;
});


builder.Services.AddSession(options =>
{
    // Configurações opcionais, como tempo limite da sessão, podem ser definidas aqui.
    options.IdleTimeout = TimeSpan.FromMinutes(60);
});


// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseSession(new SessionOptions
{
    IdleTimeout = TimeSpan.FromSeconds(10)
});

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
