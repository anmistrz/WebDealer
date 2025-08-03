using Microsoft.EntityFrameworkCore;
using WebPromotion.BL.CarBL;
using WebPromotion.BL.ConsultHistoryBL;
using WebPromotion.BL.DealerBL;
using WebPromotion.DAL;
using WebPromotion.DAL.CarDAL;
using WebPromotion.DAL.ConsultationDAL;
using WebPromotion.DAL.CustomerDAL;
using WebPromotion.DAL.DealerDAL;
using WebPromotion.DAL.NotificationDAL;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DBPromotionExerciseContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DBPromotionExerciseConnectionString"))
);

builder.Services.AddScoped<ICar, CarDALClass>();
builder.Services.AddScoped<ICarBL, CarBLClass>();
builder.Services.AddScoped<IDealerBL, DealerBLClass>();
builder.Services.AddScoped<IDealer, DealerDALClass>();
builder.Services.AddScoped<INotification, NotifictionDALClass>();
builder.Services.AddScoped<ICustomer, CustomerDALClass>();
builder.Services.AddScoped<IConsultHistoryBL, ConsultHistoryBLClass>();
builder.Services.AddScoped<IConsultation, ConsultationDALClass>();


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
    pattern: "{controller=Home}/{action=Index}/{id?}");

await app.RunAsync();
