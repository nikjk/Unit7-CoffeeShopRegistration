using Demo_Intro.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add our mock database to the services. We want to use "dependency injection" to "inject" the database model into controllers.
// This will allow any Controller to inject the MockDatabase, and use it.
builder.Services.AddScoped<MockDatabase>();

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

// www.example.com/   ----> This URL, there is NO pattern to match, so defaults will be used. (In our pattern below, "{controller=home}..." Home is the default. The default action is "Index" We are routed to example.com/home/index
// www.example.com/shop/         ----> This URL, MVC will look for a ShopController.cs in the Controllers folder. Controllers/ShopController.cs
// www.example.com/shop/shoes/23 ---->
// www.example.com/home/aboutme  ----> MVC will look in the Controller folder for a HomeController.cs, and then if found, call a method name AboutMe()

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

    // This patter will first look in the Controller folder for the name passed in...
    // If you pass in example.com/shop ----- MVC will look inside the Controller folder for ShopController.cs
    // If you pass in example.com/trains --- MVC will look inside the Controller folder for TrainsController.cs

app.Run();
