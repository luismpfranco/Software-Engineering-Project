using CinemaSocial.Components;
using CinemaSocial.Components.Pages.Movies;
using CinemaSocial.Data;
using CinemaSocial.Services;
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

builder.Services.AddScoped(_ => new HttpClient { BaseAddress = new Uri("http://localhost:7237") });
builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddScoped<WatchlistService>();
builder.Services.AddScoped<IReviewService, ReviewService>();
builder.Services.AddScoped<MovieDetails>();
builder.Services.AddScoped<MovieService>();
builder.Services.AddScoped < ReviewService>();
builder.Services.AddScoped<ILikeService, LikeService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();
app.MapControllers();
app.MapRazorPages();

app.UseStaticFiles();
app.UseAntiforgery();
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();