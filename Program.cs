using Core;
using SD2.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<LoggerService>();
builder.Services.AddSingleton<CoreContext>();
//builder.Services.AddSingleton<ClientService>();
builder.Services.AddSingleton<IClient, ClientService>();

builder.Services.AddControllersWithViews();


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

app.Run();

/*
 f1(
    // 1
    // 2
    f2()
    //11
)

 f2(
    // 3
    f3()
    //9
    //10
)

 f3(
    //4
    //5
    //6
    f4()
    //8
)

 f4(
    //7
)

 
 
 
 */
