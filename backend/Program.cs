using Microsoft.EntityFrameworkCore;
using pwa_trabalho_sga.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//
builder.Services.AddScoped<IEstudanteRepository, EstudanteRepository>();
builder.Services.AddScoped<ILoginRepository, LoginRepository>();
builder.Services.AddScoped<INotaRepository, NotaRepository>();
builder.Services.AddAutoMapper(typeof(Program).Assembly);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(
    options => options.UseNpgsql(builder.Configuration.GetConnectionString("Connection"))
);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});

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

// Configuração do CORS
app.UseCors();

app.UseAuthorization();

app.MapControllerRoute(name: "default", pattern: "{controller=Login}/{action=Login}/{id?}");

app.Run();
