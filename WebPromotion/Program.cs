using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using WebPromotion.BL.CarBL;
using WebPromotion.BL.ConsultHistoryBL;
using WebPromotion.BL.DealerBL;
using DealerApi.DAL.Context;
using DealerApi.DAL.DAL;
using DealerApi.DAL.Extension;
using DealerApi.DAL.Interfaces;
using WebPromotion.Services.Consultation;
// using WebPromotion.BL.DealerCar;
using WebPromotion.Services.DealerCar;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Configure Auth
builder.Services.AddAuthentication(defaultScheme: IdentityConstants.ApplicationScheme)
    .AddIdentityCookies();

// Add Identity Core services
builder.Services.AddIdentityCore<IdentityUser>(options => {
    options.Password.RequireDigit = false;
    options.Password.RequiredLength = 6;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
});

// Register DAL and Application services
builder.Services.AddDataAccessLayerServices(builder.Configuration);

// Register Application services
builder.Services.AddHttpClient<IDealerCarServices, DealerCarServices>();


// Register MVC services
builder.Services.AddScoped<ICarBL, CarBLClass>();
builder.Services.AddScoped<IDealerBL, DealerBLClass>();
builder.Services.AddScoped<IConsultHistoryBL, ConsultHistoryBLClass>();
builder.Services.AddScoped<IConsultationServices, ConsultationServices>();
// builder.Services.AddScoped<IDealerCarBusiness, DealerCarBusiness>();



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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

await app.RunAsync();
