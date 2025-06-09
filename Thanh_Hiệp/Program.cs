using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Thanh_Hiệp.Services; // Đảm bảo using đúng service của bạn

var builder = WebApplication.CreateBuilder(args);

// Thêm các dịch vụ vào container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<CakeService>(); // Đăng ký CakeService của bạn

var app = builder.Build();

// Cấu hình HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host"); // Dòng này sẽ trỏ đến file _Host.cshtml

app.Run();