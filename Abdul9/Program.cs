var builder = WebApplication.CreateBuilder(args);

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

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");  //ye jo aik parameter 
   //hai isme question mark isliye laga hai ki ye parameter optional hai isme 
   //is parameter ka hum use kare ya na kare ye hamre par depened karta hai 
   //lekin jo do aur hai unka hona compulsori hai usme question mark nahi 
   // hai isliye 

app.Run();
