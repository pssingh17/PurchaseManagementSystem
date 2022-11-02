using PurchaseManagementSystem.Data;

using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Authentication.Cookies;



var builder = WebApplication.CreateBuilder(args);



builder.Services.AddRazorPages();



builder.Services.AddDbContext<ItemContext>(options =>

  options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));



builder.Services.AddDatabaseDeveloperPageExceptionFilter();



// Add services to the container.

builder.Services.AddControllersWithViews();

builder.Services.AddAuthentication(
    CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(option => {
        option.LoginPath = "/Access/Login";
        option.ExpireTimeSpan = TimeSpan.FromMinutes(20);

    });

var app = builder.Build();



// Configure the HTTP request pipeline.

if (!app.Environment.IsDevelopment())

{

    app.UseExceptionHandler("/Home/Error");

}

else

{

    app.UseDeveloperExceptionPage();

    app.UseMigrationsEndPoint();

}



using (var scope = app.Services.CreateScope())

{

    var services = scope.ServiceProvider;



    var context = services.GetRequiredService<ItemContext>();

    var v = context.Database.EnsureCreated();

    DbInitializer.Initialize(context);

}

app.UseStaticFiles();



app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();



app.MapControllerRoute(

  name: "default",

  pattern: "{controller=Access}/{action=Login}/{id?}");



app.Run();