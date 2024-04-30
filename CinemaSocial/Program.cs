using CinemaSocial.Components;
using CinemaSocial.Data;
using CinemaSocial.Models.Entities;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.Cookie.Name = "auth_token";
        options.LoginPath = "/login";
        options.Cookie.MaxAge = TimeSpan.FromMinutes(30);
        options.AccessDeniedPath = "/access-denied";
    });
builder.Services.AddAuthorization();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseSqlite("Data Source=cinema.db"));

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddControllers();


var types = new[]
{
    typeof(UserAccount)
};
/*builder.Services.AddSingleton<IFactory>(sp => new Factory(types));
builder.Services.AddDbContext<GameContext>(ServiceLifetime.Transient);
builder.Services.AddSingleton<IUnitOfWork, UnitOfWork>();*/
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:7237") });


var app = builder.Build();
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseRouting();
app.MapControllers();

app.MapBlazorHub();
//app.MapFallbackToPage("/_Host");

app.UseStaticFiles();
app.UseAntiforgery();
app.UseAuthentication();
app.UseAuthorization();

app.UseHttpsRedirection();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();








